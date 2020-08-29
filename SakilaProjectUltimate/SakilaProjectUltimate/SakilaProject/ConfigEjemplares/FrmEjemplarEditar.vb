Imports MySql.Data.MySqlClient
Public Class FrmEjemplarEditar
    Private datos As MySqlDataReader
    Private id_campus, id_libro As Integer
    Private cambioscampus, cambioslibro As Integer
    Private codigoisbn As String

    Private Sub FrmEjemplarEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarcampus()
        cargarlibro()
        misfunciones.seleccionCb(Cbcampus, id_campus)
        misfunciones.seleccionCb(cblibro, id_libro)
        codigoisbn = txtejemplar.Text
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM ejemplar INNER JOIN campus ON campus.id_campus=ejemplar.id_campus INNER JOIN libro ON libro.id_libro=ejemplar.id_libro WHERE id_ejemplar=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbcampus.Text = datos("nombre_campus")
                cblibro.Text = datos("Titulo")
                txtejemplar.Text = datos("CodigoISBN")
                cbestado.Text = datos("estado")
                CBDisponibilidad.Text = datos("Disponibilidad")
                txtedicion.Text = datos("Edicion")
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

    Private Sub Cbcampus_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cblibro_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub cblibro_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cblibro.SelectedIndexChanged
        cambioslibro = 1
        Dim sql As String = "select * from libro WHERE id_libro='" & cblibro.SelectedItem.value & "';"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtedicion.Text = datos("Edicion")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub Cbcampus_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cbcampus.SelectedIndexChanged
        cambioscampus = 1
    End Sub

    Private Sub BtnGuardarNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_ejemplar As Integer = 0
        Dim validadorcodigoISBN As String = ""
        Dim sql1 As String = "SELECT * FROM ejemplar WHERE codigoISBN='" & txtejemplar.Text & "' AND CodigoISBN <> '" & codigoisbn & "';"
        datos = mibd.consulta(sql1)
        If datos.HasRows Then
            While datos.Read
                validadorcodigoISBN = datos("CodigoISBN")
            End While
        End If
        datos.Close()

        If validadorcodigoISBN <> txtejemplar.Text Then
            If txtejemplar.Text <> "" Then
                If cambioscampus = 1 And cambioslibro = 0 Then
                    sql = "Update `biblioteca`.`ejemplar` Set `CodigoISBN`='" & txtejemplar.Text & "', `estado`='" & cbestado.Text & "', `Disponibilidad`='" & CBDisponibilidad.Text &
                    "', `id_libro`='" & misfunciones.getId1 & "', `id_campus`='" & Cbcampus.SelectedItem.value & "' WHERE `id_ejemplar`='" & misfunciones.getId & "';"
                ElseIf cambioscampus = 0 And cambioslibro = 1 Then
                    sql = "Update `biblioteca`.`ejemplar` Set `CodigoISBN`='" & txtejemplar.Text & "', `estado`='" & cbestado.Text & "', `Disponibilidad`='" & CBDisponibilidad.Text &
                    "', `id_libro`='" & cblibro.SelectedItem.value & "', `id_campus`='" & misfunciones.getId2 & "' WHERE `id_ejemplar`='" & misfunciones.getId & "';"
                ElseIf cambioscampus = 1 And cambioslibro = 1 Then
                    sql = "Update `biblioteca`.`ejemplar` Set `CodigoISBN`='" & txtejemplar.Text & "', `estado`='" & cbestado.Text & "', `Disponibilidad`='" & CBDisponibilidad.Text & "', `id_libro`='" & cblibro.SelectedValue & "', `id_campus`='" & Cbcampus.SelectedValue & "' WHERE (`id_ejemplar`='" & misfunciones.getId & "');"
                ElseIf cambioscampus = 0 And cambioslibro = 0 Then
                    sql = "Update `biblioteca`.`ejemplar` Set `CodigoISBN`='" & txtejemplar.Text & "', `estado`='" & cbestado.Text & "', `Disponibilidad`='" & CBDisponibilidad.Text &
                    "', `id_libro`='" & misfunciones.getId1 & "', `id_campus`='" & misfunciones.getId2 & "' WHERE (`id_ejemplar`='" & misfunciones.getId & "');"
                End If
                mibd.sentencias(sql)
                Me.Dispose()
            Else
                MsgBox("Ingrese todos los datos", MsgBoxStyle.Exclamation, "READER SYSTEM")
            End If
        Else
            MsgBox("Este Codigo ISBN ya existe", MsgBoxStyle.Critical, "READER SYSTEM")
        End If
    End Sub

    Private Sub cargarlibro()
        cblibro.Items.Clear()
        Dim sql As String = "select * from libro ORDER BY Titulo ASC"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cblibro.Items.Add(New Elementos(datos("Titulo"), datos("id_libro")))
            End While
        End If
        datos.Close()
    End Sub
End Class