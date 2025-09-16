Imports System.Data.OleDb

Public Class DBmanager
    Private ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\ms_access_stuff\reminderAppDB.accdb;"

    Public Function LoadDBdata(username As String, Optional filter As String = "", Optional column As String = "", Optional orderBy As String = "ASC") As DataTable

        Dim query As String = "SELECT ID, Reminder, Description, Deadline, Done FROM Reminders WHERE username = ?"
        Dim finalQuery As String = query

        If filter <> "" Then
            finalQuery &= " " & filter
        End If

        If column <> "" Then
            finalQuery &= " ORDER BY " & column & " " & orderBy
        End If

        Dim data As New DataTable()

        Try

            Using connection As New OleDbConnection(connectionString)
                Using cmd As New OleDbCommand(finalQuery, connection)
                    cmd.Parameters.Add("@username", OleDbType.VarWChar).Value = username
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(data)
                    End Using
                End Using
                connection.Close()
            End Using

        Catch ex As Exception

        End Try


        Return data

    End Function

    Public Function SortedDBdata(username As String, column As String, orderBy As String)

        Dim query As String = "SELECT ID, Reminder, Description, Deadline, Done FROM Reminders WHERE username = ?"

        Dim finalQuery As String = query & " ORDER BY " & column & " " & orderBy

        Dim data As New DataTable()

        Try

            Using connection As New OleDbConnection(connectionString)
                Using cmd As New OleDbCommand(finalQuery, connection)
                    cmd.Parameters.Add("@username", OleDbType.VarWChar).Value = username
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(data)
                    End Using
                End Using
                connection.Close()
            End Using

        Catch ex As Exception

        End Try

        Return data

    End Function

End Class
