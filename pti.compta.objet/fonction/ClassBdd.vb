Public NotInheritable Class ClassBdd
    Private Sub New()

    End Sub

    ''' <summary>
    ''' Permet de récupérer les données d'une table
    ''' </summary>
    ''' <param name="Sql">Requete SQL</param>
    ''' <param name="Table">Table de la base de donnée</param>
    ''' <param name="Base">Base de donnée</param>
    ''' <returns>La table dans le cache mémoire</returns>
    Shared Function LoadDb(ByVal Sql As String, ByVal Table As String, ByVal Base As String) As DataTable
        Dim cnx As New OleDb.OleDbConnection() 'On crée la variable de connexion
        Dim dts As New DataSet() 'On crée un cache mémoire des données
        Dim dtt As New DataTable() 'On crée la représentation de la table dans le cache
        cnx.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\" & Base 'définition du chemin de connexion
        cnx.Open() 'on ouvre la connexion
        Dim dta As New OleDb.OleDbDataAdapter(Sql, cnx) 'on adapte la connexion par rapport à ça requete
        dta.Fill(dts, Table) 'On aligne les données du dataset par rapport à la table (si la table n'existe pas l'erreur est ici)
        dtt = dts.Tables(Table) 'On envoi dans le dtt la table virtuelle
        cnx.Close() 'On ferme la connexion
        Return dtt
    End Function

    ''' <summary>
    ''' Suppression de ligne dans la base de donnée
    ''' </summary>
    ''' <param name="Sql">Requete SQL</param>
    ''' <param name="Base">Base de donnée</param>
    ''' <remarks>L'index doit être récupéré précisément</remarks>
    Shared Sub DeleteInDb(ByVal Sql As String, ByVal Base As String)
        Dim cnx As New OleDb.OleDbConnection() 'On crée la variable de connexion
        cnx.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\" & Base 'définition du chemin de connexion
        cnx.Open() 'on ouvre la connexion
        Dim oledbcmd = cnx.CreateCommand()
        oledbcmd.CommandText = Sql

        oledbcmd.ExecuteNonQuery()

        cnx.Close() 'On ferme la connexion
    End Sub

    ''' <summary>
    ''' Permet d'ajouter des données à la base de donnée
    ''' </summary>
    ''' <param name="Sql">Requete SQL</param>
    ''' <param name="Base">Base de donnée</param>
    Shared Function SaveDb(ByVal Sql As String, ByVal Base As String)
        Dim cnx As New OleDb.OleDbConnection() 'On crée la variable de connexion
        cnx.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\" & Base 'définition du chemin de connexion
        cnx.Open() 'on ouvre la connexion
        Dim oledbcmd = cnx.CreateCommand()
        oledbcmd.CommandText = Sql
        oledbcmd.ExecuteNonQuery()
        oledbcmd.CommandText = "Select @@Identity"
        Dim _id As Integer = oledbcmd.ExecuteScalar()
        cnx.Close() 'On ferme la connexion
        Return _id
    End Function

    ''' <summary>
    ''' Permet d'ajouter des données à la base de donnée
    ''' </summary>
    ''' <param name="Datas">Données à ajouter</param>
    ''' <param name="Sql">Requete SQL</param>
    ''' <param name="Table">Table de la base de donnée</param>
    ''' <param name="Base">Base de donnée</param>
    Shared Sub AddInDb(ByVal Datas As String(), ByVal Sql As String, ByVal Table As String, ByVal Base As String)
        Dim cnx As New OleDb.OleDbConnection() 'On crée la variable de connexion
        Dim dts As New DataSet() 'On crée un cache mémoire des données
        Dim dtt As New DataTable() 'On crée la représentation de la table dans le cache
        Dim dtr As DataRow = Nothing 'On crée la représentation de la ligne dans la table
        cnx.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\" & Base 'définition du chemin de connexion
        cnx.Open() 'on ouvre la connexion
        Dim dta As New OleDb.OleDbDataAdapter(Sql, cnx) 'on adapte la connexion par rapport à ça requete
        dta.Fill(dts, Table) 'On aligne les données du dataset par rapport à la table (si la table n'existe pas l'erreur est ici)
        dtt = dts.Tables(Table) 'On envoi dans le dtt la table virtuelle
        dtr = dtt.NewRow() 'On définit la ligne comme étant une nouvelle ligne de la table virtuelle
        dtr(0) = dtt.Rows.Count + 1 'La premiere donnée sera d'incrémenter l'ID de la ligne
        For i As Integer = 1 To Datas.Length 'on rempli toutes les autres colonnes avec les données
            dtr(i) = Datas(i - 1)
        Next
        dtt.Rows.Add(dtr) 'On ajoute la ligne au datatable
        Dim cmd As New OleDb.OleDbCommandBuilder(dta) 'Création de la commande de modification de la base de donnée
        dta.UpdateCommand = cmd.GetUpdateCommand 'On définit la requete de modification
        dta.Update(dts, Table) ' on modifie en fonction des nouvelles données
        cnx.Close() 'On ferme la connexion
    End Sub

    ''' <summary>
    ''' Recherche de données dans une colonne d'une table d'une base de donnée
    ''' </summary>
    ''' <param name="dtt">Datatable</param>
    ''' <param name="Champs">Champs de la table</param>
    ''' <param name="data">Donnée à rechercher</param>
    ''' <returns>Le nombre de fois qu'il y a la donnée dans la table</returns>
    ''' <remarks>La casse ne rentre pas en compte</remarks>
    Shared Function SearchInDb(ByVal dtt As DataTable, ByVal Champs As String, ByVal data As String) As Integer
        Dim i As Integer = 0 'initialisation du compteur de données trouvés
        Dim j As Integer = dtt.Columns.IndexOf(Champs) 'on récupère l'index de la colonne en question
        For k As Integer = 0 To dtt.Rows.Count - 1 'On recherche toutes les données pouvant etre les memes que celle choisi
            If (data.ToLower() = dtt.Rows(k)(j).ToString().ToLower()) Then
                i += 1 'on incrémente
            End If
        Next
        Return i
    End Function

    ''' <summary>
    ''' Permet de récupérer les données d'une cellule d'une table de la base de donnée
    ''' </summary>
    ''' <param name="Sql">Requete SQL</param>
    ''' <param name="Table">Table de la base de donnée</param>
    ''' <param name="Base">Base de donnée</param>
    ''' <param name="Champs">Champs de la table</param>
    ''' <remarks>La requete doit être précise et doit préciser la ligne ou la donnée se trouve</remarks>
    Shared Function LoadDataSelected(ByVal Sql As String, ByVal Table As String, ByVal Base As String, ByVal Champs As String) As String
        Dim cnx As New OleDb.OleDbConnection() 'On crée la variable de connexion
        Dim cmd As New OleDb.OleDbCommand() 'on crée la variable de commande
        Dim data As String = String.Empty 'on crée la variable de la donnée à récupérer
        cnx.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\" & Base 'définition du chemin de connexion
        cmd = cnx.CreateCommand() 'on crée la commande
        cmd.CommandText = Sql 'On définit la requete pour effectuer la commande
        cnx.Open() 'On ouvre la connexion
        Dim rdr As OleDb.OleDbDataReader = cmd.ExecuteReader() 'création de la variable de lecture et execute la lecture
        rdr.Read() 'Lit les données
        If (rdr.HasRows) Then 'Vérifie s'il y a des lignes à lire
            data = rdr(Champs) 'Récupère la donnée contenue dans la ligne et dans la collonne
        End If
        rdr.Close() 'Arrete la lecture des données
        cnx.Close() 'On ferme la connexion
        Return data
    End Function

    ''' <summary>
    ''' Permet de modifier les données de la base de donnée
    ''' </summary>
    ''' <param name="data">Donnée à modifier</param>
    ''' <param name="Sql">Requete SQL</param>
    ''' <param name="Table">Table de la base de données</param>
    ''' <param name="Base">Base de données</param>
    ''' <param name="Champs">Champs de la table</param>
    ''' <param name="index">Index de la ligne</param>
    ''' <remarks>La récupération de l'index doit être précis et celui de la base de donnée et non celui du dtg, listbox ou encore combobox</remarks>
    Shared Sub UpdateInDb(ByVal data As String, ByVal Sql As String, ByVal Table As String, ByVal Base As String, ByVal Champs As String, ByVal index As Integer)
        Dim cnx As New OleDb.OleDbConnection() 'On crée la variable de connexion
        Dim dts As New DataSet() 'On crée un cache mémoire des données
        Dim dtt As New DataTable() 'On crée la représentation de la table dans le cache
        Dim dtr As DataRow = Nothing 'On crée la représentation de la ligne dans la table
        cnx.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\" & Base 'définition du chemin de connexion
        cnx.Open() 'on ouvre la connexion
        Dim dta As New OleDb.OleDbDataAdapter(Sql, cnx) 'on adapte la connexion par rapport à ça requete
        dta.Fill(dts, Table) 'On aligne les données du dataset par rapport à la table (si la table n'existe pas l'erreur est ici)
        dtt = dts.Tables(Table) 'On envoi dans le dtt la table virtuelle
        dtr = dtt.Rows(index) 'Récupération de la ligne à l'index précisé
        dtr(Champs) = data 'Assignation de la nouvelle donnée
        Dim cmd As New OleDb.OleDbCommandBuilder(dta) 'Création de la commande de modification de la base de donnée
        dta.UpdateCommand = cmd.GetUpdateCommand 'On définit la requete de modification
        dta.Update(dts, Table) ' on modifie en fonction des nouvelles données
        cnx.Close() 'On ferme la connexion
    End Sub

    ''' <summary>
    ''' Récupère l'index précis de la ligne demandé
    ''' </summary>
    ''' <param name="dtt">Datatable contenant la table de la base de donnée</param>
    ''' <param name="Champs">Champs de la table</param>
    ''' <param name="data">Donnée de l'index à récupérer</param>
    Shared Function GetIndexInDb(ByVal dtt As DataTable, ByVal Champs As String, ByVal data As String) As Integer
        Dim i As Integer = 0 'Création de la variable de récupération de l'index
        Dim j As Integer = dtt.Columns.IndexOf(Champs) 'on récupère l'index de la colonne en question
        For k As Integer = 0 To dtt.Rows.Count - 1 'On recherche toutes les données pouvant etre les memes que celle choisi
            If (data = dtt.Rows(k)(j)) Then
                i = k 'on enregistre
                Exit For 'On quitte la fonction on a récupéré l'index que l'on voulait
            End If
        Next
        Return i
    End Function


End Class