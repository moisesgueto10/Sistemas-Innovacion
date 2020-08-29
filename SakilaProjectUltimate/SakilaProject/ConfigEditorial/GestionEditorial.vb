Imports MySql.Data.MySqlClient
Public Class GestionEditorial
    Private datos As MySqlDataReader
    Public id As Integer
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub

    Private Sub GestionEditorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub Actualizar()
        lvPrincipal.Clear()
        cargarLVHeaders()
        cargarLVDatos()
        cargarcantidad()
    End Sub

    Sub cargarcantidad()
        Dim sq1l As String = ""
        sq1l = "SELECT COUNT(*) as conta FROM biblioteca.editorial;"
        datos = mibd.consulta(sq1l)
        If datos.HasRows Then
            While datos.Read
                lblcantidad.Text = datos("conta")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_editorial").Width() = 0
        lvPrincipal.Columns.Add("Nombre de editorial").Width() = 300
        lvPrincipal.Columns.Add("Procedencia de origen").Width() = 300
    End Sub

    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM `gestion editorial`;" 'VISTAS
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_editorial"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_editorial"))
                lvPrincipal.Items(i).SubItems.Add(registros("Procedencia_de_Origen"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            id = lvPrincipal.SelectedItems(0).Text
            misfunciones.setId(id)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FrmEditorialNuevo.ShowDialog()
        Actualizar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmEditorialEditar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmEditorialEliminar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para eliminar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub
End Class