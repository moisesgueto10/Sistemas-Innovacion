Imports MySql.Data.MySqlClient
Public Class FrmCarreraEliminar
    Private datos As MySqlDataReader

    Private Sub FrmCarreraEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM carrera WHERE id_carrera=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                TxtNombre.Text = datos("nombre_carrera")
            End While
        End If
        datos.Close()

    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "DELETE FROM `biblioteca`.`carrera` WHERE (`id_carrera` = '" & misfunciones.getId & "');"
        mibd.sentencias(sql)
        frmMenu.AbrirFormEnPanel(Of GestionCarrera)()
        Me.Dispose()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionCarrera)()
        Me.Dispose()
    End Sub
End Class