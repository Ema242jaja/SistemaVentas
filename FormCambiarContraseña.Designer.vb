<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCambiarContraseña
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
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblContraseñaActual = New System.Windows.Forms.Label()
        Me.TxtContraseñaActual = New System.Windows.Forms.TextBox()
        Me.LblContraseñaNueva = New System.Windows.Forms.Label()
        Me.TxtContraseñaNueva = New System.Windows.Forms.TextBox()
        Me.LblConfirmar = New System.Windows.Forms.Label()
        Me.TxtConfirmar = New System.Windows.Forms.TextBox()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        ' LblUsuario
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(20, 20)
        Me.LblUsuario.Text = "Usuario:" 

        ' TxtUsuario
        Me.TxtUsuario.Location = New System.Drawing.Point(120, 20)
        Me.TxtUsuario.Size = New System.Drawing.Size(200, 20)

        ' LblContraseñaActual
        Me.LblContraseñaActual.AutoSize = True
        Me.LblContraseñaActual.Location = New System.Drawing.Point(20, 60)
        Me.LblContraseñaActual.Text = "Contraseña Actual:" 

        ' TxtContraseñaActual
        Me.TxtContraseñaActual.Location = New System.Drawing.Point(120, 60)
        Me.TxtContraseñaActual.Size = New System.Drawing.Size(200, 20)
        Me.TxtContraseñaActual.PasswordChar = "*"c\n
        ' LblContraseñaNueva
        Me.LblContraseñaNueva.AutoSize = True
        Me.LblContraseñaNueva.Location = New System.Drawing.Point(20, 100)
        Me.LblContraseñaNueva.Text = "Contraseña Nueva:" 

        ' TxtContraseñaNueva
        Me.TxtContraseñaNueva.Location = New System.Drawing.Point(120, 100)
        Me.TxtContraseñaNueva.Size = New System.Drawing.Size(200, 20)
        Me.TxtContraseñaNueva.PasswordChar = "*"c

        ' LblConfirmar
        Me.LblConfirmar.AutoSize = True
        Me.LblConfirmar.Location = New System.Drawing.Point(20, 140)
        Me.LblConfirmar.Text = "Confirmar:" 

        ' TxtConfirmar
        Me.TxtConfirmar.Location = New System.Drawing.Point(120, 140)
        Me.TxtConfirmar.Size = New System.Drawing.Size(200, 20)
        Me.TxtConfirmar.PasswordChar = "*"c

        ' BtnCambiar
        Me.BtnCambiar.Location = New System.Drawing.Point(120, 180)
        Me.BtnCambiar.Size = New System.Drawing.Size(90, 30)
        Me.BtnCambiar.Text = "Cambiar" 

        ' BtnCancelar
        Me.BtnCancelar.Location = New System.Drawing.Point(230, 180)
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.BtnCancelar.Text = "Cancelar" 

        ' FormCambiarContraseña
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 230)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblContraseñaActual)
        Me.Controls.Add(Me.TxtContraseñaActual)
        Me.Controls.Add(Me.LblContraseñaNueva)
        Me.Controls.Add(Me.TxtContraseñaNueva)
        Me.Controls.Add(Me.LblConfirmar)
        Me.Controls.Add(Me.TxtConfirmar)
        Me.Controls.Add(Me.BtnCambiar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Name = "FormCambiarContraseña"
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LblContraseñaActual As System.Windows.Forms.Label
    Friend WithEvents TxtContraseñaActual As System.Windows.Forms.TextBox
    Friend WithEvents LblContraseñaNueva As System.Windows.Forms.Label
    Friend WithEvents TxtContraseñaNueva As System.Windows.Forms.TextBox
    Friend WithEvents LblConfirmar As System.Windows.Forms.Label
    Friend WithEvents TxtConfirmar As System.Windows.Forms.TextBox
    Friend WithEvents BtnCambiar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class