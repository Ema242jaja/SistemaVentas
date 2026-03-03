Public Class FormCambiarContraseña
    Private Sub FormCambiarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Cambiar Contraseña"
        TxtUsuario.Focus()
    End Sub

    Private Sub BtnCambiar_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click
        Dim usuario As String = TxtUsuario.Text.Trim()
        Dim contraseñaActual As String = TxtContraseñaActual.Text.Trim()
        Dim contraseñaNueva As String = TxtContraseñaNueva.Text.Trim()
        Dim confirmar As String = TxtConfirmar.Text.Trim()

        ' Validaciones
        If usuario = "" Or contraseñaActual = "" Or contraseñaNueva = "" Then
            MsgBox("Por favor complete todos los campos", MsgBoxStyle.Exclamation)
            Return
        End If

        If contraseñaNueva <> confirmar Then
            MsgBox("Las contraseñas nuevas no coinciden", MsgBoxStyle.Exclamation)
            TxtContraseñaNueva.Clear()
            TxtConfirmar.Clear()
            Return
        End If

        If contraseñaNueva.Length < 4 Then
            MsgBox("La contraseña debe tener al menos 4 caracteres", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Verificar contraseña actual
        Dim dt As DataTable = ConexionBD.EjecutarConsulta(
            "SELECT * FROM Usuarios WHERE Usuario='" & usuario & "' AND Contraseña='" & contraseñaActual & "'"
        )

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ' Actualizar contraseña
            Dim sql As String = "UPDATE Usuarios SET Contraseña='" & contraseñaNueva & "' WHERE Usuario='" & usuario & "'"
            
            If ConexionBD.EjecutarComando(sql) Then
                MsgBox("¡Contraseña actualizada exitosamente!", MsgBoxStyle.Information)
                Me.Close()
            End If
        Else
            MsgBox("Usuario o contraseña actual incorrectos", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class