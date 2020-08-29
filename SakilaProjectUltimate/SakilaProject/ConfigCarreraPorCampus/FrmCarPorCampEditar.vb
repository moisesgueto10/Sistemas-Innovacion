Imports MySql.Data.MySqlClient
Public Class FrmCarPorCampEditar
    Private datos As MySqlDataReader
    Private id_campus, id_carrera As Integer
    Private cambioscampus, cambioscarrera As Integer
    Private campus, carrera As String

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionCarreraPorCampus)()
        Me.Dispose()
    End Sub

    Private Sub FrmCarPorCampEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarcarrera()
        cargarcampus()
        misfunciones.seleccionCb(CBCarrera, id_carrera)
        misfunciones.seleccionCb(CBcampus, id_campus)
        campus = CBcampus.Text
        carrera = CBCarrera.Text
        If misfunciones.getIdusuario <> "root" Then
            CBcampus.SelectedIndex = misfunciones.getcampus - 1
            CBcampus.Enabled = False
        End If
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM carreras_por_campus INNER JOIN campus ON campus.id_campus=carreras_por_campus.id_campus INNER JOIN carrera ON carrera.id_carrera=carreras_por_campus.id_carrera WHERE carreras_por_campus.id_campus='" & misfunciones.getId & "' AND carreras_por_campus.id_carrera='" & misfunciones.getId1 & "';"

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                CBCarrera.Text = datos("nombre_carrera")
                CBcampus.Text = datos("nombre_campus")
            End While
        End If
        datos.Close()

    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click

        Dim sql As String = ""
        Dim validadorcampus As String = ""
        Dim validadorcarrera As String = ""
        Dim repetido As String = ""

        If cambioscarrera = 1 And cambioscampus = 1 Then
            repetido = "SELECT * FROM carreras_por_campus WHERE id_campus='" & CBcampus.SelectedItem.value & "' AND id_carrera='" & CBCarrera.SelectedItem.value & "';"
        ElseIf cambioscampus = 1 And cambioscarrera = 0 Then
            repetido = "SELECT * FROM carreras_por_campus WHERE id_campus='" & CBcampus.SelectedItem.value & "' AND id_carrera='" & misfunciones.getId1 & "';"
        ElseIf cambioscampus = 0 And cambioscarrera = 1 Then
            repetido = "SELECT * FROM carreras_por_campus WHERE id_campus='" & misfunciones.getId & "' AND id_carrera='" & CBCarrera.SelectedItem.value & "';"
        End If

        If cambioscampus = 1 Or cambioscarrera = 1 Then
            datos = mibd.consulta(repetido)
            If datos.HasRows Then
                While datos.Read
                    validadorcampus = datos("id_campus")
                    validadorcarrera = datos("id_carrera")
                End While
            End If
            datos.Close()
        End If

        If (cambioscarrera = 0 And cambioscampus = 0) Or (campus = CBcampus.Text And carrera = CBCarrera.Text) Then
            Me.Dispose()
            Me.Hide()
            Me.Close()
        Else
            If cambioscarrera = 1 And cambioscampus = 1 Then
                If Val(validadorcampus) = CBcampus.SelectedItem.value And Val(validadorcarrera) = CBCarrera.SelectedItem.value Then
                    MsgBox("La carrera " & CBCarrera.Text & " en el campus " & CBcampus.Text & " ya existe")
                    CBcampus.Text = campus
                    CBCarrera.Text = carrera
                Else
                    sql = "UPDATE `biblioteca`.`carreras_por_campus` Set `id_campus` = '" & CBcampus.SelectedItem.value & "', `id_carrera` = '" & CBCarrera.SelectedItem.value & "' WHERE (`id_campus` = '" & misfunciones.getId & "') and (`id_carrera` = '" & misfunciones.getId1 & "');"
                    mibd.sentencias(sql)
                    Me.Dispose()
                End If

            ElseIf cambioscampus = 1 And cambioscarrera = 0 Then
                If Val(validadorcampus) = CBcampus.SelectedItem.value And Val(validadorcarrera) = misfunciones.getId1 Then
                    MsgBox("La carrera " & CBCarrera.Text & " en el campus " & CBcampus.Text & " ya existe")
                    CBcampus.Text = campus
                    CBCarrera.Text = carrera
                Else
                    sql = "UPDATE `biblioteca`.`carreras_por_campus` SET `id_campus` = '" & CBcampus.SelectedItem.value & "' WHERE (`id_campus` = '" & misfunciones.getId & "') and (`id_carrera` = '" & misfunciones.getId1 & "');"
                    mibd.sentencias(sql)
                    Me.Dispose()
                End If

            ElseIf cambioscampus = 0 And cambioscarrera = 1 Then
                If Val(validadorcampus) = misfunciones.getId And Val(validadorcarrera) = CBCarrera.SelectedItem.value Then
                    MsgBox("La carrera " & CBCarrera.Text & " en el campus " & CBcampus.Text & " ya existe")
                    CBcampus.Text = campus
                    CBCarrera.Text = carrera
                Else
                    sql = "UPDATE `biblioteca`.`carreras_por_campus` SET  `id_carrera` = '" & CBCarrera.SelectedItem.value & "' WHERE (`id_campus` = '" & misfunciones.getId & "') and (`id_carrera` = '" & misfunciones.getId1 & "');"
                    mibd.sentencias(sql)
                    Me.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub CBcampus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBcampus.SelectedIndexChanged
        cambioscampus = 1
    End Sub

    Private Sub CBCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCarrera.SelectedIndexChanged
        cambioscarrera = 1
    End Sub

    Private Sub cargarcarrera()
        CBCarrera.Items.Clear()
        Dim sql As String = "select * from carrera"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                CBCarrera.Items.Add(New Elementos(datos("nombre_carrera"), datos("id_carrera")))
            End While
        End If
        datos.Close()
    End Sub

    Private Sub cargarcampus()
        CBcampus.Items.Clear()
        Dim sql As String = "select * from campus"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                CBcampus.Items.Add(New Elementos(datos("nombre_campus"), datos("id_campus")))
            End While
        End If
        datos.Close()
    End Sub
End Class