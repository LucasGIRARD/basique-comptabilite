Public Class compte

    Private _id As Integer = 0
    Private _numero As String = ""
    Private _libelle As String = ""
    Private _informations As String = ""


    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property numero As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Public Property libelle As String
        Get
            Return _libelle
        End Get
        Set(ByVal value As String)
            _libelle = value
        End Set
    End Property

    Public Property informations As String
        Get
            Return _informations
        End Get
        Set(ByVal value As String)
            _informations = value
        End Set
    End Property
End Class
