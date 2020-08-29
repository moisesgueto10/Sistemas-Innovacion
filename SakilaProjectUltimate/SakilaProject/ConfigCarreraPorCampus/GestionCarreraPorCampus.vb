Imports MySql.Data.MySqlClient
Public Class GestionCarreraPorCampus
    Public idcampus, idcarrera As Integer
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FrmCarPorCampNuevo.ShowDialog()
        Actualizar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmCarPorCampEditar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmCarPorCampEliminar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para eliminar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub GestionCarreraPorCampus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub Actualizar()
        lvPrincipal.Clear()
        cargarLVHeaders()
        cargarLVDatos()
    End Sub

    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_campus").Width() = 0
        lvPrincipal.Columns.Add("Campus").Width() = 200
        lvPrincipal.Columns.Add("id_carrera").Width() = 0
        lvPrincipal.Columns.Add("Carrera").Width() = 200
    End Sub

    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()


        Dim query As String = ""
        Dim registros As MySqlDataReader
        If misfunciones.getIdusuario <> "root" Then
            query = "SELECT * FROM carreras_por_campus INNER JOIN campus ON campus.id_campus=carreras_por_campus.id_campus INNER JOIN carrera ON carrera.id_carrera=carreras_por_campus.id_carrera WHERE carreras_por_campus.id_campus='" & misfunciones.getcampus & "';"
        Else
            query = "SELECT * FROM carreras_por_campus INNER JOIN campus ON campus.id_campus=carreras_por_campus.id_campus INNER JOIN carrera ON carrera.id_carrera=carreras_por_campus.id_carrera;"
        End If

        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_carrera"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_carrera"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            idcampus = lvPrincipal.SelectedItems(0).SubItems(0).Text
            misfunciones.setId(idcampus)
            idcarrera = lvPrincipal.SelectedItems(0).SubItems(2).Text
            misfunciones.setId1(idcarrera)
        Catch ex As Exception

        End Try
    End Sub
End Class