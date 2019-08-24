<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Crea_Modifica_Rol
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGV_ROLES = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_RolID = New System.Windows.Forms.TextBox()
        Me.Txt_Desc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGV_ROLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_ROLES
        '
        Me.DGV_ROLES.AllowUserToAddRows = False
        Me.DGV_ROLES.AllowUserToDeleteRows = False
        Me.DGV_ROLES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_ROLES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ROLES.Location = New System.Drawing.Point(72, 206)
        Me.DGV_ROLES.Name = "DGV_ROLES"
        Me.DGV_ROLES.ReadOnly = True
        Me.DGV_ROLES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ROLES.Size = New System.Drawing.Size(376, 88)
        Me.DGV_ROLES.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rol ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripcion"
        '
        'Txt_RolID
        '
        Me.Txt_RolID.Location = New System.Drawing.Point(150, 72)
        Me.Txt_RolID.Name = "Txt_RolID"
        Me.Txt_RolID.ReadOnly = True
        Me.Txt_RolID.Size = New System.Drawing.Size(104, 20)
        Me.Txt_RolID.TabIndex = 5
        '
        'Txt_Desc
        '
        Me.Txt_Desc.Location = New System.Drawing.Point(150, 114)
        Me.Txt_Desc.Multiline = True
        Me.Txt_Desc.Name = "Txt_Desc"
        Me.Txt_Desc.Size = New System.Drawing.Size(319, 49)
        Me.Txt_Desc.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(213, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Crear Roles"
        '
        'Crea_Modifica_Rol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 337)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Desc)
        Me.Controls.Add(Me.Txt_RolID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_ROLES)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Crea_Modifica_Rol"
        Me.Text = "Crea_Modifica_Rol"
        CType(Me.DGV_ROLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_ROLES As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents Txt_RolID As TextBox
    Public WithEvents Txt_Desc As TextBox
End Class
