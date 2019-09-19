Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Module Consultas



    Public Sub Guardar_Empleado(ID As Integer, Nombre As String, Apellido As String, Identidad As String, Salario As Double, Correo As String,
                                Telefono As String, Puesto As String,
                                Imagen As PictureBox)
        Try


            Dim Imag As String
            'Convertimos la imagen a Bytes '
            Imag = bytesToString(Imagen_Bytes(Imagen.Image))
            'Llamamos al procedimiento Al'
            Dim sql As String = ("SP_GUARDA_EMPLEADO " & ID & ",'" & Nombre & "','" & Apellido & "','" & Identidad & "','" & Salario & "','" & Correo & "','" & Telefono & "','" & Puesto & "','" & Imag & "'")


            Conexion_BD.Open()
            Dim Comando As New SqlCommand(sql, Conexion_BD.conn)

            Conexion_BD.Open()
            If Conexion_BD.conn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            Conexion_BD.Close()
            MessageBox.Show("Empleado Guardado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Public Sub Carga_Empleados()
        Dim Emple As New DataTable
        Dim DA As New SqlDataAdapter("CARGA_EMPLEADOS", Conexion_BD.conn)

        Try
            Conexion_BD.Open()
            DA.Fill(Emple)
            Empleados.DGV_Empleados.DataSource = Emple
            Conexion_BD.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    'Guardando roles'
    Public Sub Guarda_Rol()
        'CAPTURANDO LAS VARIABLES'
        Dim ID As Integer
        Dim Descripcion As String
        ID = CInt(Crea_Modifica_Rol.Txt_RolID.Text)
        Descripcion = Crea_Modifica_Rol.Txt_Desc.Text


        Try
            Conexion_BD.Open()
            Dim Guarda_Rol = New SqlClient.SqlCommand("GUARDA_ROL " & ID & ",'" & Descripcion & "'", Conexion_BD.conn)
            Guarda_Rol.ExecuteNonQuery()
            Conexion_BD.Close()
            MessageBox.Show("Rol Guardado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Elimina_Rol()
        Dim ID As Integer
        ID = CInt(Crea_Modifica_Rol.Txt_RolID.Text)

        Try
            Conexion_BD.Open()

            Dim ELIMINA As New SqlClient.SqlCommand("ELIMINA_ROL " & ID, Conexion_BD.conn)
            ELIMINA.ExecuteNonQuery()
            Conexion_BD.Close()
        Catch ex As Exception

        End Try
        MessageBox.Show("Rol Eliminado")
    End Sub
    Public Sub Nuevo_Rol()
        'Limpiando el TextBox de Descripcion'
        Crea_Modifica_Rol.Txt_Desc.Clear()

        'Foco en la Caja de descripcion'
        Crea_Modifica_Rol.Txt_Desc.Select()

        Dim Rol_ID_Max As Int32

        ''Obtenemos el Ultimo ID del rol en la base'
        Dim ROLMAX As New SqlClient.SqlCommand("SP_ULTIMO_ID_ROL", Conexion_BD.conn)

        Dim DataReader As SqlClient.SqlDataReader

        'Obteniedo los valores de la Consulta'
        Try

            Conexion_BD.Open()
            DataReader = ROLMAX.ExecuteReader

            While DataReader.Read()
                Rol_ID_Max = DataReader.GetInt32(0)
            End While
            Conexion_BD.Close()

            Crea_Modifica_Rol.Txt_RolID.Text = Convert.ToString((Rol_ID_Max + 1))

        Catch ex As Exception

        End Try
    End Sub
    'Cargando DGV con los roles registrados'
    Public Sub CargaRoles()
        Dim Empleados As New DataTable
        Dim DA As New SqlDataAdapter("SELECT_ROLES", Conexion_BD.conn)
      


        Try
            Conexion_BD.Open()

            DA.Fill(Empleados)
            Crea_Modifica_Rol.DGV_ROLES.DataSource = Empleados
            Conexion_BD.Close()
        Catch ex As Exception

        End Try
    End Sub
    'Cargando DGV con las regiones registradas'
    Public Sub CargaRegiones()

        Dim DTRegiones As New DataTable
        Dim DA As New SqlDataAdapter("SP_CARGAREGIONES ", Conexion_BD.conn)

        Try

            Conexion_BD.Open()
            DA.Fill(DTRegiones)
            Regiones.DGV_Regiones.DataSource = DTRegiones
            Conexion_BD.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Guardando o actualizando la nueva region'
    Public Sub Guarda_Region()
        'Capturando los valores a guardar'
        Dim ID_Region As Integer
        Dim Nombre As String
        ID_Region = CInt(Regiones.Txt_RegionID.Text)
        Nombre = Regiones.Txt_Nombre.Text

        'Declarando variables SQL'
        Dim Guarda_Region = New SqlClient.SqlCommand("SP_GUARDAREGION " & ID_Region & ",'" & Nombre & "'", Conexion_BD.conn)
        Try
            Conexion_BD.Open()
            Guarda_Region.ExecuteNonQuery()

            Conexion_BD.Close()

            MessageBox.Show("Región Guardada")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub Elimina_Region()
        Dim ID = CInt(Regiones.Txt_RegionID.Text)
        Dim Elimina_Region As New SqlClient.SqlCommand("SP_ELIMINAREGION " & ID, Conexion_BD.conn)
        Try

            Conexion_BD.Open()
            Elimina_Region.ExecuteNonQuery()

            Conexion_BD.Close()
        Catch ex As Exception

        End Try
    End Sub
    'Esto se va a cambiar en la modificacion de la base'
    Public Sub Ultimo_ID_Region()
        'Borrando los TextBox'
        Regiones.Txt_Nombre.Clear()
        Regiones.Txt_RegionID.Clear()
        'focus en la descripcion'
        Regiones.Txt_Nombre.Select()

        Dim Rol_Max_Regiones As Int32

        Dim DataReader As SqlClient.SqlDataReader

        Dim ID_Max As New SqlClient.SqlCommand("SP_ULTIMO_ID_REGIONES", Conexion_BD.conn)

        Try
            Conexion_BD.Open()
            DataReader = ID_Max.ExecuteReader

            While DataReader.Read()
                Rol_Max_Regiones = DataReader.GetInt32(0)
            End While
            Conexion_BD.Close()

            Regiones.Txt_RegionID.Text = Convert.ToString((Rol_Max_Regiones + 1))
        Catch ex As Exception

        End Try

    End Sub
    'Cargando las Regiones en el combobox del formulario de paises'
    Public Sub Carga_Regiones()
        Dim Regiones As New DataTable
        Dim DA_Regiones As New SqlClient.SqlDataAdapter("SP_CARGAREGIONES", Conexion_BD.conn)

        Try
            Conexion_BD.Open()
            DA_Regiones.Fill(Regiones)
            Pais.CMB_Regiones.DataSource = Regiones
            'Pais.CMB_Regiones.DisplayMember = "Nombre"
            Pais.CMB_Regiones.ValueMember = "Nombre"
            Conexion_BD.Close()
        Catch ex As Exception

        End Try



    End Sub
    Public Sub Carga_Pais(Region As String)

        Dim Paises As New SqlClient.SqlDataAdapter("CARGA_PAIS '" & Region & "'", Conexion_BD.conn)
        Dim DTPaises As New DataTable

        Try
            Conexion_BD.Open()
            Paises.Fill(DTPaises)

            Pais.DGV_Paises.DataSource = DTPaises
            Conexion_BD.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Ultimo_Pais As Int32

    Public Region As String
    Public Sub Nuevo_Pais()
        Pais.Txt_Codigo.Clear()
        Pais.Txt_Nombre.Clear()

        Pais.Txt_Codigo.Select()

        Dim DataReader As SqlClient.SqlDataReader

        Dim ID_Max As New SqlClient.SqlCommand("SP_ULTIMO_PAIS", Conexion_BD.conn)

        Try
            Conexion_BD.Open()
            DataReader = ID_Max.ExecuteReader

            While DataReader.Read()
                Ultimo_Pais = DataReader.GetInt32(0)
            End While
            Conexion_BD.Close()

            Ultimo_Pais = ((Ultimo_Pais + 1))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Public Sub Guardar_Pais()


        Region = Pais.CMB_Regiones.Text

        Dim Pais_ID As Integer
        Pais_ID = Ultimo_Pais
        Dim Codigo As Integer
        Codigo = CInt(Pais.Txt_Codigo.Text)
        Dim Nombre As String
        Nombre = Pais.Txt_Nombre.Text

        Dim Nuevo_Pais As New SqlClient.SqlCommand("NUEVO_PAIS " & Pais_ID & ",'" & Nombre & "'," & Codigo & ",'" & Region & "'", Conexion_BD.conn)

        Try
            Conexion_BD.Open()
            Nuevo_Pais.ExecuteNonQuery()

            Conexion_BD.Close()
            MessageBox.Show("País Guardado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Carga_Pais(Region)
    End Sub
    Public Sub Elimina_Pais()

        Dim Nombre As String
        Nombre = Pais.Txt_Nombre.Text
        Dim Elimina_Pais As New SqlClient.SqlCommand("SP_ELIMINA_PAIS '" & Nombre & "'", Conexion_BD.conn)

        Try
            Conexion_BD.Open()
            Elimina_Pais.ExecuteNonQuery()
            Conexion_BD.Close()
            MessageBox.Show("Pais Eliminado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Carga_Pais(Region)

    End Sub

    Public Sub Carga_Puestos()
        Dim DT_Puestos As New DataTable
        Dim DA_Puestos As New SqlClient.SqlDataAdapter("SP_CARGA_PUESTOS", Conexion_BD.conn)

        Try
            Conexion_BD.Open()
            DA_Puestos.Fill(DT_Puestos)
            Puestos.DGV_Puestos.DataSource = DT_Puestos
            Conexion_BD.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Nuevo_Puesto()

        Puestos.Txt_Puesto.Clear()
        Puestos.Txt_SMaximo.Clear()
        Puestos.Txt_SMinimo.Clear()

        Dim ID As Int32
        Dim DataReader As SqlClient.SqlDataReader
        Dim Puesto_Max As New SqlClient.SqlCommand("SP_ULTMO_PUESTO", Conexion_BD.conn)

        Try
            Conexion_BD.Open()
            DataReader = Puesto_Max.ExecuteReader
            While DataReader.Read()
                ID = DataReader.GetInt32(0)

            End While

            Puestos.Txt_IDPuesto.Text = (ID + 1).ToString()
            Conexion_BD.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Guarda_Puesto()
        Dim Puesto_ID = CInt(Puestos.Txt_IDPuesto.Text)
        Dim Titulo = Puestos.Txt_Puesto.Text
        Dim Salario_Min = CDbl(Puestos.Txt_SMinimo.Text)
        Dim Salario_Max = CDbl(Puestos.Txt_SMaximo.Text)


        Dim Nuevo_Rol As New SqlClient.SqlCommand("SP_GUARDA_PUESTO " & Puesto_ID & ",'" & Titulo & "'," & Salario_Min & "," & Salario_Max, Conexion_BD.conn)

        Try
            Conexion_BD.Open()
            Nuevo_Rol.ExecuteNonQuery()
            Conexion_BD.Close()
            MessageBox.Show("Puesto Guadado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub Elimina_Puesto()
        Dim Puesto_ID = CInt(Puestos.Txt_IDPuesto.Text)
        Dim Elimina_Puesto As New SqlClient.SqlCommand("SP_ELIMINA_PUESTO " & Puesto_ID, Conexion_BD.conn)

        Try
            Conexion_BD.Open()
            Elimina_Puesto.ExecuteNonQuery()
            Conexion_BD.Close()
            MessageBox.Show("Puesto Eliminado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Module
