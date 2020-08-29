Imports MySql.Data.MySqlClient
Public Class FrmEditorialEditar
    Private datos As MySqlDataReader

    Private Sub FrmEditorialEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
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
        Dim sql As String = "UPDATE `biblioteca`.`editorial` SET `nombre_editorial` = '" & TxtNombre.Text & "', `Procedencia_de_Origen` = '" & txtorigen.Text & "' WHERE (`id_editorial` = '" & misfunciones.getId & "');"

        If Trim(TxtNombre.Text) <> "" And Trim(txtorigen.Text) <> "" Then
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