Public Class MainForm

    'mga variambles man
    Dim db As New DBmanager()
    Dim sortDirection As Boolean = True

    'Pindutan ng bagong palatandaan

    Private Sub NewReminderButton_Click(sender As Object, e As EventArgs) Handles newReminderButton.Click
        Dim newWindow As New AddWindow()
        newWindow.ShowDialog()

    End Sub
    Private Sub NewReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewReminderToolStripMenuItem.Click
        Dim newWindow As New AddWindow()
        newWindow.ShowDialog()

    End Sub
    Private Sub NewReminderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewReminderToolStripMenuItem1.Click
        Dim newWindow As New AddWindow()
        newWindow.ShowDialog()

    End Sub

    'Pindutan ng pagtanggal ng palatandaan

    Private Sub DeleteReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteReminderToolStripMenuItem.Click

        confirmButton.Visible = True
        ExButtonDeleteMode.Visible = True

        reminderView.MultiSelect = True
        reminderView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub deleteReminderButton_Click(sender As Object, e As EventArgs) Handles deleteReminderButton.Click

        confirmButton.Visible = True
        ExButtonDeleteMode.Visible = True

        reminderView.MultiSelect = True
        reminderView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub ExButtonDeleteMode_Click(sender As Object, e As EventArgs) Handles ExButtonDeleteMode.Click

        reminderView.MultiSelect = True
        reminderView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        confirmButton.Visible = False
        ExButtonDeleteMode.Visible = False

    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        deleteReminder()
    End Sub

    'Tool strippppsss

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        ReminderController.MarkDoneClick()
    End Sub


    'Mga paraan:

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Logged in as: " & LoginForm.current_username
        LoadDB()
        confirmButton.Visible = False
        ExButtonDeleteMode.Visible = False
        reminderView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Public Sub LoadDB()

        reminderView.DataSource = db.LoadDBdata(LoginForm.current_username)
        reminderView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        reminderView.RowHeadersVisible = False

        If reminderView.Columns.Contains("ID") Then
            reminderView.Columns("ID").Visible = False
        End If

        If reminderView.Columns.Contains("Description") Then
            reminderView.Columns("Description").Visible = False
        End If

        If reminderView.Columns.Contains("Description") Then
            reminderView.Columns("Description").Visible = False
        End If

    End Sub

    Private Sub deleteReminder()

        For Each row As DataGridViewRow In reminderView.SelectedRows
            Try
                Dim idToDelete As Integer = Convert.ToInt32(row.Cells("ID").Value)
                ReminderController.DeleteReminder(idToDelete)

                reminderView.Rows.Remove(row)
            Catch ex As Exception
                MessageBox.Show("cant delete empty row")
            End Try

        Next

        confirmButton.Visible = False
        ExButtonDeleteMode.Visible = False

    End Sub

    Private Sub reminderView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles reminderView.CellContentClick
        ReminderController.UpdateClick()
    End Sub

    Private Sub EditReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditReminderToolStripMenuItem.Click
        ReminderController.UpdateClick()
    End Sub

    'SOrting events, tangina man inaantok na aakooooo !! 

    Private Sub SortByReminder_Click(sender As Object, e As EventArgs) Handles SortByReminder.Click

        If sortDirection = True Then
            reminderView.DataSource = db.SortedDBdata(LoginForm.current_username, "Reminder", "DESC")
            sortDirection = False
        ElseIf sortDirection = False Then
            reminderView.DataSource = db.SortedDBdata(LoginForm.current_username, "Reminder", "ASC")
            sortDirection = True
        End If

    End Sub

    Private Sub SortByDateMan_Click(sender As Object, e As EventArgs) Handles SortByDateMan.Click

        If sortDirection = True Then
            reminderView.DataSource = db.SortedDBdata(LoginForm.current_username, "Deadline", "DESC")
            sortDirection = False
        ElseIf sortDirection = False Then
            reminderView.DataSource = db.SortedDBdata(LoginForm.current_username, "Deadline", "ASC")
            sortDirection = True
        End If

    End Sub

    Private Sub SortByStatus_Click(sender As Object, e As EventArgs) Handles SortByStatus.Click
        If sortDirection = True Then
            reminderView.DataSource = db.SortedDBdata(LoginForm.current_username, "Done", "DESC")
            sortDirection = False
        ElseIf sortDirection = False Then
            reminderView.DataSource = db.SortedDBdata(LoginForm.current_username, "Done", "ASC")
            sortDirection = True
        End If
    End Sub

    Private Sub ShowAllSort_Click(sender As Object, e As EventArgs) Handles ShowAllSort.Click
        reminderView.DataSource = db.LoadDBdata(LoginForm.current_username)
    End Sub

    Private Sub ShowTodaySort_Click(sender As Object, e As EventArgs) Handles ShowTodaySort.Click
        reminderView.DataSource = db.LoadDBdata(LoginForm.current_username, "AND DateValue([Deadline]) = Date()")
    End Sub

    Private Sub ShowUpcomingSort_Click(sender As Object, e As EventArgs) Handles ShowUpcomingSort.Click
        reminderView.DataSource = db.LoadDBdata(LoginForm.current_username, "AND DateValue([Deadline]) > Date()")
    End Sub

    Private Sub ShowCompletedSort_Click(sender As Object, e As EventArgs) Handles ShowCompletedSort.Click
        reminderView.DataSource = db.LoadDBdata(LoginForm.current_username, "AND Done = 'Yes'")
    End Sub
End Class
