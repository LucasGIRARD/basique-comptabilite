Public Class comptes
    Inherits List(Of compte)

    Private _idToDelete As New ArrayList
    Private _idToAdd As New ArrayList
    Private _i As Integer = -1

    Public Sub New()
        load()
    End Sub

    Public Shadows Sub Add(ByVal _item As compte)
        If _item.id = 0 Then
            _item.id = _i
            _i = _i - 1
        End If
        MyBase.Add(_item)
        _idToAdd.Add(IndexOf(_item))
    End Sub

    Public Shadows Sub Remove(ByVal _item As compte)
        If _item.id <> 0 Then
            _idToDelete.Add(_item.id)
        Else
            _idToAdd.Remove(IndexOf(_item))
        End If
        MyBase.Remove(_item)
    End Sub

    Public Shadows Property Item(ByVal index As Integer) As compte
        Get
            Return MyBase.Item(index)
        End Get
        Set(ByVal _item As compte)
            MyBase.Item(index) = _item
        End Set
    End Property

    Public Sub load()
        Dim _resultatBdd = ClassBdd.LoadDb("SELECT * FROM COMPTES", "COMPTES", "data.accdb")

        For Each dr As DataRow In _resultatBdd.Rows
            MyBase.Add(New compte With
                         {.id = CType(dr("id"), Integer),
                          .numero = CType(dr("numero"), Integer),
                          .libelle = dr("libelle").ToString,
                          .informations = dr("informations").ToString})
        Next

        _resultatBdd.Clear()
    End Sub


    Public Sub save()
        Dim _strIdToDel As String
        Dim _oldId

        For Each _item In _idToDelete
            If _strIdToDel Is Nothing Then
                _strIdToDel = _item
            Else
                _strIdToDel = _strIdToDel & "," & _item
            End If
        Next
        If _strIdToDel <> "" Then
            ClassBdd.DeleteInDb("DELETE * FROM COMPTES WHERE id IN (" & _strIdToDel & ")", "data.accdb")
        End If

        For Each comptePlan In Me
            If _idToAdd.Contains(IndexOf(comptePlan)) Then
                _oldId = comptePlan.id
                comptePlan.id = ClassBdd.SaveDb("INSERT INTO COMPTES (numero, libelle, informations) VALUES ('" & comptePlan.numero & "', '" & comptePlan.libelle & "', '" & comptePlan.informations & "')", "data.accdb")
                Main._operations.corectCompte(_oldId, comptePlan.id)
            Else
                ClassBdd.SaveDb("UPDATE COMPTES SET numero = '" & comptePlan.numero & "', libelle = '" & comptePlan.libelle & "', informations = '" & comptePlan.informations & "'", "data.accdb")
            End If
        Next
    End Sub
End Class