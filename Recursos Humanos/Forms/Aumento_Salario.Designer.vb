<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aumento_Salario
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_Puesto = New System.Windows.Forms.TextBox()
        Me.Txt_Salario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_NNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_NSalario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_NPuesto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DGV_Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aumento de Salarios"
        '
        'DGV_Empleados
        '
        Me.DGV_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Empleados.Location = New System.Drawing.Point(78, 50)
        Me.DGV_Empleados.Name = "DGV_Empleados"
        Me.DGV_Empleados.Size = New System.Drawing.Size(498, 136)
        Me.DGV_Empleados.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Puesto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Salario Actual"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(102, 35)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.ReadOnly = True
        Me.Txt_Nombre.Size = New System.Drawing.Size(140, 20)
        Me.Txt_Nombre.TabIndex = 22
        '
        'Txt_Puesto
        '
        Me.Txt_Puesto.Location = New System.Drawing.Point(102, 71)
        Me.Txt_Puesto.Name = "Txt_Puesto"
        Me.Txt_Puesto.ReadOnly = True
        Me.Txt_Puesto.Size = New System.Drawing.Size(140, 20)
        Me.Txt_Puesto.TabIndex = 23
        '
        'Txt_Salario
        '
        Me.Txt_Salario.Location = New System.Drawing.Point(102, 105)
        Me.Txt_Salario.Name = "Txt_Salario"
        Me.Txt_Salario.ReadOnly = True
        Me.Txt_Salario.Size = New System.Drawing.Size(140, 20)
        Me.Txt_Salario.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_Salario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Puesto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 147)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actual"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_NNombre)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Txt_NSalario)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Txt_NPuesto)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(353, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 147)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nuevo"
        '
        'Txt_NNombre
        '
        Me.Txt_NNombre.Location = New System.Drawing.Point(102, 32)
        Me.Txt_NNombre.Name = "Txt_NNombre"
        Me.Txt_NNombre.ReadOnly = True
        Me.Txt_NNombre.Size = New System.Drawing.Size(140, 20)
        Me.Txt_NNombre.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Nombre"
        '
        'Txt_NSalario
        '
        Me.Txt_NSalario.Location = New System.Drawing.Point(102, 105)
        Me.Txt_NSalario.Name = "Txt_NSalario"
        Me.Txt_NSalario.Size = New System.Drawing.Size(140, 20)
        Me.Txt_NSalario.TabIndex = 24
        Me.Txt_NSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Puesto"
        '
        'Txt_NPuesto
        '
        Me.Txt_NPuesto.Location = New System.Drawing.Point(102, 71)
        Me.Txt_NPuesto.Name = "Txt_NPuesto"
        Me.Txt_NPuesto.ReadOnly = True
        Me.Txt_NPuesto.Size = New System.Drawing.Size(140, 20)
        Me.Txt_NPuesto.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Nuevo Salario"
        '
        'Aumento_Salario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 398)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV_Empleados)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aumento_Salario"
        Me.Text = "Aumento_Salario"
        CType(Me.DGV_Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_Empleados As DataGridView
    Friend WithEvents Label2 As Label
    Public WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Txt_Puesto As TextBox
    Friend WithEvents Txt_Salario As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Txt_NNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_NSalario As TextBox
    Public WithEvents Label7 As Label
    Friend WithEvents Txt_NPuesto As TextBox
    Friend WithEvents Label8 As Label
End Class
