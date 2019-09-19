Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography

Public Class Conexion_BD

    Public Shared conn As New SqlClient.SqlConnection

    Public Shared Function conectar(ByVal x As String, ByVal y As String) As Boolean
        Dim String_Conection As String = ("server=" & x & ";INITIAL catalog=" & y & ";Integrated security=true")
        Try
            conn.ConnectionString = String_Conection
            If conn.State = ConnectionState.Open Then
                conectar = True
            Else
                conn.Open()
                conectar = True
                MessageBox.Show("Conexión Exitosa")
            End If
        Catch ex As Exception
            conectar = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al conectar a la BD")
        End Try
    End Function
    Public Shared Sub Open()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else

        End If
    End Sub
    Public Shared Sub Close()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        Else
        End If
    End Sub

End Class
