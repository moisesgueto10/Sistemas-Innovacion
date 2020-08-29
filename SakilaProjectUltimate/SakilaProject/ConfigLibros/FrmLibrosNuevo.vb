Imports MySql.Data.MySqlClient
Public Class FrmLibrosNuevo
    Private datos As MySqlDataReader
    Private id_autor, id_editorial As Integer
    Private Sub FrmLibrosNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargareditorial()
        cargareautor()
        misfunciones.seleccionCb(ComboBoxautor, id_autor)
        misfunciones.seleccionCb(ComboBoxeditorial, id_editorial)
        ComboBoxautor.SelectedIndex = 0
        ComboBoxeditorial.SelectedIndex = 0
        TxtArea.Text = "Pasillo "
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub cargareditorial()
        ComboBoxeditorial.Items.Clear()
        Dim sql As String = "select * from editorial ORDER BY nombre_editorial ASC"
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
        Dim sql As String = "select * from autor ORDER BY nombre ASC"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                ComboBoxautor.Items.Add(New Elementos(datos("nombre"), datos("id_autor")))
            End While
        End If
        datos.Close()
    End Sub

    Private Sub TxtArea_TextChanged(sender As Object, e As EventArgs) Handles TxtArea.TextChanged
        If TxtArea.Text.Length < 8 Then
            TxtArea.Text = "Pasillo "
            TxtArea.SelectionStart = TxtArea.Text.Length
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FrmEditorialNuevo.ShowDialog()
        cargareditorial()
        misfunciones.seleccionCb(ComboBoxeditorial, id_editorial)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAutorNuevo.ShowDialog()
        cargareautor()
        misfunciones.seleccionCb(ComboBoxautor, id_autor)
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_libro As Integer = 0
        Dim validadoredicion As String = ""
        If IsNumeric(TxtEdicion.Text) Then
            Dim sql1 As String = "SELECT * FROM libro WHERE Titulo='" & TxtTitulo.Text & "' AND Edicion = '" & TxtEdicion.Text & "';"
            datos = mibd.consulta(sql1)
            If datos.HasRows Then
                While datos.Read
                    validadoredicion = datos("Edicion")
                End While
            End If
            datos.Close()
        End If

        If validadoredicion = TxtEdicion.Text Then
            MsgBox("Este libro ya ha sido ingresado, elija otra edicion o cambie el nombre del libro", MsgBoxStyle.Critical, "READER SYSTEM")
        Else
            If Trim(TxtTitulo.Text) <> "" And Trim(ComboBoxeditorial.Text) <> "" And Trim(TxtEdicion.Text) <> "" And Trim(TxtArea.Text) <> "" And Trim(ComboBoxeditorial.Text) <> "" And Trim(TxtDescripcion.Text) <> "" Then
                Try
                    sql = "SELECT MAX(id_libro) as id FROM libro;"
                    registros = mibd.consulta(sql)

                    If registros.HasRows Then
                        While registros.Read
                            id_libro = registros("id")
                        End While
                    End If

                    registros.Close()
                    sql = "INSERT INTO `biblioteca`.`libro` (`id_libro`, `Titulo`, `Edicion`, `Area`, `Descripcion`, `id_editorial`, `id_autor`) VALUES ('" &
                    id_libro + 1 & "','" & TxtTitulo.Text & "', '" & Val(TxtEdicion.Text) & "' , '" & TxtArea.Text & "' , '" & TxtDescripcion.Text & "' , '" & ComboBoxeditorial.SelectedItem.value & "' , '" & ComboBoxautor.SelectedItem.value & "');"
                    mibd.sentencias(sql)
                    Me.Dispose()
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            Else
                MsgBox("Debe ingresar todos los campos obligatorios e ingresar la edicion con numeros", MsgBoxStyle.Exclamation, "READER SYSTEM")
            End If
        End If

    End Sub
End Class