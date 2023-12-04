<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxConPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxFirst = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxLast = New System.Windows.Forms.TextBox()
        Me.TextBoxNickname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelErrorPass = New System.Windows.Forms.Label()
        Me.LabelErrorConPass = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelErrorUsername = New System.Windows.Forms.Label()
        Me.LabelNickName = New System.Windows.Forms.Label()
        Me.TextBoxPhoneNum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelCorrect = New System.Windows.Forms.Label()
        Me.DateTimePickerBirthday = New System.Windows.Forms.DateTimePicker()
        Me.LabelBirthday = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(173, 96)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(182, 22)
        Me.TextBoxUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(173, 140)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(182, 22)
        Me.TextBoxEmail.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(173, 183)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(182, 22)
        Me.TextBoxPassword.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'TextBoxConPass
        '
        Me.TextBoxConPass.Location = New System.Drawing.Point(173, 230)
        Me.TextBoxConPass.Name = "TextBoxConPass"
        Me.TextBoxConPass.Size = New System.Drawing.Size(182, 22)
        Me.TextBoxConPass.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Confirm Password"
        '
        'TextBoxFirst
        '
        Me.TextBoxFirst.Location = New System.Drawing.Point(173, 272)
        Me.TextBoxFirst.Name = "TextBoxFirst"
        Me.TextBoxFirst.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxFirst.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Name"
        '
        'TextBoxLast
        '
        Me.TextBoxLast.Location = New System.Drawing.Point(279, 270)
        Me.TextBoxLast.Name = "TextBoxLast"
        Me.TextBoxLast.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxLast.TabIndex = 0
        '
        'TextBoxNickname
        '
        Me.TextBoxNickname.Location = New System.Drawing.Point(173, 321)
        Me.TextBoxNickname.Name = "TextBoxNickname"
        Me.TextBoxNickname.Size = New System.Drawing.Size(182, 22)
        Me.TextBoxNickname.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nickname"
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Location = New System.Drawing.Point(382, 504)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(182, 55)
        Me.ButtonCreate.TabIndex = 2
        Me.ButtonCreate.Text = "Create And Access"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        Me.ButtonCreate.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(49, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(317, 46)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "CREATE USER"
        '
        'LabelErrorPass
        '
        Me.LabelErrorPass.AutoSize = True
        Me.LabelErrorPass.ForeColor = System.Drawing.Color.Red
        Me.LabelErrorPass.Location = New System.Drawing.Point(379, 186)
        Me.LabelErrorPass.Name = "LabelErrorPass"
        Me.LabelErrorPass.Size = New System.Drawing.Size(12, 17)
        Me.LabelErrorPass.TabIndex = 1
        Me.LabelErrorPass.Text = "."
        '
        'LabelErrorConPass
        '
        Me.LabelErrorConPass.AutoSize = True
        Me.LabelErrorConPass.ForeColor = System.Drawing.Color.Red
        Me.LabelErrorConPass.Location = New System.Drawing.Point(379, 230)
        Me.LabelErrorConPass.Name = "LabelErrorConPass"
        Me.LabelErrorConPass.Size = New System.Drawing.Size(12, 17)
        Me.LabelErrorConPass.TabIndex = 1
        Me.LabelErrorConPass.Text = "."
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.ForeColor = System.Drawing.Color.LawnGreen
        Me.LabelEmail.Location = New System.Drawing.Point(379, 145)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(12, 17)
        Me.LabelEmail.TabIndex = 1
        Me.LabelEmail.Text = "."
        '
        'LabelErrorUsername
        '
        Me.LabelErrorUsername.AutoSize = True
        Me.LabelErrorUsername.ForeColor = System.Drawing.Color.Red
        Me.LabelErrorUsername.Location = New System.Drawing.Point(379, 101)
        Me.LabelErrorUsername.Name = "LabelErrorUsername"
        Me.LabelErrorUsername.Size = New System.Drawing.Size(12, 17)
        Me.LabelErrorUsername.TabIndex = 1
        Me.LabelErrorUsername.Text = "."
        '
        'LabelNickName
        '
        Me.LabelNickName.AutoSize = True
        Me.LabelNickName.ForeColor = System.Drawing.Color.Red
        Me.LabelNickName.Location = New System.Drawing.Point(379, 326)
        Me.LabelNickName.Name = "LabelNickName"
        Me.LabelNickName.Size = New System.Drawing.Size(12, 17)
        Me.LabelNickName.TabIndex = 1
        Me.LabelNickName.Text = "."
        '
        'TextBoxPhoneNum
        '
        Me.TextBoxPhoneNum.Location = New System.Drawing.Point(173, 359)
        Me.TextBoxPhoneNum.Name = "TextBoxPhoneNum"
        Me.TextBoxPhoneNum.Size = New System.Drawing.Size(182, 22)
        Me.TextBoxPhoneNum.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 362)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Phone Number"
        '
        'LabelCorrect
        '
        Me.LabelCorrect.AutoSize = True
        Me.LabelCorrect.ForeColor = System.Drawing.Color.Chartreuse
        Me.LabelCorrect.Location = New System.Drawing.Point(379, 364)
        Me.LabelCorrect.Name = "LabelCorrect"
        Me.LabelCorrect.Size = New System.Drawing.Size(12, 17)
        Me.LabelCorrect.TabIndex = 1
        Me.LabelCorrect.Text = "."
        '
        'DateTimePickerBirthday
        '
        Me.DateTimePickerBirthday.Location = New System.Drawing.Point(173, 397)
        Me.DateTimePickerBirthday.Name = "DateTimePickerBirthday"
        Me.DateTimePickerBirthday.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerBirthday.TabIndex = 3
        '
        'LabelBirthday
        '
        Me.LabelBirthday.AutoSize = True
        Me.LabelBirthday.Location = New System.Drawing.Point(405, 402)
        Me.LabelBirthday.Name = "LabelBirthday"
        Me.LabelBirthday.Size = New System.Drawing.Size(12, 17)
        Me.LabelBirthday.TabIndex = 1
        Me.LabelBirthday.Text = "."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 608)
        Me.Controls.Add(Me.DateTimePickerBirthday)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.LabelBirthday)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelErrorUsername)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelCorrect)
        Me.Controls.Add(Me.LabelNickName)
        Me.Controls.Add(Me.LabelErrorConPass)
        Me.Controls.Add(Me.LabelErrorPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxLast)
        Me.Controls.Add(Me.TextBoxPhoneNum)
        Me.Controls.Add(Me.TextBoxNickname)
        Me.Controls.Add(Me.TextBoxFirst)
        Me.Controls.Add(Me.TextBoxConPass)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxConPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxFirst As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxLast As TextBox
    Friend WithEvents TextBoxNickname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelErrorPass As Label
    Friend WithEvents LabelErrorConPass As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelErrorUsername As Label
    Friend WithEvents LabelNickName As Label
    Friend WithEvents TextBoxPhoneNum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelCorrect As Label
    Friend WithEvents DateTimePickerBirthday As DateTimePicker
    Friend WithEvents LabelBirthday As Label
End Class
