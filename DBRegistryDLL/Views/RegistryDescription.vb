Public Class RegistryDescription
    Private _RegistryDescription As String
    Public Property Registry_Description() As String
        Get
            Return _RegistryDescription
        End Get
        Set(ByVal value As String)
            _RegistryDescription = value
        End Set
    End Property
End Class
