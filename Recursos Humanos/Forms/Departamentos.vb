Public Class Departamentos
    Private Sub Departamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaDepartamento(DGV_Departamentos, CMB_Localidades)
    End Sub

    Private Sub DGV_Departamentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Departamentos.CellClick
        Dim i As Integer = DGV_Departamentos.CurrentRow.Index


        Txt_DepID.Text = DGV_Departamentos.Item(0, i).Value
        Txt_Nombre.Text = DGV_Departamentos.Item(1, i).Value
        Txt_Jefe.Text = DGV_Departamentos.Item(2, i).Value



    End Sub

    Private Sub Txt_Jefe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Jefe.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class