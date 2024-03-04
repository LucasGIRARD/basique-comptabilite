Public Class operations
    Inherits DataSet

    Private Const _entityName As String = "operations"

    Private Const _colNameId As String = "id"
    Private Const _colNameIdCompte As String = "idCompte"
    Private Const _colNameNumero As String = "numero"
    Private Const _colNameDate As String = "dateOP"
    Private Const _colNameLibelle As String = "libelle"
    Private Const _colNameMontant As String = "montant"
    Private Const _colNameType As String = "type"

    Private _idToDelete As New ArrayList
    Private _idToAdd As New ArrayList

    Public Sub New()
        MyBase.New
        Tables.Add(_entityName)

        With Tables(_entityName).Columns
            .Add(_colNameId, GetType(Integer))
            .Add(_colNameIdCompte, GetType(Integer))
            .Add(_colNameNumero, GetType(Integer))
            .Add(_colNameDate, GetType(Date))
            .Add(_colNameLibelle, GetType(String))
            .Add(_colNameMontant, GetType(Double))
            .Add(_colNameType, GetType(String))
        End With

        loadDB()
    End Sub

    Public ReadOnly Property entityName As String
        Get
            Return _entityName
        End Get
    End Property

    Public ReadOnly Property colNameId As String
        Get
            Return _colNameId
        End Get
    End Property

    Public ReadOnly Property colNameIdCompte As String
        Get
            Return _colNameIdCompte
        End Get
    End Property

    Public ReadOnly Property colNameNumero As String
        Get
            Return _colNameNumero
        End Get
    End Property

    Public ReadOnly Property colNameDate As String
        Get
            Return _colNameDate
        End Get
    End Property

    Public ReadOnly Property colNameLibelle As String
        Get
            Return _colNameLibelle
        End Get
    End Property

    Public ReadOnly Property colNameMontant As String
        Get
            Return _colNameMontant
        End Get
    End Property

    Public ReadOnly Property colNameType As String
        Get
            Return _colNameType
        End Get
    End Property


    Public Function IndexOf(ByVal _value As DataRow)
        Dim _index = Tables(_entityName).Rows.IndexOf(_value)

        Return _index
    End Function

    Public Function Add(ByVal _item As operation)
        Dim _DR As DataRow = Tables(_entityName).NewRow

        _DR(_colNameId) = _item.id
        _DR(_colNameIdCompte) = _item.idCompte
        _DR(_colNameNumero) = _item.numero
        _DR(_colNameDate) = _item.dateOP
        _DR(_colNameLibelle) = _item.libelle
        _DR(_colNameMontant) = _item.montant
        _DR(_colNameType) = _item.type

        Tables(_entityName).Rows.Add(_DR)
        _idToAdd.Add(IndexOf(_DR))
        Return Tables(_entityName).Rows.IndexOf(_DR)
    End Function

    Public Function AddInternal(ByVal _item As operation)
        Dim _DR As DataRow = Tables(_entityName).NewRow

        _DR(_colNameId) = _item.id
        _DR(_colNameIdCompte) = _item.idCompte
        _DR(_colNameNumero) = _item.numero
        _DR(_colNameDate) = _item.dateOP
        _DR(_colNameLibelle) = _item.libelle
        _DR(_colNameMontant) = _item.montant
        _DR(_colNameType) = _item.type

        Tables(_entityName).Rows.Add(_DR)

        Return Tables(_entityName).Rows.IndexOf(_DR)
    End Function

    Public Sub Remove(ByVal index As Integer)
        Try
            Dim _id = Tables(_entityName).Rows(index)(colNameId)
            If _id <> 0 Then
                _idToDelete.Add(_id)
            Else
                _idToAdd.Remove(index)
            End If
            Tables(_entityName).Rows.RemoveAt(index)
        Catch ex As IndexOutOfRangeException
            System.Windows.Forms.MessageBox.Show("Index not valid!")
        End Try
    End Sub

    Public Sub removeCompte(ByVal _item As compte)
        For Each _row In Tables(_entityName).Rows
            Dim _index As Integer = Tables(_entityName).Rows.IndexOf(_row)
            If Item(_index).idCompte = _item.id Then
                _row(_colNameIdCompte) = 0
            End If
        Next
    End Sub

    Default Public Property Item(ByVal _index As Integer) As operation
        Get
            Dim _DR As DataRow = Tables(_entityName).Rows(_index)
            Dim _item As New operation

            _item.id = _DR(_colNameId)
            _item.idCompte = _DR(_colNameIdCompte)
            _item.numero = _DR(_colNameNumero)
            _item.dateOP = _DR(_colNameDate)
            _item.libelle = _DR(_colNameLibelle)
            _item.montant = _DR(_colNameMontant)
            _item.type = _DR(_colNameType)

            Return _item
        End Get
        Set(ByVal _item As operation)
            Dim _DR As DataRow = Tables(_entityName).Rows(_index)

            _DR(_colNameId) = _item.id
            _DR(_colNameIdCompte) = _item.idCompte
            _DR(_colNameNumero) = _item.numero
            _DR(_colNameDate) = _item.dateOP
            _DR(_colNameLibelle) = _item.libelle
            _DR(_colNameMontant) = _item.montant
            _DR(_colNameType) = _item.type
        End Set
    End Property

    Public ReadOnly Property Items As List(Of operation)
        Get
            Dim _list As New List(Of operation)
            For Each _row As DataRow In Tables(_entityName).Rows
                Dim _item As operation = Item(Tables(_entityName).Rows.IndexOf(_row))
                _list.Add(_item)
            Next
            Return _list
        End Get
    End Property

    Public Sub corectLibelle()
        For Each _row As DataRow In Tables(_entityName).Rows
            For Each _row2 As DataRow In Tables(_entityName).Rows
                If _row(_colNameNumero) = _row2(_colNameNumero) And _row(_colNameLibelle) <> _row2(_colNameLibelle) Then
                    _row2(_colNameLibelle) = _row(_colNameLibelle)
                End If
            Next
        Next
    End Sub

    Public Sub corectCompte(_oldId, _newID)
        For Each _row As DataRow In Tables(_entityName).Rows
            If _row(_colNameIdCompte) = _oldId Then
                _row(_colNameIdCompte) = _newID
            End If
        Next
    End Sub

    Public Sub corectLibelle(ByVal _index As Integer)
        Dim _row As DataRow = Tables(_entityName).Rows(_index)
        For Each _row2 As DataRow In Tables(_entityName).Rows
            If _row(_colNameLibelle) IsNot DBNull.Value And _row2(_colNameLibelle) IsNot DBNull.Value Then
                If _row(_colNameNumero) = _row2(_colNameNumero) And Not (_row(_colNameLibelle) = _row2(_colNameLibelle)) Then
                    _row2(_colNameLibelle) = _row(_colNameLibelle)
                End If
            End If
        Next
    End Sub

    Public Sub loadDB()
        Dim resultatBdd = ClassBdd.LoadDb("SELECT * FROM OPERATIONS", "OPERATIONS", "data.accdb")
        Dim tempNumCompte
        For Each dr As DataRow In resultatBdd.Rows
            If DBNull.Value Is dr(_colNameIdCompte) Then
                tempNumCompte = -1
            Else
                tempNumCompte = dr(_colNameIdCompte)
            End If

            AddInternal(New operation With
                         {.id = CType(dr(_colNameId), Integer),
                          .idCompte = CType(tempNumCompte, Integer),
                          .numero = CType(dr(_colNameNumero), Integer),
                          .dateOP = CType(dr(_colNameDate), Date),
                          .libelle = dr(_colNameLibelle).ToString,
                          .montant = CType(dr(_colNameMontant), Double),
                          .type = dr(_colNameType).ToString})
        Next
        corectLibelle()
    End Sub

    Public Sub saveDB()
        Dim _strIdToDel As String

        For Each _item In _idToDelete
            If _strIdToDel Is Nothing Then
                _strIdToDel = _item
            Else
                _strIdToDel = _strIdToDel & "," & _item
            End If
        Next
        If _strIdToDel <> "" Then
            ClassBdd.DeleteInDb("DELETE * FROM OPERATIONS WHERE id IN (" & _strIdToDel & ")", "data.accdb")
        End If

        For Each _DR In Tables(_entityName).Rows
            Dim _item = Items(IndexOf(_DR))
            If _idToAdd.Contains(IndexOf(_DR)) Then
                If _item.idCompte = -1 Then
                    _DR(colNameId) = ClassBdd.SaveDb("INSERT INTO OPERATIONS (numero, dateOP, Libelle, Montant, type) VALUES ('" & _item.numero & "', '" & _item.dateOP & "', '" & _item.libelle & "', '" & _item.montant & "', '" & _item.type & "')", "data.accdb")
                Else
                    _DR(colNameId) = ClassBdd.SaveDb("INSERT INTO OPERATIONS (idCompte, numero, dateOP, Libelle, Montant, type) VALUES ('" & _item.idCompte & "', '" & _item.numero & "', '" & _item.dateOP & "', '" & _item.libelle & "', '" & _item.montant & "', '" & _item.type & "')", "data.accdb")
                End If
            Else
                If _item.idCompte = -1 Then
                    ClassBdd.SaveDb("UPDATE OPERATIONS SET idCompte = '" & _item.idCompte & "', numero = '" & _item.numero & "', dateOP = '" & _item.dateOP & "', Libelle = '" & _item.libelle & "', Montant = '" & _item.montant & "', type = '" & _item.type & "'", "data.accdb")
                Else
                    ClassBdd.SaveDb("UPDATE OPERATIONS SET idCompte = '" & _item.idCompte & "', numero = '" & _item.numero & "', dateOP = '" & _item.dateOP & "', Libelle = '" & _item.libelle & "', Montant = '" & _item.montant & "', type = '" & _item.type & "'", "data.accdb")
                End If
            End If
        Next
    End Sub
End Class
