Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        
        'Declare variables
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String
        
        'Assign user inputs to variables
        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text

        stOccupation = lstOccupation.SelectedItem

        'Display user selections
        MsgBox("Hello " & stFirstName & " " & stLastName & "!  You are a " & stGender & " " & stOccupation & "!")



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load additional jobs into program
        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")
        lstOccupation.Items.Add("Wrestler")
    End Sub
End Class
