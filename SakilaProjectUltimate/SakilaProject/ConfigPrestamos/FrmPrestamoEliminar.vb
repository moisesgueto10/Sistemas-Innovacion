Imports MySql.Data.MySqlClient
Public Class FrmPrestamoEliminar
    Private datos As MySqlDataReader


    Private Sub FrmPrestamoEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT *, prestamo_libro.identidad as identidad1 FROM prestamo_libro INNER JOIN alumnos ON alumnos.identidad=prestamo_libro.identidad INNER JOIN ejemplar ON ejemplar.id_ejemplar=prestamo_libro.id_ejemplar INNER JOIN libro ON libro.id_libro= ejemplar.id_libro
        WHERE id_prestamo_libro=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                CBLibro.Text = datos("Titulo")
                txtedicion.Text = datos("Edicion")
                cbISBN.Text = datos("CodigoISBN")
                cbdevolucion.Text = Convert.ToString(datos("fecha_devolucion"))
                txtprestamo.Text = Convert.ToDateTime(datos("fecha_prestamo")).ToString("yyyy-MM-dd HH:MM:ss")
                txtentrega.Text = Convert.ToDateTime(datos("fecha_entrega")).ToString("yyyy-MM-dd HH:MM:ss")
                CBRecibido.Text = datos("recibido")
                CBRetraso.Text = datos("retraso")
                txtidentidad.Text = datos("identidad1")
                TxtNombre.Text = datos("Nombre") & " " & datos("Apellido")
            End While
        End If
        datos.Close()

    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "DELETE FROM `biblioteca`.`prestamo_libro` WHERE `id_prestamo_libro`='" & misfunciones.getId & "';"
        mibd.sentencias(sql)
        Dim comando As String = "UPDATE `biblioteca`.`ejemplar` SET `Disponibilidad`='Disponible' WHERE `CodigoISBN`='" & cbISBN.Text & "';"
        mibd.sentencias(comando)
        GestionEjemplares.Actualizar()
        Me.Dispose()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

End Class