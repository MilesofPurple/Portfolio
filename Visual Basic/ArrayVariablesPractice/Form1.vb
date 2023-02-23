Public Class Form1
    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            MsgBox(aiData(i))
        Next



    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        MsgBox(aiData(0) & vbNewLine & aiData(1) & vbNewLine & aiData(2) & vbNewLine & aiData(3) & vbNewLine & aiData(4))



    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click

        Dim aiData(4) As Integer
        Dim iSum As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            iSum = iSum + aiData(i)
        Next

        MsgBox(iSum)


    End Sub

    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click

        Dim aiData(4) As Integer
        Dim iSum As Integer
        Dim iCount As Integer
        Dim iAverage As Integer


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            iSum = iSum + aiData(i)
            iCount = iCount + 1
        Next

        iAverage = iSum / iCount

        MsgBox(iAverage)

    End Sub

    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click

        Dim aiData(4) As Integer
        Dim iSum As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            If aiData(i) > 20 Then
                iSum = iSum + aiData(i)
            End If
        Next

        MsgBox(iSum)

    End Sub

    Private Sub btnExercise6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click

        Dim aiData(4) As Integer
        Dim iHighest As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            If aiData(i) > iHighest Then
                iHighest = aiData(i)
            End If
        Next

        MsgBox(iHighest)

    End Sub

    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click

        Dim aiData(4) As Integer
        Dim iHighest As Integer
        Dim iLowest As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        'Search for highest number in array
        For i = 0 To 4
            If aiData(i) > iHighest Then
                iHighest = aiData(i)
            End If
        Next

        'Assign highest number to lowest variable
        iLowest = iHighest

        'Search for lowest number in array.
        For i = 0 To 4
            If aiData(i) < iLowest Then
                iLowest = aiData(i)
            End If
        Next

        MsgBox(iLowest)

    End Sub

    Private Sub btnExercise8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        MsgBox((aiData(0) * 2) & " " & (aiData(1) * 2) & " " & (aiData(2) * 2) & " " & (aiData(3) * 2) & " " & (aiData(4) * 2))

    End Sub
End Class
