<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.CboCliente = New System.Windows.Forms.ComboBox()
        Me.LblVendedor = New System.Windows.Forms.Label()
        Me.CboVendedor = New System.Windows.Forms.ComboBox()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.CboProducto = New System.Windows.Forms.ComboBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.BtnAgregarProducto = New System.Windows.Forms.Button()
        Me.DgvDetalles = New System.Windows.Forms.DataGridView()
        Me.LblTotalVenta = New System.Windows.Forms.Label()
        Me.BtnGuardarVenta = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblBuscarCliente = New System.Windows.Forms.Label()
        Me.TxtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.LblBuscarProducto = New System.Windows.Forms.Label()
        Me.TxtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.BtnBuscarVentas = New System.Windows.Forms.Button()
        Me.DgvResultados = New System.Windows.Forms.DataGridView()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        ' GroupBox1
        Me.GroupBox1.Controls.Add(Me.LblCliente)
        Me.GroupBox1.Controls.Add(Me.CboCliente)
        Me.GroupBox1.Controls.Add(Me.LblVendedor)
        Me.GroupBox1.Controls.Add(Me.CboVendedor)
        Me.GroupBox1.Controls.Add(Me.LblProducto)
        Me.GroupBox1.Controls.Add(Me.CboProducto)
        Me.GroupBox1.Controls.Add(Me.LblCantidad)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.BtnAgregarProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Venta"

        ' LblCliente
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(10, 30)
        Me.LblCliente.Text = "Cliente:"
        Me.CboCliente.Location = New System.Drawing.Point(80, 30)
        Me.CboCliente.Size = New System.Drawing.Size(150, 20)

        ' LblVendedor
        Me.LblVendedor.AutoSize = True
        Me.LblVendedor.Location = New System.Drawing.Point(250, 30)
        Me.LblVendedor.Text = "Vendedor:"
        Me.CboVendedor.Location = New System.Drawing.Point(330, 30)
        Me.CboVendedor.Size = New System.Drawing.Size(150, 20)

        ' LblProducto
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Location = New System.Drawing.Point(500, 30)
        Me.LblProducto.Text = "Producto:"
        Me.CboProducto.Location = New System.Drawing.Point(570, 30)
        Me.CboProducto.Size = New System.Drawing.Size(170, 20)

        ' LblCantidad
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(10, 70)
        Me.LblCantidad.Text = "Cantidad:"
        Me.TxtCantidad.Location = New System.Drawing.Point(80, 70)
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)

        ' BtnAgregarProducto
        Me.BtnAgregarProducto.Location = New System.Drawing.Point(200, 70)
        Me.BtnAgregarProducto.Size = New System.Drawing.Size(120, 30)
        Me.BtnAgregarProducto.Text = "Agregar Producto"

        ' DgvDetalles
        Me.DgvDetalles.Location = New System.Drawing.Point(12, 170)
        Me.DgvDetalles.Name = "DgvDetalles"
        Me.DgvDetalles.Size = New System.Drawing.Size(760, 200)
        Me.DgvDetalles.TabIndex = 1

        ' LblTotalVenta
        Me.LblTotalVenta.AutoSize = True
        Me.LblTotalVenta.Location = New System.Drawing.Point(630, 380)
        Me.LblTotalVenta.Font = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
        Me.LblTotalVenta.Text = "Total: Q0.00"

        ' BtnGuardarVenta
        Me.BtnGuardarVenta.Location = New System.Drawing.Point(12, 380)
        Me.BtnGuardarVenta.Size = New System.Drawing.Size(110, 30)
        Me.BtnGuardarVenta.Text = "Guardar Venta"

        ' GroupBox2
        Me.GroupBox2.Controls.Add(Me.LblBuscarCliente)
        Me.GroupBox2.Controls.Add(Me.TxtBuscarCliente)
        Me.GroupBox2.Controls.Add(Me.LblBuscarProducto)
        Me.GroupBox2.Controls.Add(Me.TxtBuscarProducto)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarVentas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 420)
        Me.GroupBox2.Size = New System.Drawing.Size(760, 80)
        Me.GroupBox2.Text = "Buscar Ventas (INNER JOIN)"

        ' LblBuscarCliente
        Me.LblBuscarCliente.AutoSize = True
        Me.LblBuscarCliente.Location = New System.Drawing.Point(10, 25)
        Me.LblBuscarCliente.Text = "Cliente:"
        Me.TxtBuscarCliente.Location = New System.Drawing.Point(80, 25)
        Me.TxtBuscarCliente.Size = New System.Drawing.Size(150, 20)

        ' LblBuscarProducto
        Me.LblBuscarProducto.AutoSize = True
        Me.LblBuscarProducto.Location = New System.Drawing.Point(250, 25)
        Me.LblBuscarProducto.Text = "Producto:"
        Me.TxtBuscarProducto.Location = New System.Drawing.Point(330, 25)
        Me.TxtBuscarProducto.Size = New System.Drawing.Size(150, 20)

        ' BtnBuscarVentas
        Me.BtnBuscarVentas.Location = New System.Drawing.Point(510, 25)
        Me.BtnBuscarVentas.Size = New System.Drawing.Size(100, 25)
        Me.BtnBuscarVentas.Text = "Buscar"

        ' DgvResultados
        Me.DgvResultados.Location = New System.Drawing.Point(12, 510)
        Me.DgvResultados.Name = "DgvResultados"
        Me.DgvResultados.Size = New System.Drawing.Size(760, 200)
        Me.DgvResultados.TabIndex = 2

        ' BtnLimpiar
        Me.BtnLimpiar.Location = New System.Drawing.Point(130, 380)
        Me.BtnLimpiar.Size = New System.Drawing.Size(110, 30)
        Me.BtnLimpiar.Text = "Limpiar"

        ' BtnSalir
        Me.BtnSalir.Location = New System.Drawing.Point(662, 380)
        Me.BtnSalir.Size = New System.Drawing.Size(110, 30)
        Me.BtnSalir.Text = "Salir"

        ' FormVentas
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 720)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvDetalles)
        Me.Controls.Add(Me.LblTotalVenta)
        Me.Controls.Add(Me.BtnGuardarVenta)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DgvResultados)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FormVentas"
        Me.Text = "Sistema de Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCliente As System.Windows.Forms.Label
    Friend WithEvents CboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents LblVendedor As System.Windows.Forms.Label
    Friend WithEvents CboVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents LblProducto As System.Windows.Forms.Label
    Friend WithEvents CboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents BtnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents DgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents LblTotalVenta As System.Windows.Forms.Label
    Friend WithEvents BtnGuardarVenta As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblBuscarCliente As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarCliente As System.Windows.Forms.TextBox
    Friend WithEvents LblBuscarProducto As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarProducto As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscarVentas As System.Windows.Forms.Button
    Friend WithEvents DgvResultados As System.Windows.Forms.DataGridView
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
End Class