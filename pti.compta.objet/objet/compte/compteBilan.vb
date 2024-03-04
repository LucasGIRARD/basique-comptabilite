Public Class compteBilan

    Private _classe As Integer
    Private _numero As Integer
    Private _libelle As String
    Private _debit As Double
    Private _credit As Double
    Private _solde As Double

    Public Property classe As Integer
        Get
            Return _classe
        End Get
        Set(ByVal value As Integer)
            _classe = value
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

    Public Property libelle As String
        Get
            Return _libelle
        End Get
        Set(ByVal value As String)
            _libelle = value
        End Set
    End Property

    Public Property debit As Double
        Get
            Return _debit
        End Get
        Set(ByVal value As Double)
            _debit = value
        End Set
    End Property

    Public Property credit As Double
        Get
            Return _credit
        End Get
        Set(ByVal value As Double)
            _credit = value
        End Set
    End Property

    Public Property solde As Double
        Get
            Return _solde
        End Get
        Set(ByVal value As Double)
            _solde = value
        End Set
    End Property
End Class
