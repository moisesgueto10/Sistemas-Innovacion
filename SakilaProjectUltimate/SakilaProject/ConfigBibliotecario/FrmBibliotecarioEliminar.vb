Imports MySql.Data.MySqlClient
Public Class FrmBibliotecarioEliminar
    Private datos As MySqlDataReader
    Private id_campus As Integer

    Private Sub FrmBibliotecarioEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM bibliotecario INNER JOIN campus ON campus.id_campus=bibliotecario.id_campus WHERE nombre_de_usuario='" & misfunciones.getId3 & "';"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtusuario.Text = datos("nombre_de_usuario")
                txtcontra.Text = datos("contrasena")
                Cbcampus.Text = datos("nombre_campus")
                TxtNombre.Text = datos("nombre")
                TxtApellido.Text = datos("apellido")
                txtnacimiento.Text = datos("Fecha_de_Nacimiento")
                txtidentidad.Text = datos("identidad")
                TxtDireccion.Text = datos("direccion")
            End While
        End If
        datos.Close()

    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
        Me.Dispose()
    End Sub

    Private Sub BtnGuardarNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = ""
        sql = "DELETE FROM `biblioteca`.`bibliotecario` WHERE `nombre_de_usuario`='" & misfunciones.getId3 & "';"
        mibd.sentencias(sql)
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
        Me.Dispose()
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
        Me.Dispose()
    End Sub
End Class