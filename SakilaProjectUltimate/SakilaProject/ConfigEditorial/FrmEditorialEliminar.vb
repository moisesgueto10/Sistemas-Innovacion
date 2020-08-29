Imports MySql.Data.MySqlClient
Public Class FrmEditorialEliminar
    Private datos As MySqlDataReader

    Private Sub FrmEditorialEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM editorial WHERE id_editorial=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                TxtNombre.Text = datos("nombre_editorial")
                txtorigen.Text = datos("Procedencia_de_Origen")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "DELETE FROM `biblioteca`.`editorial` WHERE (`id_editorial` = '" & misfunciones.getId & "');"
        mibd.sentencias(sql)
        Me.Dispose()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub
End Class