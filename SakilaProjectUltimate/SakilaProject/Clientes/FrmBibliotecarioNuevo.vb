Imports MySql.Data.MySqlClient
Public Class frmBibliotecarioNuevo
    Private datos As MySqlDataReader
    Private id_campus As Integer

    Private Sub frmClienteNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargarPais()
        'cargarCiudad()

        misfunciones.seleccionCb(Cbcampus, id_campus)
        cargarcampus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        accion()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
        Me.Dispose()
    End Sub

    Private Sub cargarcampus()
        Cbcampus.Items.Clear()
        Dim sql As String = "select * from campus"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbcampus.Items.Add(New Elementos(datos("nombre_campus"), datos("id_campus")))
            End While
        End If
        datos.Close()
        Cbcampus.SelectedIndex = 0
    End Sub

    Private Sub accion()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_bibliotecario As Integer = 0, id_campus As Integer = 0


        If Trim(TxtNombre.Text) <> "" And Trim(TxtApellido.Text) <> "" And Trim(TxtEdad.Text) <> "" And Trim(TxtDireccion.Text) <> "" Then
            Try
                sql = "SELECT MAX(id_bibliotecario) as id FROM bibliotecario;"
                registros = mibd.consulta(sql)


                If registros.HasRows Then
                    While registros.Read
                        id_bibliotecario = registros("id")
                    End While
                End If
                registros.Close()

                sql = "INSERT INTO bibliotecario (id_bibliotecario, id_campus, nombre, apellido, edad, direccion) values ('" &
                id_bibliotecario + 1 & "','" & Cbcampus.SelectedItem.value & "', '" & TxtNombre.Text & "' , '" & TxtApellido.Text & "' , '" &
                TxtEdad.Text & "' , '" & TxtDireccion.Text & "'  );"

                mibd.sentencias(sql)


                frmMenu.PanelFormularios.Controls.Remove(GestionBibliotecario)
                GestionBibliotecario.Dispose()

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