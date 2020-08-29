Imports MySql.Data.MySqlClient
Public Class FrmLibrosEliminar
    Private datos As MySqlDataReader
    Private id_autor, id_editorial As Integer

    Private Sub FrmLibrosEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_libro As Integer = 0

        sql = "DELETE FROM `biblioteca`.`libro` WHERE `id_libro`='" & misfunciones.getId & "';"

        mibd.sentencias(sql)

        frmMenu.AbrirFormEnPanel(Of GestionLibros)()
        Me.Dispose()
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionLibros)()
        Me.Dispose()
    End Sub
End Class