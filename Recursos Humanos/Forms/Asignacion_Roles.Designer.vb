<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Asignacion_Roles
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
        Me.DGV_Roles_Asignados = New System.Windows.Forms.DataGridView()
        Me.Rol_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Roles_Disponibles = New System.Windows.Forms.DataGridView()
        Me.BTN_Asignar = New System.Windows.Forms.Button()
        Me.BTN_Revocar = New System.Windows.Forms.Button()
        Me.CMB_Usuarios = New System.Windows.Forms.ComboBox()
        Me.LBL_Usuario = New System.Windows.Forms.Label()
        Me.LBL_RolesDisponibles = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGV_Roles_Asignados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Roles_Disponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Roles_Asignados
        '
        Me.DGV_Roles_Asignados.AllowUserToAddRows = False
        Me.DGV_Roles_Asignados.AllowUserToDeleteRows = False
        Me.DGV_Roles_Asignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Roles_Asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Roles_Asignados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rol_ID, Me.Nombre})
        Me.DGV_Roles_Asignados.Location = New System.Drawing.Point(357, 116)
        Me.DGV_Roles_Asignados.Name = "DGV_Roles_Asignados"
        Me.DGV_Roles_Asignados.ReadOnly = True
        Me.DGV_Roles_Asignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Roles_Asignados.Size = New System.Drawing.Size(172, 204)
        Me.DGV_Roles_Asignados.TabIndex = 2
        '
        'Rol_ID
        '
        Me.Rol_ID.HeaderText = "Rol_ID"
        Me.Rol_ID.Name = "Rol_ID"
        Me.Rol_ID.ReadOnly = True
        Me.Rol_ID.Width = 65
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 69
        '
        'DGV_Roles_Disponibles
        '
        Me.DGV_Roles_Disponibles.AllowUserToAddRows = False
        Me.DGV_Roles_Disponibles.AllowUserToDeleteRows = False
        Me.DGV_Roles_Disponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Roles_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Roles_Disponibles.Location = New System.Drawing.Point(78, 116)
        Me.DGV_Roles_Disponibles.Name = "DGV_Roles_Disponibles"
        Me.DGV_Roles_Disponibles.ReadOnly = True
        Me.DGV_Roles_Disponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Roles_Disponibles.Size = New System.Drawing.Size(172, 204)
        Me.DGV_Roles_Disponibles.TabIndex = 3
        '
        'BTN_Asignar
        '
        Me.BTN_Asignar.Location = New System.Drawing.Point(265, 174)
        Me.BTN_Asignar.Name = "BTN_Asignar"
        Me.BTN_Asignar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Asignar.TabIndex = 4
        Me.BTN_Asignar.Text = ">"
        Me.BTN_Asignar.UseVisualStyleBackColor = True
        '
        'BTN_Revocar
        '
        Me.BTN_Revocar.Location = New System.Drawing.Point(265, 225)
        Me.BTN_Revocar.Name = "BTN_Revocar"
        Me.BTN_Revocar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Revocar.TabIndex = 5
        Me.BTN_Revocar.Text = "<"
        Me.BTN_Revocar.UseVisualStyleBackColor = True
        '
        'CMB_Usuarios
        '
        Me.CMB_Usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_Usuarios.FormattingEnabled = True
        Me.CMB_Usuarios.Location = New System.Drawing.Point(229, 40)
        Me.CMB_Usuarios.Name = "CMB_Usuarios"
        Me.CMB_Usuarios.Size = New System.Drawing.Size(177, 21)
        Me.CMB_Usuarios.TabIndex = 6
        '
        'LBL_Usuario
        '
        Me.LBL_Usuario.AutoSize = True
        Me.LBL_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Usuario.Location = New System.Drawing.Point(146, 38)
        Me.LBL_Usuario.Name = "LBL_Usuario"
        Me.LBL_Usuario.Size = New System.Drawing.Size(64, 20)
        Me.LBL_Usuario.TabIndex = 7
        Me.LBL_Usuario.Text = "Usuario"
        '
        'LBL_RolesDisponibles
        '
        Me.LBL_RolesDisponibles.AutoSize = True
        Me.LBL_RolesDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_RolesDisponibles.Location = New System.Drawing.Point(89, 90)
        Me.LBL_RolesDisponibles.Name = "LBL_RolesDisponibles"
        Me.LBL_RolesDisponibles.Size = New System.Drawing.Size(136, 20)
        Me.LBL_RolesDisponibles.TabIndex = 8
        Me.LBL_RolesDisponibles.Text = "Roles Disponibles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(370, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Roles Asignados"
        '
        'Asignacion_Roles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(584, 381)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBL_RolesDisponibles)
        Me.Controls.Add(Me.LBL_Usuario)
        Me.Controls.Add(Me.CMB_Usuarios)
        Me.Controls.Add(Me.BTN_Revocar)
        Me.Controls.Add(Me.BTN_Asignar)
        Me.Controls.Add(Me.DGV_Roles_Disponibles)
        Me.Controls.Add(Me.DGV_Roles_Asignados)
        Me.Name = "Asignacion_Roles"
        Me.Text = "Asignacion_Roles"
        CType(Me.DGV_Roles_Asignados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Roles_Disponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Roles_Asignados As DataGridView
    Friend WithEvents DGV_Roles_Disponibles As DataGridView
    Friend WithEvents BTN_Asignar As Button
    Friend WithEvents BTN_Revocar As Button
    Friend WithEvents CMB_Usuarios As ComboBox
    Friend WithEvents LBL_Usuario As Label
    Friend WithEvents LBL_RolesDisponibles As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Rol_ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
End Class
