
Public Class operation

    Private _id As Integer
    Private _idCompte As Integer = 0
    Private _numero As Integer
    Private _dateOP As Date
    Private _libelle As String = ""
    Private _montant As Double
    Private _type As String = ""


    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property idCompte As Integer
        Get
            Return _idCompte
        End Get
        Set(ByVal value As Integer)
            _idCompte = value
        End Set
    End Property

    Public Property numero As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property

    Public Property dateOP As Date
        Get
            Return _dateOP
        End Get
        Set(ByVal value As Date)
            _dateOP = value
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

    Public Property montant As Double
        Get
            Return _montant
        End Get
        Set(ByVal value As Double)
            _montant = value
        End Set
    End Property

    Public Property type As String
        Get
            Return _type
        End Get
        Set(ByVal value As String)
            _type = value
        End Set
    End Property

End Class
