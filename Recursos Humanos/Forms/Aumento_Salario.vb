Public Class Aumento_Salario
    Private Sub Aumento_Salario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Empleados(DGV_Empleados)
    End Sub

    Private Sub DGV_Empleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Empleados.CellClick
        Dim i As Integer
        i = DGV_Empleados.CurrentRow.Index

        Txt_NNombre.Text = DGV_Empleados.Item(1, i).Value
        Txt_Nombre.Text = DGV_Empleados.Item(1, i).Value
        Txt_NPuesto.Text = DGV_Empleados.Item(3, i).Value
        Txt_Puesto.Text = DGV_Empleados.Item(3, i).Value
        Txt_Salario.Text = DGV_Empleados.Item(4, i).Value


    End Sub

    Private Sub Txt_NSalario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_NSalario.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class