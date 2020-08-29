Imports MySql.Data.MySqlClient
Public Class FrmLibrosEditar
    Private datos As MySqlDataReader
    Private id_autor, id_editorial As Integer
    Private cambioseditorial, cambiosautor As Integer
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionLibros)()
        Me.Dispose()
    End Sub

    Private Sub FrmLibrosEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargareditorial()
        cargareautor()
        misfunciones.seleccionCb(ComboBoxautor, id_autor)
        misfunciones.seleccionCb(ComboBoxeditorial, id_editorial)

    End Sub

    Private Sub cargareditorial()
        ComboBoxeditorial.Items.Clear()
        Dim sql As String = "select * from editorial"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                ComboBoxeditorial.Items.Add(New Elementos(datos("nombre_editorial"), datos("id_editorial")))
            End While
        End If
        datos.Close()
    End Sub

    Private Sub cargareautor()
        ComboBoxautor.Items.Clear()
        Dim sql As String = "select * from autor"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                ComboBoxautor.Items.Add(New Elementos(datos("nombre"), datos("id_autor")))
            End While
        End If
        datos.Close()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM libro  INNER JOIN autor ON autor.id_autor=libro.id_autor INNER JOIN editorial ON editorial.id_editorial=libro.id_editorial
        WHERE id_libro=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                TxtTitulo.Text = datos("Titulo")
                ComboBoxeditorial.Text = datos("nombre_editorial")
                TxtEdicion.Text = datos("Edicion")
                TxtArea.Text = datos("Area")
                ComboBoxautor.Text = datos("nombre")
                TxtDescripcion.Text = datos("Descripcion")
                TxtESBN.Text = datos("CodigoESBN")
            End While
        End If
        datos.Close()

    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_libro As Integer = 0
        If Trim(TxtTitulo.Text) <> "" And Trim(ComboBoxeditorial.Text) <> "" And Trim(TxtEdicion.Text) <> "" And Trim(TxtArea.Text) <> "" And Trim(ComboBoxeditorial.Text) <> "" And Trim(TxtDescripcion.Text) <> "" And Trim(TxtESBN.Text) <> "" Then
            If cambiosautor = 1 And cambioseditorial = 0 Then
                sql = "Update `biblioteca`.`libro` Set `Titulo`='" & TxtTitulo.Text & "', `id_editorial`='" & misfunciones.getId1 &
                           "', `Edicion`='" & TxtEdicion.Text & "', `Area`='" & TxtArea.Text & "', `id_autor`='" & ComboBoxautor.SelectedItem.value &
                           "', `Descripcion`='" & TxtDescripcion.Text & "', `CodigoESBN`='" & TxtESBN.Text & "' WHERE `id_libro`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)
            ElseIf cambioseditorial = 1 And cambiosautor = 0 Then
                sql = "Update `biblioteca`.`libro` Set `Titulo`='" & TxtTitulo.Text & "', `id_editorial`='" & ComboBoxeditorial.SelectedItem.value &
                            "', `Edicion`='" & TxtEdicion.Text & "', `Area`='" & TxtArea.Text & "', `id_autor`='" & misfunciones.getId2 &
                            "', `Descripcion`='" & TxtDescripcion.Text & "', `CodigoESBN`='" & TxtESBN.Text & "' WHERE `id_libro`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)
            ElseIf cambioseditorial = 1 And cambiosautor = 1 Then
                sql = "Update `biblioteca`.`libro` Set `Titulo`='" & TxtTitulo.Text & "', `id_editorial`='" & ComboBoxeditorial.SelectedItem.value &
                            "', `Edicion`='" & TxtEdicion.Text & "', `Area`='" & TxtArea.Text & "', `id_autor`='" & ComboBoxautor.SelectedItem.value &
                            "', `Descripcion`='" & TxtDescripcion.Text & "', `CodigoESBN`='" & TxtESBN.Text & "' WHERE `id_libro`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)

            ElseIf cambioseditorial = 0 And cambiosautor = 0 Then
                sql = "Update `biblioteca`.`libro` Set `Titulo`='" & TxtTitulo.Text & "', `id_editorial`='" & misfunciones.getId1 &
                           "', `Edicion`='" & TxtEdicion.Text & "', `Area`='" & TxtArea.Text & "', `id_autor`='" & misfunciones.getId2 &
                           "', `Descripcion`='" & TxtDescripcion.Text & "', `CodigoESBN`='" & TxtESBN.Text & "' WHERE `id_libro`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)
            End If

            frmMenu.AbrirFormEnPanel(Of GestionLibros)()
            Me.Dispose()
        Else
            MsgBox("Ingrese todos los campos")
        End If
    End Sub

    Private Sub ComboBoxeditorial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxeditorial.SelectedIndexChanged
        cambioseditorial = 1
    End Sub

    Private Sub ComboBoxautor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxautor.SelectedIndexChanged
        cambiosautor = 1
    End Sub

End Class