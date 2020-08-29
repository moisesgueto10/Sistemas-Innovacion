Imports MySql.Data.MySqlClient
Public Class FrmEditorialNuevo
    Private datos As MySqlDataReader

    Private Sub FrmEditorialNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_editorial As Integer = 0

        If Trim(TxtNombre.Text) <> "" And Trim(txtorigen.Text) <> "" Then

            sql = "SELECT MAX(id_editorial) as id FROM editorial;"
            registros = mibd.consulta(sql)

            If registros.HasRows Then
                While registros.Read
                    id_editorial = registros("id")
                End While
            End If
            registros.Close()

            sql = "INSERT INTO `biblioteca`.`editorial` (`id_editorial`, `nombre_editorial`, `Procedencia_de_Origen`) VALUES ('" & id_editorial + 1 & "','" & TxtNombre.Text & "','" & txtorigen.Text & "');"
            mibd.sentencias(sql)
            Me.Dispose()
        Else
            MsgBox("Ingrese nombre de la carrera", MsgBoxStyle.Exclamation, "READER SYSTEM")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub
End Class