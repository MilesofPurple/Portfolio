Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblNumber1 As Double
        Dim dblNumber2 As Double

        Dim dblResult As Double

        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text

        dblResult = dblNumber1 + dblNumber2
        MsgBox("The sum of " & dblNumber1 & " and " & dblNumber2 & " is: " & dblResult)

        dblResult = dblNumber1 - dblNumber2
        MsgBox("The difference between " & dblNumber1 & " and " & dblNumber2 & " is: " & dblResult)

        dblResult = dblNumber1 * dblNumber2
        MsgBox("The product of " & dblNumber1 & " and " & dblNumber2 & " is: " & dblResult)

        dblResult = dblNumber1 / dblNumber2
        MsgBox("The ratio of " & dblNumber2 & "s in " & dblNumber1 & " is: " & dblResult)

        dblResult = dblNumber1 ^ dblNumber2
        MsgBox(dblNumber1 & " raised to the power of " & dblNumber2 & " is: " & dblResult)

        dblResult = dblNumber1 \ dblNumber2
        MsgBox(dblNumber1 & " divided by " & dblNumber2 & " without remainder is: " & dblResult)

        dblResult = dblNumber1 Mod dblNumber2
        MsgBox("The remainder of " & dblNumber1 & " divided by " & dblNumber2 & " is: " & dblResult)


    End Sub


End Class
