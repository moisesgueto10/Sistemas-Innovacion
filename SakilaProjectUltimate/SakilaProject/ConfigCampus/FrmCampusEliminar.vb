Imports MySql.Data.MySqlClient
Public Class FrmCampusEliminar
    Private datos As MySqlDataReader

    Private Sub FrmCampusEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM campus Inner Join ciudad ON campus.id_ciudad= ciudad.id_ciudad
        WHERE id_campus=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtcampusnombre.Text = datos("nombre_campus")
                Cbciudad.Text = datos("nombre_ciudad")
            End While
        End If
        datos.Close()

    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "DELETE FROM `biblioteca`.`campus` WHERE (`id_campus` = '" & misfunciones.getId & "');"
        mibd.sentencias(sql)
        frmMenu.AbrirFormEnPanel(Of GestionCampus)()
        Me.Dispose()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionCampus)()
        Me.Dispose()
    End Sub
End Class