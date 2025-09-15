Imports System.Data.OleDb

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Logged in as: " & LoginForm.current_username
        LoadDB()
    End Sub


    Public Sub LoadDB()
        Dim db As New DBmanager()
        reminderView.DataSource = db.LoadDBdata(LoginForm.current_username)
        reminderView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        reminderView.RowHeadersVisible = False
    End Sub

    Private Sub NewReminder_Click(sender As Object, e As EventArgs) Handles newReminder.Click
        AddWindow.ShowDialog()
    End Sub


End Class
