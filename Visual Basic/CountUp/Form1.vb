Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        
        'Declare variables
        Dim decNumber As Decimal
        Dim stOddOrEven As String
        Dim iCount As Integer

        'Ask how high we want to count up to
        decNumber = InputBox("What number do you want to count up to?")
        
        'Ask if we want to display even or odd numbers
        dOrEven = InputBox("Do you want odd numbers or even numbers?")
        
        
        'Display odd or even numbers depending on user selection
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
