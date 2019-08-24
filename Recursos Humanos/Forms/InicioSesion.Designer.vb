<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Lbl_Notificacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Location = New System.Drawing.Point(124, 30)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(120, 20)
        Me.Txt_Usuario.TabIndex = 2
        '
        'Txt_Password
        '
        Me.Txt_Password.Location = New System.Drawing.Point(124, 73)
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Password.Size = New System.Drawing.Size(120, 20)
        Me.Txt_Password.TabIndex = 3
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(11, 181)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(119, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Registrar nuevo usuario"
        '
        'Btn_Login
        '
        Me.Btn_Login.Location = New System.Drawing.Point(141, 130)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(103, 23)
        Me.Btn_Login.TabIndex = 5
        Me.Btn_Login.Text = "Iniciar Sesión"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'Lbl_Notificacion
        '
        Me.Lbl_Notificacion.AutoSize = True
        Me.Lbl_Notificacion.Location = New System.Drawing.Point(31, 118)
        Me.Lbl_Notificacion.Name = "Lbl_Notificacion"
        Me.Lbl_Notificacion.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Notificacion.TabIndex = 6
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 219)
        Me.Controls.Add(Me.Lbl_Notificacion)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Txt_Password)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InicioSesion"
        Me.Text = "Inicio de sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Btn_Login As Button
    Friend WithEvents Lbl_Notificacion As Label
End Class
