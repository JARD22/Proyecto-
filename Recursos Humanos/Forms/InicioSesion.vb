Public Class InicioSesion
    Private numero_intentos As Integer = 0

    Public Usuario, Pass, Estado, PassDesencript

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RegistroUsuario.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        Dim intentosblanco As Integer = 0


        Dim Query As New SqlClient.SqlCommand("SELECT Usuario, Contraseña, Estado FROM USUARIOS WHERE Usuario= '" & Txt_Usuario.Text & "'", varconexion)
        Dim dr As SqlClient.SqlDataReader


        Dim Update As New SqlClient.SqlCommand



        If Validacion(Txt_Usuario.Text, Txt_Password.Text) = True Then


            Try
                varconexion.Open()
                dr = Query.ExecuteReader
                While dr.Read()

                    Usuario = dr.GetString(0)
                    Pass = dr.GetString(1)
                    Estado = dr.GetString(2)
                End While
                varconexion.Close()

            Catch Ex As Exception
                MessageBox.Show(Ex.Message)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Todos los campos son necesarios")
            Txt_Usuario.Select()
            Exit Sub
        End If

        'EVALUANDO EL RESULTADO DE LA CONSULTA ANTES DE LAS SIGUIENTES VALIDACIONES'
        If Usuario Is Nothing Then
            Lbl_Notificacion.Text = "Usuario o contraseña incorrectos"
            Exit Sub
        End If

        'VERIFICANDO EL ESTADO DEL USUARIO
        If Estado = "Desactivad" Then
            MessageBox.Show("Su usuario ha sido desactivado, contacte al administrador")
            Exit Sub
        End If


        'COMPARANDO PASSWORD DESENCRIPTADO Y USUARIO
        If Desencriptar(Pass) = Txt_Password.Text And Usuario = Txt_Usuario.Text Then
            Main.Show()
            Me.Hide()
        Else
            Lbl_Notificacion.Text = "Usuario o contraseña incorrectos"
            numero_intentos = numero_intentos + 1
        End If

        'DESACTIVANDO USUARIO Y BOTON DE LA FORMA

        If numero_intentos = 3 Then
            Try
                varconexion.Open()
                Update = New SqlClient.SqlCommand("  UPDATE  USUARIOS SET Estado = 'Desactivad' WHERE Usuario ='" + Usuario + "'", varconexion)
                Update.ExecuteNonQuery()

                MessageBox.Show("Usuario desactivado, contacte con el administrador")


            Catch ex As Exception
                MsgBox(ex.Message)

                varconexion.Close()
            End Try

        End If

        'COLOCANDO EL NOMBRE DE USUARIO EN EL TOOLSTRIPSTATUSLABEL'
        Main.ToolStripStatusLabel1.Text = Usuario



    End Sub

    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
