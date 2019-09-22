Public Class Localidades
    Private Sub Localidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos los datos en el DGV'
        Carga_Localidades(DGV_Localidades)
        'Cargamos los paises en el combobox para habilitar la creacion de nuevas localidades
        Paises(CMB_Paises)
    End Sub

    Private Sub DGV_Localidades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Localidades.CellClick
        Dim i As Integer = DGV_Localidades.CurrentRow.Index

        Txt_ID.Text = DGV_Localidades.Item(0, i).Value
        Txt_Ciudad.Text = DGV_Localidades.Item(1, i).Value
        Txt_Direccion.Text = DGV_Localidades.Item(2, i).Value
        Txt_Departamento.Text = DGV_Localidades.Item(3, i).Value
    End Sub
End Class