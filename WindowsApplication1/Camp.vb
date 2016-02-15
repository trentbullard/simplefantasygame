Public Class Camp
    Private campid As Integer
    Private campSpecies As String
    Private campMinLevel As Integer
    Private campMaxLevel As Integer

    Public Sub New()
        campid = -1
        campSpecies = getSpecies()
        campMinLevel = 1
        campMaxLevel = 50
    End Sub

    Public Sub New(id As Integer)
        campid = id
        campSpecies = getSpecies()
        campMinLevel = 1
        campMaxLevel = 50
    End Sub

    Public Sub New(row As GameDatabaseDataSet.StaticCampRow)
        campid = row("id")
        campSpecies = row("species")
        campMinLevel = row("minLevel")
        campMaxLevel = row("maxLevel")
    End Sub

    Public ReadOnly Property id As Integer
        Get
            Return campid
        End Get
    End Property

    Public ReadOnly Property species As String
        Get
            Return campSpecies
        End Get
    End Property

    Public ReadOnly Property minLevel As Integer
        Get
            Return campMinLevel
        End Get
    End Property

    Public ReadOnly Property maxLevel As Integer
        Get
            Return campMaxLevel
        End Get
    End Property

    Public Sub save(ds As GameDatabaseDataSet,
                    bs As BindingSource,
                    ta As GameDatabaseDataSetTableAdapters.StaticCampTableAdapter)
        Dim newRow As DataRow = ds.Tables("StaticCamp").NewRow()
        newRow("species") = campSpecies
        newRow("minLevel") = campMinLevel
        newRow("maxLevel") = campMaxLevel
        ds.Tables("StaticCamp").Rows.Add(newRow)
        Try
            bs.EndEdit()
            ta.Update(ds.StaticCamp)
        Catch ex As Exception
            MsgBox("failed to add static creature to database.")
        End Try
    End Sub
End Class
