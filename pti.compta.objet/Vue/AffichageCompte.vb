Imports System.Windows.Forms

Public Class AffichageCompte

    Public _idToDelete As New ArrayList
    Public _idToAdd As New ArrayList

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim _canClose = True

        For Each _item In Main._comptes
            If _item.numero = "" And Not _idToDelete.Contains(Main._comptes.IndexOf(_item)) Then
                _canClose = False
            End If
        Next

        If _canClose Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Veuillez remplir les numéros de comptes manquant ou les supprimer.", , "Erreur")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AffichageCompte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Main._comptes
        DataGridView1.Columns(0).Visible = False
    End Sub

    Private Sub BoutonAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoutonAjouter.Click
        Dim _compte As New compte
        Main._comptes.Add(_compte)
        Dim _id As Integer = Main._comptes.IndexOf(_compte)
        _idToAdd.Add(_id)
        refreshView()
    End Sub

    Private Sub BoutonSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoutonSupprimer.Click
        If DataGridView1.Rows.Count > 0 And DataGridView1.CurrentRow IsNot Nothing Then
            Dim _id As Integer = DataGridView1.CurrentRow.Index
            DataGridView1.CurrentCell = Nothing
            DataGridView1.Rows(_id).Visible = False
            _idToDelete.Add(_id)
        Else
            MsgBox("Impossible d'effectuer cette opération : il n'y a plus de ligne dans le tableau.", , "Erreur")
        End If
    End Sub

    Private Sub refreshView()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = Main._comptes
        DataGridView1.Columns(0).Visible = False
        DataGridView1.CurrentCell = Nothing

        For Each _row In DataGridView1.Rows
            If _idToDelete.Contains(_row.index) Then
                DataGridView1.Rows(_row.index).Visible = False
            End If
        Next
    End Sub

End Class
