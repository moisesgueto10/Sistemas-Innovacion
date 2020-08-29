Imports MySql.Data.MySqlClient
Public Class GestionBibliotecario
    Public id, id2 As Integer

    Public Sub GestionBibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Public Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_bibliotecario").Width() = 150
        lvPrincipal.Columns.Add("id_campus").Width() = 0
        lvPrincipal.Columns.Add("campus").Width() = 200
        lvPrincipal.Columns.Add("nombre").Width() = 120
        lvPrincipal.Columns.Add("apellido").Width() = 120
        lvPrincipal.Columns.Add("edad").Width() = 100
        lvPrincipal.Columns.Add("direccion").Width() = 300
    End Sub

    ''' <summary>
    ''' Función para cargar los datos de bibliotecario en el Listview
    ''' </summary>
    Public Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM bibliotecario INNER JOIN campus ON campus.id_campus=bibliotecario.id_campus;"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_bibliotecario"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre"))
                lvPrincipal.Items(i).SubItems.Add(registros("apellido"))
                lvPrincipal.Items(i).SubItems.Add(registros("edad"))
                lvPrincipal.Items(i).SubItems.Add(registros("direccion"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            id = lvPrincipal.SelectedItems(0).Text
            misfunciones.setId(id)
            id2 = lvPrincipal.SelectedItems(0).SubItems(1).Text
            misfunciones.setId1(id2)
        Catch ex As Exception
    
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        frmBibliotecarioNuevo.Show()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            frmBibliotecarioEditar.Show()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmBibliotecarioEliminar.Show()
        Else
            MsgBox("Seleccione una fila para eliminar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Public Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub

    Public Sub Actualizar()
        lvPrincipal.Clear()
        cargarLVHeaders()
        cargarLVDatos()
    End Sub
End Class