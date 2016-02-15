Public Class Player
    Private playerid As Integer
    Private playerName As String
    Private playerLevel As Integer
    Private playerExperience As Integer
    Private playerGold As Integer

    Public Sub New()
        playerid = -1
        playerName = "name"
        playerLevel = 1
        playerExperience = 1
        playerGold = 0
    End Sub

    Public Sub New(name As String)
        playerid = -1
        playerName = name
        playerLevel = 1
        playerExperience = 1
        playerGold = 100
    End Sub

    Public Sub New(id As Integer, name As String, level As Integer, exp As Integer, gold As Integer)
        playerid = id
        playerName = name
        playerLevel = level
        playerExperience = exp
        playerGold = gold
    End Sub

    Public Sub New(row As GameDatabaseDataSet.PlayersRow)
        playerid = row("id")
        playerName = row("name")
        playerLevel = row("level")
        playerExperience = row("experience")
        playerGold = row("gold")
    End Sub

    Public ReadOnly Property id() As Integer
        Get
            Return playerid
        End Get
    End Property

    Public ReadOnly Property name() As String
        Get
            Return playerName
        End Get
    End Property

    Public ReadOnly Property level() As Integer
        Get
            Return playerLevel
        End Get
    End Property

    Public ReadOnly Property exp() As Integer
        Get
            Return playerExperience
        End Get
    End Property

    Public ReadOnly Property gold() As Integer
        Get
            Return playerGold
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return "(" & playerLevel & ") " & playerName
    End Function

    Public Sub GainExp(amount)
        playerExperience += amount
        If playerExperience >= (playerLevel + 1) ^ 5 Then
            playerLevel += 1
            MsgBox("DING! gratz, you leveled up!")
        End If
    End Sub

    Public Sub GainGold(amount)
        playerGold += amount
    End Sub

    Public Function SpendGold(amount) As Boolean
        Dim priorAmountHeld As Integer = playerGold
        priorAmountHeld -= amount
        If priorAmountHeld < 0 Then
            MsgBox("you dont have enough gold")
            Return False
        Else
            playerGold -= amount
            Return True
        End If
    End Function

    Public Sub ReName(newName)
        playerName = newName
    End Sub

    Public Sub Save(ByRef dataSet As GameDatabaseDataSet,
                    ByRef bindingSource As BindingSource,
                    ByRef tableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter)
        If Not tableAdapter.GetPlayerByid(playerid).Any Then
            Dim newRow As DataRow = dataSet.Tables("Players").NewRow()
            newRow("name") = playerName
            newRow("level") = playerLevel
            newRow("experience") = playerExperience
            newRow("gold") = playerGold
            dataSet.Tables("Players").Rows.Add(newRow)
        Else
            dataSet.Players(playerid - 1).name = playerName
            dataSet.Players(playerid - 1).level = playerLevel
            dataSet.Players(playerid - 1).experience = playerExperience
            dataSet.Players(playerid - 1).gold = playerGold
        End If
        Try
            bindingSource.EndEdit()
            tableAdapter.Update(dataSet.Players)
        Catch ex As Exception
            MsgBox("failed to update database record for " & Me.ToString)
        End Try
    End Sub
End Class