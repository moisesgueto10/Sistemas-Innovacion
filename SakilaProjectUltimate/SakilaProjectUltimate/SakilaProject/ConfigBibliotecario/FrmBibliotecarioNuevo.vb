Imports MySql.Data.MySqlClient
Public Class frmBibliotecarioNuevo
    Private datos As MySqlDataReader
    Private id_campus As Integer

    Private Sub frmClienteNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargarPais()
        'cargarCiudad()

        misfunciones.seleccionCb(Cbcampus, id_campus)
        cargarcampus()
    End Sub

    Private Sub cargarcampus()
        Cbcampus.Items.Clear()
        Dim sql As String = "select * from campus"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbcampus.Items.Add(New Elementos(datos("nombre_campus"), datos("id_campus")))
            End While
        End If
        datos.Close()
        Cbcampus.SelectedIndex = 0
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim Sql As String = "INSERT INTO `biblioteca`.`bibliotecario` (`nombre_de_usuario`, `id_campus`, `nombre`, `apellido`, `contrasena`, `Fecha_de_Nacimiento`, `identidad`, `direccion`) VALUES ('" & txtusuario.Text & "', '" & Cbcampus.SelectedItem.value & "', '" & TxtNombre.Text & "', '" & TxtApellido.Text & "', '" & txtcontra.Text & "', '" & Convert.ToDateTime(txtnacimiento.Text).ToString("yyyy-MM-dd") & "', '" & Val(txtidentidad.Text) & "', '" & TxtDireccion.Text & "');"
        Dim validadoridentidad As String = ""
        Dim validadorusuario As String = ""
        Dim repetido As String = "SELECT * FROM bibliotecario WHERE identidad='" & txtidentidad.Text & "' OR nombre_de_usuario='" & txtusuario.Text & "';"
        datos = mibd.consulta(repetido)
        If datos.HasRows Then
            While datos.Read
                validadoridentidad = datos("identidad")
                validadorusuario = datos("nombre_de_usuario")
            End While
        End If
        datos.Close()
        If validadoridentidad = txtidentidad.Text Or validadorusuario = txtusuario.Text Then
            MsgBox("La identidad o el usuario ya existe", MsgBoxStyle.Critical, "READER SYSTEM")
        Else
            If Trim(TxtApellido.Text) <> "" And Trim(txtcontra.Text) <> "" And Trim(TxtDireccion.Text) <> "" And Trim(txtidentidad.Text) <> "" And Trim(txtnacimiento.Text) <> "" And Trim(TxtNombre.Text) <> "" And Trim(txtusuario.Text) <> "" And IsNumeric(txtidentidad.Text) Then
                mibd.sentencias(Sql)
                Me.Dispose()
            Else
                MsgBox("Ingrese todos los campos", MsgBoxStyle.Exclamation, "READER SYSTEM")
            End If
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
        Me.Dispose()
    End Sub

    Private Sub btncalendario_Click(sender As Object, e As EventArgs) Handles btncalendario.Click
        If MonthCalendar1.Visible = True Then
            MonthCalendar1.Visible = False
        Else
            MonthCalendar1.Visible = True
        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        txtnacimiento.Text = MonthCalendar1.SelectionEnd.Date.ToString("yyyy-MM-dd")
    End Sub
End Class