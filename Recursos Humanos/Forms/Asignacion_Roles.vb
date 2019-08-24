Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class Asignacion_Roles

    Private Sub Asignacion_Roles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGANDO EL COMBOBOX CON LOS USUARIOS'
        Try

            varconexion.Open()
            Dim Usuarios As New DataTable
            'Dim DA_Usuarios As New SqlClient.SqlCommand("SELECT_USUARIO", varconexion)
            Dim DA_Usuarios As New SqlClient.SqlDataAdapter("SELECT_USUARIO", varconexion)

            DA_Usuarios.Fill(Usuarios)
            CMB_Usuarios.DataSource = Usuarios
            'CMB_Usuarios.DisplayMember = "Usuarios"
            CMB_Usuarios.ValueMember = "Usuario"
            varconexion.Close()
        Catch ex As Exception

        End Try



        'CARGANDO LOS ROLES DISPONIBLES'
        Dim ROLES As New DataTable
        Dim DA_Roles As New SqlDataAdapter("SELECT_ROLES", varconexion)
        Me.DGV_Roles_Disponibles.Rows.Clear()
        Try
            varconexion.Open()

            DA_Roles.Fill(ROLES)
            DGV_Roles_Disponibles.DataSource = ROLES
            varconexion.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_Asignar_Click(sender As Object, e As EventArgs) Handles BTN_Asignar.Click
        Dim ID, Nombre As String
        Try
            ID = DGV_Roles_Disponibles(0, DGV_Roles_Disponibles.CurrentRow.Index).Value
            Nombre = DGV_Roles_Disponibles(1, DGV_Roles_Disponibles.CurrentRow.Index).Value

            DGV_Roles_Asignados.Rows.Add(ID, Nombre)
            DGV_Roles_Disponibles.Rows.RemoveAt(DGV_Roles_Disponibles.CurrentRow.Index)
        Catch ex As Exception
        End Try


    End Sub

    Private Sub BTN_Revocar_Click(sender As Object, e As EventArgs) Handles BTN_Revocar.Click


        Dim ID, ROL As String
        Try
            ID = DGV_Roles_Asignados(0, DGV_Roles_Asignados.CurrentRow.Index).Value
            ROL = DGV_Roles_Asignados(1, DGV_Roles_Asignados.CurrentRow.Index).Value

            DGV_Roles_Disponibles.Rows.Add(ID, ROL)
            DGV_Roles_Asignados.Rows.RemoveAt(DGV_Roles_Asignados.CurrentRow.Index)
        Catch ex As Exception

        End Try
    End Sub
End Class