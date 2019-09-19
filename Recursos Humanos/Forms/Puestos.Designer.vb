<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Puestos
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
        Me.Txt_IDPuesto = New System.Windows.Forms.TextBox()
        Me.Txt_Puesto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_SMinimo = New System.Windows.Forms.TextBox()
        Me.Txt_SMaximo = New System.Windows.Forms.TextBox()
        Me.DGV_Puestos = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_Puestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID_Puesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Puesto"
        '
        'Txt_IDPuesto
        '
        Me.Txt_IDPuesto.Location = New System.Drawing.Point(149, 43)
        Me.Txt_IDPuesto.Name = "Txt_IDPuesto"
        Me.Txt_IDPuesto.ReadOnly = True
        Me.Txt_IDPuesto.Size = New System.Drawing.Size(127, 20)
        Me.Txt_IDPuesto.TabIndex = 2
        '
        'Txt_Puesto
        '
        Me.Txt_Puesto.Location = New System.Drawing.Point(149, 71)
        Me.Txt_Puesto.Name = "Txt_Puesto"
        Me.Txt_Puesto.Size = New System.Drawing.Size(127, 20)
        Me.Txt_Puesto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Salario Mínimo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Salario Máximo"
        '
        'Txt_SMinimo
        '
        Me.Txt_SMinimo.Location = New System.Drawing.Point(149, 109)
        Me.Txt_SMinimo.Name = "Txt_SMinimo"
        Me.Txt_SMinimo.Size = New System.Drawing.Size(127, 20)
        Me.Txt_SMinimo.TabIndex = 6
        Me.Txt_SMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_SMaximo
        '
        Me.Txt_SMaximo.Location = New System.Drawing.Point(149, 147)
        Me.Txt_SMaximo.Name = "Txt_SMaximo"
        Me.Txt_SMaximo.Size = New System.Drawing.Size(127, 20)
        Me.Txt_SMaximo.TabIndex = 7
        Me.Txt_SMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DGV_Puestos
        '
        Me.DGV_Puestos.AllowUserToAddRows = False
        Me.DGV_Puestos.AllowUserToDeleteRows = False
        Me.DGV_Puestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Puestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Puestos.Location = New System.Drawing.Point(12, 207)
        Me.DGV_Puestos.Name = "DGV_Puestos"
        Me.DGV_Puestos.ReadOnly = True
        Me.DGV_Puestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Puestos.Size = New System.Drawing.Size(376, 88)
        Me.DGV_Puestos.TabIndex = 8
        '
        'Puestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 320)
        Me.Controls.Add(Me.DGV_Puestos)
        Me.Controls.Add(Me.Txt_SMaximo)
        Me.Controls.Add(Me.Txt_SMinimo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Puesto)
        Me.Controls.Add(Me.Txt_IDPuesto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Puestos"
        Me.Text = "Puestos"
        CType(Me.DGV_Puestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_IDPuesto As TextBox
    Friend WithEvents Txt_Puesto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_SMinimo As TextBox
    Friend WithEvents Txt_SMaximo As TextBox
    Friend WithEvents DGV_Puestos As DataGridView
End Class
