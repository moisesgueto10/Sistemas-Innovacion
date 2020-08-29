Imports MySql.Data.MySqlClient
Public Class FrmEjemplarEliminar
    Private datos As MySqlDataReader

    Private Sub BtnGuardarNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = ""
        sql = "DELETE FROM `biblioteca`.`ejemplar` WHERE `id_ejemplar`='" & misfunciones.getId & "';"
        mibd.sentencias(sql)
        Me.Dispose()
    End Sub

    Private Sub FrmEjemplarEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM ejemplar INNER JOIN campus ON campus.id_campus=ejemplar.id_campus INNER JOIN libro ON libro.id_libro=ejemplar.id_libro WHERE id_ejemplar=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbcampus.Text = datos("nombre_campus")
                cblibro.Text = datos("Titulo")
                txtejemplar.Text = datos("CodigoISBN")
                cbestado.Text = datos("estado")
                CBDisponibilidad.Text = datos("Disponibilidad")
                txtedicion.Text = datos("Edicion")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Me.Dispose()
    End Sub
End Class