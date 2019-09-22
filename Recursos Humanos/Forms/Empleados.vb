Public Class Empleados

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrir_imagen(PB_Foto)
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Empleados(DGV_Empleados)
    End Sub
End Class