Public Class VClientes
    Dim id As Integer
    Dim nombre, direccion, telefono, identificacion, fecha_registro As String

    Public Property gId
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property
    Public Property gNombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property gDireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property gTelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property

    Public Property gIdentificacion
        Get
            Return identificacion
        End Get
        Set(value)
            identificacion = value
        End Set
    End Property

    Public Property gFecha_Registro
        Get
            Return fecha_registro
        End Get
        Set(value)
            fecha_registro = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByRef id As Integer, ByRef nombre As String, ByVal direccion As String, ByVal telefono As String, ByVal identificacion As String, ByVal fecha_registro As String)
        gId = id
        gNombre = nombre
        gDireccion = direccion
        gTelefono = telefono
        gIdentificacion = identificacion
        gFecha_Registro = fecha_registro
    End Sub
End Class
