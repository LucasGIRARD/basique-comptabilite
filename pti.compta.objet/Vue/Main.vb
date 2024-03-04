Public Class Main
    Public _comptes As New comptes
    Public _operations As New operations
    Private comboCompte As New List(Of compte)

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        resetDGV()
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(0).DataPropertyName = _operations.colNameId
        DataGridView1.Columns(1).DataPropertyName = _operations.colNameNumero
        DataGridView1.Columns(2).DataPropertyName = _operations.colNameDate
        DataGridView1.Columns(3).DataPropertyName = _operations.colNameLibelle
        DataGridView1.Columns(4).DataPropertyName = _operations.colNameIdCompte
        resetCBB()
        DataGridView1.Columns(5).DataPropertyName = _operations.colNameMontant
        DataGridView1.Columns(6).DataPropertyName = _operations.colNameType
    End Sub

    Private Sub boutonAjouterLigne_Click(sender As Object, e As EventArgs) Handles boutonAjouterLigne.Click
        Dim _operation As New operation
        _operations.Add(_operation)
        EnregistrerToolStripMenuItem1.Enabled = True
    End Sub

    Private Sub boutonSupprimerLigne_Click(sender As Object, e As EventArgs) Handles boutonSupprimerLigne.Click

        If DataGridView1.Rows.Count > 0 Then
            _operations.Remove(DataGridView1.CurrentRow.Index)
            EnregistrerToolStripMenuItem1.Enabled = True
        Else
            MsgBox("Impossible d'effectuer cette opération : il n'y a plus de ligne dans le tableau.", , "Erreur")
        End If
    End Sub

    Private Sub CompteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompteToolStripMenuItem1.Click
        AffichageCompte.ShowDialog()
        If AffichageCompte.DialogResult = DialogResult.OK Then
            For Each _id In AffichageCompte._idToDelete
                _operations.removeCompte(_comptes(_id))
                _comptes.Remove(_comptes(_id))
            Next
            resetCBB()
        Else
            For Each _id In AffichageCompte._idToAdd
                _operations.removeCompte(_comptes(_id))
                _comptes.Remove(_comptes(_id))
            Next
        End If
    End Sub

    Private Sub JournalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JournalToolStripMenuItem.Click
        LigneAnalyse.Show()
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        EnregistrerToolStripMenuItem1.Enabled = True
        If e.RowIndex <> -1 Then
            _operations.corectLibelle(_operations.IndexOf(DataGridView1.Rows(e.RowIndex).DataBoundItem.row))
        End If
    End Sub

    Private Sub EnregistrerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem1.Click
        _comptes.save()
        _operations.saveDB()
        EnregistrerToolStripMenuItem1.Enabled = False
    End Sub

    Private Sub QuitterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem1.Click
        Close()
    End Sub

    Private Sub resetDGV()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = _operations
        DataGridView1.DataMember = _operations.entityName
    End Sub

    Private Sub resetCBB()
        columnCompte.DataSource = Nothing
        comboCompte.Clear()
        comboCompte.Add(New compte() With {.id = 0, .numero = " ", .libelle = ""})
        comboCompte.AddRange(_comptes)
        columnCompte.DataSource = comboCompte
        columnCompte.DisplayMember = "numero"
        columnCompte.ValueMember = "id"
    End Sub
End Class