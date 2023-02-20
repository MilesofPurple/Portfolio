Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("Welcome to the VB.NET programming course!")

        MessageBox.Show("This is another message.")

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Sean"
        stLastName = "Miles"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & "!  I hope you are well!")


        stFirstName = "Shepard"
        stLastName = "Book"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & "!  I hope you are well!")

    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date


        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColor = "Red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 10000.0
        dtDateRegistered = #2/10/2023#

        MsgBox("The car is a " & stColor & " " & stMake & " " & stModel & " with " & iDoors & " doors and it's taxed status is " & bTaxed & ". " &
               vbNewLine & iEngineSize & " engine size. Costs " & decPrice & " and registered " & dtDateRegistered)

    End Sub
End Class
