Imports MySql.Data.MySqlClient
Public Class FrmPrestamos
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub FrmPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLVHeaders()
        cargarLVDatos()
    End Sub

    ''' <summary>
    ''' Función para cargar las columnas del Listview
    ''' </summary>
    Private Sub cargarLVHeaders()
        lvPrincipal.Columns.Add("id_prestamo_libro").Width() = 0
        lvPrincipal.Columns.Add("Alumno").Width() = 100
        lvPrincipal.Columns.Add("Apellido").Width() = 100
        lvPrincipal.Columns.Add("identidad").Width() = 100
        lvPrincipal.Columns.Add("Ejemplares").Width() = 90
        lvPrincipal.Columns.Add("fecha_prestamo").Width() = 190
        lvPrincipal.Columns.Add("fecha_entrega").Width() = 190
        lvPrincipal.Columns.Add("fecha_devolucion").Width() = 190
        lvPrincipal.Columns.Add("recibido").Width() = 80
        lvPrincipal.Columns.Add("retraso").Width() = 75
    End Sub

    ''' <summary>
    ''' Función para cargar los datos de clientes en el Listview
    ''' </summary>
    Private Sub cargarLVDatos()
        lvPrincipal.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT id_prestamo_libro, Nombre AS Alumno, identidad, Apellido, id_ejemplar AS Ejemplares, fecha_prestamo,
                               fecha_entrega, fecha_devolucion, recibido, retraso FROM prestamo_libro 
                               INNER JOIN alumnos ON alumnos.identidad = prestamo_libro.identidad;"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPrincipal.Items.Add(registros("id_prestamo_libro"))
                lvPrincipal.Items(i).SubItems.Add(registros("Alumno"))
                lvPrincipal.Items(i).SubItems.Add(registros("Apellido"))
                lvPrincipal.Items(i).SubItems.Add(registros("identidad"))
                lvPrincipal.Items(i).SubItems.Add(registros("Ejemplares"))
                lvPrincipal.Items(i).SubItems.Add(registros("fecha_prestamo"))
                lvPrincipal.Items(i).SubItems.Add(registros("fecha_entrega"))
                lvPrincipal.Items(i).SubItems.Add(registros("fecha_devolucion"))
                lvPrincipal.Items(i).SubItems.Add(registros("recibido"))
                lvPrincipal.Items(i).SubItems.Add(registros("retraso"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

End Class