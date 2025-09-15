Public Class AddWindow
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ProcessAdd()
        MainForm.LoadDB()
        Me.Close()
    End Sub

    Private Sub ExButton_Click(sender As Object, e As EventArgs) Handles ExButton.Click
        Me.Close()
    End Sub

    Private Sub ProcessAdd()

        Dim reminderTitle As String = ReminderTitleBox.Text

        Dim reminderDescription As String = ReminderDescBox.Text

        Dim reminderDate As DateTime = ReminderDatePicker.Value

        Dim reminder As New Reminder()

        reminder.Reminder = reminderTitle
        reminder.Description = reminderDescription
        reminder.Deadline = reminderDate

        ReminderController.PostReminder(reminder)

    End Sub


End Class