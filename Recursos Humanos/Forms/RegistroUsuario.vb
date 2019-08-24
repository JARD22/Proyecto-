
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class RegistroUsuario
    Public Empleados As New DataTable
    Public DA As New SqlDataAdapter("SELECT Empleado_ID, Primer_Nombre, Primer_Apellido FROM EMPLEADOS", varconexion)
    Public nuevousuario As New SqlClient.SqlCommand
    Private Sub RegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DGV_Empleados.Rows.Clear()

        Try
            varconexion.Open()

            DA.Fill(Empleados)
            DGV_Empleados.DataSource = Empleados
            varconexion.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_Empleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Empleados.CellClick

        Dim i As Integer
        i = DGV_Empleados.CurrentRow.Index
        Txt_Usuario.Text = DGV_Empleados.Item(1, i).Value + "." + DGV_Empleados.Item(2, i).Value
        Lbl_IDemp.Text = DGV_Empleados.Item(0, i).Value
    End Sub

    Private Sub Btn_Registrar_Click(sender As Object, e As EventArgs) Handles Btn_Registrar.Click

        Dim Pass As String
        Dim ConfPass As String
        Dim passencript As String


        Pass = Txt_Pass.Text
        ConfPass = Txt_CofPass.Text
        passencript = Encriptar(Pass)


        If (Validacion(Pass)) = False Then
            MessageBox.Show("Su contraseña debe tener 8 caracteres, minúsculas,mayúsculas y simbolos")

        End If

        If Pass = ConfPass Then
            varconexion.Open()
            nuevousuario = New SqlClient.SqlCommand("INSERT INTO USUARIOS (Usuario, Fecha_Contrato, Empleado_ID, Estado, Contraseña) VALUES ('" + Txt_Usuario.Text + "',GETDATE()" + ",'" + Lbl_IDemp.Text + "','" + "Activo','" + passencript + "')", varconexion)
            nuevousuario.ExecuteNonQuery()
            varconexion.Close()
            MessageBox.Show("Usuario Creado Exitosamente")
        Else
            MessageBox.Show("Las contrase;as no coinciden")
        End If





    End Sub

    Private Sub DGV_Empleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Empleados.CellContentClick

    End Sub
End Class