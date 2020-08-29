Imports MySql.Data.MySqlClient
Public Class FrmAlumnoEditar
    Private datos As MySqlDataReader
    Private id_campus, id_carrera As Integer
    Private cambioscampus, cambioscarrera As Integer

    Private Sub FrmUsuarioEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarcarrera()
        cargarcampus()
        misfunciones.seleccionCb(Cbcarrera, id_carrera)
        misfunciones.seleccionCb(CBcampus, id_campus)
        If misfunciones.getIdusuario <> "root" Then
            CBcampus.SelectedIndex = misfunciones.getcampus - 1
            CBcampus.Enabled = False
        End If
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM alumnos INNER JOIN campus ON campus.id_campus=alumnos.id_campus INNER JOIN carrera ON carrera.id_carrera=alumnos.id_carrera WHERE identidad='" & misfunciones.getId3 & "';"

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                TxtIdentidad.Text = datos("Identidad")
                TxtNombre.Text = datos("Nombre")
                Cbcarrera.Text = datos("nombre_carrera")
                TxtApellido.Text = datos("Apellido")
                TxtTelefono.Text = datos("Telefono")
                CBcampus.Text = datos("nombre_campus")
                txtedad.Text = Convert.ToDateTime(datos("fecha_de_nacimiento")).ToString("yyyy-MM-dd")
                TxtDireccion.Text = datos("Direccion")
            End While
        End If
        datos.Close()

    End Sub

    Private Sub cargarcarrera()
        Cbcarrera.Items.Clear()
        Dim sql As String = ""
        If misfunciones.getIdusuario <> "root" Then
            sql = "select * from carrera INNER JOIN carreras_por_campus ON carreras_por_campus.id_carrera=carrera.id_carrera WHERE id_campus='" & misfunciones.getcampus & "';"
        Else
            sql = "select * from carrera;"
        End If
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbcarrera.Items.Add(New Elementos(datos("nombre_carrera"), datos("id_carrera")))
            End While
        End If
        datos.Close()
    End Sub

    Private Sub Cbcarrera_SelectedIndexChanged(sender As Object, e As EventArgs)
        cambioscarrera = 1
    End Sub

    Private Sub CBcampus_SelectedIndexChanged(sender As Object, e As EventArgs)
        cambioscampus = 1
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        txtedad.Text = MonthCalendar1.SelectionEnd.Date.ToString("yyyy-MM-dd")
    End Sub

    Private Sub BtnGuardarNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_usuario As Integer = 0
        Dim validadoridentidad As String = ""
        Dim sql1 As String = "SELECT * FROM alumnos WHERE identidad='" & TxtIdentidad.Text & "' AND identidad <> '" & misfunciones.getId3 & "';"
        datos = mibd.consulta(sql1)
        If datos.HasRows Then
            While datos.Read
                validadoridentidad = datos("identidad")
            End While
        End If
        datos.Close()

        If validadoridentidad <> TxtIdentidad.Text Then
            If Trim(TxtNombre.Text) <> "" And Trim(TxtApellido.Text) <> "" And Trim(txtedad.Text) <> "" And Trim(TxtDireccion.Text) <> "" Then
                If cambioscarrera = 1 And cambioscampus = 0 Then
                    sql = "Update `biblioteca`.`alumnos` Set `id_carrera` = '" & Cbcarrera.SelectedItem.value & "', `id_campus` = '" & misfunciones.getId2 &
                               "', `Nombre` = '" & TxtNombre.Text & "', `Apellido` = '" & TxtApellido.Text & "', `Telefono` = '" & TxtTelefono.Text &
                               "', `fecha_de_nacimiento` = '" & txtedad.Text & "', `Direccion` = '" & TxtDireccion.Text & "', `identidad` = '" & TxtIdentidad.Text & "' WHERE `identidad`='" & misfunciones.getId3 & "';"

                ElseIf cambioscampus = 1 And cambioscarrera = 0 Then
                    sql = "Update `biblioteca`.`alumnos` Set `id_carrera` = '" & misfunciones.getId1 & "', `id_campus` = '" & CBcampus.SelectedItem.value &
                               "', `Nombre` = '" & TxtNombre.Text & "', `Apellido` = '" & TxtApellido.Text & "', `Telefono` = '" & TxtTelefono.Text &
                               "', `fecha_de_nacimiento` = '" & txtedad.Text & "', `Direccion` = '" & TxtDireccion.Text & "', `identidad` = '" & TxtIdentidad.Text & "' WHERE `identidad`='" & misfunciones.getId3 & "';"

                ElseIf cambioscampus = 1 And cambioscarrera = 1 Then
                    sql = "Update `biblioteca`.`alumnos` Set `id_carrera` = '" & Cbcarrera.SelectedItem.value & "', `id_campus` = '" & CBcampus.SelectedItem.value &
                               "', `Nombre` = '" & TxtNombre.Text & "', `Apellido` = '" & TxtApellido.Text & "', `Telefono` = '" & TxtTelefono.Text &
                               "', `fecha_de_nacimiento` = '" & txtedad.Text & "', `Direccion` = '" & TxtDireccion.Text & "', `identidad` = '" & TxtIdentidad.Text & "' WHERE `identidad`='" & misfunciones.getId3 & "';"


                ElseIf cambioscampus = 0 And cambioscarrera = 0 Then
                    sql = "Update `biblioteca`.`alumnos` Set `id_carrera` = '" & misfunciones.getId1 & "', `id_campus` = '" & misfunciones.getId2 & "', `Nombre` = '" & TxtNombre.Text & "', `Apellido` = '" & TxtApellido.Text & "', `Telefono` = '" & TxtTelefono.Text & "', `fecha_de_nacimiento` = '" & txtedad.Text & "', `Direccion` = '" & TxtDireccion.Text & "', `identidad` = '" & TxtIdentidad.Text & "' WHERE `identidad`='" & misfunciones.getId3 & "';"
                End If

                mibd.sentencias(sql)
                Me.Dispose()
            Else
                MsgBox("Ingrese todos los campos", MsgBoxStyle.Exclamation, "READER SYSTEM")
            End If
        Else
            MsgBox("Esta identidad ya esta existente", MsgBoxStyle.Critical, "READER SYSTEM")
        End If
    End Sub

    Private Sub BtnFechaNacimiento_Click(sender As Object, e As EventArgs) Handles BtnFechaNacimiento.Click
        If MonthCalendar1.Visible = True Then
            MonthCalendar1.Visible = False
        Else
            MonthCalendar1.Visible = True
        End If
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
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