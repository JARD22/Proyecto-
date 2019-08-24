<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroUsuario
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
        Me.DGV_Empleados = New System.Windows.Forms.DataGridView()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Lbl_Usuario = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.Txt_Pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_CofPass = New System.Windows.Forms.TextBox()
        Me.Btn_Registrar = New System.Windows.Forms.Button()
        Me.Lbl_IDemp = New System.Windows.Forms.Label()
        CType(Me.DGV_Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleados"
        '
        'DGV_Empleados
        '
        Me.DGV_Empleados.AllowUserToAddRows = False
        Me.DGV_Empleados.AllowUserToDeleteRows = False
        Me.DGV_Empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Empleados.Location = New System.Drawing.Point(36, 41)
        Me.DGV_Empleados.Name = "DGV_Empleados"
        Me.DGV_Empleados.ReadOnly = True
        Me.DGV_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Empleados.Size = New System.Drawing.Size(376, 88)
        Me.DGV_Empleados.TabIndex = 1
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Location = New System.Drawing.Point(159, 162)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.ReadOnly = True
        Me.Txt_Usuario.Size = New System.Drawing.Size(146, 20)
        Me.Txt_Usuario.TabIndex = 2
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Location = New System.Drawing.Point(33, 162)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Usuario.TabIndex = 3
        Me.Lbl_Usuario.Text = "Usuario"
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.Location = New System.Drawing.Point(33, 201)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(61, 13)
        Me.Usuario.TabIndex = 4
        Me.Usuario.Text = "Contraseña"
        '
        'Txt_Pass
        '
        Me.Txt_Pass.Location = New System.Drawing.Point(159, 194)
        Me.Txt_Pass.MaxLength = 8
        Me.Txt_Pass.Name = "Txt_Pass"
        Me.Txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Pass.Size = New System.Drawing.Size(146, 20)
        Me.Txt_Pass.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Confirmar Contraseña"
        '
        'Txt_CofPass
        '
        Me.Txt_CofPass.Location = New System.Drawing.Point(159, 235)
        Me.Txt_CofPass.Name = "Txt_CofPass"
        Me.Txt_CofPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_CofPass.Size = New System.Drawing.Size(146, 20)
        Me.Txt_CofPass.TabIndex = 7
        '
        'Btn_Registrar
        '
        Me.Btn_Registrar.Location = New System.Drawing.Point(174, 286)
        Me.Btn_Registrar.Name = "Btn_Registrar"
        Me.Btn_Registrar.Size = New System.Drawing.Size(113, 23)
        Me.Btn_Registrar.TabIndex = 8
        Me.Btn_Registrar.Text = "Registrar"
        Me.Btn_Registrar.UseVisualStyleBackColor = True
        '
        'Lbl_IDemp
        '
        Me.Lbl_IDemp.AutoSize = True
        Me.Lbl_IDemp.Location = New System.Drawing.Point(153, 165)
        Me.Lbl_IDemp.Name = "Lbl_IDemp"
        Me.Lbl_IDemp.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_IDemp.TabIndex = 9
        Me.Lbl_IDemp.Visible = False
        '
        'RegistroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 343)
        Me.Controls.Add(Me.Lbl_IDemp)
        Me.Controls.Add(Me.Btn_Registrar)
        Me.Controls.Add(Me.Txt_CofPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Pass)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.Lbl_Usuario)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.DGV_Empleados)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistroUsuario"
        Me.Text = "Registro Usuario"
        CType(Me.DGV_Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_Empleados As DataGridView
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Lbl_Usuario As Label
    Friend WithEvents Usuario As Label
    Friend WithEvents Txt_Pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_CofPass As TextBox
    Friend WithEvents Btn_Registrar As Button
    Friend WithEvents Lbl_IDemp As Label
End Class
