<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Localidades
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
        Me.DGV_Localidades = New System.Windows.Forms.DataGridView()
        Me.Txt_ID = New System.Windows.Forms.TextBox()
        Me.Txt_Ciudad = New System.Windows.Forms.TextBox()
        Me.Txt_Direccion = New System.Windows.Forms.TextBox()
        Me.Txt_Departamento = New System.Windows.Forms.TextBox()
        Me.CMB_Paises = New System.Windows.Forms.ComboBox()
        CType(Me.DGV_Localidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOCALIDADES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Localidad ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ciudad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Departamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "País"
        '
        'DGV_Localidades
        '
        Me.DGV_Localidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Localidades.Location = New System.Drawing.Point(38, 267)
        Me.DGV_Localidades.Name = "DGV_Localidades"
        Me.DGV_Localidades.Size = New System.Drawing.Size(432, 100)
        Me.DGV_Localidades.TabIndex = 6
        '
        'Txt_ID
        '
        Me.Txt_ID.Location = New System.Drawing.Point(139, 69)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.ReadOnly = True
        Me.Txt_ID.Size = New System.Drawing.Size(178, 20)
        Me.Txt_ID.TabIndex = 7
        '
        'Txt_Ciudad
        '
        Me.Txt_Ciudad.Location = New System.Drawing.Point(139, 110)
        Me.Txt_Ciudad.Name = "Txt_Ciudad"
        Me.Txt_Ciudad.Size = New System.Drawing.Size(178, 20)
        Me.Txt_Ciudad.TabIndex = 8
        '
        'Txt_Direccion
        '
        Me.Txt_Direccion.Location = New System.Drawing.Point(139, 149)
        Me.Txt_Direccion.Multiline = True
        Me.Txt_Direccion.Name = "Txt_Direccion"
        Me.Txt_Direccion.Size = New System.Drawing.Size(178, 30)
        Me.Txt_Direccion.TabIndex = 9
        '
        'Txt_Departamento
        '
        Me.Txt_Departamento.Location = New System.Drawing.Point(139, 189)
        Me.Txt_Departamento.Name = "Txt_Departamento"
        Me.Txt_Departamento.Size = New System.Drawing.Size(178, 20)
        Me.Txt_Departamento.TabIndex = 11
        '
        'CMB_Paises
        '
        Me.CMB_Paises.FormattingEnabled = True
        Me.CMB_Paises.Location = New System.Drawing.Point(139, 222)
        Me.CMB_Paises.Name = "CMB_Paises"
        Me.CMB_Paises.Size = New System.Drawing.Size(178, 21)
        Me.CMB_Paises.TabIndex = 10
        '
        'Localidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 379)
        Me.Controls.Add(Me.Txt_Departamento)
        Me.Controls.Add(Me.CMB_Paises)
        Me.Controls.Add(Me.Txt_Direccion)
        Me.Controls.Add(Me.Txt_Ciudad)
        Me.Controls.Add(Me.Txt_ID)
        Me.Controls.Add(Me.DGV_Localidades)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Localidades"
        Me.Text = "Localidades"
        CType(Me.DGV_Localidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DGV_Localidades As DataGridView
    Friend WithEvents Txt_ID As TextBox
    Friend WithEvents Txt_Ciudad As TextBox
    Friend WithEvents Txt_Direccion As TextBox
    Friend WithEvents Txt_Departamento As TextBox
    Friend WithEvents CMB_Paises As ComboBox
End Class
