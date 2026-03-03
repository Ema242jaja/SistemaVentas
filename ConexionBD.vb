Imports System.Data.OleDb

Public Class ConexionBD
    Private Shared conexion As OleDbConnection
    Private Shared rutaBD As String = Application.StartupPath & "\VentasDB.accdb"

    ' Obtener conexión
    Public Shared Function ObtenerConexion() As OleDbConnection
        Try
            conexion = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & rutaBD & ";Persist Security Info=False;")
            conexion.Open()
            Return conexion
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos: " & ex.Message, MsgBoxStyle.Critical, "Error de Conexión")
            Return Nothing
        End Try
    End Function

    ' Cerrar conexión
    Public Shared Sub CerrarConexion()
        If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    ' Ejecutar consulta SELECT
    Public Shared Function EjecutarConsulta(sql As String) As DataTable
        Try
            Dim dt As New DataTable
            Dim adaptador As New OleDbDataAdapter(sql, ObtenerConexion())
            adaptador.Fill(dt)
            CerrarConexion()
            Return dt
        Catch ex As Exception
            MsgBox("Error en consulta: " & ex.Message, MsgBoxStyle.Critical, "Error SQL")
            Return Nothing
        End Try
    End Function

    ' Ejecutar comando (INSERT, UPDATE, DELETE)
    Public Shared Function EjecutarComando(sql As String) As Boolean
        Try
            Dim cmd As New OleDbCommand(sql, ObtenerConexion())
            cmd.ExecuteNonQuery()
            CerrarConexion()
            Return True
        Catch ex As Exception
            MsgBox("Error al ejecutar comando: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class