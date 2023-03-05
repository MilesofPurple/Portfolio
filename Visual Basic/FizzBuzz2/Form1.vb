Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim iNumber As Integer
        Dim iFizz As Integer
        Dim iBuzz As Integer
        Dim iFizzBuzz As Integer



        For iNumber = 1 To 100


            'Reset integers at the start of the loop
            iFizz = 0
            iBuzz = 0
            iFizzBuzz = 0

            'Begin loop to check if number is in multiple of 3 and 5, and to print "FizzBuzz" and continue if true
            Do Until iFizzBuzz >= 100
                iFizzBuzz = iFizzBuzz + 15
                If iFizzBuzz = iNumber Then
                    MsgBox("FizzBuzz")
                    Continue For
                End If
            Loop

            'Begin loop to check if number is in multiple of 5 and to print "Buzz" and continue if true
            Do Until iBuzz >= 100
                iBuzz = iBuzz + 5
                If iBuzz = iNumber Then
                    MsgBox("Buzz")
                    Continue For
                End If
            Loop

            'Begin loop to check if number is in multiple of 3 and to print "Fizz" and continue if true
            Do Until iFizz >= 100
                iFizz = iFizz + 3
                If iFizz = iNumber Then
                    MsgBox("Fizz")
                    Continue For
                End If
            Loop
            'Prints number if no other conditions are met
            MsgBox(iNumber)
        Next
    End Sub
End Class
