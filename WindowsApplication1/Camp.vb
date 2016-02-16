Public Class Camp
    Private campid As Integer
    Private campSpecies As String
    Private campName As String
    Private campMinLevel As Integer
    Private campMaxLevel As Integer

    Public Sub New()
        campid = -1
        campSpecies = getSpecies()
        campName = campSpecies & " camp " & campid
        campMinLevel = 1
        campMaxLevel = 50
    End Sub

    Public Sub New(id As Integer)
        campid = id
        campSpecies = getSpecies()
        campName = campSpecies & " camp " & campid
        campMinLevel = 1
        campMaxLevel = 50
    End Sub

    Public Sub New(row As GameDatabaseDataSet.StaticCampsRow)
        campid = row("id")
        campSpecies = row("species")
        campName = row("name")
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

    Public Property name As String
        Get
            Return campName
        End Get
        Set(value As String)
            campName = value
        End Set
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
                    ta As GameDatabaseDataSetTableAdapters.StaticCampsTableAdapter)
        Dim newRow As DataRow = ds.Tables("StaticCamps").NewRow()
        newRow("species") = campSpecies
        newRow("minLevel") = campMinLevel
        newRow("maxLevel") = campMaxLevel
        newRow("name") = campName
        ds.Tables("StaticCamps").Rows.Add(newRow)
        'Try
        '    bs.EndEdit()
        '    ta.Update(ds.StaticCamps)
        'Catch ex As Exception
        '    MsgBox("failed to add camp to database.")
        'End Try

        bs.EndEdit()
        ta.Update(ds.StaticCamps)
    End Sub
End Class
