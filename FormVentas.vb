Imports System.Data.OleDb

Public Class FormVentas
    Private dtClientes As DataTable
    Private dtVendedores As DataTable
    Private dtProductos As DataTable
    Private ventasActuales As New List(Of Dictionary(Of String, Object))

    Private Const IMPUESTO As Decimal = 0.13 ' 13% de impuesto

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema de Ventas"
        CargarDatos()
        ConfigurarDataGridView()
        LimpiarFormulario()
    End Sub

    Private Sub CargarDatos()
        ' Cargar Clientes
        dtClientes = ConexionBD.EjecutarConsulta("SELECT IdCliente, NombreCliente, Apellido FROM Clientes ORDER BY NombreCliente")
        If dtClientes IsNot Nothing Then
            CboCliente.DataSource = dtClientes
            CboCliente.DisplayMember = "NombreCliente"
            CboCliente.ValueMember = "IdCliente"
        End If

        ' Cargar Vendedores
        dtVendedores = ConexionBD.EjecutarConsulta("SELECT IdVendedor, NombreVendedor, Apellido FROM Vendedores ORDER BY NombreVendedor")
        If dtVendedores IsNot Nothing Then
            CboVendedor.DataSource = dtVendedores
            CboVendedor.DisplayMember = "NombreVendedor"
            CboVendedor.ValueMember = "IdVendedor"
        End If

        ' Cargar Productos
        dtProductos = ConexionBD.EjecutarConsulta("SELECT IdProducto, NombreProducto, Precio FROM Productos ORDER BY NombreProducto")
        If dtProductos IsNot Nothing Then
            CboProducto.DataSource = dtProductos
            CboProducto.DisplayMember = "NombreProducto"
            CboProducto.ValueMember = "IdProducto"
        End If
    End Sub

    Private Sub ConfigurarDataGridView()
        DgvDetalles.Columns.Clear()
        DgvDetalles.Columns.Add("IdVenta", "ID")
        DgvDetalles.Columns.Add("Cliente", "Cliente")
        DgvDetalles.Columns.Add("Vendedor", "Vendedor")
        DgvDetalles.Columns.Add("Producto", "Producto")
        DgvDetalles.Columns.Add("Cantidad", "Cantidad")
        DgvDetalles.Columns.Add("PrecioUnitario", "Precio Unit.")
        DgvDetalles.Columns.Add("SubTotal", "SubTotal")
        DgvDetalles.Columns.Add("Impuesto", "Impuesto")
        DgvDetalles.Columns.Add("Total", "Total")
        DgvDetalles.Columns.Add("Fecha", "Fecha")

        ' Ajustar ancho
        For Each col As DataGridViewColumn In DgvDetalles.Columns
            col.Width = 70
        Next
    End Sub

    Private Sub BtnAgregarProducto_Click(sender As Object, e As EventArgs) Handles BtnAgregarProducto.Click
        Dim cantidad As Integer

        ' Validaciones
        If CboCliente.SelectedIndex = -1 Or CboVendedor.SelectedIndex = -1 Or CboProducto.SelectedIndex = -1 Then
            MsgBox("Por favor seleccione cliente, vendedor y producto", MsgBoxStyle.Exclamation)
            Return
        End If

        If Not Integer.TryParse(TxtCantidad.Text, cantidad) Or cantidad <= 0 Then
            MsgBox("Ingrese una cantidad válida (mayor a 0)", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Obtener datos
        Dim idCliente As Integer = Convert.ToInt32(CboCliente.SelectedValue)
        Dim idVendedor As Integer = Convert.ToInt32(CboVendedor.SelectedValue)
        Dim idProducto As Integer = Convert.ToInt32(CboProducto.SelectedValue)
        Dim precioUnitario As Decimal = Convert.ToDecimal(ObtenerPrecioProducto(idProducto))

        ' Cálculos
        Dim subTotal As Decimal = cantidad * precioUnitario
        Dim impuestoCalculado As Decimal = subTotal * IMPUESTO
        Dim total As Decimal = subTotal + impuestoCalculado

        ' Agregar a DataGridView
        AgregarFilaAlGrid(idCliente, idVendedor, idProducto, cantidad, precioUnitario, subTotal, impuestoCalculado, total)

        ' Guardar en lista temporal
        Dim venta As New Dictionary(Of String, Object) From {
            {"IdCliente", idCliente},
            {"IdVendedor", idVendedor},
            {"IdProducto", idProducto},
            {"Cantidad", cantidad},
            {"PrecioUnitario", precioUnitario},
            {"SubTotal", subTotal},
            {"Impuesto", impuestoCalculado},
            {"Total", total},
            {"FechaVenta", DateTime.Now}
        }
        ventasActuales.Add(venta)

        TxtCantidad.Clear()
        LblTotalVenta.Text = "Total General: Q" & CalcularTotalGeneral().ToString("F2")
    End Sub

    Private Sub AgregarFilaAlGrid(idCliente As Integer, idVendedor As Integer, idProducto As Integer, 
                                   cantidad As Integer, precioUnitario As Decimal, subTotal As Decimal, 
                                   impuesto As Decimal, total As Decimal)
        Dim cliente As String = ObtenerNombreCliente(idCliente)
        Dim vendedor As String = ObtenerNombreVendedor(idVendedor)
        Dim producto As String = ObtenerNombreProducto(idProducto)
        Dim idVenta As Integer = DgvDetalles.Rows.Count + 1

        DgvDetalles.Rows.Add(
            idVenta,
            cliente,
            vendedor,
            producto,
            cantidad,
            precioUnitario.ToString("F2"),
            subTotal.ToString("F2"),
            impuesto.ToString("F2"),
            total.ToString("F2"),
            DateTime.Now.ToString("yyyy-MM-dd")
        )
    End Sub

    Private Function ObtenerPrecioProducto(idProducto As Integer) As Decimal
        Dim dt As DataTable = ConexionBD.EjecutarConsulta(
            "SELECT Precio FROM Productos WHERE IdProducto=" & idProducto
        )
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return Convert.ToDecimal(dt.Rows(0)("Precio"))
        End If
        Return 0
    End Function

    Private Function ObtenerNombreCliente(idCliente As Integer) As String
        Dim dt As DataTable = ConexionBD.EjecutarConsulta(
            "SELECT NombreCliente FROM Clientes WHERE IdCliente=" & idCliente
        )
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)("NombreCliente").ToString()
        End If
        Return ""
    End Function

    Private Function ObtenerNombreVendedor(idVendedor As Integer) As String
        Dim dt As DataTable = ConexionBD.EjecutarConsulta(
            "SELECT NombreVendedor FROM Vendedores WHERE IdVendedor=" & idVendedor
        )
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)("NombreVendedor").ToString()
        End If
        Return ""
    End Function

    Private Function ObtenerNombreProducto(idProducto As Integer) As String
        Dim dt As DataTable = ConexionBD.EjecutarConsulta(
            "SELECT NombreProducto FROM Productos WHERE IdProducto=" & idProducto
        )
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)("NombreProducto").ToString()
        End If
        Return ""
    End Function

    Private Function CalcularTotalGeneral() As Decimal
        Dim total As Decimal = 0
        For Each venta As Dictionary(Of String, Object) In ventasActuales
            total += Convert.ToDecimal(venta("Total"))
        Next
        Return total
    End Function

    Private Sub BtnGuardarVenta_Click(sender As Object, e As EventArgs) Handles BtnGuardarVenta.Click
        If ventasActuales.Count = 0 Then
            MsgBox("Agregue al menos un producto antes de guardar", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            For Each venta As Dictionary(Of String, Object) In ventasActuales
                Dim sql As String = String.Format(
                    "INSERT INTO Ventas (IdCliente, IdVendedor, IdProducto, Cantidad, PrecioUnitario, SubTotal, Impuesto, Total, FechaVenta) " &
                    "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, #{8}#)",
                    venta("IdCliente"),
                    venta("IdVendedor"),
                    venta("IdProducto"),
                    venta("Cantidad"),
                    venta("PrecioUnitario"),
                    venta("SubTotal"),
                    venta("Impuesto"),
                    venta("Total"),
                    Convert.ToDateTime(venta("FechaVenta")).ToString("yyyy-MM-dd")
                )

                ConexionBD.EjecutarComando(sql)
            Next

            MsgBox("¡Ventas guardadas exitosamente!", MsgBoxStyle.Information)
            LimpiarFormulario()
        Catch ex As Exception
            MsgBox("Error al guardar ventas: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnBuscarVentas_Click(sender As Object, e As EventArgs) Handles BtnBuscarVentas.Click
        ' Búsqueda con INNER JOIN
        Dim sql As String = "SELECT v.IdVenta, c.NombreCliente, ve.NombreVendedor, p.NombreProducto, " &
                            "v.Cantidad, v.PrecioUnitario, v.SubTotal, v.Impuesto, v.Total, v.FechaVenta " &
                            "FROM Ventas v " &
                            "INNER JOIN Clientes c ON v.IdCliente = c.IdCliente " &
                            "INNER JOIN Vendedores ve ON v.IdVendedor = ve.IdVendedor " &
                            "INNER JOIN Productos p ON v.IdProducto = p.IdProducto"

        ' Agregar filtros si existen
        Dim filtros As List(Of String) = New List(Of String)

        If TxtBuscarCliente.Text <> "" Then
            filtros.Add("c.NombreCliente LIKE '%" & TxtBuscarCliente.Text & "%'")
        End If

        If TxtBuscarProducto.Text <> "" Then
            filtros.Add("p.NombreProducto LIKE '%" & TxtBuscarProducto.Text & "%'")
        End If

        If filtros.Count > 0 Then
            sql &= " WHERE " & String.Join(" AND ", filtros)
        End If

        Dim dt As DataTable = ConexionBD.EjecutarConsulta(sql)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            DgvResultados.DataSource = dt
        Else
            MsgBox("No se encontraron resultados", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub LimpiarFormulario()
        TxtCantidad.Clear()
        TxtBuscarCliente.Clear()
        TxtBuscarProducto.Clear()
        DgvDetalles.Rows.Clear()
        DgvResultados.DataSource = Nothing
        ventasActuales.Clear()
        LblTotalVenta.Text = "Total General: Q0.00"
        CargarDatos()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub
End Class