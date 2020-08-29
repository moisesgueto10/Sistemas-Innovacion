Imports MySql.Data.MySqlClient
Public Class GestionEjemplares
    Private datos As MySqlDataReader
    Private id, idcampus, idlibro As Integer

    Private Sub GestionEjemplares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Public Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_ejemplar").Width() = 0
        lvPrincipal.Columns.Add("id_campus").Width() = 0
        lvPrincipal.Columns.Add("id_libro").Width() = 0
        lvPrincipal.Columns.Add("libro").Width() = 350
        lvPrincipal.Columns.Add("Estado").Width() = 120
        lvPrincipal.Columns.Add("Disponibilidad").Width() = 150
        lvPrincipal.Columns.Add("CodigoISBN").Width() = 240
        lvPrincipal.Columns.Add("campus").Width() = 250
    End Sub

    Public Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = ""
        If misfunciones.getIdusuario <> "root" Then
            query = "SELECT * FROM `gestion ejemplares` WHERE id_campus='" & misfunciones.getcampus & "';" 'VISTAS
        Else
            query = "SELECT * FROM `gestion ejemplares`;" 'VISTAS
        End If
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_ejemplar"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_libro"))
                lvPrincipal.Items(i).SubItems.Add(registros("Titulo"))
                lvPrincipal.Items(i).SubItems.Add(registros("estado"))
                lvPrincipal.Items(i).SubItems.Add(registros("Disponibilidad"))
                lvPrincipal.Items(i).SubItems.Add(registros("CodigoISBN"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_campus"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FrmEjemplarNuevo.ShowDialog()
        Actualizar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmEjemplarEditar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmEjemplarEliminar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para eliminar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            id = Val(lvPrincipal.SelectedItems(0).SubItems(0).Text)
            misfunciones.setId(id)
            idlibro = Val(lvPrincipal.SelectedItems(0).SubItems(2).Text)
            misfunciones.setId1(idlibro)
            idcampus = Val(lvPrincipal.SelectedItems(0).SubItems(1).Text)
            misfunciones.setId2(idcampus)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblcantidadejemplar_Click(sender As Object, e As EventArgs) Handles lblcantidadejemplar.Click

    End Sub

    Public Sub Actualizar()
        lvPrincipal.Clear()
        cargarLVHeaders()
        cargarLVDatos()
        cargarcantidadejemplares()
    End Sub

    Sub cargarcantidadejemplares()
        Dim sq1l As String = ""
        If misfunciones.getIdusuario <> "root" Then
            sq1l = "SELECT COUNT(*) as conta FROM biblioteca.ejemplar WHERE id_campus='" & misfunciones.getcampus & "';"
        Else
            sq1l = "SELECT COUNT(*) as conta FROM biblioteca.ejemplar;"
        End If
        datos = mibd.consulta(sq1l)
        If datos.HasRows Then
            While datos.Read
                lblcantidadejemplar.Text = datos("conta")
            End While
        End If
        datos.Close()
    End Sub
End Class