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
        ExButton.Location = New Point(313, 449)
        ExButton.Margin = New Padding(3, 4, 3, 4)
        ExButton.Name = "ExButton"
        ExButton.Size = New Size(86, 31)
        ExButton.TabIndex = 17
        ExButton.Text = "Cancel"
        ExButton.UseVisualStyleBackColor = True
        ' 
        ' SaveButton
        ' 
        SaveButton.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SaveButton.Location = New Point(220, 449)
        SaveButton.Margin = New Padding(3, 4, 3, 4)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(86, 31)
        SaveButton.TabIndex = 16
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(17, 70)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 15)
        Label3.TabIndex = 15
        Label3.Text = "Edit description:"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS PGothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(17, 377)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 14
        Label2.Text = "Deadline:"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ReminderDatePicker
        ' 
        ReminderDatePicker.Font = New Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ReminderDatePicker.Location = New Point(17, 397)
        ReminderDatePicker.Margin = New Padding(3, 4, 3, 4)
        ReminderDatePicker.Name = "ReminderDatePicker"
        ReminderDatePicker.Size = New Size(251, 24)
        ReminderDatePicker.TabIndex = 13
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Location = New Point(17, 99)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(112, 25)
        ToolStrip1.TabIndex = 12
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ReminderDescBox
        ' 
        ReminderDescBox.Location = New Point(16, 137)
        ReminderDescBox.Margin = New Padding(3, 4, 3, 4)
        ReminderDescBox.Name = "ReminderDescBox"
        ReminderDescBox.Size = New Size(382, 221)
        ReminderDescBox.TabIndex = 11
        ReminderDescBox.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 21)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 15)
        Label1.TabIndex = 10
        Label1.Text = "Edit a reminder:"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ReminderTitleBox
        ' 
        ReminderTitleBox.Location = New Point(170, 14)
        ReminderTitleBox.Margin = New Padding(5, 4, 5, 4)
        ReminderTitleBox.Name = "ReminderTitleBox"
        ReminderTitleBox.Size = New Size(228, 37)
        ReminderTitleBox.TabIndex = 9
        ReminderTitleBox.Text = ""
        ' 
        ' UpdateWindow
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(410, 507)
        Controls.Add(ExButton)
        Controls.Add(SaveButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ReminderDatePicker)
        Controls.Add(ToolStrip1)
        Controls.Add(ReminderDescBox)
        Controls.Add(Label1)
        Controls.Add(ReminderTitleBox)
        Name = "UpdateWindow"
        Text = "Update Reminder"
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
