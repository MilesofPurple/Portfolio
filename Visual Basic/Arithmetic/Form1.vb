Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        
        'Declare variables
        Dim dblNumber1 As Double
        Dim dblNumber2 As Double
        Dim dblResult As Double
        
        'Get both numbers from user
        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text
        
        
        'Addition
        dblResult = dblNumber1 + dblNumber2
        MsgBox("The sum of " & dblNumber1 & " and " & dblNumber2 & " is: " & dblResult)
        
        'Subtraction
        dblResult = dblNumber1 - dblNumber2
        MsgBox("The difference between " & dblNumber1 & " and " & dblNumber2 & " is: " & dblResult)
        
        'Multiplication
        dblResult = dblNumber1 * dblNumber2
        MsgBox("The product of " & dblNumber1 & " and " & dblNumber2 & " is: " & dblResult)
        
        'Division
        dblResult = dblNumber1 / dblNumber2
        MsgBox("The ratio of " & dblNumber2 & "s in " & dblNumber1 & " is: " & dblResult)
        
        'Exponentation
        dblResult = dblNumber1 ^ dblNumber2
        MsgBox(dblNumber1 & " raised to the power of " & dblNumber2 & " is: " & dblResult)
        
        'Division without remainder
        dblResult = dblNumber1 \ dblNumber2
        MsgBox(dblNumber1 & " divided by " & dblNumber2 & " without remainder is: " & dblResult)
        
        'Division with remainder only
        dblResult = dblNumber1 Mod dblNumber2
        MsgBox("The remainder of " & dblNumber1 & " divided by " & dblNumber2 & " is: " & dblResult)


    End Sub


End Class


