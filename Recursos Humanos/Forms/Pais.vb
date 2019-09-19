Public Class Pais

    Private Sub Pais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblando el DGV con los paises Registrados'
        Carga_Regiones()
    End Sub
    Public Region_ID As String

    Private Sub CMB_Regiones_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CMB_Regiones.SelectionChangeCommitted

        Region_ID = CMB_Regiones.SelectedValue

        Carga_Pais(Region_ID)

    End Sub

    Private Sub DGV_Paises_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Paises.CellClick
        Dim i As Integer
        i = DGV_Paises.CurrentRow.Index

        Txt_Codigo.Text = DGV_Paises.Item(0, i).Value
        Txt_Nombre.Text = DGV_Paises.Item(1, i).Value

    End Sub
End Class