Public Class Ascensos
    Private Sub Ascensos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Empleados(DGV_EmpleadosA)
        cargaCMBPuestos(CmbNV_Puestos)
        cargaCMBDepartamentos(CmbNV_Departamento)
    End Sub

    Private Sub DGV_EmpleadosA_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_EmpleadosA.CellClick
        Dim i As Integer
        Dim Id As Integer
        i = DGV_EmpleadosA.CurrentRow.Index

        Id = DGV_EmpleadosA.Item(0, i).Value

        TxtAC_NombreCompleto.Text = DGV_EmpleadosA.Item(1, i).Value
        TxtAC_IdPuesto.Text = DGV_EmpleadosA.Item(2, i).Value
        TxtAC_Puesto.Text = DGV_EmpleadosA.Item(3, i).Value
        'Se convierte a String el campo es solo lectura'
        TxtAC_Salario.Text = Convert.ToString(DGV_EmpleadosA.Item(4, i).Value)





    End Sub

    Private Sub txtNV_Salario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNV_Salario.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class