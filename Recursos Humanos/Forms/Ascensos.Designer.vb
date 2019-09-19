<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ascensos
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
        Me.DGV_Empleados = New System.Windows.Forms.DataGridView()
        Me.GBX_Nuevo = New System.Windows.Forms.GroupBox()
        Me.GBX_Actual = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtAC_NombreCompleto = New System.Windows.Forms.TextBox()
        Me.TxtAC_IdPuesto = New System.Windows.Forms.TextBox()
        Me.TxtAC_Puesto = New System.Windows.Forms.TextBox()
        Me.TxtAC_Salario = New System.Windows.Forms.TextBox()
        Me.CmbNV_Departamento = New System.Windows.Forms.ComboBox()
        Me.CmbNV_Puestos = New System.Windows.Forms.ComboBox()
        Me.CmbNV_Salario = New System.Windows.Forms.TextBox()
        Me.Lbl_Empleados = New System.Windows.Forms.Label()
        CType(Me.DGV_Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBX_Nuevo.SuspendLayout()
        Me.GBX_Actual.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Empleados
        '
        Me.DGV_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Empleados.Location = New System.Drawing.Point(105, 62)
        Me.DGV_Empleados.Name = "DGV_Empleados"
        Me.DGV_Empleados.Size = New System.Drawing.Size(402, 107)
        Me.DGV_Empleados.TabIndex = 0
        '
        'GBX_Nuevo
        '
        Me.GBX_Nuevo.Controls.Add(Me.CmbNV_Salario)
        Me.GBX_Nuevo.Controls.Add(Me.CmbNV_Puestos)
        Me.GBX_Nuevo.Controls.Add(Me.CmbNV_Departamento)
        Me.GBX_Nuevo.Controls.Add(Me.Label3)
        Me.GBX_Nuevo.Controls.Add(Me.Label2)
        Me.GBX_Nuevo.Controls.Add(Me.Label1)
        Me.GBX_Nuevo.Location = New System.Drawing.Point(328, 186)
        Me.GBX_Nuevo.Name = "GBX_Nuevo"
        Me.GBX_Nuevo.Size = New System.Drawing.Size(260, 150)
        Me.GBX_Nuevo.TabIndex = 1
        Me.GBX_Nuevo.TabStop = False
        Me.GBX_Nuevo.Text = "Nuevo"
        '
        'GBX_Actual
        '
        Me.GBX_Actual.Controls.Add(Me.TxtAC_Salario)
        Me.GBX_Actual.Controls.Add(Me.TxtAC_Puesto)
        Me.GBX_Actual.Controls.Add(Me.TxtAC_IdPuesto)
        Me.GBX_Actual.Controls.Add(Me.TxtAC_NombreCompleto)
        Me.GBX_Actual.Controls.Add(Me.Label5)
        Me.GBX_Actual.Controls.Add(Me.Label6)
        Me.GBX_Actual.Controls.Add(Me.Label7)
        Me.GBX_Actual.Controls.Add(Me.Label8)
        Me.GBX_Actual.Location = New System.Drawing.Point(12, 186)
        Me.GBX_Actual.Name = "GBX_Actual"
        Me.GBX_Actual.Size = New System.Drawing.Size(278, 150)
        Me.GBX_Actual.TabIndex = 2
        Me.GBX_Actual.TabStop = False
        Me.GBX_Actual.Text = "Actual"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Puestos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Salario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Puesto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ID puesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Nombre Completo"
        '
        'TxtAC_NombreCompleto
        '
        Me.TxtAC_NombreCompleto.Location = New System.Drawing.Point(130, 19)
        Me.TxtAC_NombreCompleto.Name = "TxtAC_NombreCompleto"
        Me.TxtAC_NombreCompleto.Size = New System.Drawing.Size(142, 20)
        Me.TxtAC_NombreCompleto.TabIndex = 4
        '
        'TxtAC_IdPuesto
        '
        Me.TxtAC_IdPuesto.Location = New System.Drawing.Point(130, 50)
        Me.TxtAC_IdPuesto.Name = "TxtAC_IdPuesto"
        Me.TxtAC_IdPuesto.Size = New System.Drawing.Size(142, 20)
        Me.TxtAC_IdPuesto.TabIndex = 8
        '
        'TxtAC_Puesto
        '
        Me.TxtAC_Puesto.Location = New System.Drawing.Point(130, 78)
        Me.TxtAC_Puesto.Name = "TxtAC_Puesto"
        Me.TxtAC_Puesto.Size = New System.Drawing.Size(142, 20)
        Me.TxtAC_Puesto.TabIndex = 9
        '
        'TxtAC_Salario
        '
        Me.TxtAC_Salario.Location = New System.Drawing.Point(130, 108)
        Me.TxtAC_Salario.Name = "TxtAC_Salario"
        Me.TxtAC_Salario.Size = New System.Drawing.Size(142, 20)
        Me.TxtAC_Salario.TabIndex = 10
        '
        'CmbNV_Departamento
        '
        Me.CmbNV_Departamento.FormattingEnabled = True
        Me.CmbNV_Departamento.Location = New System.Drawing.Point(104, 22)
        Me.CmbNV_Departamento.Name = "CmbNV_Departamento"
        Me.CmbNV_Departamento.Size = New System.Drawing.Size(132, 21)
        Me.CmbNV_Departamento.TabIndex = 3
        '
        'CmbNV_Puestos
        '
        Me.CmbNV_Puestos.FormattingEnabled = True
        Me.CmbNV_Puestos.Location = New System.Drawing.Point(104, 53)
        Me.CmbNV_Puestos.Name = "CmbNV_Puestos"
        Me.CmbNV_Puestos.Size = New System.Drawing.Size(132, 21)
        Me.CmbNV_Puestos.TabIndex = 4
        '
        'CmbNV_Salario
        '
        Me.CmbNV_Salario.Location = New System.Drawing.Point(104, 85)
        Me.CmbNV_Salario.Name = "CmbNV_Salario"
        Me.CmbNV_Salario.Size = New System.Drawing.Size(142, 20)
        Me.CmbNV_Salario.TabIndex = 11
        '
        'Lbl_Empleados
        '
        Me.Lbl_Empleados.AutoSize = True
        Me.Lbl_Empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Empleados.Location = New System.Drawing.Point(257, 23)
        Me.Lbl_Empleados.Name = "Lbl_Empleados"
        Me.Lbl_Empleados.Size = New System.Drawing.Size(115, 24)
        Me.Lbl_Empleados.TabIndex = 5
        Me.Lbl_Empleados.Text = "Empleados"
        '
        'Ascensos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 377)
        Me.Controls.Add(Me.Lbl_Empleados)
        Me.Controls.Add(Me.GBX_Actual)
        Me.Controls.Add(Me.GBX_Nuevo)
        Me.Controls.Add(Me.DGV_Empleados)
        Me.Name = "Ascensos"
        Me.Text = "Ascensos"
        CType(Me.DGV_Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBX_Nuevo.ResumeLayout(False)
        Me.GBX_Nuevo.PerformLayout()
        Me.GBX_Actual.ResumeLayout(False)
        Me.GBX_Actual.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Empleados As DataGridView
    Friend WithEvents GBX_Nuevo As GroupBox
    Friend WithEvents TxtAC_NombreCompleto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GBX_Actual As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbNV_Salario As TextBox
    Friend WithEvents CmbNV_Puestos As ComboBox
    Friend WithEvents CmbNV_Departamento As ComboBox
    Friend WithEvents TxtAC_Salario As TextBox
    Friend WithEvents TxtAC_Puesto As TextBox
    Friend WithEvents TxtAC_IdPuesto As TextBox
    Friend WithEvents Lbl_Empleados As Label
End Class
