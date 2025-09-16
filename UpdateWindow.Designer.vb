<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ExButton = New Button()
        SaveButton = New Button()
        Label3 = New Label()
        Label2 = New Label()
        ReminderDatePicker = New DateTimePicker()
        ToolStrip1 = New ToolStrip()
        ReminderDescBox = New RichTextBox()
        Label1 = New Label()
        ReminderTitleBox = New RichTextBox()
        SuspendLayout()
        ' 
        ' ExButton
        ' 
        ExButton.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ExButton.Location = New Point(274, 337)
        ExButton.Name = "ExButton"
        ExButton.Size = New Size(75, 23)
        ExButton.TabIndex = 17
        ExButton.Text = "Cancel"
        ExButton.UseVisualStyleBackColor = True
        ' 
        ' SaveButton
        ' 
        SaveButton.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SaveButton.Location = New Point(192, 337)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(75, 23)
        SaveButton.TabIndex = 16
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 52)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 12)
        Label3.TabIndex = 15
        Label3.Text = "Notes:"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS PGothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 283)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 12)
        Label2.TabIndex = 14
        Label2.Text = "Deadline:"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ReminderDatePicker
        ' 
        ReminderDatePicker.Font = New Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ReminderDatePicker.Location = New Point(15, 298)
        ReminderDatePicker.Name = "ReminderDatePicker"
        ReminderDatePicker.Size = New Size(220, 20)
        ReminderDatePicker.TabIndex = 13
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Location = New Point(15, 74)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(111, 25)
        ToolStrip1.TabIndex = 12
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ReminderDescBox
        ' 
        ReminderDescBox.Location = New Point(14, 103)
        ReminderDescBox.Name = "ReminderDescBox"
        ReminderDescBox.Size = New Size(335, 167)
        ReminderDescBox.TabIndex = 11
        ReminderDescBox.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 16)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 12)
        Label1.TabIndex = 10
        Label1.Text = "Reminder:"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ReminderTitleBox
        ' 
        ReminderTitleBox.Location = New Point(149, 10)
        ReminderTitleBox.Margin = New Padding(4, 3, 4, 3)
        ReminderTitleBox.Name = "ReminderTitleBox"
        ReminderTitleBox.Size = New Size(200, 29)
        ReminderTitleBox.TabIndex = 9
        ReminderTitleBox.Text = ""
        ' 
        ' UpdateWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 380)
        Controls.Add(ExButton)
        Controls.Add(SaveButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ReminderDatePicker)
        Controls.Add(ToolStrip1)
        Controls.Add(ReminderDescBox)
        Controls.Add(Label1)
        Controls.Add(ReminderTitleBox)
        Margin = New Padding(3, 2, 3, 2)
        Name = "UpdateWindow"
        Text = "View reminder"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ReminderDatePicker As DateTimePicker
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ReminderDescBox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReminderTitleBox As RichTextBox
End Class
