Imports MySql.Data.MySqlClient
Public Class GestionPrestamos
    Private datos As MySqlDataReader
    Private idprestamo, idejemplar, ididentidad As Integer
    Private idlibro As Integer

    Private Sub FrmPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
        'id_prestamo id_ejemplar nombre del libro identidad nombre completo fechas las 3 recibido retraso

    End Sub

    ''' <summary>
    ''' Función para cargar las columnas del Listview
    ''' </summary>
    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("Alumno").Width() = 150
        lvPrincipal.Columns.Add("id_prestamos").Width() = 0
        lvPrincipal.Columns.Add("id_ejemplar").Width() = 0
        lvPrincipal.Columns.Add("Identidad").Width() = 150
        lvPrincipal.Columns.Add("Titulo del libro").Width() = 200
        lvPrincipal.Columns.Add("fecha_prestamo").Width() = 190
        lvPrincipal.Columns.Add("fecha_entrega").Width() = 190
        lvPrincipal.Columns.Add("fecha_devolucion").Width() = 190
        lvPrincipal.Columns.Add("Recibido").Width() = 80
        lvPrincipal.Columns.Add("Retraso").Width() = 80
        lvPrincipal.Columns.Add("libro").Width() = 0
    End Sub

    ''' <summary>
    ''' Función para cargar los datos de clientes en el Listview
    ''' </summary>
    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = ""
        If misfunciones.getIdusuario <> "root" Then
            query = "SELECT * FROM `gestion prestamos` WHERE campus='" & misfunciones.getcampus & "';" 'VISTAS
        Else
            query = "SELECT * FROM `gestion prestamos`;"
        End If

        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("Nombre") & " " & registros("Apellido"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_prestamo_libro"))
                lvPrincipal.Items(i).SubItems.Add(registros("id_ejemplar"))
                lvPrincipal.Items(i).SubItems.Add(registros("identidad1"))
                lvPrincipal.Items(i).SubItems.Add(registros("Titulo"))
                lvPrincipal.Items(i).SubItems.Add(registros("fecha_prestamo"))
                lvPrincipal.Items(i).SubItems.Add(registros("fecha_entrega"))
                lvPrincipal.Items(i).SubItems.Add(Convert.ToString(registros("fecha_devolucion")))
                lvPrincipal.Items(i).SubItems.Add(registros("recibido1"))
                lvPrincipal.Items(i).SubItems.Add(registros("retraso"))
                lvPrincipal.Items(i).SubItems.Add(registros("libro1"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub BtnCerrarForm_Click_1(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FrmPrestamoNuevo.ShowDialog()
        Actualizar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmPrestamoEditar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para editar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (lvPrincipal.SelectedItems.Count > 0) Then
            FrmPrestamoEliminar.ShowDialog()
            Actualizar()
        Else
            MsgBox("Seleccione una fila para eliminar", MsgBoxStyle.Exclamation, "Error tipico")
        End If
    End Sub

    Private Sub Actualizar()
        lvPrincipal.Clear()
        cargarLVHeaders()
        cargarLVDatos()
        cargarcantidad()
    End Sub

    Sub cargarcantidad()
        Dim sq1l As String = ""
        If misfunciones.getIdusuario <> "root" Then
            sq1l = "SELECT COUNT(*) as conta FROM biblioteca.prestamo_libro INNER JOIN ejemplar ON ejemplar.id_ejemplar=prestamo_libro.id_ejemplar WHERE id_campus='" & misfunciones.getcampus & "';"
        Else
            sq1l = "SELECT COUNT(*) as conta FROM biblioteca.prestamo_libro;"
        End If

        datos = mibd.consulta(sq1l)
        If datos.HasRows Then
            While datos.Read
                lblcantidad.Text = datos("conta")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub lvPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPrincipal.SelectedIndexChanged
        Try
            idprestamo = Val(lvPrincipal.SelectedItems(0).SubItems(1).Text)
            misfunciones.setId(idprestamo)
            ididentidad = Val(lvPrincipal.SelectedItems(0).SubItems(3).Text)
            misfunciones.setId2(ididentidad)
            idlibro = Val(lvPrincipal.SelectedItems(0).SubItems(10).Text)
            misfunciones.setId1(idlibro)
        Catch ex As Exception

        End Try
    End Sub
End Class