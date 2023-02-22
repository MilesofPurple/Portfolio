Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim decNumber As Decimal
        Dim stOddOrEven As String
        Dim iCount As Integer


        decNumber = InputBox("What number do you want to count up to?")
        stOddOrEven = InputBox("Do you want odd numbers or even numbers?")

        If stOddOrEven.ToUpper = "ODD" Then
            For iCount = 1 To decNumber Step 2
                MsgBox(iCount)
            Next
        ElseIf stOddOrEven.ToUpper = "EVEN" Then
            For iCount = 0 To decNumber Step 2
                MsgBox(iCount)
            Next
        End If


    End Sub
End Class
