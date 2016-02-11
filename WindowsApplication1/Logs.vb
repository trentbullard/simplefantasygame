Module Logs
    Private path As String
    Private logFilePath As String
    Private logGameText As String

    Public Sub StartLog()
        path = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "TestDirectory"

        'Check for existence of game directory. Create directory if it doesn't.
        If Not My.Computer.FileSystem.DirectoryExists(path) Then
            My.Computer.FileSystem.CreateDirectory(path)
        End If

        'Create log file for game.
        logFilePath = path & "\" & "log.txt"
        If Not My.Computer.FileSystem.FileExists(logFilePath) Then
            Dim fs As IO.FileStream = IO.File.Create(logFilePath)
            fs.Close()
        End If

        'Add text to the file.
        logGameText = Now.TimeOfDay.ToString & " - Initializing... " & vbCrLf
        My.Computer.FileSystem.WriteAllText(logFilePath, logGameText, True)
    End Sub

    Public Sub LogBattle(dataRow, success)
        If Not My.Computer.FileSystem.FileExists(logFilePath) Then
            Dim fs As IO.FileStream = IO.File.Create(logFilePath)
            fs.Close()
        End If
        If success Then
            logGameText = Now.TimeOfDay.ToString & " - Successfully created battle (" & dataRow("Id") & ") at " & Now.TimeOfDay.ToString & vbCrLf
            My.Computer.FileSystem.WriteAllText(logFilePath, logGameText, True)
        Else
            logGameText = Now.TimeOfDay.ToString & " - Failed To create battle (" & dataRow("Id") & ") at " & Now.TimeOfDay.ToString & vbCrLf
            My.Computer.FileSystem.WriteAllText(logFilePath, logGameText, True)
        End If
    End Sub

    Public Sub LogAttack(dataRow, success)
        If Not My.Computer.FileSystem.FileExists(logFilePath) Then
            Dim fs As IO.FileStream = IO.File.Create(logFilePath)
            fs.Close()
        End If
        If success Then
            logGameText = Now.TimeOfDay.ToString & " - Successfully created attack (" & dataRow("Id") & ") by creature " _
                            & dataRow("aggressor") & " against creature " & dataRow("victim") _
                            & " for " & dataRow("damage") & " damage" & vbCrLf
            My.Computer.FileSystem.WriteAllText(logFilePath, logGameText, True)
        Else
            logGameText = Now.TimeOfDay.ToString & " - Failed To create attack (" & dataRow("Id") & ") by creature " _
                            & dataRow("aggressor") & " against creature " & dataRow("victim") _
                            & " for " & dataRow("damage") & " damage" & vbCrLf
            My.Computer.FileSystem.WriteAllText(logFilePath, logGameText, True)
        End If
    End Sub

    Public Sub LogCreatureDamageTaken(creature, damage)
        If Not My.Computer.FileSystem.FileExists(logFilePath) Then
            Dim fs As IO.FileStream = IO.File.Create(logFilePath)
            fs.Close()
        End If
        logGameText = Now.TimeOfDay.ToString & " - " & creature.ToString & " has taken " & damage & " damage" & vbCrLf
        My.Computer.FileSystem.WriteAllText(logFilePath, logGameText, True)
    End Sub

    Public Sub LogCreatureDeath(creature)
        If Not My.Computer.FileSystem.FileExists(logFilePath) Then
            Dim fs As IO.FileStream = IO.File.Create(logFilePath)
            fs.Close()
        End If
        logGameText = Now.TimeOfDay.ToString & " - " & creature.ToString & " has died" & vbCrLf
        My.Computer.FileSystem.WriteAllText(logFilePath, logGameText, True)
    End Sub

    Public Sub LogUsedItem(item, creature)
        If Not My.Computer.FileSystem.FileExists(logFilePath) Then
            Dim fs As IO.FileStream = IO.File.Create(logFilePath)
            fs.Close()
        End If
        logGameText = Now.TimeOfDay.ToString & " - " & item.ToString & " used on " & creature.ToString & vbCrLf
        My.Computer.FileSystem.WriteAllText(logFilePath, logGameText, True)
    End Sub

    Public Sub LogNewPlayer(dataRow, success)
        If Not My.Computer.FileSystem.FileExists(logFilePath) Then
            Dim fs As IO.FileStream = IO.File.Create(logFilePath)
            fs.Close()
        End If
        If success Then
            logGameText = Now.TimeOfDay.ToString & " - Successfully created (player " & dataRow("id") & ") " & dataRow("name") & vbCrLf
            My.Computer.FileSystem.WriteAllText(logFilePath, logGameText, True)
        Else
            logGameText = Now.TimeOfDay.ToString & " - Failed To create (player " & dataRow("id") & ") " & dataRow("name") & vbCrLf
            My.Computer.FileSystem.WriteAllText(logFilePath, logGameText, True)
        End If
    End Sub
End Module
