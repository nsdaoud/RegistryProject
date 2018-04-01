Public Interface IWaredFax304Manager
    Function GetWaredFax304Data() As DataTable

    Function insertWaredFax304Data(ByVal _lstofWaredfax304 As List(Of Waredfax304)) As Boolean

    Function UpdateWaredFax304Data(ByVal _lstofWaredfax304 As List(Of Waredfax304)) As Boolean

    Function DeleteWaredFax304Data(ByVal _lstofWaredfax304 As List(Of Waredfax304)) As Boolean
End Interface
