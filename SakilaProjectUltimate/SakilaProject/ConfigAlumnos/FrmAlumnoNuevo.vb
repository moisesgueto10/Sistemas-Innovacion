Imports MySql.Data.MySqlClient
Public Class FrmAlumnoNuevo
    Private datos As MySqlDataReader
    Private id_campus, id_carrera As Integer

    Private Sub frmClienteNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcarrera()
        cargarcampus()
        misfunciones.seleccionCb(Cbcarrera, id_carrera)
        misfunciones.seleccionCb(CBcampus, id_campus)
        If misfunciones.getIdusuario <> "root" Then
            CBcampus.SelectedIndex = misfunciones.getcampus - 1
            CBcampus.Enabled = False
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        accion()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionAlumnos)()
        Me.Dispose()
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
        Cbcarrera.SelectedIndex = 0
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
        CBcampus.SelectedIndex = 0
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        txtedad.Text = MonthCalendar1.SelectionEnd.Date.ToString("yyyy-MM-dd")
    End Sub

    Private Sub BtnFechaNacimiento_Click(sender As Object, e As EventArgs) Handles BtnFechaNacimiento.Click
        If MonthCalendar1.Visible = True Then
            MonthCalendar1.Visible = False
        Else
            MonthCalendar1.Visible = True
        End If
    End Sub

    Private Sub accion()
        Dim sql As String = ""
        Dim validadoridentidad As String = ""
        Dim sql1 As String = "SELECT * FROM alumnos WHERE identidad='" & TxtIdentidad.Text & "';"
        datos = mibd.consulta(sql1)
        If datos.HasRows Then
            While datos.Read
                validadoridentidad = datos("identidad")
            End While
        End If
        datos.Close()

        If validadoridentidad <> TxtIdentidad.Text Then
            If Trim(TxtNombre.Text) <> "" And Trim(TxtApellido.Text) <> "" And Trim(txtedad.Text) <> "" And Trim(TxtDireccion.Text) <> "" And IsNumeric(TxtIdentidad.Text) Then
                Try
                    sql = "INSERT INTO `biblioteca`.`alumnos` (`identidad`, `id_carrera`, `id_campus`, `Nombre`, `Apellido`, `Telefono`, `fecha_de_nacimiento`, `Direccion`) VALUES ('" &
                    TxtIdentidad.Text & "','" & Cbcarrera.SelectedItem.value & "', '" & CBcampus.SelectedItem.value & "' , '" & TxtNombre.Text & "' , '" & TxtApellido.Text & "' , '" & TxtTelefono.Text & "' , '" & Convert.ToDateTime(txtedad.Text).ToString("yyyy-MM-dd") & "' , '" & TxtDireccion.Text & "');"
                    mibd.sentencias(sql)
                    Me.Dispose()
                Catch ex As Exception

                End Try
            Else
                MsgBox("Debe ingresar todos los campos obligatorios", MsgBoxStyle.Exclamation, "READER SYSTEM")
            End If
        ElseIf validadoridentidad = TxtIdentidad.Text Then
            MsgBox("Esta identidad ya existe", MsgBoxStyle.Critical, "READER SYSTEM")
        End If

    End Sub
End Class