Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim stFruit As String

        stFruit = "Banana"

        MsgBox(stFruit)

        stFruit = "Orange"

        Dim stFruit2 As String

        stFruit2 = "Pineapple"

        stFruit2 = stFruit

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
