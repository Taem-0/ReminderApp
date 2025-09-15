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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewReminderToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        NewReminderToolStripMenuItem1 = New ToolStripMenuItem()
        EditReminderToolStripMenuItem = New ToolStripMenuItem()
        DeleteReminderToolStripMenuItem = New ToolStripMenuItem()
        MarkAsDoneToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        ShowAllToolStripMenuItem = New ToolStripMenuItem()
        ShowTodayToolStripMenuItem = New ToolStripMenuItem()
        ShowUpcomingToolStripMenuItem = New ToolStripMenuItem()
        ShowCompletedToolStripMenuItem = New ToolStripMenuItem()
        SortByToolStripMenuItem = New ToolStripMenuItem()
        TitleToolStripMenuItem = New ToolStripMenuItem()
        DateToolStripMenuItem = New ToolStripMenuItem()
        DueDateToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        ToolStrip1 = New ToolStrip()
        newReminder = New ToolStripLabel()
        ToolStripLabel2 = New ToolStripLabel()
        ToolStripLabel3 = New ToolStripLabel()
        ToolStripLabel4 = New ToolStripLabel()
        ToolStripLabel5 = New ToolStripLabel()
        reminderView = New DataGridView()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        CType(reminderView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(627, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewReminderToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewReminderToolStripMenuItem
        ' 
        NewReminderToolStripMenuItem.Name = "NewReminderToolStripMenuItem"
        NewReminderToolStripMenuItem.Size = New Size(186, 26)
        NewReminderToolStripMenuItem.Text = "New reminder"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(186, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewReminderToolStripMenuItem1, EditReminderToolStripMenuItem, DeleteReminderToolStripMenuItem, MarkAsDoneToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' NewReminderToolStripMenuItem1
        ' 
        NewReminderToolStripMenuItem1.Name = "NewReminderToolStripMenuItem1"
        NewReminderToolStripMenuItem1.Size = New Size(200, 26)
        NewReminderToolStripMenuItem1.Text = "New reminder"
        ' 
        ' EditReminderToolStripMenuItem
        ' 
        EditReminderToolStripMenuItem.Name = "EditReminderToolStripMenuItem"
        EditReminderToolStripMenuItem.Size = New Size(200, 26)
        EditReminderToolStripMenuItem.Text = "Edit reminder"
        ' 
        ' DeleteReminderToolStripMenuItem
        ' 
        DeleteReminderToolStripMenuItem.Name = "DeleteReminderToolStripMenuItem"
        DeleteReminderToolStripMenuItem.Size = New Size(200, 26)
        DeleteReminderToolStripMenuItem.Text = "Delete reminder"
        ' 
        ' MarkAsDoneToolStripMenuItem
        ' 
        MarkAsDoneToolStripMenuItem.Name = "MarkAsDoneToolStripMenuItem"
        MarkAsDoneToolStripMenuItem.Size = New Size(200, 26)
        MarkAsDoneToolStripMenuItem.Text = "Mark as done"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ShowAllToolStripMenuItem, ShowTodayToolStripMenuItem, ShowUpcomingToolStripMenuItem, ShowCompletedToolStripMenuItem, SortByToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(55, 24)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' ShowAllToolStripMenuItem
        ' 
        ShowAllToolStripMenuItem.Name = "ShowAllToolStripMenuItem"
        ShowAllToolStripMenuItem.Size = New Size(204, 26)
        ShowAllToolStripMenuItem.Text = "Show all"
        ' 
        ' ShowTodayToolStripMenuItem
        ' 
        ShowTodayToolStripMenuItem.Name = "ShowTodayToolStripMenuItem"
        ShowTodayToolStripMenuItem.Size = New Size(204, 26)
        ShowTodayToolStripMenuItem.Text = "Show today"
        ' 
        ' ShowUpcomingToolStripMenuItem
        ' 
        ShowUpcomingToolStripMenuItem.Name = "ShowUpcomingToolStripMenuItem"
        ShowUpcomingToolStripMenuItem.Size = New Size(204, 26)
        ShowUpcomingToolStripMenuItem.Text = "Show upcoming"
        ' 
        ' ShowCompletedToolStripMenuItem
        ' 
        ShowCompletedToolStripMenuItem.Name = "ShowCompletedToolStripMenuItem"
        ShowCompletedToolStripMenuItem.Size = New Size(204, 26)
        ShowCompletedToolStripMenuItem.Text = "Show completed"
        ' 
        ' SortByToolStripMenuItem
        ' 
        SortByToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TitleToolStripMenuItem, DateToolStripMenuItem, DueDateToolStripMenuItem})
        SortByToolStripMenuItem.Name = "SortByToolStripMenuItem"
        SortByToolStripMenuItem.Size = New Size(204, 26)
        SortByToolStripMenuItem.Text = "Sort by"
        ' 
        ' TitleToolStripMenuItem
        ' 
        TitleToolStripMenuItem.Name = "TitleToolStripMenuItem"
        TitleToolStripMenuItem.Size = New Size(153, 26)
        TitleToolStripMenuItem.Text = "Title"
        ' 
        ' DateToolStripMenuItem
        ' 
        DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        DateToolStripMenuItem.Size = New Size(153, 26)
        DateToolStripMenuItem.Text = "Due date"
        ' 
        ' DueDateToolStripMenuItem
        ' 
        DueDateToolStripMenuItem.Name = "DueDateToolStripMenuItem"
        DueDateToolStripMenuItem.Size = New Size(153, 26)
        DueDateToolStripMenuItem.Text = "Status"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(0, 36)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(410, 105)
        Panel1.TabIndex = 1
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {newReminder, ToolStripLabel2, ToolStripLabel3, ToolStripLabel4, ToolStripLabel5})
        ToolStrip1.Location = New Point(0, 145)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(240, 25)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' newReminder
        ' 
        newReminder.Name = "newReminder"
        newReminder.Size = New Size(39, 22)
        newReminder.Text = "New"
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(0, 22)
        ' 
        ' ToolStripLabel3
        ' 
        ToolStripLabel3.Name = "ToolStripLabel3"
        ToolStripLabel3.Size = New Size(35, 22)
        ToolStripLabel3.Text = "Edit"
        ' 
        ' ToolStripLabel4
        ' 
        ToolStripLabel4.Name = "ToolStripLabel4"
        ToolStripLabel4.Size = New Size(53, 22)
        ToolStripLabel4.Text = "Delete"
        ' 
        ' ToolStripLabel5
        ' 
        ToolStripLabel5.Name = "ToolStripLabel5"
        ToolStripLabel5.Size = New Size(100, 22)
        ToolStripLabel5.Text = "Mark as Done"
        ' 
        ' reminderView
        ' 
        reminderView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        reminderView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        reminderView.Location = New Point(0, 183)
        reminderView.Margin = New Padding(3, 4, 3, 4)
        reminderView.Name = "reminderView"
        reminderView.RowHeadersWidth = 51
        reminderView.Size = New Size(627, 382)
        reminderView.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Bottom
        Label1.Location = New Point(0, 581)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(627, 601)
        Controls.Add(Label1)
        Controls.Add(reminderView)
        Controls.Add(ToolStrip1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "MainForm"
        Text = " "
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(reminderView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewReminderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewReminderToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditReminderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteReminderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkAsDoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowTodayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowUpcomingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowCompletedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortByToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DueDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents newReminder As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents reminderView As DataGridView
    Friend WithEvents Label1 As Label

End Class
