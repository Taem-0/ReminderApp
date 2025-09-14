Imports System.Data.OleDb

Public Class DBmanager
    Private ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Source\Repos\ReminderApp\ms_access_stuff\reminderAppDB.accdb;"

    Public Function LoadDBdata() As DataTable
        Dim query As String = "SELECT Reminder, Description, Deadline, Done FROM Reminders;"
        Dim data As New DataTable()

        Using connection As New OleDbConnection(connectionString)
            Using cmd As New OleDbCommand(query, connection)
                Using adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(data)
                End Using
            End Using
        End Using


        Return data
    End Function

End Class
