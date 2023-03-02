Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        
        'Declare variables
        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decTotalCost As Decimal
        Dim decDiscount As Decimal
        Dim decPostage As Decimal

        'Assign values to variables
        decPrice = 5
        iQuantity = 10
        decDiscount = 2
        decPostage = 3
        
        'Calculate total cost to mail
        decTotalCost = (decPrice - decDiscount) * iQuantity + decPostage
        
        'Display total cost
        MsgBox(decTotalCost)

        'BO(DM)(AS) - Brackets Order Division Multiplication Addition Subtraction
        'PE(MD)(AS) - Parentheses Exponentiation Multiplication Division Addition Subtraction
        
        
        Dim iResult As Integer
        iResult = 10 - 5 + 2
        MsgBox(iResult)

        iResult = 10 + 2 - 5
        MsgBox(iResult)

        iResult = 10 - 2 + 5
        MsgBox(iResult)

        iResult = 10 / 5 * 2
        MsgBox(iResult)

        iResult = 2 * 10 / 5
        MsgBox(iResult)

        iResult = 10 * 5 / 2
        MsgBox(iResult)


    End Sub
End Class
