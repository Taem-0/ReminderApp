Imports System.Data.OleDb

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Logged in as: " & LoginForm.current_username
        LoadDB()
        confirmButton.Visible = False
        ExButtonDeleteMode.Visible = False
        reminderView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub NewReminderButton_Click(sender As Object, e As EventArgs) Handles newReminderButton.Click
        AddWindow.ShowDialog()
    End Sub
    Private Sub NewReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewReminderToolStripMenuItem.Click
        AddWindow.ShowDialog()
    End Sub
    Private Sub NewReminderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewReminderToolStripMenuItem1.Click
        AddWindow.ShowDialog()
    End Sub

    Private Sub deleteReminderButton_Click(sender As Object, e As EventArgs) Handles deleteReminderButton.Click

        confirmButton.Visible = True
        ExButtonDeleteMode.Visible = True

        reminderView.MultiSelect = True
        reminderView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        deleteReminder()
    End Sub

    Private Sub ExButtonDeleteMode_Click(sender As Object, e As EventArgs) Handles ExButtonDeleteMode.Click

        reminderView.MultiSelect = True
        reminderView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        confirmButton.Visible = False
        ExButtonDeleteMode.Visible = False

    End Sub

    Public Sub LoadDB()
        Dim db As New DBmanager()

        reminderView.DataSource = db.LoadDBdata(LoginForm.current_username)
        reminderView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        reminderView.RowHeadersVisible = False

        If reminderView.Columns.Contains("ID") Then
            reminderView.Columns("ID").Visible = False
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

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles EditReminder_btn.Click
        ReminderController.UpdateClick()
    End Sub

    Private Sub EditReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditReminderToolStripMenuItem.Click
        ReminderController.UpdateClick()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        ReminderController.MarkDoneClick()
    End Sub
End Class
