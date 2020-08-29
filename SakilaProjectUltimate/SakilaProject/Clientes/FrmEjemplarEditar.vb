Imports MySql.Data.MySqlClient
Public Class FrmEjemplarEditar
    Private datos As MySqlDataReader
    Private id_campus, id_libro As Integer
    Private cambioscampus, cambioslibro As Integer

    Private Sub FrmEjemplarEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcampus()
        misfunciones.seleccionCb(Cbcampus, id_campus)
        cargarlibro()
        misfunciones.seleccionCb(cblibro, id_libro)
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM ejemplar INNER JOIN campus ON campus.id_campus=ejemplar.id_campus INNER JOIN libro ON libro.id_libro=ejemplar.id_libro WHERE id_ejemplar=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbcampus.Text = datos("nombre_campus")
                cblibro.Text = datos("Titulo")
                txtejemplar.Text = datos("num_ejemplar")
                cbestado.Text = datos("estado")
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

    Private Sub Cbcampus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbcampus.SelectedIndexChanged
        cambioscampus = 1
    End Sub

    Private Sub cblibro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblibro.SelectedIndexChanged
        cambioslibro = 1
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionEjemplares)()
        Me.Dispose()
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", id_ejemplar As Integer = 0, id_campus As Integer = 0
        If txtejemplar.Text <> "" Then
            If cambioscampus = 1 And cambioslibro = 0 Then
                sql = "Update `biblioteca`.`ejemplar` Set `num_ejemplar`='" & txtejemplar.Text & "', `estado`='" & cbestado.Text &
                    "', `id_libro`='" & misfunciones.getId1 & "', `id_campus`='" & Cbcampus.SelectedItem.value & "' WHERE `id_ejemplar`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)
                frmMenu.AbrirFormEnPanel(Of GestionEjemplares)()
                Me.Dispose()
            ElseIf cambioscampus = 0 And cambioslibro = 1 Then
                sql = "Update `biblioteca`.`ejemplar` Set `num_ejemplar`='" & txtejemplar.Text & "', `estado`='" & cbestado.Text &
                    "', `id_libro`='" & cblibro.SelectedItem.value & "', `id_campus`='" & misfunciones.getId2 & "' WHERE `id_ejemplar`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)
                frmMenu.AbrirFormEnPanel(Of GestionEjemplares)()
                Me.Dispose()
            ElseIf cambioscampus = 1 And cambioslibro = 1 Then
                sql = "Update `biblioteca`.`ejemplar` Set `num_ejemplar`='" & txtejemplar.Text & "', `estado`='" & cbestado.Text &
                    "', `id_libro`='" & cblibro.SelectedItem.value & "', `id_campus`='" & Cbcampus.SelectedItem.value & "' WHERE `id_ejemplar`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)
                frmMenu.AbrirFormEnPanel(Of GestionEjemplares)()
                Me.Dispose()
            ElseIf cambioscampus = 0 And cambioslibro = 0 Then
                sql = "Update `biblioteca`.`ejemplar` Set `num_ejemplar`='" & txtejemplar.Text & "', `estado`='" & cbestado.Text &
                    "', `id_libro`='" & misfunciones.getId1 & "', `id_campus`='" & misfunciones.getId2 & "' WHERE `id_ejemplar`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)
                frmMenu.AbrirFormEnPanel(Of GestionEjemplares)()
                Me.Dispose()

            End If
        Else
            MsgBox("Ingrese todos los datos")
        End If

    End Sub

    Private Sub cargarlibro()
        cblibro.Items.Clear()
        Dim sql As String = "select * from libro"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cblibro.Items.Add(New Elementos(datos("Titulo"), datos("id_libro")))
            End While
        End If
        datos.Close()
    End Sub
End Class