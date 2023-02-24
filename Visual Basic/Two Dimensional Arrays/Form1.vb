Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'Declare array
        Dim astPeople(4, 5) As String

        'Populate array
        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahamta"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim y As Integer

        For y = 0 To 5
            MsgBox(astPeople(3, y))
        Next

    End Sub

    Private Sub btnRow_Click(sender As Object, e As EventArgs) Handles btnRow.Click

        'Declare array
        Dim astPeople(4, 5) As String

        'Populate array
        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahamta"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        For i = 0 To 5
            MsgBox(astPeople(0, i) & " " & astPeople(1, i) & " " & astPeople(2, i) & " " & astPeople(3, i) & " " & astPeople(4, i))
        Next

    End Sub

    Private Sub btnColumn_Click(sender As Object, e As EventArgs) Handles btnColumn.Click

        'Declare array
        Dim astPeople(4, 5) As String

        'Populate array
        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahamta"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim x As Integer
        Dim y As Integer

        For x = 0 To 4
            For y = 0 To 5
                MsgBox(astPeople(x, y))
            Next
        Next




        ''For i = 0 To 5
        ''MsgBox(astPeople(0, i) & vbNewLine & astPeople(1, i) & vbNewLine & astPeople(2, i) & vbNewLine & astPeople(3, i) & vbNewLine & astPeople(4, i))
        ''Next

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click

        'Declare array
        Dim astPeople(4, 5) As String

        'Populate array
        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahamta"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim x As Integer
        Dim y As Integer
        Dim stOut As String

        For y = 0 To 5
            For x = 0 To 4
                stOut = stOut & astPeople(x, y) & " "
            Next
            stOut = stOut & vbNewLine
        Next

        MsgBox(stOut)

        ''MsgBox(astPeople(0, 0) & " " & astPeople(1, 0) & " " & astPeople(2, 0) & " " & astPeople(3, 0) & " " & astPeople(4, 0) & vbNewLine &
        ''astPeople(0, 1) & " " & astPeople(1, 1) & " " & astPeople(2, 1) & " " & astPeople(3, 1) & " " & astPeople(4, 1) & vbNewLine &
        ''astPeople(0, 2) & " " & astPeople(1, 2) & " " & astPeople(2, 2) & " " & astPeople(3, 2) & " " & astPeople(4, 2) & vbNewLine &
        ''astPeople(0, 3) & " " & astPeople(1, 3) & " " & astPeople(2, 3) & " " & astPeople(3, 3) & " " & astPeople(4, 3) & vbNewLine &
        ''astPeople(0, 4) & " " & astPeople(1, 4) & " " & astPeople(2, 4) & " " & astPeople(3, 4) & " " & astPeople(4, 4) & vbNewLine &
        ''astPeople(0, 5) & " " & astPeople(1, 5) & " " & astPeople(2, 5) & " " & astPeople(3, 5) & " " & astPeople(4, 5) & vbNewLine)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        ''Declare search variable
        Dim stSurname As String
        Dim iSurname As Integer

        'Declare array
        Dim astPeople(4, 5) As String

        'Populate array
        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahamta"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim x As Integer
        Dim y As Integer
        Dim bFound As Boolean
        Dim stTarget As String
        Dim stOut As String

        bFound = False

        stTarget = InputBox("Enter the surname of the person you want to find.")


        For y = 0 To 5
            If astPeople(1, y).ToUpper = stTarget.ToUpper Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = True Then
            For x = 0 To 4
                stOut = stOut & astPeople(x, y) & " "
            Next
        Else
            MsgBox("Not found.")
        End If

        MsgBox(stOut)

        ''
        ''stSurname = InputBox("Enter the surname of the person you want to find.")
        ''iSurname = 1

        ''For i = 0 To 5
        ''If stSurname.ToUpper = astPeople(iSurname, i).ToUpper Then
        ''MsgBox(astPeople(0, i) & " " & astPeople(1, i) & " " & astPeople(2, i) & " " & astPeople(3, i) & " " & astPeople(4, i))
        ''End If
        ''Next


    End Sub
End Class
