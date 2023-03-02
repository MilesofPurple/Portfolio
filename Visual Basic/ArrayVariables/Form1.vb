Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        
        'Declare variables
        Dim stFruit As String
        Dim stFruit2 As String
        
        'Assign a fruit to variable
        stFruit = "Banana"

        MsgBox(stFruit)
        
        'Change fruits
        stFruit = "Orange"

        stFruit2 = "Pineapple"
        
        'Override fruit2 with fruit
        stFruit2 = stFruit
        
        'Display overriden fruit
        MsgBox(stFruit2)

    End Sub

    Private Sub btnArray_Click(sender As Object, e As EventArgs) Handles btnArray.Click


        'Declare the array
        Dim astFruits(4) As String


        'Fill the array
        astFruits(0) = "Banana"
        astFruits(1) = "Orange"
        astFruits(2) = "Pineapple"
        astFruits(3) = "Strawberry"
        astFruits(4) = "Mango"

        'Display Pineapple
        MsgBox(astFruits(2))

        'Display array through loop
        For i = 0 To 4
            MsgBox(astFruits(i))
        Next

    End Sub
End Class
