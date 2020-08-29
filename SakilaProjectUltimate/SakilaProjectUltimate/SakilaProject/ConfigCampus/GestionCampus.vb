Imports MySql.Data.MySqlClient
Public Class GestionCampus
    Public id, id2 As Integer
    Private datos As MySqlDataReader
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub

    Private Sub GestionCampus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sq1l = "SELECT COUNT(*) as conta FROM biblioteca.campus;"
        datos = mibd.consulta(sq1l)
        If datos.HasRows Then
            While datos.Read
                lblcantidad.Text = datos("conta")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_campus").Width() = 0
        lvPrincipal.Columns.Add("Campus").Width() = 200
        lvPrincipal.Columns.Add("id_ciudad").Width() = 0
        lvPrincipal.Columns.Add("Ciudad").Width() = 200
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            id = lvPrincipal.SelectedItems(0).Text
            misfunciones.setId(id)
            id2 = lvPrincipal.SelectedItems(0).SubItems(2).Text
            misfunciones.setId1(id2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FrmCampusNuevo.ShowDialog()
        Actualizar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmCampusEditar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmCampusEliminar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para eliminar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "CALL `gestion campus`();" 'PROCEDIMIENTO
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_ciudad"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_ciudad"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub
End Class