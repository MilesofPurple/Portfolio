<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExamScore = New System.Windows.Forms.TextBox()
        Me.btnGetGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(477, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the examination score:"
        '
        'txtExamScore
        '
        Me.txtExamScore.Location = New System.Drawing.Point(717, 302)
        Me.txtExamScore.MaxLength = 3
        Me.txtExamScore.Name = "txtExamScore"
        Me.txtExamScore.Size = New System.Drawing.Size(107, 31)
        Me.txtExamScore.TabIndex = 1
        '
        'btnGetGrade
        '
        Me.btnGetGrade.Location = New System.Drawing.Point(634, 398)
        Me.btnGetGrade.Name = "btnGetGrade"
        Me.btnGetGrade.Size = New System.Drawing.Size(190, 100)
        Me.btnGetGrade.TabIndex = 2
        Me.btnGetGrade.Text = "Get Grade"
        Me.btnGetGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1426, 790)
        Me.Controls.Add(Me.btnGetGrade)
        Me.Controls.Add(Me.txtExamScore)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents btnGetGrade As Button
End Class
