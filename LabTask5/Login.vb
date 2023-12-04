'SITI NUR AIN 20DDT21F2003
'DDT4A


Public Class Login
    Public Nama As String = "SitiNurAin"


    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Try

            'Username
            Dim username As String = TextBoxUsername.Text.Trim()
            If username.Length > 6 Then
                Dim enteredUsername As String = TextBoxUsername.Text.Trim()
                If enteredUsername = Nama Then

                    LabelErrorUsername2.Text = "Valid username"
                    LabelErrorUsername2.ForeColor = Color.Chartreuse
                Else
                    LabelErrorUsername2.Text = "Invalid username"
                    LabelErrorUsername2.ForeColor = Color.DarkRed
                    Return 'prevent login if username is incorrect

                End If
            Else
                LabelErrorUsername.Text = "Sorry, your username need to be 6 characters long"
                LabelErrorUsername.ForeColor = Color.DarkRed
                Return 'prevent login if username is incorrect

            End If

            ' Password
            Dim passcode As String = TextBoxPassword.Text
            Dim temP As String = passcode.Trim()
            If temP.Length < 8 Then
                LabelErrorPass.Text = "Invalid Password"
                LabelErrorPass.ForeColor = Color.DarkRed
                Return
                'prevent login if password is incorrect

            Else
                'LabeltemP.Text = "char" & temP 
                LabelErrorPass.Text = "Valid Password"
                LabelErrorPass.ForeColor = Color.Chartreuse

            End If

            Nama = TextBoxUsername.Text.Remove(0, 7).Insert(0, "Ms.")

            'First and Last Name
            'Dim firstName As String = First
            'firstName.Remove(5).Insert(0, "Ms.")
            'Dim LastName As String = Last
            'LastName.Insert(0, "")

            'will show home form if username and password are correct
            Home.Show()

        Catch ex As Exception
            ' Handle the exception here
            MsgBox("An error occurred: " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged
        If CheckBoxPass.Checked = True Then
            TextBoxPassword.UseSystemPasswordChar = True 'if the checkbox is checked, the password will not be hide
        Else
            TextBoxPassword.UseSystemPasswordChar = False 'if the checkbox is NOT checked, the password will be hide
        End If

    End Sub


End Class