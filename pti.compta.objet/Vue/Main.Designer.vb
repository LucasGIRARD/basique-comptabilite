<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.boutonAjouterLigne = New System.Windows.Forms.ToolStripMenuItem()
        Me.boutonSupprimerLigne = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.JournalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperçuavantimpressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SommaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ÀproposdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnLibelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCompte = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.columnMontant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDebitCredit = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(837, 549)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.MenuStrip2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(831, 24)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boutonAjouterLigne, Me.boutonSupprimerLigne})
        Me.MenuStrip2.Location = New System.Drawing.Point(64, 0)
        Me.MenuStrip2.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(172, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'boutonAjouterLigne
        '
        Me.boutonAjouterLigne.Image = CType(resources.GetObject("boutonAjouterLigne.Image"), System.Drawing.Image)
        Me.boutonAjouterLigne.Name = "boutonAjouterLigne"
        Me.boutonAjouterLigne.Size = New System.Drawing.Size(74, 20)
        Me.boutonAjouterLigne.Text = "Ajouter"
        '
        'boutonSupprimerLigne
        '
        Me.boutonSupprimerLigne.Image = CType(resources.GetObject("boutonSupprimerLigne.Image"), System.Drawing.Image)
        Me.boutonSupprimerLigne.Name = "boutonSupprimerLigne"
        Me.boutonSupprimerLigne.Size = New System.Drawing.Size(90, 20)
        Me.boutonSupprimerLigne.Text = "Supprimer"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(62, 24)
        Me.MenuStrip1.TabIndex = 0
        '
        'FichierToolStripMenuItem1
        '
        Me.FichierToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompteToolStripMenuItem1, Me.JournalToolStripMenuItem, Me.ToolStripSeparator3, Me.EnregistrerToolStripMenuItem1, Me.toolStripSeparator4, Me.QuitterToolStripMenuItem1})
        Me.FichierToolStripMenuItem1.Name = "FichierToolStripMenuItem1"
        Me.FichierToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem1.Text = "&Fichier"
        '
        'CompteToolStripMenuItem1
        '
        Me.CompteToolStripMenuItem1.Name = "CompteToolStripMenuItem1"
        Me.CompteToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.CompteToolStripMenuItem1.Text = "Compte"
        '
        'JournalToolStripMenuItem
        '
        Me.JournalToolStripMenuItem.Name = "JournalToolStripMenuItem"
        Me.JournalToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.JournalToolStripMenuItem.Text = "Analyse"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(127, 6)
        '
        'EnregistrerToolStripMenuItem1
        '
        Me.EnregistrerToolStripMenuItem1.Image = CType(resources.GetObject("EnregistrerToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EnregistrerToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EnregistrerToolStripMenuItem1.Name = "EnregistrerToolStripMenuItem1"
        Me.EnregistrerToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.EnregistrerToolStripMenuItem1.Text = "&Enregistrer"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(127, 6)
        '
        'QuitterToolStripMenuItem1
        '
        Me.QuitterToolStripMenuItem1.Name = "QuitterToolStripMenuItem1"
        Me.QuitterToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.QuitterToolStripMenuItem1.Text = "&Quitter"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 529)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(837, 20)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 15)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnId, Me.columnNumero, Me.columnDate, Me.columnLibelle, Me.columnCompte, Me.columnMontant, Me.columnDebitCredit})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 33)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.Size = New System.Drawing.Size(831, 493)
        Me.DataGridView1.TabIndex = 2
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregistrerToolStripMenuItem, Me.toolStripSeparator1, Me.ImprimerToolStripMenuItem, Me.AperçuavantimpressionToolStripMenuItem, Me.toolStripSeparator2, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Image = CType(resources.GetObject("EnregistrerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EnregistrerToolStripMenuItem.Text = "&Enregistrer"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(202, 6)
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.Image = CType(resources.GetObject("ImprimerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ImprimerToolStripMenuItem.Text = "&Imprimer"
        '
        'AperçuavantimpressionToolStripMenuItem
        '
        Me.AperçuavantimpressionToolStripMenuItem.Image = CType(resources.GetObject("AperçuavantimpressionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AperçuavantimpressionToolStripMenuItem.Name = "AperçuavantimpressionToolStripMenuItem"
        Me.AperçuavantimpressionToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(202, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompteToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ActionToolStripMenuItem.Text = "&Action"
        '
        'CompteToolStripMenuItem
        '
        Me.CompteToolStripMenuItem.Name = "CompteToolStripMenuItem"
        Me.CompteToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.CompteToolStripMenuItem.Text = "Compte"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SommaireToolStripMenuItem, Me.IndexToolStripMenuItem, Me.toolStripSeparator5, Me.ÀproposdeToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AideToolStripMenuItem.Text = "Aide (&?)"
        '
        'SommaireToolStripMenuItem
        '
        Me.SommaireToolStripMenuItem.Name = "SommaireToolStripMenuItem"
        Me.SommaireToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SommaireToolStripMenuItem.Text = "&Sommaire"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(144, 6)
        '
        'ÀproposdeToolStripMenuItem
        '
        Me.ÀproposdeToolStripMenuItem.Name = "ÀproposdeToolStripMenuItem"
        Me.ÀproposdeToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ÀproposdeToolStripMenuItem.Text = "À &propos de..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(43, 20)
        Me.ToolStripMenuItem1.Text = "Save"
        '
        'ColumnId
        '
        Me.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColumnId.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColumnId.HeaderText = "Id"
        Me.ColumnId.MinimumWidth = 50
        Me.ColumnId.Name = "ColumnId"
        Me.ColumnId.Width = 50
        '
        'columnNumero
        '
        Me.columnNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.columnNumero.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnNumero.HeaderText = "N° Opération"
        Me.columnNumero.MinimumWidth = 100
        Me.columnNumero.Name = "columnNumero"
        '
        'columnDate
        '
        Me.columnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.columnDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.columnDate.HeaderText = "Date"
        Me.columnDate.MinimumWidth = 100
        Me.columnDate.Name = "columnDate"
        '
        'columnLibelle
        '
        Me.columnLibelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnLibelle.HeaderText = "Libellé"
        Me.columnLibelle.Name = "columnLibelle"
        '
        'columnCompte
        '
        Me.columnCompte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.columnCompte.DefaultCellStyle = DataGridViewCellStyle5
        Me.columnCompte.HeaderText = "Compte"
        Me.columnCompte.MinimumWidth = 100
        Me.columnCompte.Name = "columnCompte"
        Me.columnCompte.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnCompte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'columnMontant
        '
        Me.columnMontant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.columnMontant.DefaultCellStyle = DataGridViewCellStyle6
        Me.columnMontant.HeaderText = "Montant"
        Me.columnMontant.MinimumWidth = 50
        Me.columnMontant.Name = "columnMontant"
        Me.columnMontant.Width = 69
        '
        'columnDebitCredit
        '
        Me.columnDebitCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnDebitCredit.DefaultCellStyle = DataGridViewCellStyle7
        Me.columnDebitCredit.HeaderText = "Débit ou Crédit ?"
        Me.columnDebitCredit.Items.AddRange(New Object() {" ", "Débit", "Crédit"})
        Me.columnDebitCredit.MinimumWidth = 20
        Me.columnDebitCredit.Name = "columnDebitCredit"
        Me.columnDebitCredit.Width = 90
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(837, 549)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AperçuavantimpressionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CompteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents boutonAjouterLigne As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boutonSupprimerLigne As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SommaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ÀproposdeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FichierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JournalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColumnId As DataGridViewTextBoxColumn
    Friend WithEvents columnNumero As DataGridViewTextBoxColumn
    Friend WithEvents columnDate As DataGridViewTextBoxColumn
    Friend WithEvents columnLibelle As DataGridViewTextBoxColumn
    Friend WithEvents columnCompte As DataGridViewComboBoxColumn
    Friend WithEvents columnMontant As DataGridViewTextBoxColumn
    Friend WithEvents columnDebitCredit As DataGridViewComboBoxColumn
End Class
