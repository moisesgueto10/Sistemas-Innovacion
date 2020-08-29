Imports MySql.Data.MySqlClient
Public Class FrmCampusEditar
    Private datos As MySqlDataReader
    Private id_ciudad As Integer
    Private cambiosciudad As Integer
    Private nombre_del_campus As String

    Private Sub FrmCampusEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarciudad()
        misfunciones.seleccionCb(Cbciudad, id_ciudad)
        cargarDatos()
        nombre_del_campus = txtcampusnombre.Text
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM campus Inner Join ciudad ON campus.id_ciudad= ciudad.id_ciudad
        WHERE id_campus=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtcampusnombre.Text = datos("nombre_campus")
                Cbciudad.Text = datos("nombre_ciudad")
            End While
        End If
        datos.Close()

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

    Private Sub Cbciudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbciudad.SelectedIndexChanged
        cambiosciudad = 1
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_campus As Integer = 0
        Dim validadorcampus As String = ""
        Dim sql1 As String = "SELECT * FROM campus WHERE nombre_campus='" & txtcampusnombre.Text & "' AND nombre_campus <> '" & nombre_del_campus & "';"
        datos = mibd.consulta(sql1)
        If datos.HasRows Then
            While datos.Read
                validadorcampus = datos("nombre_campus")
            End While
        End If
        datos.Close()

        If validadorcampus = txtcampusnombre.Text Then
            MsgBox("Esta carrera ya ha sido ingresada", MsgBoxStyle.Critical, "READER SYSTEM")
            txtcampusnombre.Text = nombre_del_campus
        Else
            If Trim(txtcampusnombre.Text) <> "" And Trim(Cbciudad.Text) <> "" Then
                If cambiosciudad = 1 Then
                    sql = "UPDATE `biblioteca`.`campus` SET `id_ciudad` = '" & Cbciudad.SelectedItem.value & "', `nombre_campus` = '" & txtcampusnombre.Text & "' WHERE (`id_campus` = '" & misfunciones.getId & "');"
                    'value
                Else
                    sql = "UPDATE `biblioteca`.`campus` SET `id_ciudad` = '" & misfunciones.getId1 & "', `nombre_campus` = '" & txtcampusnombre.Text & "' WHERE (`id_campus` = '" & misfunciones.getId & "');"
                    'getid1
                End If
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
End Class