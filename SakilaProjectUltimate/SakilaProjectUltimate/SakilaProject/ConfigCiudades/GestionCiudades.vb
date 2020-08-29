Imports MySql.Data.MySqlClient
Public Class GestionCiudades
    Private datos As MySqlDataReader
    Private id As Integer
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FrmCiudadesNuevo.ShowDialog()
        Actualizar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmCiudadesEditar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmCiudadesEliminar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            id = Val(lvPrincipal.SelectedItems(0).SubItems(0).Text)
            misfunciones.setId(id)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GestionCiudades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sq1l = "SELECT COUNT(*) as conta FROM biblioteca.ciudad;"
        datos = mibd.consulta(sq1l)
        If datos.HasRows Then
            While datos.Read
                lblcantidad.Text = datos("conta")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_ciudad").Width() = 0
        lvPrincipal.Columns.Add("Ciudad").Width() = 280
    End Sub

    ''' <summary>
    ''' Función para cargar los datos de clientes en el Listview
    ''' </summary>
    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim i As Integer = 0
        Dim query As String = "SELECT * FROM `gestion ciudades`;" 'VISTAS
        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_ciudad"))
                lvPrincipal.Items(i).SubItems.Add(registros("nombre_ciudad"))
                i += 1
            End While
        End If
        registros.Close()

    End Sub
End Class