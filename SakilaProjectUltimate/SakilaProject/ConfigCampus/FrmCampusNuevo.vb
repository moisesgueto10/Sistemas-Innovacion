Imports MySql.Data.MySqlClient
Public Class FrmCampusNuevo
    Private datos As MySqlDataReader
    Private id_ciudad As Integer

    Private Sub FrmCampusNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarciudad()
        misfunciones.seleccionCb(Cbciudad, id_ciudad)
    End Sub

    Private Sub cargarciudad()
        Cbciudad.Items.Clear()
        Dim sql As String = "select * from ciudad"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbciudad.Items.Add(New Elementos(datos("nombre_ciudad"), datos("id_ciudad")))
            End While
        End If
        datos.Close()
        Cbciudad.SelectedIndex = 0
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_campus As Integer = 0
        Dim validadorcampus As String = ""
        Dim sql1 As String = "SELECT * FROM campus WHERE nombre_campus='" & txtcampusnombre.Text & "';"
        datos = mibd.consulta(sql1)
        If datos.HasRows Then
            While datos.Read
                validadorcampus = datos("nombre_campus")
            End While
        End If
        datos.Close()

        If validadorcampus = txtcampusnombre.Text Then
            MsgBox("Esta carrera ya ha sido ingresada", MsgBoxStyle.Critical, "READER SYSTEM")
        Else
            If Trim(txtcampusnombre.Text) <> "" And Trim(Cbciudad.Text) <> "" Then

                sql = "SELECT MAX(id_campus) as id FROM campus;"
                registros = mibd.consulta(sql)

                If registros.HasRows Then
                    While registros.Read
                        id_campus = registros("id")
                    End While
                End If
                registros.Close()

                sql = "INSERT INTO `biblioteca`.`campus` (`id_campus`, `id_ciudad`, `nombre_campus`) VALUES ('" & id_campus + 1 & "','" & Cbciudad.SelectedItem.value & "', '" & txtcampusnombre.Text & "');"

                mibd.sentencias(sql)
                Me.Dispose()
            Else
                MsgBox("Ingrese nombre del campus", MsgBoxStyle.Exclamation, "READER SYSTEM")
            End If
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionCampus)()
        Me.Dispose()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Cbciudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbciudad.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtcampusnombre_TextChanged(sender As Object, e As EventArgs) Handles txtcampusnombre.TextChanged

    End Sub
End Class