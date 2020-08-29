Imports MySql.Data.MySqlClient
Public Class GestionAlumnos
    Private datos As MySqlDataReader
    Public id As String
    Public idcampus As Integer
    Public idcarrera As Integer

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    ''' <summary>
    ''' Función para cargar las columnas del Listview
    ''' </summary>
    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("identidad").Width() = 140
        lvPrincipal.Columns.Add("id_Carrera").Width() = 0
        lvPrincipal.Columns.Add("Carrera").Width() = 150
        lvPrincipal.Columns.Add("id_campus").Width() = 0
        lvPrincipal.Columns.Add("Campus").Width() = 200
        lvPrincipal.Columns.Add("Nombre").Width() = 90
        lvPrincipal.Columns.Add("Apellido").Width() = 90
        lvPrincipal.Columns.Add("Fecha de nacimiento").Width() = 150
        lvPrincipal.Columns.Add("Telefono").Width() = 100
        lvPrincipal.Columns.Add("Direccion").Width() = 190
    End Sub

    ''' <summary>
    ''' Función para cargar los datos de usuarios en el Listview
    ''' </summary>
    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = ""
        If misfunciones.getIdusuario <> "root" Then
            query = "SELECT * FROM `gestion alumnos` WHERE id_campus='" & misfunciones.getcampus & "';" 'VISTAS
        Else
            query = "SELECT * FROM `gestion alumnos`;" 'VISTAS
        End If


        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("identidad"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_carrera"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_carrera"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("Nombre"))
                lvPrincipal.Items(i).SubItems.Add(registros("Apellido"))
                lvPrincipal.Items(i).SubItems.Add(Convert.ToDateTime(registros("fecha_de_nacimiento")).ToString("yyyy-MM-dd"))
                lvPrincipal.Items(i).SubItems.Add(registros("Telefono"))
                lvPrincipal.Items(i).SubItems.Add(registros("Direccion"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            id = lvPrincipal.SelectedItems(0).SubItems(0).Text
            misfunciones.setId3(id)
            idcarrera = Val(lvPrincipal.SelectedItems(0).SubItems(1).Text)
            misfunciones.setId1(idcarrera)
            idcampus = Val(lvPrincipal.SelectedItems(0).SubItems(3).Text)
            misfunciones.setId2(idcampus)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FrmAlumnoNuevo.ShowDialog()
        Actualizar()
    End Sub

    ''' <summary>
    ''' Para verificar que haya seleccionado una fila para editar
    ''' </summary>
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmAlumnoEditar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmAlumnoEliminar.ShowDialog()
            Actualizar()
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
        cargarcantidadalumnos()
    End Sub

    Sub cargarcantidadalumnos()
        Dim sq1l As String = ""
        If misfunciones.getIdusuario <> "root" Then
            sq1l = "SELECT COUNT(*) as conta FROM biblioteca.alumnos WHERE id_campus='" & misfunciones.getcampus & "';"
        Else
            sq1l = "SELECT COUNT(*) as conta FROM biblioteca.alumnos;"
        End If
        datos = mibd.consulta(sq1l)
        If datos.HasRows Then
            While datos.Read
                lblcantidadalumnos.Text = datos("conta")
            End While
        End If
        datos.Close()
    End Sub

End Class