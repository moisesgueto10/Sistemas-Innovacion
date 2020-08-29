Imports MySql.Data.MySqlClient
Public Class FrmCiudadesNuevo
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionCiudades)()
        Me.Dispose()
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_ciudad As Integer = 0

        If Trim(TxtCiudad.Text) <> "" Then
            sql = "SELECT MAX(id_ciudad) as id FROM ciudad;"
            registros = mibd.consulta(sql)

            If registros.HasRows Then
                While registros.Read
                    id_ciudad = registros("id")
                End While
            End If

            registros.Close()
            sql = "INSERT INTO `biblioteca`.`ciudad` (`id_ciudad`, `nombre_ciudad`) VALUES ('" & id_ciudad + 1 & "', '" & TxtCiudad.Text & "');"
            mibd.sentencias(sql)
            frmMenu.AbrirFormEnPanel(Of GestionCiudades)()
            Me.Dispose()
        End If
    End Sub
End Class