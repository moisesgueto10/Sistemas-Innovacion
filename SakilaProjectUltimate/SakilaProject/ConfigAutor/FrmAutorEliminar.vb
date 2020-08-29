Imports MySql.Data.MySqlClient
Public Class FrmAutorEliminar
    Private datos As MySqlDataReader
    Private Sub FrmAutorEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM autor WHERE id_autor=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtnombre.Text = datos("nombre")
                txtnacionalidad.Text = datos("Nacionalidad")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "DELETE FROM `biblioteca`.`autor` WHERE (`id_autor` = '" & misfunciones.getId & "');"
        mibd.sentencias(sql)

        Me.Dispose()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Me.Dispose()
    End Sub
End Class