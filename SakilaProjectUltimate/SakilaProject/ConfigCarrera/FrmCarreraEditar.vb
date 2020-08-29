Imports MySql.Data.MySqlClient
Public Class FrmCarreraEditar
    Private datos As MySqlDataReader
    Private nombre_del_campus As String
    Private Sub FrmCarreraEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        nombre_del_campus = TxtNombre.Text
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM carrera WHERE id_carrera=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                TxtNombre.Text = datos("nombre_carrera")
            End While
        End If
        datos.Close()

    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "UPDATE `biblioteca`.`carrera` SET `nombre_carrera` = '" & TxtNombre.Text & "' WHERE (`id_carrera` = '" & misfunciones.getId & "');"
        Dim validadorcarrera As String = ""
        Dim sql1 As String = "SELECT * FROM carrera WHERE nombre_carrera='" & TxtNombre.Text & "' AND nombre_carrera <> '" & nombre_del_campus & "';"
        datos = mibd.consulta(sql1)
        If datos.HasRows Then
            While datos.Read
                validadorcarrera = datos("nombre_carrera")
            End While
        End If
        datos.Close()

        If validadorcarrera = TxtNombre.Text Then
            MsgBox("Esta carrera ya ha sido ingresada", MsgBoxStyle.Critical, "READER SYSTEM")
            TxtNombre.Text = nombre_del_campus
        Else
            If Trim(TxtNombre.Text) <> "" Then
                mibd.sentencias(sql)
                Me.Dispose()
            Else
                MsgBox("ingrese nombre de la carrera", MsgBoxStyle.Exclamation, "READER SYSTEM")
            End If
        End If



    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionCarrera)()
        Me.Dispose()
    End Sub
End Class