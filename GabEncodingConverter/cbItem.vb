Friend Class cbItem
    Public _CodePage As Integer
    Public _DisplayString As String

    Public Property CodePage() As Integer
        Get
            Return _CodePage
        End Get
        Set(ByVal value As Integer)
            _CodePage = value
        End Set
    End Property

    Public Property DisplayString() As String
        Get
            Return _DisplayString
        End Get
        Set(ByVal value As String)
            _DisplayString = value
        End Set
    End Property

    Public Sub New(ByVal itemCodePage As Integer, ByVal itemDisplayString As String)
        _CodePage = itemCodePage
        _DisplayString = itemDisplayString
    End Sub

    Public Overrides Function ToString() As String
        Return DisplayString
    End Function
End Class
