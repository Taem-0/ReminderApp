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

End Class
