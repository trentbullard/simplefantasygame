Public Class Tier
    Private tierid As Integer
    Private tierCamp As Camp
    Private tierBoss As Creature

    Public Sub New()
        tierid = -1
        tierCamp = New Camp
        tierBoss = New Creature
    End Sub

    Public Sub New(id As Integer)
        tierid = id
        tierCamp = New Camp
        tierBoss = New Creature
    End Sub

    Public Sub New(camp As Camp)
        tierid = -1
        tierCamp = camp
        tierBoss = New Creature
    End Sub

    Public Sub New(row As GameDatabaseDataSet.StaticCampTierRow)
        tierid = row("id")
        tierCamp = New Camp(CInt(row("campid")))
        tierBoss = New Creature(CInt(row("bossid")))
    End Sub

    Public ReadOnly Property id As Integer
        Get
            Return tierid
        End Get
    End Property

    Public ReadOnly Property camp As Camp
        Get
            Return tierCamp
        End Get
    End Property

    Public Property boss As Creature
        Get
            Return tierBoss
        End Get
        Set(value As Creature)
            tierBoss = value
        End Set
    End Property

    Public Sub save(ds As GameDatabaseDataSet,
                    bs As BindingSource,
                    ta As GameDatabaseDataSetTableAdapters.StaticCampTierTableAdapter)
        Dim newRow As DataRow = ds.Tables("StaticCampTier").NewRow()
        newRow("campid") = tierCamp.id
        newRow("bossid") = Roll(20)
        ds.Tables("StaticCampTier").Rows.Add(newRow)
        Try
            bs.EndEdit()
            ta.Update(ds.StaticCampTier)
        Catch ex As Exception
            MsgBox("failed to add static creature to database.")
        End Try
    End Sub
End Class
