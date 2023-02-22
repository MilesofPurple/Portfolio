Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim stName As String

        Do While True
            stName = InputBox("Please enter your name")
            If stName = "MILES" Then
                Exit Do
            End If
        Loop

        MsgBox("Hello " & stName)

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim stAge As String
        Dim iAge As Integer

        Do While IsNumeric(stAge) = False
            stAge = InputBox("Please enter your age in years")
        Loop

        iAge = CInt(stAge)

        MsgBox("Hello, you are " & iAge & " years old.")
    End Sub
End Class
