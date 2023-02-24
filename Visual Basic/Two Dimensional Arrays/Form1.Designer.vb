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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnRow = New System.Windows.Forms.Button()
        Me.btnColumn = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(582, 152)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(332, 131)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "2D Array"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnRow
        '
        Me.btnRow.Location = New System.Drawing.Point(22, 357)
        Me.btnRow.Name = "btnRow"
        Me.btnRow.Size = New System.Drawing.Size(334, 157)
        Me.btnRow.TabIndex = 1
        Me.btnRow.Text = "Display data items row wise"
        Me.btnRow.UseVisualStyleBackColor = True
        '
        'btnColumn
        '
        Me.btnColumn.Location = New System.Drawing.Point(387, 357)
        Me.btnColumn.Name = "btnColumn"
        Me.btnColumn.Size = New System.Drawing.Size(334, 157)
        Me.btnColumn.TabIndex = 2
        Me.btnColumn.Text = "Display data items column wise"
        Me.btnColumn.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(757, 357)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(334, 157)
        Me.btnAll.TabIndex = 3
        Me.btnAll.Text = "Display all data items at once"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1122, 357)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(334, 157)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search for a person"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 812)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnColumn)
        Me.Controls.Add(Me.btnRow)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnRow As Button
    Friend WithEvents btnColumn As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents btnSearch As Button
End Class
