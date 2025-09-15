Public Class UpdateWindow

    Public ReminderID As Integer
    Public ReminderTitle As String
    Public ReminderDesc As String
    Public ReminderDate As DateTime

    Private Sub UpdateWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReminderTitleBox.Text = ReminderTitle
        ReminderDescBox.Text = ReminderDesc
        ReminderDatePicker.Value = ReminderDate
    End Sub

    Private Sub ReminderDescBox_TextChanged(sender As Object, e As EventArgs) Handles ReminderDescBox.TextChanged

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim reminder As New Reminder()
        reminder.Reminder = ReminderTitleBox.Text
        reminder.Description = ReminderDescBox.Text
        reminder.Deadline = ReminderDatePicker.Value

        ReminderController.UpdateReminder(ReminderID, reminder)

        Me.Close()
    End Sub

    Private Sub ExButton_Click(sender As Object, e As EventArgs) Handles ExButton.Click
        Me.Close()
    End Sub
End Class