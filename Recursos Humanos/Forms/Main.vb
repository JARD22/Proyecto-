Public Class Main



    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub AsignarRolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarRolToolStripMenuItem.Click
        Dim Roles As New Asignacion_Roles
        Roles.MdiParent = Me

        Roles.Show()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = String.Format("{0:G}", DateTime.Now)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CreacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreacionToolStripMenuItem.Click

        Crea_Modifica_Rol.MdiParent = Me
        Crea_Modifica_Rol.Show()
    End Sub

    Private Sub BTN_Guardar_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click
        'CAPTURANDO LAS VARIABLES'
        Dim ID As Integer
        Dim Descripcion As String
        ID = CInt(Crea_Modifica_Rol.Txt_RolID.Text)
        Descripcion = Crea_Modifica_Rol.Txt_Desc.Text
        'CAPTURANDO EL CONTROL ACTIVO'
        If ActiveControl Is Crea_Modifica_Rol Then

            Try
                varconexion.Open()
                Dim Guarda_Rol = New SqlClient.SqlCommand("GUARDA_ESTADO " & ID & ",'" & Descripcion & "'", varconexion)
                Guarda_Rol.ExecuteNonQuery()
                varconexion.Close()
                MessageBox.Show("Rol Guardado")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub BTN_Nuevo_Click(sender As Object, e As EventArgs) Handles BTN_Nuevo.Click


        'Borrando los Text del Formulario  y asignando el nuevo valor de rol al Txt_RolID'
        If ActiveControl Is Crea_Modifica_Rol Then
            'Limpiando el TextBox de Descripcion'
            Crea_Modifica_Rol.Txt_Desc.Clear()

            'Foco en la Caja de descripcion'
            Crea_Modifica_Rol.Txt_Desc.Select()

            'Maximizando la ventana en el MDI'
            'Crea_Modifica_Rol.WindowState = System.Windows.Forms.FormWindowState.Maximized

            Dim Rol_Max As Int32

            ''Obtenemos el Ultimo ID del rol en la base'
            Dim ROLMAX As New SqlClient.SqlCommand("ULTIMO_ID", varconexion)

            Dim DataReader As SqlClient.SqlDataReader


            Try

                varconexion.Open()
                DataReader = ROLMAX.ExecuteReader

                While DataReader.Read()
                    Rol_Max = DataReader.GetInt32(0)
                End While
                varconexion.Close()

                Crea_Modifica_Rol.Txt_RolID.Text = Convert.ToString((Rol_Max + 1))

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub ActivacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivacionToolStripMenuItem.Click
        Activacion_Usuario.MdiParent = Me
        Activacion_Usuario.Show()
    End Sub
End Class