Imports MySql.Data.MySqlClient
Public Class frmBibliotecarioEditar
    Private datos As MySqlDataReader
    Private id_campus As Integer
    Private campos As Integer

    Private Sub frmClienteEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(misfunciones.getId)
        cargarDatos()
        cargarcampus()
        misfunciones.seleccionCb(Cbcampus, id_campus)
        'misfunciones.seleccionCb(cbPais, pais_id)
        'misfunciones.seleccionCb(cbCiudad, ciudad_id)
    End Sub


    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM bibliotecario Inner Join campus ON campus.id_campus= bibliotecario.id_campus
        WHERE id_bibliotecario=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                TxtNombre.Text = datos("nombre")
                Cbcampus.Text = datos("nombre_campus")
                TxtApellido.Text = datos("apellido")
                TxtEdad.Text = datos("edad")
                TxtDireccion.Text = datos("direccion")
            End While
        End If
        datos.Close()

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
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_bibliotecario As Integer = 0, id_campus As Integer = 0
        If Trim(TxtNombre.Text) <> "" And Trim(TxtApellido.Text) <> "" And Trim(TxtEdad.Text) <> "" And Trim(TxtDireccion.Text) <> "" Then
            If campos = 1 Then
                sql = "Update `biblioteca`.`bibliotecario` Set `id_campus`='" & Cbcampus.SelectedItem.value & "', `nombre`='" & TxtNombre.Text &
                "', `apellido`='" & TxtApellido.Text & "', `edad`='" & TxtEdad.Text & "', `direccion`='" & TxtDireccion.Text &
                "' WHERE `id_bibliotecario`='" & misfunciones.getId & "';"

                mibd.sentencias(sql)
            Else
                sql = "Update `biblioteca`.`bibliotecario` Set `id_campus`='" & misfunciones.getId1 & "', `nombre`='" & TxtNombre.Text &
                            "', `apellido`='" & TxtApellido.Text & "', `edad`='" & TxtEdad.Text & "', `direccion`='" & TxtDireccion.Text &
                            "' WHERE `id_bibliotecario`='" & misfunciones.getId & "';"

                mibd.sentencias(sql)
            End If
            GestionBibliotecario.Actualizar()
            frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
            Me.Dispose()
        Else
            MsgBox("Ingrese todos los datos")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
        Me.Dispose()
    End Sub

    Private Sub Cbcampus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbcampus.SelectedIndexChanged
        campos = 1
    End Sub
End Class