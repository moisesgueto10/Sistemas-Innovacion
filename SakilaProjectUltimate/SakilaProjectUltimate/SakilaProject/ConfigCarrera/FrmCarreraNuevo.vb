Imports MySql.Data.MySqlClient
Public Class FrmCarreraNuevo
    Private datos As MySqlDataReader

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_carrera As Integer = 0
        Dim validadorcarrera As String = ""
        Dim sql1 As String = "SELECT * FROM carrera WHERE nombre_carrera='" & TxtNombre.Text & "';"
        datos = mibd.consulta(sql1)
        If datos.HasRows Then
            While datos.Read
                validadorcarrera = datos("nombre_carrera")
            End While
        End If
        datos.Close()

        If validadorcarrera = TxtNombre.Text Then
            MsgBox("Esta carrera ya ha sido ingresada", MsgBoxStyle.Critical, "READER SYSTEM")
        Else
            If Trim(TxtNombre.Text) <> "" Then

                sql = "SELECT MAX(id_carrera) as id FROM carrera;"
                registros = mibd.consulta(sql)

                If registros.HasRows Then
                    While registros.Read
                        id_carrera = registros("id")
                    End While
                End If
                registros.Close()

                sql = "INSERT INTO `biblioteca`.`carrera` (`id_carrera`, `nombre_carrera`) VALUES ('" & id_carrera + 1 & "','" & TxtNombre.Text & "');"

                mibd.sentencias(sql)
                Me.Dispose()
            Else
                MsgBox("Ingrese nombre de la carrera", MsgBoxStyle.Exclamation, "READER SYSTEM")
            End If
        End If


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionCarrera)()
        Me.Dispose()
    End Sub
End Class