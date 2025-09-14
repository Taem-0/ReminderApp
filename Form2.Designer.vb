<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblUsername = New Label()
        Register_username = New TextBox()
        lblPassword = New Label()
        Register_password = New TextBox()
        Register_btnRegister = New Button()
        Register_btnCancel = New Button()
        REGISTER_PANEL = New Panel()
        Register_showpass = New CheckBox()
        Label5 = New Label()
        Register_confirmpass = New TextBox()
        LOGIN_PANEL = New Panel()
        Login_showpass = New CheckBox()
        LinkLabel1 = New LinkLabel()
        Label1 = New Label()
        Label2 = New Label()
        Login_btn = New Button()
        Login_username = New TextBox()
        Label3 = New Label()
        Login_password = New TextBox()
        REGISTER_PANEL.SuspendLayout()
        LOGIN_PANEL.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ActiveCaptionText
        lblTitle.Location = New Point(190, 27)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(305, 40)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Account Registration"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 13.8F)
        lblUsername.ForeColor = SystemColors.ActiveCaptionText
        lblUsername.Location = New Point(83, 97)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(122, 31)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username:"
        ' 
        ' Register_username
        ' 
        Register_username.Location = New Point(209, 97)
        Register_username.Name = "Register_username"
        Register_username.Size = New Size(286, 27)
        Register_username.TabIndex = 2
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 13.8F)
        lblPassword.ForeColor = SystemColors.ActiveCaptionText
        lblPassword.Location = New Point(90, 147)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(115, 31)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password:"
        ' 
        ' Register_password
        ' 
        Register_password.Location = New Point(211, 147)
        Register_password.Name = "Register_password"
        Register_password.Size = New Size(284, 27)
        Register_password.TabIndex = 4
        ' 
        ' Register_btnRegister
        ' 
        Register_btnRegister.BackColor = SystemColors.GradientActiveCaption
        Register_btnRegister.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Register_btnRegister.Location = New Point(211, 293)
        Register_btnRegister.Name = "Register_btnRegister"
        Register_btnRegister.Size = New Size(119, 35)
        Register_btnRegister.TabIndex = 7
        Register_btnRegister.Text = "Register"
        Register_btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Register_btnCancel
        ' 
        Register_btnCancel.BackColor = SystemColors.GradientActiveCaption
        Register_btnCancel.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Register_btnCancel.Location = New Point(376, 293)
        Register_btnCancel.Name = "Register_btnCancel"
        Register_btnCancel.Size = New Size(119, 35)
        Register_btnCancel.TabIndex = 8
        Register_btnCancel.Text = "Cancel"
        Register_btnCancel.UseVisualStyleBackColor = False
        ' 
        ' REGISTER_PANEL
        ' 
        REGISTER_PANEL.Controls.Add(Register_showpass)
        REGISTER_PANEL.Controls.Add(Label5)
        REGISTER_PANEL.Controls.Add(Register_confirmpass)
        REGISTER_PANEL.Controls.Add(lblTitle)
        REGISTER_PANEL.Controls.Add(Register_btnCancel)
        REGISTER_PANEL.Controls.Add(lblUsername)
        REGISTER_PANEL.Controls.Add(Register_btnRegister)
        REGISTER_PANEL.Controls.Add(Register_username)
        REGISTER_PANEL.Controls.Add(lblPassword)
        REGISTER_PANEL.Controls.Add(Register_password)
        REGISTER_PANEL.Location = New Point(12, 12)
        REGISTER_PANEL.Name = "REGISTER_PANEL"
        REGISTER_PANEL.Size = New Size(564, 331)
        REGISTER_PANEL.TabIndex = 9
        ' 
        ' Register_showpass
        ' 
        Register_showpass.AutoSize = True
        Register_showpass.Location = New Point(209, 230)
        Register_showpass.Name = "Register_showpass"
        Register_showpass.Size = New Size(134, 24)
        Register_showpass.TabIndex = 11
        Register_showpass.Text = "Show password"
        Register_showpass.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(8, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(202, 31)
        Label5.TabIndex = 9
        Label5.Text = "Confirm Password:"
        ' 
        ' Register_confirmpass
        ' 
        Register_confirmpass.Location = New Point(211, 196)
        Register_confirmpass.Name = "Register_confirmpass"
        Register_confirmpass.Size = New Size(284, 27)
        Register_confirmpass.TabIndex = 10
        ' 
        ' LOGIN_PANEL
        ' 
        LOGIN_PANEL.Controls.Add(Login_showpass)
        LOGIN_PANEL.Controls.Add(LinkLabel1)
        LOGIN_PANEL.Controls.Add(Label1)
        LOGIN_PANEL.Controls.Add(Label2)
        LOGIN_PANEL.Controls.Add(Login_btn)
        LOGIN_PANEL.Controls.Add(Login_username)
        LOGIN_PANEL.Controls.Add(Label3)
        LOGIN_PANEL.Controls.Add(Login_password)
        LOGIN_PANEL.Location = New Point(582, 12)
        LOGIN_PANEL.Name = "LOGIN_PANEL"
        LOGIN_PANEL.Size = New Size(564, 331)
        LOGIN_PANEL.TabIndex = 10
        ' 
        ' Login_showpass
        ' 
        Login_showpass.AutoSize = True
        Login_showpass.Location = New Point(209, 180)
        Login_showpass.Name = "Login_showpass"
        Login_showpass.Size = New Size(134, 24)
        Login_showpass.TabIndex = 10
        Login_showpass.Text = "Show password"
        Login_showpass.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Orchid
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 11F)
        LinkLabel1.LinkColor = Color.Blue
        LinkLabel1.Location = New Point(161, 277)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(334, 25)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Don't have an Account yet? Click here!"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(259, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 40)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(83, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 31)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Login_btn
        ' 
        Login_btn.BackColor = SystemColors.GradientActiveCaption
        Login_btn.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Login_btn.Location = New Point(279, 226)
        Login_btn.Name = "Login_btn"
        Login_btn.Size = New Size(119, 35)
        Login_btn.TabIndex = 7
        Login_btn.Text = "Login"
        Login_btn.UseVisualStyleBackColor = False
        ' 
        ' Login_username
        ' 
        Login_username.Location = New Point(209, 97)
        Login_username.Name = "Login_username"
        Login_username.Size = New Size(286, 27)
        Login_username.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(90, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 31)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' Login_password
        ' 
        Login_password.Location = New Point(211, 147)
        Login_password.Name = "Login_password"
        Login_password.Size = New Size(284, 27)
        Login_password.TabIndex = 4
        ' 
        ' Form2
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(661, 545)
        Controls.Add(LOGIN_PANEL)
        Controls.Add(REGISTER_PANEL)
        Name = "Form2"
        Text = "Registration Form"
        REGISTER_PANEL.ResumeLayout(False)
        REGISTER_PANEL.PerformLayout()
        LOGIN_PANEL.ResumeLayout(False)
        LOGIN_PANEL.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Register_username As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents Register_password As TextBox
    Friend WithEvents Register_btnRegister As Button
    Friend WithEvents Register_btnCancel As Button
    Friend WithEvents REGISTER_PANEL As Panel
    Friend WithEvents LOGIN_PANEL As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Login_btn As Button
    Friend WithEvents Login_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Login_password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Register_confirmpass As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Login_showpass As CheckBox
    Friend WithEvents Register_showpass As CheckBox
End Class
