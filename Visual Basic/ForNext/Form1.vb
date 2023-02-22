Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCount As Integer
        Dim stOut As String

        For iCount = 50 To 0 Step -5
            stOut = stOut & iCount & vbNewLine
            MsgBox("Hello!" & iCount)
            MsgBox("How are you?")
            MsgBox("Well, I hope.")
        Next
    End Sub
End Class
