Imports System.Data.OleDb

Public Class Form2
    Private Enum PanelType
        LOGIN
        REGISTER
    End Enum

    Public current_username As String

    Dim Conn_String As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\ms_access_stuff\Database1.accdb;"
    Dim Conn As New OleDbConnection(Conn_String)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterPanel()
        Login_password.UseSystemPasswordChar = True
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterPanel()
        HidePanels()
    End Sub
    Private Sub HidePanels()
        REGISTER_PANEL.Visible = False
        LOGIN_PANEL.Visible = True
    End Sub
    Private Sub CenterPanel()
        REGISTER_PANEL.Left = (Me.ClientSize.Width - REGISTER_PANEL.Width) \ 2
        REGISTER_PANEL.Top = (Me.ClientSize.Height - REGISTER_PANEL.Height) \ 2
        LOGIN_PANEL.Left = (Me.ClientSize.Width - LOGIN_PANEL.Width) \ 2
        LOGIN_PANEL.Top = (Me.ClientSize.Height - LOGIN_PANEL.Height) \ 2
    End Sub

    Private Sub Show_panel(paneltoshow As PanelType)

        LOGIN_PANEL.Visible = False
        REGISTER_PANEL.Visible = False

        Register_username.Text = ""
        Register_password.Text = ""
        Register_confirmpass.Text = ""
        Register_showpass.Checked = False


        Login_username.Text = ""
        Login_password.Text = ""
        Login_showpass.Checked = False

        Select Case paneltoshow
            Case PanelType.LOGIN
                LOGIN_PANEL.Visible = True
            Case PanelType.REGISTER
                REGISTER_PANEL.Visible = True
        End Select

    End Sub


    'REGISTER_PANEL stuff
    Private Sub REGISTER_PANEL_Paint(sender As Object, e As PaintEventArgs) Handles REGISTER_PANEL.Paint

    End Sub
    Private Sub Register_username_TextChanged(sender As Object, e As EventArgs) Handles Register_username.TextChanged

    End Sub

    Private Sub Register_password_TextChanged(sender As Object, e As EventArgs) Handles Register_password.TextChanged

    End Sub

    Private Sub Register_confirmpass_TextChanged(sender As Object, e As EventArgs) Handles Register_confirmpass.TextChanged

    End Sub

    Private Sub Register_email_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Register_btnCancel_Click(sender As Object, e As EventArgs) Handles Register_btnCancel.Click
        Show_panel(PanelType.LOGIN)
        Login_username.Focus()
    End Sub
    Private Sub Register_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Register_showpass.CheckedChanged
        If Register_showpass.Checked Then
            Register_password.UseSystemPasswordChar = False
            Register_confirmpass.UseSystemPasswordChar = False
        Else
            Register_password.UseSystemPasswordChar = True
            Register_confirmpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Register_btnRegister_Click(sender As Object, e As EventArgs) Handles Register_btnRegister.Click

        If Register_username.Text.Length < 3 Then
            MessageBox.Show("Username must be at least 3 characters long.", "Username Too Short!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Register_username.Focus()
            Return
        End If

        If Register_password.Text.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters long.", "Password Too Weak!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Register_password.Focus()
            Return
        End If

        If Register_confirmpass.Text <> Register_password.Text Then
            MessageBox.Show("Passwords do not match.", "Password Mismatch!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Register_confirmpass.Focus()
            Return
        End If

        Try
            Using cmd As New OleDbCommand("INSERT INTO Accounts ([USERNAME], [PASSWORD], [EMAIL]) VALUES (@Username, @Password, @Email)", Conn)

                cmd.Parameters.AddWithValue("@Username", Register_username.Text)
                cmd.Parameters.AddWithValue("@Password", Register_password.Text)

                Conn.Open()
                cmd.ExecuteNonQuery()
                Conn.Close()

                MessageBox.Show("Account registered successfully!")
                Show_panel(PanelType.LOGIN)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub



    'LOGIN_PANEL stuff
    Private Function CheckCredentials(username As String, password As String) As Boolean
        Dim result As Boolean = False
        Try
            Using cmd As New OleDbCommand("SELECT * FROM Accounts WHERE [USERNAME] = @Username AND [PASSWORD] = @Password", Conn)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)

                Conn.Open()
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        result = True
                    End If
                End Using
                Conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
        Return result
    End Function

    Private Sub LOGIN_PANEL_Paint(sender As Object, e As PaintEventArgs) Handles LOGIN_PANEL.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Show_panel(PanelType.REGISTER)
        Register_username.Focus()
    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click

        If Login_username.Text = "admin" And Login_password.Text = "admin" Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            current_username = Login_username.Text
            Me.Hide()
            MainForm.ShowDialog()
            Me.Show()
            Login_username.Text = ""
            Login_password.Text = ""
            Login_username.Focus()
        ElseIf CheckCredentials(Login_username.Text, Login_password.Text) Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            current_username = Login_username.Text
            Me.Hide()
            MainForm.ShowDialog()
            Me.Show()
            Login_username.Text = ""
            Login_password.Text = ""
            Login_username.Focus()
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Login_username.Text = ""
            Login_password.Text = ""
            Login_username.Focus()
        End If

    End Sub

    Private Sub Login_password_TextChanged(sender As Object, e As EventArgs) Handles Login_password.TextChanged

    End Sub

    Private Sub Login_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Login_showpass.CheckedChanged
        If Login_showpass.Checked Then
            Login_password.UseSystemPasswordChar = False
        Else
            Login_password.UseSystemPasswordChar = True
        End If
    End Sub

End Class