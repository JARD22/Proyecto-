Public Class Puestos
    Private Sub Puestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Puestos()
    End Sub

    Private Sub DGV_Puestos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Puestos.CellClick
        Dim i As Integer
        i = DGV_Puestos.CurrentRow.Index

        Txt_IDPuesto.Text = DGV_Puestos.Item(0, i).Value
        Txt_Puesto.Text = DGV_Puestos.Item(1, i).Value
        Txt_SMinimo.Text = DGV_Puestos.Item(2, i).Value
        Txt_SMaximo.Text = DGV_Puestos.Item(3, i).Value
    End Sub
End Class