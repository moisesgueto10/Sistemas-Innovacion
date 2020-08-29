Imports MySql.Data.MySqlClient
Public Class GestionBibliotecario
    Private datos As MySqlDataReader
    Public id2 As Integer
    Public id As String
    Public id3 As String
    Public contrasena1 As String
    Public permisoeditar As Integer
    Public permisoeliminar As Integer
    Public bibliotecario As String = misfunciones.getIdusuario

    Private Sub GestionBibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("Nombre de usuario").Width() = 100
        lvPrincipal.Columns.Add("Identidad").Width() = 150
        lvPrincipal.Columns.Add("id_campus").Width() = 0
        lvPrincipal.Columns.Add("Campus").Width() = 200
        lvPrincipal.Columns.Add("Nombre").Width() = 120
        lvPrincipal.Columns.Add("Apellido").Width() = 120
        lvPrincipal.Columns.Add("Contraseña").Width() = 0
        lvPrincipal.Columns.Add("Fecha de nacimiento").Width() = 150
        lvPrincipal.Columns.Add("Direccion").Width() = 300
    End Sub

    ''' <summary>
    ''' Función para cargar los datos de bibliotecario en el Listview
    ''' </summary>
    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "call `gestion bibliotecario`();" 'PROCEDIMIENTO
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("nombre_de_usuario"))
                lvPrincipal.Items(i).SubItems.Add(registros("identidad"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_campus"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre"))
                lvPrincipal.Items(i).SubItems.Add(registros("apellido"))
                lvPrincipal.Items(i).SubItems.Add(registros("contrasena"))
                lvPrincipal.Items(i).SubItems.Add(registros("Fecha_de_Nacimiento"))
                lvPrincipal.Items(i).SubItems.Add(registros("direccion"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmBibliotecarioNuevo.ShowDialog()
        Actualizar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        permisoeditar = misfunciones.getId2


        If (lvPrincipal.SelectedItems.Count > 0) Then
            If bibliotecario = lvPrincipal.SelectedItems(0).Text Or bibliotecario = "root" Then
                frmBibliotecarioEditar.ShowDialog()
                Actualizar()
            Else
                MsgBox("Solo puede editar su propio perfil de bibliotecario", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            If bibliotecario = lvPrincipal.SelectedItems(0).Text Or bibliotecario = "root" Then
                If lvPrincipal.SelectedItems(0).Text = "root" Then
                    MsgBox("Usted no puede borrar el usuario root")
                Else
                    FrmBibliotecarioEliminar.ShowDialog()
                    Actualizar()
                End If
            Else
                MsgBox("Solo puede eliminar su propio perfil de bibliotecario", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        Else
            MsgBox("Seleccione una fila para eliminar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            id = lvPrincipal.SelectedItems(0).Text
            misfunciones.setId3(id)
            id3 = Val(lvPrincipal.SelectedItems(0).SubItems(1).Text)
            misfunciones.setId4(id3)
            id2 = Val(lvPrincipal.SelectedItems(0).SubItems(2).Text)
            misfunciones.setId1(id2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Actualizar()
        lvPrincipal.Clear()
        cargarLVHeaders()
        cargarLVDatos()
        bibliotecario = misfunciones.getIdusuario
        cargarcantidad()
    End Sub

    Sub cargarcantidad()
        Dim sq1l As String = ""
        sq1l = "SELECT COUNT(*) as conta FROM biblioteca.bibliotecario;"
        datos = mibd.consulta(sq1l)
        If datos.HasRows Then
            While datos.Read
                lblcantidad.Text = datos("conta")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub lblcantidad_Click(sender As Object, e As EventArgs) Handles lblcantidad.Click

    End Sub
End Class