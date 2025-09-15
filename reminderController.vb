Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class ReminderController

    Private Shared connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\ms_access_stuff\reminderAppDB.accdb;"

    Public Shared Sub PostReminder(reminder As Reminder)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using cmd As New OleDbCommand("INSERT INTO Reminders (Reminder, Description, Deadline, Done, Username) VALUES (?, ?, ?, ?, ?)", connection)
                cmd.Parameters.Add("@reminder", OleDbType.VarWChar).Value = reminder.Reminder
                cmd.Parameters.Add("@description", OleDbType.VarWChar).Value = reminder.Description
                cmd.Parameters.Add("@deadline", OleDbType.Date).Value = reminder.Deadline
                cmd.Parameters.Add("@done", OleDbType.VarWChar).Value = reminder.Done
                cmd.Parameters.Add("@username", OleDbType.VarWChar).Value = LoginForm.current_username

                cmd.ExecuteNonQuery()
            End Using

            connection.Close()

        End Using
    End Sub

    Public Shared Sub DeleteReminder(idToDelete As Integer)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using cmd As New OleDbCommand("DELETE FROM Reminders WHERE ID = ?", connection)
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = idToDelete

                cmd.ExecuteNonQuery()
            End Using

            connection.Close()
        End Using
    End Sub


    Public Shared Sub UpdateReminder(idToUpdate As Integer, updatedReminder As Reminder)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Using cmd As New OleDbCommand("UPDATE Reminders SET Reminder = ?, Description = ?, Deadline = ?, Done = ? WHERE ID = ?", connection)
                cmd.Parameters.Add("@reminder", OleDbType.VarWChar).Value = updatedReminder.Reminder
                cmd.Parameters.Add("@description", OleDbType.VarWChar).Value = updatedReminder.Description
                cmd.Parameters.Add("@deadline", OleDbType.Date).Value = updatedReminder.Deadline
                cmd.Parameters.Add("@done", OleDbType.VarWChar).Value = updatedReminder.Done
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = idToUpdate
                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using
    End Sub

    Public Shared Sub UpdateClick()

        MainForm.reminderView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        If MainForm.reminderView.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a reminder to edit.")
            Return
        End If

        Dim row As DataGridViewRow = MainForm.reminderView.SelectedRows(0)

        If row.Cells("ID").Value Is Nothing OrElse IsDBNull(row.Cells("ID").Value) Then
            MessageBox.Show("Invalid reminder selected.")
            Return
        End If

        UpdateWindow.ReminderID = Convert.ToInt32(row.Cells("ID").Value)
        UpdateWindow.ReminderTitle = row.Cells("Reminder").Value.ToString()
        UpdateWindow.ReminderDesc = row.Cells("Description").Value.ToString()
        UpdateWindow.ReminderDate = Convert.ToDateTime(row.Cells("Deadline").Value)

        UpdateWindow.ShowDialog()
        MainForm.LoadDB()

    End Sub

    Public Shared Sub MarkAsDone(idToUpdate As Integer, doneStatus As String)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Using cmd As New OleDbCommand("UPDATE Reminders SET Done = ? WHERE ID = ?", connection)
                cmd.Parameters.Add("@done", OleDbType.VarWChar).Value = doneStatus
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = idToUpdate
                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using
    End Sub

    Public Shared Sub MarkDoneClick()
        MainForm.reminderView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If MainForm.reminderView.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a reminder to mark as done.")
            Return
        End If
        Dim row As DataGridViewRow = MainForm.reminderView.SelectedRows(0)
        If row.Cells("ID").Value Is Nothing OrElse IsDBNull(row.Cells("ID").Value) Then
            MessageBox.Show("Invalid reminder selected.")
            Return
        End If
        Dim reminderID As Integer = Convert.ToInt32(row.Cells("ID").Value)
        Dim currentStatus As String = row.Cells("Done").Value.ToString()
        Dim newStatus As String = If(currentStatus = "Yes", "No", "Yes")
        MarkAsDone(reminderID, newStatus)
        MainForm.LoadDB()
    End Sub

End Class
