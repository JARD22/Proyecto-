<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pais
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
        Me.CMB_Regiones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.DGV_Paises = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_Paises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMB_Regiones
        '
        Me.CMB_Regiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_Regiones.FormattingEnabled = True
        Me.CMB_Regiones.Location = New System.Drawing.Point(134, 37)
        Me.CMB_Regiones.Name = "CMB_Regiones"
        Me.CMB_Regiones.Size = New System.Drawing.Size(142, 21)
        Me.CMB_Regiones.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Regiones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción"
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.Location = New System.Drawing.Point(134, 82)
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(142, 20)
        Me.Txt_Codigo.TabIndex = 5
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(134, 123)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(142, 20)
        Me.Txt_Nombre.TabIndex = 6
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.Enabled = False
        Me.Txt_Descripcion.Location = New System.Drawing.Point(134, 160)
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(142, 20)
        Me.Txt_Descripcion.TabIndex = 7
        '
        'DGV_Paises
        '
        Me.DGV_Paises.AllowUserToAddRows = False
        Me.DGV_Paises.AllowUserToDeleteRows = False
        Me.DGV_Paises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Paises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Paises.Location = New System.Drawing.Point(23, 218)
        Me.DGV_Paises.Name = "DGV_Paises"
        Me.DGV_Paises.ReadOnly = True
        Me.DGV_Paises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Paises.Size = New System.Drawing.Size(376, 88)
        Me.DGV_Paises.TabIndex = 9
        '
        'Pais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 336)
        Me.Controls.Add(Me.DGV_Paises)
        Me.Controls.Add(Me.Txt_Descripcion)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Txt_Codigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMB_Regiones)
        Me.Name = "Pais"
        Me.Text = "Pais"
        CType(Me.DGV_Paises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DGV_Paises As DataGridView
    Public WithEvents CMB_Regiones As ComboBox
    Public WithEvents Txt_Codigo As TextBox
    Public WithEvents Txt_Nombre As TextBox
    Public WithEvents Txt_Descripcion As TextBox
End Class
