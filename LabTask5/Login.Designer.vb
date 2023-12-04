<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.LabelErrorUsername = New System.Windows.Forms.Label()
        Me.LabelErrorPass = New System.Windows.Forms.Label()
        Me.LabelErrorUsername2 = New System.Windows.Forms.Label()
        Me.CheckBoxPass = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MADE Soulmaze", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(716, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 51)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MADE Soulmaze Outline", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(616, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 52)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Magneto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(644, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 48)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sports News"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxUsername)
        Me.GroupBox1.Location = New System.Drawing.Point(643, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 72)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Username"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.Location = New System.Drawing.Point(9, 21)
        Me.TextBoxUsername.Multiline = True
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(255, 39)
        Me.TextBoxUsername.TabIndex = 0
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(9, 21)
        Me.TextBoxPassword.Multiline = True
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(255, 39)
        Me.TextBoxPassword.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxPassword)
        Me.GroupBox2.Location = New System.Drawing.Point(643, 387)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 74)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Password"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonLogin.Location = New System.Drawing.Point(679, 571)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(213, 52)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "LOGIN"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'LabelErrorUsername
        '
        Me.LabelErrorUsername.AutoSize = True
        Me.LabelErrorUsername.BackColor = System.Drawing.Color.Transparent
        Me.LabelErrorUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorUsername.Location = New System.Drawing.Point(647, 309)
        Me.LabelErrorUsername.Name = "LabelErrorUsername"
        Me.LabelErrorUsername.Size = New System.Drawing.Size(0, 25)
        Me.LabelErrorUsername.TabIndex = 7
        '
        'LabelErrorPass
        '
        Me.LabelErrorPass.AutoSize = True
        Me.LabelErrorPass.BackColor = System.Drawing.Color.Transparent
        Me.LabelErrorPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorPass.Location = New System.Drawing.Point(647, 480)
        Me.LabelErrorPass.Name = "LabelErrorPass"
        Me.LabelErrorPass.Size = New System.Drawing.Size(0, 25)
        Me.LabelErrorPass.TabIndex = 7
        '
        'LabelErrorUsername2
        '
        Me.LabelErrorUsername2.AutoSize = True
        Me.LabelErrorUsername2.BackColor = System.Drawing.Color.Transparent
        Me.LabelErrorUsername2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorUsername2.Location = New System.Drawing.Point(653, 309)
        Me.LabelErrorUsername2.Name = "LabelErrorUsername2"
        Me.LabelErrorUsername2.Size = New System.Drawing.Size(0, 25)
        Me.LabelErrorUsername2.TabIndex = 7
        '
        'CheckBoxPass
        '
        Me.CheckBoxPass.AutoSize = True
        Me.CheckBoxPass.Location = New System.Drawing.Point(950, 428)
        Me.CheckBoxPass.Name = "CheckBoxPass"
        Me.CheckBoxPass.Size = New System.Drawing.Size(129, 21)
        Me.CheckBoxPass.TabIndex = 8
        Me.CheckBoxPass.Text = "Show Password"
        Me.CheckBoxPass.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.LabTask5.My.Resources.Resources._45998406673e36fc707946cf7a62b4d7
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(506, 686)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1166, 687)
        Me.Controls.Add(Me.CheckBoxPass)
        Me.Controls.Add(Me.LabelErrorPass)
        Me.Controls.Add(Me.LabelErrorUsername2)
        Me.Controls.Add(Me.LabelErrorUsername)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents LabelErrorUsername As Label
    Friend WithEvents LabelErrorPass As Label
    Friend WithEvents LabelErrorUsername2 As Label
    Friend WithEvents CheckBoxPass As CheckBox
End Class
