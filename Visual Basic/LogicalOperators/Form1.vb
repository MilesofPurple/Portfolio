Public Class Form1
    Private Sub btnGetGrade_Click(sender As Object, e As EventArgs) Handles btnGetGrade.Click
        Dim iScore As Integer
        
        'Get input from user, filtering for numbers to convert to Integer
        If IsNumeric(txtExamScore.Text) = True Then
            iScore = CInt(txtExamScore.Text)
        Else
            MsgBox("You must enter a number")
            Exit Sub
        End If

        'Display score results
        If Not (iScore >= 0 Or iScore <= 100) Then
            MsgBox("That is not a valid score.  Enter a number between 0 and 100")
        ElseIf iScore <= 20 Then
            MsgBox("GRADE F")
        ElseIf iScore > 20 And iScore <= 30 Then
            MsgBox("GRADE E")
        ElseIf iScore > 30 And iScore <= 40 Then
            MsgBox("GRADE D")
        ElseIf iScore > 40 And iScore <= 50 Then
            MsgBox("GRADE C")
        ElseIf iScore > 50 And iScore <= 70 Then
            MsgBox("GRADE B")
        Else
            MsgBox("GRADE A")
        End If

        MsgBox("all done")
    End Sub
End Class
