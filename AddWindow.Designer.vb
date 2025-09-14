<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddWindow
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
        ReminderTitleBox = New RichTextBox()
        Label1 = New Label()
        ReminderDescBox = New RichTextBox()
        ToolStrip1 = New ToolStrip()
        ReminderDatePicker = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        SaveButton = New Button()
        ExButton = New Button()
        SuspendLayout()
        ' 
        ' ReminderTitleBox
        ' 
        ReminderTitleBox.Location = New Point(122, 12)
        ReminderTitleBox.Margin = New Padding(4, 3, 4, 3)
        ReminderTitleBox.Name = "ReminderTitleBox"
        ReminderTitleBox.Size = New Size(225, 29)
        ReminderTitleBox.TabIndex = 0
        ReminderTitleBox.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 17)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 12)
        Label1.TabIndex = 1
        Label1.Text = "Enter a reminder:"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ReminderDescBox
        ' 
        ReminderDescBox.Location = New Point(12, 104)
        ReminderDescBox.Name = "ReminderDescBox"
        ReminderDescBox.Size = New Size(335, 167)
        ReminderDescBox.TabIndex = 2
        ReminderDescBox.Text = ""
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Location = New Point(13, 76)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(111, 25)
        ToolStrip1.TabIndex = 3
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ReminderDatePicker
        ' 
        ReminderDatePicker.Font = New Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ReminderDatePicker.Location = New Point(13, 299)
        ReminderDatePicker.Name = "ReminderDatePicker"
        ReminderDatePicker.Size = New Size(220, 20)
        ReminderDatePicker.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS PGothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 284)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 12)
        Label2.TabIndex = 5
        Label2.Text = "Deadline:"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 54)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 12)
        Label3.TabIndex = 6
        Label3.Text = "Enter description:"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' SaveButton
        ' 
        SaveButton.Location = New Point(191, 338)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(75, 23)
        SaveButton.TabIndex = 7
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' ExButton
        ' 
        ExButton.Location = New Point(272, 338)
        ExButton.Name = "ExButton"
        ExButton.Size = New Size(75, 23)
        ExButton.TabIndex = 8
        ExButton.Text = "Cancel"
        ExButton.UseVisualStyleBackColor = True
        ' 
        ' AddWindow
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
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
        Margin = New Padding(4, 3, 4, 3)
        Name = "AddWindow"
        Text = "Add a reminder"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ReminderTitleBox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReminderDescBox As RichTextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ReminderDatePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents ExButton As Button
End Class
