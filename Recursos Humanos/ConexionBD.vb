Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Module ConexionBD


    Public cadena As String = "Data Source=JORGEAGUILERA;" & "Initial Catalog=RRHH;" & " Integrated Security=True"
    Public varconexion As New SqlConnection(cadena)




    Public Sub conectar()


        If varconexion.State = ConnectionState.Open Then
            MessageBox.Show("Conexion Exitosa")
        Else
            varconexion.Open()
        End If
    End Sub
    Public Sub desconectar()
        varconexion.Close()
    End Sub

End Module
