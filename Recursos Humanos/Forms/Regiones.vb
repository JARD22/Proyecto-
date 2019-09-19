

Public Class Regiones
    Private Sub Regiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaRegiones()
    End Sub

    Private Sub DGV_Regiones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Regiones.CellClick
        Dim i As Integer
        i = DGV_Regiones.CurrentRow.Index

        Txt_RegionID.Text = DGV_Regiones.Item(0, i).Value
        Txt_Nombre.Text = DGV_Regiones.Item(1, i).Value
    End Sub
End Class