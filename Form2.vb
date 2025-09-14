Public Class Form2
    Public Enum PanelType
        LOGIN
        REGISTER
    End Enum
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterPanel()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterPanel()
        hidePanels()
    End Sub
    Private Sub hidePanels()
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

        Login_username.Text = ""
        Login_password.Text = ""

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

    Private Sub Register_btnRegister_Click(sender As Object, e As EventArgs) Handles Register_btnRegister.Click

    End Sub



    'LOGIN_PANEL stuff
    Private Sub LOGIN_PANEL_Paint(sender As Object, e As PaintEventArgs) Handles LOGIN_PANEL.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Show_panel(PanelType.REGISTER)
        Register_username.Focus()
    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click

        If Login_username.Text = "admin" And Login_password.Text = "admin" Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form1.ShowDialog()
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

    Private Sub Login_username_TextChanged(sender As Object, e As EventArgs) Handles Login_username.TextChanged

    End Sub
End Class