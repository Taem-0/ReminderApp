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
        ReminderTitleBox.Location = New Point(168, 16)
        ReminderTitleBox.Margin = New Padding(5, 4, 5, 4)
        ReminderTitleBox.Name = "ReminderTitleBox"
        ReminderTitleBox.Size = New Size(228, 37)
        ReminderTitleBox.TabIndex = 0
        ReminderTitleBox.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 23)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter a reminder:"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ReminderDescBox
        ' 
        ReminderDescBox.Location = New Point(14, 139)
        ReminderDescBox.Margin = New Padding(3, 4, 3, 4)
        ReminderDescBox.Name = "ReminderDescBox"
        ReminderDescBox.Size = New Size(382, 221)
        ReminderDescBox.TabIndex = 2
        ReminderDescBox.Text = ""
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Location = New Point(15, 101)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(112, 25)
        ToolStrip1.TabIndex = 3
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ReminderDatePicker
        ' 
        ReminderDatePicker.Font = New Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ReminderDatePicker.Location = New Point(15, 399)
        ReminderDatePicker.Margin = New Padding(3, 4, 3, 4)
        ReminderDatePicker.Name = "ReminderDatePicker"
        ReminderDatePicker.Size = New Size(251, 24)
        ReminderDatePicker.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS PGothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 379)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 5
        Label2.Text = "Deadline:"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 72)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 15)
        Label3.TabIndex = 6
        Label3.Text = "Enter description:"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' SaveButton
        ' 
        SaveButton.Location = New Point(218, 451)
        SaveButton.Margin = New Padding(3, 4, 3, 4)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(86, 31)
        SaveButton.TabIndex = 7
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' ExButton
        ' 
        ExButton.Location = New Point(311, 451)
        ExButton.Margin = New Padding(3, 4, 3, 4)
        ExButton.Name = "ExButton"
        ExButton.Size = New Size(86, 31)
        ExButton.TabIndex = 8
        ExButton.Text = "Cancel"
        ExButton.UseVisualStyleBackColor = True
        ' 
        ' AddWindow
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
        Margin = New Padding(5, 4, 5, 4)
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
