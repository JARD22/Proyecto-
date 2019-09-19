<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarRolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManteniminetoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaísToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscensosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AumentoDeSalarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BTN_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.BTN_Guardar = New System.Windows.Forms.ToolStripButton()
        Me.BTN_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ManteniminetoToolStripMenuItem, Me.EmpleadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarRolToolStripMenuItem, Me.CreacionToolStripMenuItem, Me.ActivacionToolStripMenuItem})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.NuevoToolStripMenuItem.Text = "Administracion"
        '
        'AsignarRolToolStripMenuItem
        '
        Me.AsignarRolToolStripMenuItem.Name = "AsignarRolToolStripMenuItem"
        Me.AsignarRolToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AsignarRolToolStripMenuItem.Text = "Asignar Rol"
        '
        'CreacionToolStripMenuItem
        '
        Me.CreacionToolStripMenuItem.Name = "CreacionToolStripMenuItem"
        Me.CreacionToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CreacionToolStripMenuItem.Text = "Creacion"
        '
        'ActivacionToolStripMenuItem
        '
        Me.ActivacionToolStripMenuItem.Name = "ActivacionToolStripMenuItem"
        Me.ActivacionToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ActivacionToolStripMenuItem.Text = "Activacion"
        '
        'ManteniminetoToolStripMenuItem
        '
        Me.ManteniminetoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegionesToolStripMenuItem, Me.PaísToolStripMenuItem, Me.LocalidadesToolStripMenuItem, Me.DepartamentosToolStripMenuItem, Me.PuestosToolStripMenuItem})
        Me.ManteniminetoToolStripMenuItem.Name = "ManteniminetoToolStripMenuItem"
        Me.ManteniminetoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ManteniminetoToolStripMenuItem.Text = "Mantenimineto"
        '
        'RegionesToolStripMenuItem
        '
        Me.RegionesToolStripMenuItem.Name = "RegionesToolStripMenuItem"
        Me.RegionesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.RegionesToolStripMenuItem.Text = "Regiones"
        '
        'PaísToolStripMenuItem
        '
        Me.PaísToolStripMenuItem.Name = "PaísToolStripMenuItem"
        Me.PaísToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PaísToolStripMenuItem.Text = "País"
        '
        'LocalidadesToolStripMenuItem
        '
        Me.LocalidadesToolStripMenuItem.Name = "LocalidadesToolStripMenuItem"
        Me.LocalidadesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LocalidadesToolStripMenuItem.Text = "Localidades"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'PuestosToolStripMenuItem
        '
        Me.PuestosToolStripMenuItem.Name = "PuestosToolStripMenuItem"
        Me.PuestosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PuestosToolStripMenuItem.Text = "Puestos"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.AscensosToolStripMenuItem, Me.AumentoDeSalarioToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'AscensosToolStripMenuItem
        '
        Me.AscensosToolStripMenuItem.Name = "AscensosToolStripMenuItem"
        Me.AscensosToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AscensosToolStripMenuItem.Text = "Ascensos"
        '
        'AumentoDeSalarioToolStripMenuItem
        '
        Me.AumentoDeSalarioToolStripMenuItem.Name = "AumentoDeSalarioToolStripMenuItem"
        Me.AumentoDeSalarioToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AumentoDeSalarioToolStripMenuItem.Text = "Aumento de Salario"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 727)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(693, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Usuario"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripStatusLabel2.RightToLeftAutoMirrorImage = True
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(76, 17)
        Me.ToolStripStatusLabel2.Text = "Hora y Fecha"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTN_Nuevo, Me.BTN_Guardar, Me.BTN_Eliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BTN_Nuevo
        '
        Me.BTN_Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BTN_Nuevo.Image = CType(resources.GetObject("BTN_Nuevo.Image"), System.Drawing.Image)
        Me.BTN_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_Nuevo.Name = "BTN_Nuevo"
        Me.BTN_Nuevo.Size = New System.Drawing.Size(46, 22)
        Me.BTN_Nuevo.Text = "Nuevo"
        '
        'BTN_Guardar
        '
        Me.BTN_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BTN_Guardar.Image = CType(resources.GetObject("BTN_Guardar.Image"), System.Drawing.Image)
        Me.BTN_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_Guardar.Name = "BTN_Guardar"
        Me.BTN_Guardar.Size = New System.Drawing.Size(57, 22)
        Me.BTN_Guardar.Text = "Gruardar"
        '
        'BTN_Eliminar
        '
        Me.BTN_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BTN_Eliminar.Image = CType(resources.GetObject("BTN_Eliminar.Image"), System.Drawing.Image)
        Me.BTN_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_Eliminar.Name = "BTN_Eliminar"
        Me.BTN_Eliminar.Size = New System.Drawing.Size(54, 22)
        Me.BTN_Eliminar.Text = "Eliminar"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 749)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents AsignarRolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CreacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BTN_Nuevo As ToolStripButton
    Friend WithEvents BTN_Guardar As ToolStripButton
    Friend WithEvents BTN_Eliminar As ToolStripButton
    Friend WithEvents ManteniminetoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaísToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AscensosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AumentoDeSalarioToolStripMenuItem As ToolStripMenuItem
End Class
