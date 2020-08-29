Imports MySql.Data.MySqlClient
Public Class FrmUsuarioNuevo
    Private datos As MySqlDataReader
    Private id_campus, id_carrera As Integer

    Private Sub frmClienteNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarcarrera()
        cargarcampus()
        misfunciones.seleccionCb(Cbcarrera, id_carrera)
        misfunciones.seleccionCb(CBcampus, id_campus)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        accion()


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionUsuarios)()
        Me.Dispose()
    End Sub

    Private Sub cargarcarrera()
        Cbcarrera.Items.Clear()
        Dim sql As String = "select * from carrera"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbcarrera.Items.Add(New Elementos(datos("nombre_carrera"), datos("id_carrera")))
            End While
        End If
        datos.Close()
        Cbcarrera.SelectedIndex = 0
    End Sub

    Private Sub cargarcampus()
        CBcampus.Items.Clear()
        Dim sql As String = "select * from campus"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                CBcampus.Items.Add(New Elementos(datos("nombre_campus"), datos("id_campus")))
            End While
        End If
        datos.Close()
        CBcampus.SelectedIndex = 0
    End Sub

    Private Sub accion()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_usuario As Integer = 0


        If Trim(TxtNombre.Text) <> "" And Trim(TxtApellido.Text) <> "" And Trim(TxtEdad.Text) <> "" And Trim(TxtDireccion.Text) <> "" Then
            Try


                sql = "SELECT MAX(id_usuario) as id FROM usuario;"
                registros = mibd.consulta(sql)


                If registros.HasRows Then
                    While registros.Read
                        id_usuario = registros("id")
                    End While
                End If



                registros.Close()
                sql = "INSERT INTO `biblioteca`.`usuario` (`id_usuario`, `id_carrera`, `id_campus`, `Nombre`, `Apellido`, `Telefono`, `fecha_de_nacimiento`, `Direccion`, `Num_Identidad`) VALUES ('" &
                id_usuario + 1 & "','" & Cbcarrera.SelectedItem.value & "', '" & CBcampus.SelectedItem.value & "' , '" & TxtNombre.Text & "' , '" & TxtApellido.Text & "' , '" & TxtTelefono.Text & "' , '" & txtedad.Text & "' , '" & TxtDireccion.Text & "' , '" & Convert.ToString(TxtIdentidad.Text) & "');"

                mibd.sentencias(sql)

                frmMenu.AbrirFormEnPanel(Of GestionUsuarios)()
                Me.Dispose()

            Catch ex As Exception

            End Try


            'sql = "INSERT INTO customer (store_id, first_name, last_name, email, address_id, active, create_date)"

        Else
            MessageBox.Show("Debe ingresar todos los campos obligatorios")
        End If

    End Sub

    ''' <summary>
    ''' Procedimiento para cargar la lista de paises en el ComboBox
    ''' </summary>
    Private Sub cargarPais()
        'cbPais.Items.Clear()
        Dim sql As String = "select * from country"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                'cbPais.Items.Add(New Elementos(datos("country"), datos("country_id")))
            End While
        End If
        datos.Close()
        'cbPais.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Procedimiento para cargar la lista de ciudades en el ComboBox
    ''' </summary>
    Private Sub cargarCiudad()
        'cbCiudad.Items.Clear()
        'Dim sql As String = "select * from city where country_id=" & cbPais.SelectedItem.value
        'datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                'cbCiudad.Items.Add(New Elementos(datos("city"), datos("city_id")))
            End While
        End If
        datos.Close()
        'cbCiudad.SelectedIndex = 0
    End Sub

    Private Sub cbPais_SelectedIndexChanged(sender As Object, e As EventArgs)
        cargarCiudad()
    End Sub

End Class