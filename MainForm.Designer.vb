<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewReminderToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        NewReminderToolStripMenuItem1 = New ToolStripMenuItem()
        EditReminderToolStripMenuItem = New ToolStripMenuItem()
        DeleteReminderToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        ShowAllSort = New ToolStripMenuItem()
        ShowTodaySort = New ToolStripMenuItem()
        ShowUpcomingSort = New ToolStripMenuItem()
        ShowCompletedSort = New ToolStripMenuItem()
        SortByToolStripMenuItem = New ToolStripMenuItem()
        SortByReminder = New ToolStripMenuItem()
        SortByDateMan = New ToolStripMenuItem()
        SortByStatus = New ToolStripMenuItem()
        TitleCard = New Panel()
        TextBox1 = New TextBox()
        ToolStrip1 = New ToolStrip()
        newReminderButton = New ToolStripLabel()
        ToolStripLabel2 = New ToolStripLabel()
        deleteReminderButton = New ToolStripLabel()
        ToolStripLabel5 = New ToolStripLabel()
        reminderView = New DataGridView()
        Label1 = New Label()
        confirmButton = New Button()
        ExButtonDeleteMode = New Button()
        Panel2 = New Panel()
        MenuStrip1.SuspendLayout()
        TitleCard.SuspendLayout()
        ToolStrip1.SuspendLayout()
        CType(reminderView, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(360, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewReminderToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewReminderToolStripMenuItem
        ' 
        NewReminderToolStripMenuItem.Name = "NewReminderToolStripMenuItem"
        NewReminderToolStripMenuItem.Size = New Size(149, 22)
        NewReminderToolStripMenuItem.Text = "New reminder"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(149, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewReminderToolStripMenuItem1, EditReminderToolStripMenuItem, DeleteReminderToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' NewReminderToolStripMenuItem1
        ' 
        NewReminderToolStripMenuItem1.Name = "NewReminderToolStripMenuItem1"
        NewReminderToolStripMenuItem1.Size = New Size(158, 22)
        NewReminderToolStripMenuItem1.Text = "New reminder"
        ' 
        ' EditReminderToolStripMenuItem
        ' 
        EditReminderToolStripMenuItem.Name = "EditReminderToolStripMenuItem"
        EditReminderToolStripMenuItem.Size = New Size(158, 22)
        EditReminderToolStripMenuItem.Text = "Edit reminder"
        ' 
        ' DeleteReminderToolStripMenuItem
        ' 
        DeleteReminderToolStripMenuItem.Name = "DeleteReminderToolStripMenuItem"
        DeleteReminderToolStripMenuItem.Size = New Size(158, 22)
        DeleteReminderToolStripMenuItem.Text = "Delete reminder"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ShowAllSort, ShowTodaySort, ShowUpcomingSort, ShowCompletedSort, SortByToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(44, 20)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' ShowAllSort
        ' 
        ShowAllSort.Name = "ShowAllSort"
        ShowAllSort.Size = New Size(180, 22)
        ShowAllSort.Text = "Show all"
        ' 
        ' ShowTodaySort
        ' 
        ShowTodaySort.Name = "ShowTodaySort"
        ShowTodaySort.Size = New Size(180, 22)
        ShowTodaySort.Text = "Show today"
        ' 
        ' ShowUpcomingSort
        ' 
        ShowUpcomingSort.Name = "ShowUpcomingSort"
        ShowUpcomingSort.Size = New Size(180, 22)
        ShowUpcomingSort.Text = "Show upcoming"
        ' 
        ' ShowCompletedSort
        ' 
        ShowCompletedSort.Name = "ShowCompletedSort"
        ShowCompletedSort.Size = New Size(180, 22)
        ShowCompletedSort.Text = "Show completed"
        ' 
        ' SortByToolStripMenuItem
        ' 
        SortByToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SortByReminder, SortByDateMan, SortByStatus})
        SortByToolStripMenuItem.Name = "SortByToolStripMenuItem"
        SortByToolStripMenuItem.Size = New Size(180, 22)
        SortByToolStripMenuItem.Text = "Sort by"
        ' 
        ' SortByReminder
        ' 
        SortByReminder.Name = "SortByReminder"
        SortByReminder.Size = New Size(125, 22)
        SortByReminder.Text = "Reminder"
        ' 
        ' SortByDateMan
        ' 
        SortByDateMan.Name = "SortByDateMan"
        SortByDateMan.Size = New Size(125, 22)
        SortByDateMan.Text = "Due date"
        ' 
        ' SortByStatus
        ' 
        SortByStatus.Name = "SortByStatus"
        SortByStatus.Size = New Size(125, 22)
        SortByStatus.Text = "Status"
        ' 
        ' TitleCard
        ' 
        TitleCard.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TitleCard.Controls.Add(TextBox1)
        TitleCard.Location = New Point(0, 27)
        TitleCard.Name = "TitleCard"
        TitleCard.Size = New Size(359, 79)
        TitleCard.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.ControlText
        TextBox1.Location = New Point(45, 0)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(275, 77)
        TextBox1.TabIndex = 0
        TextBox1.TabStop = False
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {newReminderButton, ToolStripLabel2, deleteReminderButton, ToolStripLabel5})
        ToolStrip1.Location = New Point(0, 109)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(162, 25)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' newReminderButton
        ' 
        newReminderButton.Name = "newReminderButton"
        newReminderButton.Size = New Size(31, 22)
        newReminderButton.Text = "New"
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(0, 22)
        ' 
        ' deleteReminderButton
        ' 
        deleteReminderButton.Name = "deleteReminderButton"
        deleteReminderButton.Size = New Size(40, 22)
        deleteReminderButton.Text = "Delete"
        ' 
        ' ToolStripLabel5
        ' 
        ToolStripLabel5.Name = "ToolStripLabel5"
        ToolStripLabel5.Size = New Size(79, 22)
        ToolStripLabel5.Text = "Mark as Done"
        ' 
        ' reminderView
        ' 
        reminderView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        reminderView.BackgroundColor = SystemColors.Control
        reminderView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        reminderView.GridColor = SystemColors.Window
        reminderView.Location = New Point(0, 137)
        reminderView.Name = "reminderView"
        reminderView.RowHeadersWidth = 51
        reminderView.Size = New Size(360, 287)
        reminderView.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' confirmButton
        ' 
        confirmButton.Dock = DockStyle.Right
        confirmButton.Location = New Point(210, 0)
        confirmButton.Name = "confirmButton"
        confirmButton.Size = New Size(75, 30)
        confirmButton.TabIndex = 5
        confirmButton.Text = "Confirm"
        confirmButton.UseVisualStyleBackColor = True
        ' 
        ' ExButtonDeleteMode
        ' 
        ExButtonDeleteMode.Dock = DockStyle.Right
        ExButtonDeleteMode.Location = New Point(285, 0)
        ExButtonDeleteMode.Name = "ExButtonDeleteMode"
        ExButtonDeleteMode.Size = New Size(75, 30)
        ExButtonDeleteMode.TabIndex = 6
        ExButtonDeleteMode.Text = "Cancel"
        ExButtonDeleteMode.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(confirmButton)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ExButtonDeleteMode)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 446)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(360, 30)
        Panel2.TabIndex = 7
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(360, 476)
        Controls.Add(Panel2)
        Controls.Add(reminderView)
        Controls.Add(ToolStrip1)
        Controls.Add(TitleCard)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TitleCard.ResumeLayout(False)
        TitleCard.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(reminderView, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewReminderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewReminderToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteReminderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowCompletedSort As ToolStripMenuItem
    Friend WithEvents SortByToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortByReminder As ToolStripMenuItem
    Friend WithEvents SortByDateMan As ToolStripMenuItem
    Friend WithEvents SortByStatus As ToolStripMenuItem
    Friend WithEvents TitleCard As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents newReminderButton As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents deleteReminderButton As ToolStripLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents reminderView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents confirmButton As Button
    Friend WithEvents ExButtonDeleteMode As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents EditReminderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ShowAllSort As ToolStripMenuItem
    Friend WithEvents ShowTodaySort As ToolStripMenuItem
    Friend WithEvents ShowUpcomingSort As ToolStripMenuItem

End Class
