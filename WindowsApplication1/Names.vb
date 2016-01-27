Module Names
    Public Function ProperCase(name As String) As String
        name = name.Trim
        Dim properName As String = ""
        Dim words() As String = name.Split(" ")
        For Each word In words
            If String.IsNullOrWhiteSpace(word) Then
            ElseIf word.Count = 1 Then
                properName = properName + word.ToUpper + " "
            Else
                properName = properName + word.Substring(0, 1).ToUpper + word.Substring(1).ToLower + " "
            End If
        Next
        Return properName.Trim()
    End Function
End Module
