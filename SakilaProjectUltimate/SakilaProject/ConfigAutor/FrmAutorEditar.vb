Imports MySql.Data.MySqlClient
Public Class FrmAutorEditar
    Private datos As MySqlDataReader
    Private Sub FrmAutorEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatos()
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
        Dim sql As String = "UPDATE `biblioteca`.`autor` SET `nombre` = '" & txtnombre.Text & "', `Nacionalidad` = '" & txtnacionalidad.Text & "' WHERE (`id_autor` = '" & misfunciones.getId & "');"
        If Trim(txtnacionalidad.Text) <> "" And Trim(txtnombre.Text) <> "" Then
            mibd.sentencias(sql)

            Me.Dispose()
        Else
            MsgBox("Ingrese todos los campos", MsgBoxStyle.Exclamation, "READER SYSTEM")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Me.Dispose()
    End Sub
End Class