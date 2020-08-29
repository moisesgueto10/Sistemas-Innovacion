Imports MySql.Data.MySqlClient
Public Class GestionLibros
    Public id As Integer
    Public id1 As Integer
    Public id2 As Integer

    Private Sub GestionLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    ''' <summary>
    ''' Función para cargar las columnas del Listview
    ''' </summary>
    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_libro").Width() = 0
        lvPrincipal.Columns.Add("Titulo").Width() = 280
        lvPrincipal.Columns.Add("id_editorial").Width() = 0
        lvPrincipal.Columns.Add("Editorial").Width() = 100
        lvPrincipal.Columns.Add("Edicion").Width() = 70
        lvPrincipal.Columns.Add("Area").Width() = 100
        lvPrincipal.Columns.Add("id_autor").Width() = 0
        lvPrincipal.Columns.Add("Nombre Autor").Width() = 180
        lvPrincipal.Columns.Add("Descripcion").Width() = 230
        lvPrincipal.Columns.Add("Codigo(ESBN)").Width() = 150
    End Sub

    ''' <summary>
    ''' Función para cargar los datos de clientes en el Listview
    ''' </summary>
    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM libro INNER JOIN autor ON autor.id_autor=libro.id_autor INNER JOIN editorial ON editorial.id_editorial=libro.id_editorial;"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_libro"))
                lvPrincipal.Items(i).SubItems.Add(registros("Titulo"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_editorial"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_editorial"))
                lvPrincipal.Items(i).SubItems.Add(registros("Edicion"))
                lvPrincipal.Items(i).SubItems.Add(registros("Area"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_autor"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre"))
                lvPrincipal.Items(i).SubItems.Add(registros("Descripcion"))
                lvPrincipal.Items(i).SubItems.Add(registros("CodigoESBN"))

                i += 1
            End While
        End If
        registros.Close()

    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            id = Val(lvPrincipal.SelectedItems(0).SubItems(0).Text)
            misfunciones.setId(id)
            id1 = Val(lvPrincipal.SelectedItems(0).SubItems(2).Text)
            misfunciones.setId1(id1)
            id2 = Val(lvPrincipal.SelectedItems(0).SubItems(6).Text)
            misfunciones.setId2(id2)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Dispose()
        FrmLibrosNuevo.Show()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            Me.Dispose()
            FrmLibrosEditar.Show()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            Me.Dispose()
            FrmLibrosEliminar.Show()
        Else
            MsgBox("Seleccione una fila para eliminar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        frmMenu.AbrirFormEnPanel(Of GestionLibros)()
        Me.Dispose()
    End Sub

    Private Sub Actualizar()
        lvPrincipal.Clear()
        cargarLVHeaders()
        cargarLVDatos()
    End Sub

End Class
