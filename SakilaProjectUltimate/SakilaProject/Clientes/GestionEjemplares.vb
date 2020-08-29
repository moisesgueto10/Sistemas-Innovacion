Imports MySql.Data.MySqlClient
Public Class GestionEjemplares
    Private id, idcampus, idlibro As Integer

    Private Sub GestionEjemplares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_ejemplar").Width() = 0
        lvPrincipal.Columns.Add("id_campus").Width() = 0
        lvPrincipal.Columns.Add("campus").Width() = 250
        lvPrincipal.Columns.Add("id_libro").Width() = 0
        lvPrincipal.Columns.Add("libro").Width() = 350
        lvPrincipal.Columns.Add("Numero de ejemplares").Width() = 200
        lvPrincipal.Columns.Add("Estado").Width() = 120
    End Sub

    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT id_ejemplar, ejemplar.id_campus, nombre_campus, ejemplar.id_libro, Titulo, num_ejemplar, ejemplar.estado FROM ejemplar INNER JOIN campus ON campus.id_campus=ejemplar.id_campus INNER JOIN libro ON libro.id_libro=ejemplar.id_libro;"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_ejemplar"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_libro"))
                lvPrincipal.Items(i).SubItems.Add(registros("Titulo"))
                lvPrincipal.Items(i).SubItems.Add(registros("num_ejemplar"))
                lvPrincipal.Items(i).SubItems.Add(registros("estado"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Dispose()
        FrmEjemplarNuevo.Show()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.Dispose()
        FrmEjemplarEditar.Show()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Me.Dispose()
        FrmEjemplarEliminar.Show()
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            id = Val(lvPrincipal.SelectedItems(0).SubItems(0).Text)
            misfunciones.setId(id)
            idlibro = Val(lvPrincipal.SelectedItems(0).SubItems(3).Text)
            misfunciones.setId1(idlibro)
            idcampus = Val(lvPrincipal.SelectedItems(0).SubItems(1).Text)
            misfunciones.setId2(idcampus)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Actualizar()
        lvPrincipal.Clear()
        cargarLVHeaders()
        cargarLVDatos()
    End Sub
End Class