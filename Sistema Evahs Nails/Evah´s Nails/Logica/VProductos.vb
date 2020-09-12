Public Class VProductos
    Dim cantidad As Integer
    Dim id, nombre, fecha_registro, tipo_prod As String
    Dim precio_compra, precio_venta As Decimal

    Public Property gId
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property

    Public Property gCantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
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

    Public Property gPrecio_Compra
        Get
            Return precio_compra
        End Get
        Set(value)
            precio_compra = value
        End Set
    End Property

    Public Property gPrecio_Venta
        Get
            Return precio_venta
        End Get
        Set(value)
            precio_venta = value
        End Set
    End Property

    Public Property gTipo_Prod
        Get
            Return tipo_prod
        End Get
        Set(value)
            tipo_prod = value
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

    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal cantidad As Integer, ByVal precio_compra As Decimal, ByVal precio_venta As Decimal, ByVal fecha_registro As String, ByVal tipo_prod As String)
        gId = id
        gCantidad = cantidad
        gNombre = nombre
        gPrecio_Compra = precio_compra
        gPrecio_Venta = precio_venta
        gTipo_Prod = tipo_prod
        gFecha_Registro = fecha_registro
    End Sub
End Class
