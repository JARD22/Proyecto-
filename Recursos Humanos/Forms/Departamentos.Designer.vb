<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Departamentos
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
        Me.DGV_Departamentos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CMB_Localidades = New System.Windows.Forms.ComboBox()
        Me.Txt_DepID = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_Jefe = New System.Windows.Forms.TextBox()
        CType(Me.DGV_Departamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Departamentos
        '
        Me.DGV_Departamentos.AllowUserToDeleteRows = False
        Me.DGV_Departamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Departamentos.Location = New System.Drawing.Point(34, 226)
        Me.DGV_Departamentos.Name = "DGV_Departamentos"
        Me.DGV_Departamentos.Size = New System.Drawing.Size(459, 98)
        Me.DGV_Departamentos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DEPARTAMENTOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Departamento ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jefe Departamento(ID)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Localidad "
        '
        'CMB_Localidades
        '
        Me.CMB_Localidades.FormattingEnabled = True
        Me.CMB_Localidades.Location = New System.Drawing.Point(171, 172)
        Me.CMB_Localidades.Name = "CMB_Localidades"
        Me.CMB_Localidades.Size = New System.Drawing.Size(144, 21)
        Me.CMB_Localidades.TabIndex = 6
        '
        'Txt_DepID
        '
        Me.Txt_DepID.Location = New System.Drawing.Point(170, 64)
        Me.Txt_DepID.Name = "Txt_DepID"
        Me.Txt_DepID.ReadOnly = True
        Me.Txt_DepID.Size = New System.Drawing.Size(144, 20)
        Me.Txt_DepID.TabIndex = 7
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(170, 95)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(144, 20)
        Me.Txt_Nombre.TabIndex = 8
        '
        'Txt_Jefe
        '
        Me.Txt_Jefe.Location = New System.Drawing.Point(171, 136)
        Me.Txt_Jefe.Name = "Txt_Jefe"
        Me.Txt_Jefe.Size = New System.Drawing.Size(144, 20)
        Me.Txt_Jefe.TabIndex = 9
        '
        'Departamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 352)
        Me.Controls.Add(Me.Txt_Jefe)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Txt_DepID)
        Me.Controls.Add(Me.CMB_Localidades)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_Departamentos)
        Me.Name = "Departamentos"
        Me.Text = "Departamentos"
        CType(Me.DGV_Departamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Departamentos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CMB_Localidades As ComboBox
    Friend WithEvents Txt_DepID As TextBox
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Txt_Jefe As TextBox
End Class
