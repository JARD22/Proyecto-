<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regiones
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
        Me.DGV_Regiones = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_RegionID = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        CType(Me.DGV_Regiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Regiones
        '
        Me.DGV_Regiones.AllowUserToAddRows = False
        Me.DGV_Regiones.AllowUserToDeleteRows = False
        Me.DGV_Regiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Regiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Regiones.Location = New System.Drawing.Point(23, 178)
        Me.DGV_Regiones.Name = "DGV_Regiones"
        Me.DGV_Regiones.ReadOnly = True
        Me.DGV_Regiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Regiones.Size = New System.Drawing.Size(376, 88)
        Me.DGV_Regiones.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Region ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre Región"
        '
        'Txt_RegionID
        '
        Me.Txt_RegionID.Location = New System.Drawing.Point(169, 58)
        Me.Txt_RegionID.Name = "Txt_RegionID"
        Me.Txt_RegionID.ReadOnly = True
        Me.Txt_RegionID.Size = New System.Drawing.Size(138, 20)
        Me.Txt_RegionID.TabIndex = 12
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(169, 100)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(138, 20)
        Me.Txt_Nombre.TabIndex = 13
        '
        'Regiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 309)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Txt_RegionID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_Regiones)
        Me.Name = "Regiones"
        Me.Text = "Regiones"
        CType(Me.DGV_Regiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Regiones As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_RegionID As TextBox
    Friend WithEvents Txt_Nombre As TextBox
End Class
