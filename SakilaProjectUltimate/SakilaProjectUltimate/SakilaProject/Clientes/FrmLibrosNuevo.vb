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
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionLibros)()
        Me.Dispose()
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


    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_libro As Integer = 0


        If Trim(TxtTitulo.Text) <> "" And Trim(ComboBoxeditorial.Text) <> "" And Trim(TxtEdicion.Text) <> "" And Trim(TxtArea.Text) <> "" And Trim(ComboBoxeditorial.Text) <> "" And Trim(TxtDescripcion.Text) <> "" And Trim(TxtESBN.Text) <> "" Then
            Try
                sql = "SELECT MAX(id_libro) as id FROM libro;"
                registros = mibd.consulta(sql)


                If registros.HasRows Then
                    While registros.Read
                        id_libro = registros("id")
                    End While
                End If

                registros.Close()
                sql = "INSERT INTO `biblioteca`.`libro` (`id_libro`, `Titulo`, `Edicion`, `Area`, `Descripcion`, `CodigoESBN`, `id_editorial`, `id_autor`) VALUES ('" &
                id_libro + 1 & "','" & TxtTitulo.Text & "', '" & TxtEdicion.Text & "' , '" & TxtArea.Text & "' , '" & TxtDescripcion.Text & "' , '" & Convert.ToString(TxtESBN.Text) & "' , '" & ComboBoxeditorial.SelectedItem.value & "' , '" & ComboBoxautor.SelectedItem.value & "');"

                mibd.sentencias(sql)
                frmMenu.AbrirFormEnPanel(Of GestionLibros)()
                Me.Dispose()

            Catch ex As Exception
                MsgBox(ex)
            End Try

        Else
            MessageBox.Show("Debe ingresar todos los campos obligatorios")
        End If

    End Sub
End Class