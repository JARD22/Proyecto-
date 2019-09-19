<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_ID = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_Apellido = New System.Windows.Forms.TextBox()
        Me.Txt_Salario = New System.Windows.Forms.TextBox()
        Me.Txt_Correo = New System.Windows.Forms.TextBox()
        Me.Txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cmb_Puesto = New System.Windows.Forms.ComboBox()
        Me.PB_Foto = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lbl_RegistroEmpleados = New System.Windows.Forms.Label()
        Me.DGV_Empleados = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_Identidad = New System.Windows.Forms.TextBox()
        CType(Me.PB_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Salario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefono"
        '
        'Txt_ID
        '
        Me.Txt_ID.Location = New System.Drawing.Point(175, 61)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(121, 20)
        Me.Txt_ID.TabIndex = 6
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(175, 102)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Nombre.TabIndex = 7
        '
        'Txt_Apellido
        '
        Me.Txt_Apellido.Location = New System.Drawing.Point(175, 143)
        Me.Txt_Apellido.Name = "Txt_Apellido"
        Me.Txt_Apellido.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Apellido.TabIndex = 8
        '
        'Txt_Salario
        '
        Me.Txt_Salario.Location = New System.Drawing.Point(175, 189)
        Me.Txt_Salario.Name = "Txt_Salario"
        Me.Txt_Salario.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Salario.TabIndex = 9
        '
        'Txt_Correo
        '
        Me.Txt_Correo.Location = New System.Drawing.Point(175, 233)
        Me.Txt_Correo.Name = "Txt_Correo"
        Me.Txt_Correo.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Correo.TabIndex = 10
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Location = New System.Drawing.Point(175, 269)
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Telefono.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Puesto"
        '
        'Cmb_Puesto
        '
        Me.Cmb_Puesto.FormattingEnabled = True
        Me.Cmb_Puesto.Location = New System.Drawing.Point(175, 320)
        Me.Cmb_Puesto.Name = "Cmb_Puesto"
        Me.Cmb_Puesto.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_Puesto.TabIndex = 13
        '
        'PB_Foto
        '
        Me.PB_Foto.Location = New System.Drawing.Point(473, 41)
        Me.PB_Foto.Name = "PB_Foto"
        Me.PB_Foto.Size = New System.Drawing.Size(135, 143)
        Me.PB_Foto.TabIndex = 14
        Me.PB_Foto.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(493, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cargar Imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lbl_RegistroEmpleados
        '
        Me.Lbl_RegistroEmpleados.AutoSize = True
        Me.Lbl_RegistroEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistroEmpleados.Location = New System.Drawing.Point(207, 9)
        Me.Lbl_RegistroEmpleados.Name = "Lbl_RegistroEmpleados"
        Me.Lbl_RegistroEmpleados.Size = New System.Drawing.Size(228, 24)
        Me.Lbl_RegistroEmpleados.TabIndex = 16
        Me.Lbl_RegistroEmpleados.Text = "Registro de Empleados"
        '
        'DGV_Empleados
        '
        Me.DGV_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Empleados.Location = New System.Drawing.Point(55, 376)
        Me.DGV_Empleados.Name = "DGV_Empleados"
        Me.DGV_Empleados.Size = New System.Drawing.Size(498, 136)
        Me.DGV_Empleados.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "No. Identidad"
        '
        'Txt_Identidad
        '
        Me.Txt_Identidad.Location = New System.Drawing.Point(432, 266)
        Me.Txt_Identidad.Name = "Txt_Identidad"
        Me.Txt_Identidad.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Identidad.TabIndex = 19
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 528)
        Me.Controls.Add(Me.Txt_Identidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGV_Empleados)
        Me.Controls.Add(Me.Lbl_RegistroEmpleados)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PB_Foto)
        Me.Controls.Add(Me.Cmb_Puesto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_Telefono)
        Me.Controls.Add(Me.Txt_Correo)
        Me.Controls.Add(Me.Txt_Salario)
        Me.Controls.Add(Me.Txt_Apellido)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Txt_ID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        CType(Me.PB_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_ID As TextBox
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Txt_Apellido As TextBox
    Friend WithEvents Txt_Salario As TextBox
    Friend WithEvents Txt_Correo As TextBox
    Friend WithEvents Txt_Telefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Cmb_Puesto As ComboBox
    Friend WithEvents PB_Foto As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Lbl_RegistroEmpleados As Label
    Friend WithEvents DGV_Empleados As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_Identidad As TextBox
End Class
