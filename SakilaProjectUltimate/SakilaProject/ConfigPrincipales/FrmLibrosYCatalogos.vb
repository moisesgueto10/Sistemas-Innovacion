Imports MySql.Data.MySqlClient
Public Class FrmLibrosYCatalogos
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub FrmLibrosYCatalogos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLVHeaders()
        cargarLVDatos()
    End Sub

    ''' <summary>
    ''' Función para cargar las columnas del Listview
    ''' </summary>
    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_libro").Width() = 0
        lvPrincipal.Columns.Add("Titulo").Width() = 270
        lvPrincipal.Columns.Add("Editorial").Width() = 110
        lvPrincipal.Columns.Add("Edicion").Width() = 70
        lvPrincipal.Columns.Add("Area").Width() = 100
        lvPrincipal.Columns.Add("Autor").Width() = 180
        lvPrincipal.Columns.Add("Descripcion").Width() = 230
        lvPrincipal.Columns.Add("Codigo(ISBN)").Width() = 150
    End Sub

    ''' <summary>
    ''' Función para cargar los datos de clientes en el Listview
    ''' </summary>
    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM libro INNER JOIN autor ON autor.id_autor=libro.id_autor 
                               INNER JOIN editorial ON editorial.id_editorial=libro.id_editorial 
                               INNER JOIN ejemplar ON ejemplar.id_libro = libro.id_libro;"

        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_libro"))
                lvPrincipal.Items(i).SubItems.Add(registros("Titulo"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_editorial"))
                lvPrincipal.Items(i).SubItems.Add(registros("Edicion"))
                lvPrincipal.Items(i).SubItems.Add(registros("Area"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre"))
                lvPrincipal.Items(i).SubItems.Add(registros("Descripcion"))
                lvPrincipal.Items(i).SubItems.Add(registros("CodigoISBN"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged

    End Sub
End Class