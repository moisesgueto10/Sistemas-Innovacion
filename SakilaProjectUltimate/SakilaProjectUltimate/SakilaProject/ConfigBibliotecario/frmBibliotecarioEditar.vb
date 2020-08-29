Imports MySql.Data.MySqlClient
Public Class frmBibliotecarioEditar
    Private datos As MySqlDataReader
    Private id_campus As Integer
    Private campos As Integer
    Private cambiosfecha As Integer

    Private Sub frmClienteEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frmContraseñaBibliotecario.Show()
        cargarDatos()
        cargarcampus()
        misfunciones.seleccionCb(Cbcampus, id_campus)
        'misfunciones.seleccionCb(cbPais, pais_id)
        'misfunciones.seleccionCb(cbCiudad, ciudad_id)
        If txtusuario.Text = "root" Then
            txtusuario.Enabled = False
        End If
    End Sub


    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM bibliotecario INNER JOIN campus ON campus.id_campus=bibliotecario.id_campus WHERE nombre_de_usuario='" & misfunciones.getId3 & "';"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtusuario.Text = datos("nombre_de_usuario")
                txtcontra.Text = datos("contrasena")
                Cbcampus.Text = datos("nombre_campus")
                TxtNombre.Text = datos("nombre")
                TxtApellido.Text = datos("apellido")
                txtnacimiento.Text = Convert.ToDateTime(datos("Fecha_de_Nacimiento")).ToString("yyyy-MM-dd")
                txtidentidad.Text = datos("identidad")
                TxtDireccion.Text = datos("direccion")
            End While
        End If
        datos.Close()

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
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = ""

        Dim validadoridentidad As String = ""
        Dim validadorusuario As String = ""
        Dim repetido As String = "SELECT * FROM bibliotecario WHERE (identidad='" & txtidentidad.Text & "' OR nombre_de_usuario='" & txtusuario.Text & "') AND (identidad <> '" & misfunciones.getId4 & "' AND nombre_de_usuario <> '" & misfunciones.getId3 & "');"
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
            If Trim(TxtNombre.Text) <> "" And Trim(TxtApellido.Text) <> "" And Trim(txtnacimiento.Text) <> "" And Trim(TxtDireccion.Text) <> "" Then
                If campos = 1 And cambiosfecha = 1 Then
                    sql = "Update `biblioteca`.`bibliotecario` Set `id_campus`='" & Cbcampus.SelectedItem.value & "', `nombre`='" & TxtNombre.Text &
                    "', `apellido`='" & TxtApellido.Text & "', `Fecha_de_nacimiento`='" & Convert.ToDateTime(txtnacimiento.Text).ToString("yyyy-MM-dd") & "', `direccion`='" & TxtDireccion.Text &
                    "', `nombre_de_usuario`='" & txtusuario.Text & "', `contrasena`='" & txtcontra.Text & "', `identidad`='" & txtidentidad.Text & "' WHERE `nombre_de_usuario`='" & misfunciones.getId3 & "';"
                Else
                    sql = "Update `biblioteca`.`bibliotecario` Set `id_campus`='" & misfunciones.getId1 & "', `nombre`='" & TxtNombre.Text &
                                "', `apellido`='" & TxtApellido.Text & "', `Fecha_de_nacimiento`='" & Convert.ToDateTime(txtnacimiento.Text).ToString("yyyy-MM-dd") & "', `direccion`='" & TxtDireccion.Text &
                                "', `nombre_de_usuario`='" & txtusuario.Text & "', `contrasena`='" & txtcontra.Text & "', `identidad`='" & txtidentidad.Text & "' WHERE `nombre_de_usuario`='" & misfunciones.getId3 & "';"

                End If
                If misfunciones.getIdusuario <> "root" Then
                    misfunciones.setIdusuario(txtusuario.Text)
                    frmMenu.Timer1.Start()
                End If
                mibd.sentencias(sql)
                frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
                Me.Dispose()
            Else
                MsgBox("Ingrese todos los datos", MsgBoxStyle.Exclamation, "READER SYSTEM")
            End If
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
        Me.Dispose()
    End Sub

    Private Sub Cbcampus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbcampus.SelectedIndexChanged
        campos = 1
    End Sub

    Private Sub txtnacimiento_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtnacimiento.MaskInputRejected
        cambiosfecha = 1
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