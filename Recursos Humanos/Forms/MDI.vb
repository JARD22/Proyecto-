Public Class MDI




    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub AsignarRolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarRolToolStripMenuItem.Click
        Dim Roles As New Asignacion_Roles
        Roles.MdiParent = Me

        Roles.Show()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargando el conexionString'
        Conexion_BD.conectar("JORGEAGUILERA", "RRHH")
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Asignando la Hora al toolstripStatus'
        ToolStripStatusLabel2.Text = String.Format("{0:G}", DateTime.Now)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CreacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreacionToolStripMenuItem.Click
        'Cargand Form de Roles en el Main'
        Crea_Modifica_Rol.MdiParent = Me
        Crea_Modifica_Rol.Show()
    End Sub

    Private Sub BTN_Guardar_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click

        '============================================================================================================='

        'GUARDAR'
        '============================================================================================================='

        'CAPTURANDO EL CONTROL ACTIVO'

        If ActiveControl Is Localidades Then
            'Verificamos que los campos esten llenos

            If Localidades.Txt_Ciudad.Text = "" And Localidades.Txt_Departamento.Text = "" And Localidades.Txt_Direccion.Text = "" Then

                MessageBox.Show("Todos los campos son obligatorios")
                Exit Sub

                ' Asignamos los valores a las variables'

            End If

            Dim ID As Integer = Localidades.Txt_ID.Text
            Dim Ciudad As String = Localidades.Txt_Ciudad.Text
            Dim Direccion As String = Localidades.Txt_Direccion.Text
            Dim Departamento As String = Localidades.Txt_Departamento.Text
            Dim Pais As String = Localidades.CMB_Paises.Text

            If Localidades.Txt_ID.Text = "" Then
                Dim NID As Integer = 0
                GuardaLocalidad(NID, Ciudad, Direccion, Departamento, Pais)
                'Preguntamos de nuevo al usuario'
                Dim result As Integer = MessageBox.Show("¿Guardar nueva localidad?", "Precaución", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                    Exit Sub
                ElseIf result = DialogResult.No Then
                    Exit Sub
                ElseIf result = DialogResult.Yes Then
                    GuardaLocalidad(NID, Ciudad, Direccion, Departamento, Pais)
                    MessageBox.Show("Nueva localidad Guardada")
                    Carga_Localidades(Localidades.DGV_Localidades)
                    Exit Sub
                End If


            End If
            Carga_Localidades(Localidades.DGV_Localidades)
        End If

        '============================================================================================================='

        If ActiveControl Is Departamentos Then
            'Validamos que los campos no esten vacios'
            If Departamentos.Txt_Nombre.Text = "" And Departamentos.Txt_Jefe.Text = "" Then
                MessageBox.Show("Todos los campos son obligatorios")
                Exit Sub
            End If
            'Asignamos las variables'
            Dim Nombre As String = Departamentos.Txt_Nombre.Text
            Dim Jefe As Integer = CInt(Departamentos.Txt_Jefe.Text)
            Dim Localidad As String = (Departamentos.CMB_Localidades.Text)
            'Llamamos a los procedimientos'
            GuardaDepto(Nombre, Jefe, Localidad)
            'Recargamos el DGV'
            CargaDepartamento(Departamentos.DGV_Departamentos, Departamentos.CMB_Localidades)
            'Limpiamos los TextBox'
            Departamentos.Txt_DepID.Clear()
            Departamentos.Txt_Jefe.Clear()
            Departamentos.Txt_Nombre.Clear()
        End If


        If ActiveControl Is Aumento_Salario Then
            Dim i As Integer = Aumento_Salario.DGV_Empleados.CurrentRow.Index
            Dim Id As Integer
            Dim Puesto As String
            Dim Salario As Double

            Id = CInt(Aumento_Salario.DGV_Empleados.Item(0, i).Value)
            Puesto = Aumento_Salario.Txt_Puesto.Text
            Salario = CDbl(Aumento_Salario.Txt_NSalario.Text)

            'Guardamos el Aumento de salario'
            Aumento_Slr(Id, Salario, Puesto)
            'Actualizamos los registros'
            Carga_Empleados(Aumento_Salario.DGV_Empleados)
        End If


        If ActiveControl Is Ascensos Then
            'Capturamos el id del empleado directo del DGV'
            Dim i As Integer = Ascensos.DGV_EmpleadosA.CurrentRow.Index
            Dim ID As Integer
            Dim Puesto As String
            Dim Salario As Double

            ID = CInt(Ascensos.DGV_EmpleadosA.Item(0, i).Value)
            Puesto = Ascensos.CmbNV_Puestos.Text
            Salario = CDbl(Ascensos.txtNV_Salario.Text)


            NuevoPuesto(ID, Puesto, Salario)
            'Volvemos a cargar el DGV con los nuevos cambios'
            Carga_Empleados(Ascensos.DGV_EmpleadosA)
        End If


        'Mandamos todos los parametros al Procedimiento para guardarlo'

        If ActiveControl Is Empleados Then

            Guardar_Empleado(CInt(Empleados.Txt_ID.Text), Empleados.Txt_Nombre.Text, Empleados.Txt_Apellido.Text, Empleados.Txt_Identidad.Text,
                             CDbl(Empleados.Txt_Salario.Text), Empleados.Txt_Correo.Text,
                             Empleados.Txt_Telefono.Text, Empleados.Cmb_Puesto.Text, Empleados.PB_Foto)
        End If

        'Fin nuevo Empleado'
        '============================================================================================================='


        If ActiveControl Is Crea_Modifica_Rol Then

            'Invocando la consulta para guardar rol'
            Guarda_Rol()
            'Actualizando el DGV'
            CargaRoles()

            'Fin Guardar Rol'
            '============================================================================================================='

            'Capturando el formulario de Regiones '
        ElseIf ActiveControl Is Regiones Then

            'Invocando la consulta para guardar region'
            Guarda_Region()

            'Cargando el DGV de REGIONES'
            CargaRegiones()

            'Fin Guardar Region'
            '============================================================================================================='
        ElseIf ActiveControl Is Pais Then
            Guardar_Pais()

            'Fin Guardar PAIS'
            '============================================================================================================='
        ElseIf ActiveControl Is Puestos Then

            Guarda_Puesto()
            Carga_Puestos()

        End If


    End Sub

    Private Sub BTN_Nuevo_Click(sender As Object, e As EventArgs) Handles BTN_Nuevo.Click

        '============================================================================================================='

        'NUEVO'
        '============================================================================================================='

        'Capturando el form Activo'

        If ActiveControl Is Localidades Then
            'Limpiamos los controles'
            Localidades.Txt_ID.Clear()
            Localidades.Txt_Direccion.Clear()
            Localidades.Txt_Departamento.Clear()
            Localidades.Txt_Ciudad.Clear()

        End If


        If ActiveControl Is Departamentos Then
            Departamentos.Txt_DepID.Clear()
            Departamentos.Txt_Jefe.Clear()
            Departamentos.Txt_Nombre.Clear()
        End If

        'Nuevo Empleado'

        If ActiveControl Is Aumento_Salario Then
            MessageBox.Show("Opción no disponible para esta Tarea")
        End If


        If ActiveControl Is Ascensos Then
            MessageBox.Show("Opción no disponible para esta Tarea")
        End If

        If ActiveControl Is Regiones Then


            'Cargando datos en el textbox Region_id'
            Ultimo_ID_Region()
            'Volvemos a cargar el DGV de regiones con los registros actualizados'
            CargaRegiones()

            'fin Nueva Region'
            '============================================================================================================='
        ElseIf ActiveControl Is Crea_Modifica_Rol Then


            'Invocando la Consulta Nuevo Rol'
            Nuevo_Rol()
            'Volvemos cargar los Roles en el DGV'
            CargaRoles()
            'Fin Nuevo Rol'
            '============================================================================================================='
        ElseIf ActiveControl Is Pais Then
            'Invocando la Consulta Guardar un Nuevo Pais'
            Nuevo_Pais()

            'Fin Nuevo Pais'
            '============================================================================================================='
        ElseIf ActiveControl Is Puestos Then
            Nuevo_Puesto()

        End If 'End if principal'

    End Sub

    Private Sub ActivacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivacionToolStripMenuItem.Click
        'Abriendo Form de activacion de usuario'
        Activacion_Usuario.MdiParent = Me
        Activacion_Usuario.Show()
    End Sub

    Private Sub BTN_Eliminar_Click(sender As Object, e As EventArgs) Handles BTN_Eliminar.Click
        'Identificando el formulario  Abierto para borrar registros'

        If ActiveControl Is Departamentos Then
            MessageBox.Show("Opción no disponible para esta Tarea")
        End If


        If ActiveControl Is Aumento_Salario Then
            MessageBox.Show("Opción no disponible para esta Tarea")
        End If

        If ActiveControl Is Ascensos Then
            MessageBox.Show("Opción no disponible para esta Tarea")
        End If

        If ActiveControl Is Crea_Modifica_Rol Then
            'Invocando la consulta Eliminar Rol'
            Elimina_Rol()

            CargaRoles()
            'Fin elimina roles'

            '============================================================================================================='

            'Eliminando Una Region'
        ElseIf ActiveControl Is Regiones Then

            'Invocando la consulta Borrar regiones'
            Elimina_Region()

            CargaRegiones()
            'Fin eliminar regiones'

            '============================================================================================================='

        ElseIf ActiveControl Is Pais Then
            Elimina_Pais()

            Carga_Pais(Pais.CMB_Regiones.Text)
            'Fin Elimina Pais'
            '============================================================================================================='
        ElseIf ActiveControl Is Puestos Then
            Elimina_Puesto()
            Carga_Puestos()


        End If
    End Sub

    Private Sub RegionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegionesToolStripMenuItem.Click

        'Abriendo el form de Regiones'
        Regiones.MdiParent = Me
        Regiones.Show()
    End Sub

    Private Sub PaísToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaísToolStripMenuItem.Click
        'Abriendo el form de paises'
        Pais.MdiParent = Me
        Pais.Show()
    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesToolStripMenuItem.Click
        Localidades.MdiParent = Me
        Localidades.Show()
    End Sub

    Private Sub PuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestosToolStripMenuItem.Click
        'Abriendo el form de Puestos'
        Puestos.MdiParent = Me
        Puestos.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click

    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        'Abriendo el form de Regiones'
        Empleados.MdiParent = Me
        Empleados.Show()
    End Sub

    Private Sub AscensosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AscensosToolStripMenuItem.Click
        Ascensos.MdiParent = Me
        Ascensos.Show()


    End Sub

    Private Sub AumentoDeSalarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AumentoDeSalarioToolStripMenuItem.Click
        Aumento_Salario.MdiParent = Me
        Aumento_Salario.Show()
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Departamentos.MdiParent = Me
        Departamentos.Show()
    End Sub
End Class