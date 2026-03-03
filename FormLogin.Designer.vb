<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.BtnCambiarContraseña = New System.Windows.Forms.Button()
        Me.LblIntentos = New System.Windows.Forms.Label()
        Me.SuspendLayout()

        ' LblUsuario
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(50, 50)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(50, 13)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario:"

        ' TxtUsuario
        Me.TxtUsuario.Location = New System.Drawing.Point(120, 50)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(200, 20)
        Me.TxtUsuario.TabIndex = 1

        ' LblContraseña
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Location = New System.Drawing.Point(50, 100)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(64, 13)
        Me.LblContraseña.TabIndex = 2
        Me.LblContraseña.Text = "Contraseña:"

        ' TxtContraseña
        Me.TxtContraseña.Location = New System.Drawing.Point(120, 100)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = "*"c
        Me.TxtContraseña.Size = New System.Drawing.Size(200, 20)
        Me.TxtContraseña.TabIndex = 3

        ' BtnEntrar
        Me.BtnEntrar.Location = New System.Drawing.Point(120, 150)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(90, 30)
        Me.BtnEntrar.TabIndex = 4
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = True

        ' BtnCambiarContraseña
        Me.BtnCambiarContraseña.Location = New System.Drawing.Point(230, 150)
        Me.BtnCambiarContraseña.Name = "BtnCambiarContraseña"
        Me.BtnCambiarContraseña.Size = New System.Drawing.Size(90, 30)
        Me.BtnCambiarContraseña.TabIndex = 5
        Me.BtnCambiarContraseña.Text = "Cambiar Contraseña"
        Me.BtnCambiarContraseña.UseVisualStyleBackColor = True

        ' LblIntentos
        Me.LblIntentos.AutoSize = True
        Me.LblIntentos.Location = New System.Drawing.Point(50, 200)
        Me.LblIntentos.Name = "LblIntentos"
        Me.LblIntentos.Size = New System.Drawing.Size(100, 13)
        Me.LblIntentos.TabIndex = 6
        Me.LblIntentos.Text = "Intentos restantes: 3"

        ' FormLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 250)
        Me.Controls.Add(Me.LblIntentos)
        Me.Controls.Add(Me.BtnCambiarContraseña)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.LblContraseña)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblUsuario)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LblContraseña As System.Windows.Forms.Label
    Friend WithEvents TxtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents BtnEntrar As System.Windows.Forms.Button
    Friend WithEvents BtnCambiarContraseña As System.Windows.Forms.Button
    Friend WithEvents LblIntentos As System.Windows.Forms.Label