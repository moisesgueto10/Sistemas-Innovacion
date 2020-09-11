Public Class VServicios
    Dim id As Integer
    Dim nombre, descripcion As String
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

    Public Property gDescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property
End Class
