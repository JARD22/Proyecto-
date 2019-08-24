Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Activacion_Usuario

    Private Sub Activacion_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Usuarios As New DataTable
        Dim DA_Usuarios As New SqlDataAdapter("SP_ESTADO_USUARIOS", varconexion)
        Dim nuevousuario As New SqlClient.SqlCommand

        Me.DGV_Usuarios.Rows.Clear()

        Try
            varconexion.Open()

            DA_Usuarios.Fill(Usuarios)
            DGV_Usuarios.DataSource = Usuarios
            varconexion.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_Usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Usuarios.CellClick



        Dim i As Integer

        i = DGV_Usuarios.CurrentRow.Index
        If DGV_Usuarios.Item(2, i).Value = "Activado" Then
            CMB_Estado.BackColor = Color.Green
            CMB_Estado.Text = "Activado"
        Else
            CMB_Estado.BackColor = Color.Red
            CMB_Estado.Text = "Desactivado"

        End If

    End Sub

    Private Sub CMB_Estado_Click(sender As Object, e As EventArgs) Handles CMB_Estado.Click

        Dim ID_Usuario As Integer
        ID_Usuario = CInt(DGV_Usuarios.Item(0, DGV_Usuarios.CurrentRow.Index).Value)

        If CMB_Estado.Text = "Desactivado" Then
            Try
                varconexion.Open()
                Dim Update_Estado = New SqlClient.SqlCommand("SP_ACTUALIZAR_ESTADO " & ID_Usuario & ",'Desactivado'", varconexion)
                Update_Estado.ExecuteNonQuery()
                varconexion.Close()
                MessageBox.Show("Usuario Actualizado")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Usuario ya está activo")
        End If

        Dim Usuarios As New DataTable
        Dim DA_Usuarios As New SqlDataAdapter("SP_ESTADO_USUARIOS", varconexion)
        Dim nuevousuario As New SqlClient.SqlCommand


        'NOTA: CREAR UN MODULO CON TODAS LAS CONSULTAS PARA ORDENAR EL CODIGO'
        'RECARGANDO EL DATAGRID'

        Try
            varconexion.Open()

            DA_Usuarios.Fill(Usuarios)
            DGV_Usuarios.DataSource = Usuarios
            varconexion.Close()
        Catch ex As Exception

        End Try

    End Sub
End Class