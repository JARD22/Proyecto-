<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activacion_Usuario
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
        Me.DGV_Usuarios = New System.Windows.Forms.DataGridView()
        Me.Lbl_Usuarios = New System.Windows.Forms.Label()
        Me.CMB_Estado = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Usuarios
        '
        Me.DGV_Usuarios.AllowUserToAddRows = False
        Me.DGV_Usuarios.AllowUserToDeleteRows = False
        Me.DGV_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Usuarios.Location = New System.Drawing.Point(25, 59)
        Me.DGV_Usuarios.Name = "DGV_Usuarios"
        Me.DGV_Usuarios.ReadOnly = True
        Me.DGV_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Usuarios.Size = New System.Drawing.Size(350, 72)
        Me.DGV_Usuarios.TabIndex = 2
        '
        'Lbl_Usuarios
        '
        Me.Lbl_Usuarios.AutoSize = True
        Me.Lbl_Usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Usuarios.Location = New System.Drawing.Point(110, 31)
        Me.Lbl_Usuarios.Name = "Lbl_Usuarios"
        Me.Lbl_Usuarios.Size = New System.Drawing.Size(97, 25)
        Me.Lbl_Usuarios.TabIndex = 3
        Me.Lbl_Usuarios.Text = "Usuarios"
        '
        'CMB_Estado
        '
        Me.CMB_Estado.Location = New System.Drawing.Point(397, 79)
        Me.CMB_Estado.Name = "CMB_Estado"
        Me.CMB_Estado.Size = New System.Drawing.Size(118, 34)
        Me.CMB_Estado.TabIndex = 4
        Me.CMB_Estado.Text = "Estado"
        Me.CMB_Estado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(424, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Activar"
        '
        'Activacion_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 180)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMB_Estado)
        Me.Controls.Add(Me.Lbl_Usuarios)
        Me.Controls.Add(Me.DGV_Usuarios)
        Me.Name = "Activacion_Usuario"
        Me.Text = "Activacion_Usuario"
        CType(Me.DGV_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Usuarios As DataGridView
    Friend WithEvents Lbl_Usuarios As Label
    Friend WithEvents CMB_Estado As Button
    Friend WithEvents Label1 As Label
End Class
