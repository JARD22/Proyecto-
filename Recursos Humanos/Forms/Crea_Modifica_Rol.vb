﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Crea_Modifica_Rol


    Private Sub RegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Empleados As New DataTable
        Dim DA As New SqlDataAdapter("SELECT_ROLES", Conexion_BD.conn)
        Dim nuevousuario As New SqlClient.SqlCommand
        Me.DGV_ROLES.Rows.Clear()

        Try
            Conexion_BD.Open()

            DA.Fill(Empleados)
            DGV_ROLES.DataSource = Empleados
            Conexion_BD.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_ROLES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ROLES.CellClick

        Dim i As Integer
        i = DGV_ROLES.CurrentRow.Index
        Txt_RolID.Text = DGV_ROLES.Item(0, i).Value
        Txt_Desc.Text = DGV_ROLES.Item(1, i).Value

    End Sub

End Class