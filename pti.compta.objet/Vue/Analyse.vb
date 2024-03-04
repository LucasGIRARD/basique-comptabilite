Public Class LigneAnalyse
    Private LblFields As New List(Of Label)
    Private _id As Integer = 0

    Private Sub drawLine(_tab As Integer, _posX As Integer, _posY As Integer, _sizeX As Integer, _sizeY As Integer)
        LblFields.Add(New Label)
        Select Case _tab
            Case 0
                TabPage.Controls.Add(LblFields.Item(_id))
            Case 1
                TabPage1.Controls.Add(LblFields.Item(_id))
            Case 2
                TabPage2.Controls.Add(LblFields.Item(_id))
            Case 3
                TabPage4.Controls.Add(LblFields.Item(_id))
            Case 4
                TabPage5.Controls.Add(LblFields.Item(_id))
        End Select
        LblFields.Item(_id).Location = New System.Drawing.Point(_posX, _posY)
        LblFields.Item(_id).Size = New System.Drawing.Size(_sizeX, _sizeY)
        LblFields.Item(_id).Visible = True
        LblFields.Item(_id).BackColor = Color.Black
        _id = _id + 1
    End Sub

    Private Sub drawLabel(_tab As Integer, _posX As Integer, _posY As Integer, _sizeX As Integer, _sizeY As Integer, _align As String, _content As String)
        LblFields.Add(New Label)
        Select Case _tab
            Case 0
                TabPage.Controls.Add(LblFields.Item(_id))
            Case 1
                TabPage1.Controls.Add(LblFields.Item(_id))
            Case 2
                TabPage2.Controls.Add(LblFields.Item(_id))
            Case 3
                TabPage4.Controls.Add(LblFields.Item(_id))
            Case 4
                TabPage5.Controls.Add(LblFields.Item(_id))
        End Select
        LblFields.Item(_id).Location = New System.Drawing.Point(_posX, _posY)
        LblFields.Item(_id).Size = New System.Drawing.Size(_sizeX, _sizeY)
        LblFields.Item(_id).Text = _content
        Select Case _align
            Case "left"
                LblFields.Item(_id).TextAlign = ContentAlignment.MiddleLeft
            Case "center"
                LblFields.Item(_id).TextAlign = ContentAlignment.MiddleCenter
            Case "right"
                LblFields.Item(_id).TextAlign = ContentAlignment.MiddleRight
        End Select
        LblFields.Item(_id).Visible = True
        'LblFields.Item(_id).BackColor = Color.Red
        _id = _id + 1
    End Sub

    Private Sub draw()
        Dim _lastNumero As Integer
        Dim _lastLibelle As String
        Dim _totalCredit As Integer = 0
        Dim _totalDebit As Integer = 0
        Dim _totalCumul As Integer = 0
        Dim X, Y, XL, YL As Integer
        Dim _comptes = New compteBilan() {}
        Dim _i As Integer = 0
        Dim _items = New operation(Main._operations.Items.Count - 1) {}

        'Le journal
        Y = 10

        drawLabel(0, 686, Y, 70, 13, "center", "Débit")
        drawLabel(0, 769, Y, 70, 13, "center", "Crédit")

        Y = -2

        For Each _item In Main._operations.Items
            _items(_i) = _item
            _i = _i + 1
        Next

        Dim query As IEnumerable(Of operation) = _items.OrderBy(Function(c) c.dateOP)

        For Each _item In query
            If _item.numero <> _lastNumero Then
                If _lastNumero <> 0 Then
                    Y = Y + 19
                    drawLabel(0, 100, Y, 573, 13, "center", _lastLibelle)
                End If

                Y = Y + 19
                drawLabel(0, 346, Y, 66, 13, "left", _item.dateOP.ToString)

                drawLine(0, 93, Y + 6, 587, 1)

                _lastNumero = _item.numero
            End If

            Y = Y + 19
            drawLabel(0, 17, Y, 70, 13, "left", Main._comptes.Item(_item.idCompte).numero.ToString)

            If _item.type = "Débit" Then
                X = 100
            Else
                X = 150
            End If
            drawLabel(0, X, Y, 673 - X, 13, "left", Main._comptes.Item(_item.idCompte).libelle.ToString)

            If _item.type = "Débit" Then
                X = 686
            Else
                X = 769
            End If
            drawLabel(0, X, Y, 70, 13, "right", _item.montant)

            _lastLibelle = _item.libelle
            If _item.type = "Débit" Then
                _totalDebit = _totalDebit + _item.montant
            Else
                _totalCredit = _totalCredit + _item.montant
            End If
        Next

        Y = Y + 19
        drawLabel(0, 100, Y, 573, 13, "center", _lastLibelle)

        Y = Y + 19
        drawLine(0, 93, Y, 587, 1)

        Y = Y + 7
        drawLabel(0, 100, Y, 573, 13, "right", "Total")

        drawLabel(0, 686, Y, 70, 13, "right", _totalDebit)

        drawLabel(0, 769, Y, 70, 13, "right", _totalCredit)

        Y = Y + 17
        drawLine(0, 93, Y, 587, 1)

        'lignes de gauche à droite
        Y = Y - 23
        drawLine(0, 10, 23, 1, Y)
        drawLine(0, 93, 23, 1, Y)
        drawLine(0, 679, 23, 1, Y)
        drawLine(0, 762, 23, 1, Y)
        drawLine(0, 845, 23, 1, Y)

        'Le grand livre | comptes en T
        _lastNumero = Main._operations.Items(0).idCompte
        _totalDebit = 0
        _totalCredit = 0
        X = 10
        Y = 10
        YL = 39

        query = _items.OrderBy(Function(c) c.idCompte)

        For Each _item In query
            If _item.idCompte <> _lastNumero Then
                YL = YL + 19
                drawLine(1, X, Y + YL, 280, 1)
                YL = YL + 7
                drawLabel(1, X + 6, Y + YL, 128, 13, "right", _totalDebit)
                drawLabel(1, X + 147, Y + YL, 128, 13, "right", _totalCredit)

                drawLabel(1, X, Y + 13, 34, 13, "center", "Débit")
                drawLabel(1, X + 246, Y + 13, 34, 13, "center", "Crédit")
                drawLabel(1, X + 40, Y, 200, 26, "center", _lastLibelle)
                drawLine(1, X, Y + 32, 280, 1)
                drawLine(1, X + 140, Y + 32, 1, Y + YL - 29)

                If X = 10 Then
                    X = X + 320
                Else
                    X = 10
                    Y = Y + YL + 40
                End If
                YL = 39
                _lastNumero = _item.idCompte
            End If

            If _item.type = "Débit" Then
                XL = 6
            Else
                XL = 147
            End If
            drawLabel(1, X + XL, Y + YL, 128, 13, "right", _item.montant)

            _lastLibelle = Main._comptes.Item(_item.idCompte).numero.ToString + " - " + Main._comptes.Item(_item.idCompte).libelle.ToString
            If _item.type = "Débit" Then
                _totalDebit = _totalDebit + _item.montant
            Else
                _totalCredit = _totalCredit + _item.montant
            End If
        Next

        YL = YL + 19
        drawLine(1, X, Y + YL, 280, 1)
        YL = YL + 7
        drawLabel(1, X + 6, Y + YL, 128, 13, "right", _totalDebit)
        drawLabel(1, X + 147, Y + YL, 128, 13, "right", _totalCredit)

        drawLabel(1, X, Y + 13, 34, 13, "center", "Débit")
        drawLabel(1, X + 246, Y + 13, 34, 13, "center", "Crédit")
        drawLabel(1, X + 40, Y, 200, 26, "center", _lastLibelle)
        drawLine(1, X, Y + 32, 280, 1)
        drawLine(1, X + 140, Y + 32, 1, Y + YL - 29)

        'Le grand livre | tableau
        _lastNumero = Nothing
        Y = 10
        _totalDebit = 0
        _totalCredit = 0
        _totalCumul = 0
        drawLine(2, 10, Y, 835, 1)
        Y = Y + 7
        drawLabel(2, 17, Y, 70, 13, "center", "Date")
        drawLabel(2, 93, Y, 70, 13, "center", "N° Opération")
        drawLabel(2, 169, Y, 432, 13, "center", "Libellé")
        drawLabel(2, 607, Y, 70, 13, "center", "Débit")
        drawLabel(2, 683, Y, 70, 13, "center", "Crédit")
        drawLabel(2, 759, Y, 80, 13, "center", "Solde cumulé")


        For Each _item In query
            Dim _compte As compte = Main._comptes.Item(_item.idCompte)
            Dim _numCompte As Integer = _compte.numero
            Dim _classe As Integer = _numCompte.ToString.Substring(0, 1)
            If _classe <> _lastNumero Then
                If _lastNumero <> Nothing Then
                    Y = Y + 19
                    drawLine(2, 10, Y, 835, 1)
                    Y = Y + 7
                    drawLabel(2, 169, Y, 432, 13, "left", "Sous total")
                    drawLabel(2, 607, Y, 70, 13, "right", _totalDebit)
                    drawLabel(2, 683, Y, 70, 13, "right", _totalCredit)
                    drawLabel(2, 759, Y, 80, 13, "right", _totalCumul)
                End If

                Y = Y + 19
                drawLine(2, 10, Y, 835, 1)
                Y = Y + 7
                drawLabel(2, 17, Y, 70, 13, "center", _numCompte)
                drawLabel(2, 93, Y, 508, 13, "left", _compte.libelle)
                Y = Y + 19
                drawLabel(2, 169, Y, 432, 13, "left", "Cumuls antérieurs")
                drawLabel(2, 607, Y, 70, 13, "right", "0")
                drawLabel(2, 683, Y, 70, 13, "right", "0")
                drawLabel(2, 759, Y, 80, 13, "right", "0")

                _lastNumero = _classe
            End If
            Y = Y + 19
            drawLabel(2, 17, Y, 70, 13, "left", _item.dateOP)
            drawLabel(2, 93, Y, 70, 13, "center", _item.numero)
            drawLabel(2, 169, Y, 432, 13, "left", _item.libelle)
            If _item.type = "Débit" Then
                X = 607
            Else
                X = 683
            End If
            drawLabel(2, X, Y, 70, 13, "right", _item.montant)
            drawLabel(2, 759, Y, 80, 13, "right", _item.montant)

            If _item.type = "Débit" Then
                _totalDebit = _totalDebit + _item.montant
            Else
                _totalCredit = _totalCredit + _item.montant
            End If
            _totalCumul = _totalCumul + _item.montant
        Next

        If _lastNumero <> Nothing Then
            Y = Y + 19
            drawLine(2, 10, Y, 835, 1)
            Y = Y + 7
            drawLabel(2, 169, Y, 432, 13, "left", "Sous total")
            drawLabel(2, 607, Y, 70, 13, "right", _totalDebit)
            drawLabel(2, 683, Y, 70, 13, "right", _totalCredit)
            drawLabel(2, 759, Y, 80, 13, "right", _totalCumul)
        End If

        Y = Y + 3
        drawLine(2, 10, 10, 1, Y)
        drawLine(2, 845, 10, 1, Y)
        'La balance

        For Each _item In Main._operations.Items
            Dim _compte As compte = Main._comptes.Item(_item.idCompte)

            If _comptes.Count < _compte.numero + 1 Then
                ReDim Preserve _comptes(_compte.numero + 1)
            End If


            If _comptes(_compte.numero) Is Nothing Then
                ReDim Preserve _comptes(_compte.numero + 1)
                _comptes(_compte.numero) = New compteBilan
                _comptes(_compte.numero).libelle = _compte.libelle
                _comptes(_compte.numero).numero = _compte.numero
                _comptes(_compte.numero).classe = _compte.numero.ToString.Substring(0, 1)
                If _item.type = "Débit" Then
                    _comptes(_compte.numero).debit = _item.montant
                    _comptes(_compte.numero).credit = 0
                Else
                    _comptes(_compte.numero).debit = 0
                    _comptes(_compte.numero).credit = _item.montant
                End If
                _comptes(_compte.numero).solde = _item.montant
            Else
                If _item.type = "Débit" Then
                    _comptes(_compte.numero).debit = _comptes(_compte.numero).debit + _item.montant
                Else
                    _comptes(_compte.numero).credit = _comptes(_compte.numero).credit + _item.montant
                End If
                _comptes(_compte.numero).solde = _comptes(_compte.numero).solde + _item.montant
            End If
        Next

        _comptes = _comptes.Where(Function(c) c IsNot Nothing).ToArray

        Y = 10
        _totalDebit = 0
        _totalCredit = 0
        _totalCumul = 0
        _lastNumero = Nothing
        drawLine(3, 10, Y, 835, 1)
        Y = Y + 7
        drawLabel(3, 17, Y, 70, 13, "center", "N° Compte")
        drawLabel(3, 93, Y, 508, 13, "center", "Libellé")
        drawLabel(3, 607, Y, 70, 13, "center", "Débit")
        drawLabel(3, 683, Y, 70, 13, "center", "Crédit")
        drawLabel(3, 759, Y, 80, 13, "center", "Solde")

        Dim query2 As IEnumerable(Of compteBilan) = _comptes.OrderBy(Function(c) c.numero)

        For Each _item In query2
            If _item IsNot Nothing Then
                If _item.classe <> _lastNumero And _lastNumero <> Nothing Then
                    Y = Y + 19
                    drawLine(3, 10, Y, 835, 1)
                    Y = Y + 7
                    drawLabel(3, 17, Y, 578, 13, "left", "Total classe" + _lastLibelle)
                    drawLabel(3, 607, Y, 70, 13, "right", _totalDebit)
                    drawLabel(3, 683, Y, 70, 13, "right", _totalCredit)
                    drawLabel(3, 759, Y, 80, 13, "right", _totalCumul)
                End If

                Y = Y + 19
                drawLabel(3, 17, Y, 70, 13, "center", _item.numero)
                drawLabel(3, 93, Y, 508, 13, "center", _item.libelle)
                drawLabel(3, 607, Y, 70, 13, "right", _item.debit)
                drawLabel(3, 683, Y, 70, 13, "right", _item.credit)
                drawLabel(3, 759, Y, 80, 13, "right", _item.solde)

                _lastLibelle = _item.classe.ToString
                _totalDebit = _totalDebit + _item.debit
                _totalCredit = _totalCredit + _item.credit
                _totalCumul = _totalCumul + _item.solde
            End If
        Next

        Y = Y + 19
        drawLine(3, 10, Y, 835, 1)
        Y = Y + 7
        drawLabel(3, 17, Y, 578, 13, "left", "Total classe" + _lastLibelle)
        drawLabel(3, 607, Y, 70, 13, "right", _totalDebit)
        drawLabel(3, 683, Y, 70, 13, "right", _totalCredit)
        drawLabel(3, 759, Y, 80, 13, "right", _totalCumul)

        Y = Y + 3
        drawLine(3, 10, 10, 1, Y)
        drawLine(3, 845, 10, 1, Y)

        'Resultat de l'exercice

        Y = 10
        _lastNumero = Nothing
        _totalDebit = 0
        _totalCredit = 0
        _totalCumul = 0

        drawLine(4, 10, Y, 835, 1)
        Y = Y + 7
        drawLabel(4, 17, Y, 321, 13, "center", "Charges")
        drawLabel(4, 435, Y, 321, 13, "center", "Produits")
        Y = Y + 19
        drawLine(4, 10, Y, 835, 1)
        Y = Y + 7
        Y = Y - 19
        For Each _item In query2
            If _item IsNot Nothing Then

                If _item.classe <> _lastNumero Then
                    Dim _libelle As String
                    Select Case _item.classe
                        Case 1
                            _libelle = "1"
                        Case 2
                            _libelle = "2"
                        Case 3
                            _libelle = "3"
                        Case 4
                            _libelle = "4"
                        Case 5
                            _libelle = "5"
                        Case 6
                            _libelle = "6"
                        Case 7
                            _libelle = "7"
                    End Select

                    If _item.classe = 6 Or _item.classe = 7 Then
                        X = 435
                    Else
                        X = 17
                    End If
                    Y = Y + 19
                    drawLabel(4, 17, Y, 321, 13, "left", _libelle)
                End If
                Y = Y + 19
                drawLabel(4, 17, Y, 321, 13, "left", _item.libelle)

                If _item.classe = 6 Or _item.classe = 7 Then
                    X = 769
                Else
                    X = 352
                End If

                drawLabel(4, 352, Y, 70, 13, "center", _item.solde)

                _lastNumero = _item.classe
            End If
        Next

        Y = Y + 19
        drawLine(4, 10, Y, 835, 1)
        Y = Y + 7
        drawLabel(4, 17, Y, 321, 13, "center", "Total des charges")
        drawLabel(4, 352, Y, 70, 13, "center", _totalDebit)
        drawLabel(4, 435, Y, 321, 13, "center", "Total des produits")
        drawLabel(4, 769, Y, 70, 13, "center", _totalCredit)
        Y = Y + 19
        drawLine(4, 10, Y, 835, 1)
        Y = Y + 7
        drawLabel(4, 17, Y, 321, 13, "center", "Solde créditeur (bénéfice)")
        drawLabel(4, 352, Y, 70, 13, "center", _totalDebit)
        drawLabel(4, 435, Y, 321, 13, "center", "Solde débiteur (perte)")
        drawLabel(4, 769, Y, 70, 13, "center", _totalCredit)
        Y = Y + 19
        drawLine(4, 10, Y, 835, 1)
        Y = Y + 7
        drawLabel(4, 17, Y, 321, 13, "center", "Total général")
        drawLabel(4, 352, Y, 70, 13, "center", _totalDebit)
        drawLabel(4, 435, Y, 321, 13, "center", "Total général")
        drawLabel(4, 769, Y, 70, 13, "center", _totalCredit)

        Y = Y + 3
        drawLine(4, 10, 10, 1, Y)
        drawLine(4, 345, 10, 1, Y)
        drawLine(4, 428, 10, 1, Y)
        drawLine(4, 762, 10, 1, Y)
        drawLine(4, 845, 10, 1, Y)

    End Sub

    Private Sub LigneAnalyse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        draw()
    End Sub

End Class