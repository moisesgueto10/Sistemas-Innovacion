Imports MySql.Data.MySqlClient
Public Class FrmAutorNuevo
    Private datos As MySqlDataReader

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_autor As Integer = 0

        If Trim(txtnacionalidad.Text) <> "" And Trim(txtnombre.Text) <> "" Then

            sql = "SELECT MAX(id_autor) as id FROM autor;"
            registros = mibd.consulta(sql)

            If registros.HasRows Then
                While registros.Read
                    id_autor = registros("id")
                End While
            End If

            registros.Close()
            sql = "INSERT INTO `biblioteca`.`autor` (`id_autor`, `nombre`, `Nacionalidad`) VALUES ('" &
            id_autor + 1 & "','" & txtnombre.Text & "', '" & txtnacionalidad.Text & "');"

            mibd.sentencias(sql)
            Me.Dispose()

        Else
            MsgBox("Ingrese todos los campos", MsgBoxStyle.Exclamation, "READER SYSTEM")
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub FrmAutorNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class