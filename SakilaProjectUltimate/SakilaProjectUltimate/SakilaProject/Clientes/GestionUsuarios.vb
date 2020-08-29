Imports MySql.Data.MySqlClient
Public Class GestionUsuarios
    Public id As Integer
    Public idcampus As Integer
    Public idcarrera As Integer

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    ''' <summary>
    ''' Función para cargar las columnas del Listview
    ''' </summary>
    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_usuario").Width() = 0
        lvPrincipal.Columns.Add("id_carrera").Width() = 0
        lvPrincipal.Columns.Add("Carrera").Width() = 150
        lvPrincipal.Columns.Add("id_campus").Width() = 0
        lvPrincipal.Columns.Add("Campus").Width() = 200
        lvPrincipal.Columns.Add("Nombre").Width() = 120
        lvPrincipal.Columns.Add("Apellido").Width() = 120
        lvPrincipal.Columns.Add("Telefono").Width() = 100
        lvPrincipal.Columns.Add("edad").Width() = 100
        lvPrincipal.Columns.Add("Direccion").Width() = 150
        lvPrincipal.Columns.Add("Num_Identidad").Width() = 150
    End Sub

    ''' <summary>
    ''' Función para cargar los datos de usuarios en el Listview
    ''' </summary>
    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT id_usuario, usuario.id_carrera, nombre_campus, usuario.id_campus, nombre_carrera, Nombre, Apellido,
                                Telefono, Edad, Direccion, Num_Identidad FROM usuario
                                INNER JOIN campus ON campus.id_campus = usuario.id_campus
                                INNER JOIN carrera ON carrera.id_carrera = usuario.id_carrera;"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_usuario"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_carrera"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_carrera"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("Nombre"))
                lvPrincipal.Items(i).SubItems.Add(registros("Apellido"))
                lvPrincipal.Items(i).SubItems.Add(registros("Telefono"))
                lvPrincipal.Items(i).SubItems.Add(registros("edad"))
                lvPrincipal.Items(i).SubItems.Add(registros("Direccion"))
                lvPrincipal.Items(i).SubItems.Add(registros("Num_Identidad"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            id = lvPrincipal.SelectedItems(0).Text
            misfunciones.setId(id)
            idcarrera = Val(lvPrincipal.SelectedItems(0).SubItems(1).Text)
            misfunciones.setId1(idcarrera)
            idcampus = Val(lvPrincipal.SelectedItems(0).SubItems(3).Text)
            misfunciones.setId2(idcampus)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Dispose()
        FrmUsuarioNuevo.Show()
    End Sub

    ''' <summary>
    ''' Para verificar que haya seleccionado una fila para editar
    ''' </summary>
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            Me.Dispose()
            FrmUsuarioEditar.Show()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            Me.Dispose()
            FrmUsuarioEliminar.Show()
        Else
            MsgBox("Seleccione una fila para eliminar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub
    ''' <summary>
    ''' Procedimiento para actualizar las tablas despues de ingresar o editar datos
    ''' </summary>
    Private Sub Actualizar()
        lvPrincipal.Clear()
        cargarLVHeaders()
        cargarLVDatos()
    End Sub
End Class