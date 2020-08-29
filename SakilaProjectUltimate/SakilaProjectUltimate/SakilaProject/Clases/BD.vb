Imports MySql.Data.MySqlClient
''' <summary>
''' Clase que controla las conexiones a la Base de Datos
''' </summary>
Public Class BD
    Dim cadenaconexion As String

    ''' <summary>
    ''' La conexión a la base de datos
    ''' </summary>
    Public db As MySqlConnection

    Public Property estado As Boolean

    ''' <summary>
    ''' Realizamos la conexión a la base de datos
    ''' </summary>
    Public Sub conectar()
        Try
            'Creamos una nueva instancia del constructor para conexiones de MySQL
            cadenaconexion = "server=127.0.0.1; database=biblioteca; user id=root; password=""""; port=3306; Convert Zero Datetime=True;"

            'Cuando tenemos todos los datos para crear una conexión
            'Creamos una instancia de la conexión.
            db = New MySqlConnection(cadenaconexion)

            'Abrimos la conexión
            db.Open()

            'MessageBox.Show("Se conecto correctamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'Cambiamos el estado a verdadero para referirnos a que la conexion esta abierta.
            estado = True
        Catch ex As Exception
            MessageBox.Show("Otravez se te olvido prender el XAMPP ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Se cambia el valor del estado porque la conexión no esta abierta
            estado = False
        End Try
    End Sub

    ''' <summary>
    ''' Función para Insertar, Editar y Eliminar registros de la Base de Datos 
    ''' </summary>
    ''' <param name="query">Es consulta enviada por el usuario</param>
    Public Sub sentencias(ByVal query As String)
        Dim micomando As MySqlCommand
        Try
            micomando = New MySqlCommand(query, db)
            micomando.ExecuteNonQuery()
            micomando.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Función para consultar registros de la Base de Datos
    ''' </summary>
    ''' <param name="query">Es consulta enviada por el usuario</param>
    Public Function consulta(ByVal query As String)
        Dim micomando As MySqlCommand
        Dim misdatos As MySqlDataReader
        Try
            micomando = New MySqlCommand(query, db)
            misdatos = micomando.ExecuteReader

            Return misdatos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return -1
        End Try
    End Function

End Class
