Imports MySql.Data.MySqlClient
Public Class FrmBibliotecarioEliminar
    Private datos As MySqlDataReader
    Private id_campus As Integer


    Private Sub FrmBibliotecarioEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarcampus()
        misfunciones.seleccionCb(Cbcampus, id_campus)
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM bibliotecario Inner Join campus ON campus.id_campus= bibliotecario.id_campus
        WHERE id_bibliotecario=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbcampus.Text = datos("nombre_campus")
                TxtIdBibliotecario.Text = datos("id_bibliotecario")
                TxtNombre.Text = datos("nombre")
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

        sql = "DELETE FROM `biblioteca`.`bibliotecario` WHERE `id_bibliotecario`='" & misfunciones.getId & "';"

        mibd.sentencias(sql)
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
        Me.Dispose()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
        Me.Dispose()
    End Sub
End Class