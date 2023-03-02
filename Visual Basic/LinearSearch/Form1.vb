Public Class Form1
    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click
        
        'Declare array and variables
        Dim astFruit(9) As String
        Dim stTarget As String
        Dim bFound As Boolean

        'Fill array with data
        astFruit(0) = "Apple"
        astFruit(1) = "Mango"
        astFruit(2) = "Strawberry"
        astFruit(3) = "Banana"
        astFruit(4) = "Tomato"
        astFruit(5) = "Grape"
        astFruit(6) = "Pear"
        astFruit(7) = "Lemon"
        astFruit(8) = "Melon"
        astFruit(9) = "Fig"

        stTarget = InputBox("Which fruit are you looking for?")
        
        'Search array for matching string
        Dim i As Integer
        For i = 0 To 9
            If UCase(astFruit(i)) = UCase(stTarget) Then
                bFound = True
            End If
        Next

        'Display results 
        If bFound = True Then
            MsgBox("Found it!")
        Else
            MsgBox("Not found.")
        End If



    End Sub

End Class
