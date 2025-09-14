Imports System.Data.OleDb

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Logged in as: " & Form2.current_username
        LoadDB()
    End Sub


    Private Sub LoadDB()
        Dim db As New DBmanager()
        reminderView.DataSource = db.LoadDBdata()
        reminderView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub NewReminder_Click(sender As Object, e As EventArgs) Handles newReminder.Click
        AddWindow.Show()

    End Sub






End Class
