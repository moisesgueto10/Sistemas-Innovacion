Public Class Elementos
    Private mdescripcion As String
    Private mcodigo As String

    Public Sub New(ByVal descripcion As String, ByVal codigo As String)
        mdescripcion = descripcion
        mcodigo = codigo
    End Sub

    Public ReadOnly Property Text() As String
        Get
            Return mdescripcion
        End Get
    End Property

    Public ReadOnly Property Value() As String
        Get
            Return mcodigo
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return mdescripcion
    End Function

End Class