Public Class Form1
    Public Nama As String
    Public First As String
    Public Last As String


    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click

        'Username
        Dim username As String = TextBoxUsername.Text
        If username.Length > 6 Then
            Nama = TextBoxUsername.Text.Remove(0, 5)
        Else
            LabelErrorUsername.Text = "Sorry, username must be 6 to 20 characters long"
        End If

        'Email
        Dim Email As String = TextBoxEmail.Text
        If 6 < Email.Length >= 12 Then
            LabelEmail.Text = "Valid Email"
        Else
            LabelEmail.ForeColor = Color.Chartreuse
            LabelEmail.Text = "Invalid Email"
        End If


        'Password
        Dim passcode As String = TextBoxPassword.Text
        If passcode.Length < 8 Then
            LabelErrorPass.Text = "Password must be atleast 8 to 15"
        Else
            LabelErrorPass.ForeColor = Color.Chartreuse
            LabelErrorPass.Text = "Valid Password"
        End If


        'First and Last Name
        Dim firstName As String = TextBoxFirst.Text
        First = TextBoxFirst.Text.Insert(0, "Ms.")
        Dim LastName As String = TextBoxLast.Text
        Last = TextBoxLast.Text.Insert(0, "")

        'Phone Number
        Dim Phone As String = TextBoxPhoneNum.Text
        If Phone.Contains("60") Then
            LabelCorrect.Text = "Valid Phone Number"
        Else
            LabelCorrect.Text = "Enter Again !!"
            Phone = ""
        End If

        'Date Time Picker For Birthday
        LabelBirthday.Text = DateTimePickerBirthday.Value
        Dim currentYear As Int16 = System.DateTime.Now.Year
        Dim tempYear As String = CStr(LabelBirthday.Text)
        Dim tempVal = tempYear.Substring(0, 4)
        If currentYear - Val(tempVal) < 18 Then
            MsgBox("You Are Not 18+ Yet", MessageBoxIcon.Warning)
            ButtonCreate.Visible = False
        Else
            MsgBox("You are good to go")
            ButtonCreate.Visible = True
            Form2.Show()

        End If



        'Dim num As Integer
        'Dim passLength As String
        'passLength = TextBoxPassword.Text
        'num = passLength.Length 'kira length password

        'Dim temP = passLength.Trim 'dapat membuang space ruangan kosong / membuang space yang pengguna tidak nampak
        'Dim temNum As Integer = temP
        'MsgBox("char" & num &    'kira character yg dimasukkan termasuk space 
        '       "char" & temNum)  'display balik input tanpa space
        '"char" adalh bilangan characters 

        'If num < 8 Then
        '    MsgBox("Your assword must be atleast 8 to 15 characters", MessageBoxIcon.Error)
        'Else
        '    Form2.Show()
        'End If



    End Sub


End Class
