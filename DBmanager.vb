Imports System.Data.OleDb

Public Class DBmanager
    Private ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\ms_access_stuff\reminderAppDB.accdb;"

    Public Function LoadDBdata(username As String) As DataTable
        Dim query As String = "SELECT Reminder, Description, Deadline, Done FROM Reminders WHERE username = ?"
        Dim data As New DataTable()

        Using connection As New OleDbConnection(connectionString)
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.Add("@username", OleDbType.VarWChar).Value = username
                Using adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(data)
                End Using
            End Using
        End Using


        Return data
    End Function

End Class
