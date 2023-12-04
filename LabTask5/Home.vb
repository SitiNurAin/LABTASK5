Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LabelWelcome.Text = Login.Nama
            LabelFirstname.Text = Login.Nama
            'LabelLasName.Text = Login.Last
        Catch ex As Exception
            ' Handle the exception here
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub



    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        Category.Show()
        Me.Hide()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show()
        Me.Hide()


    End Sub

    Private Sub LabelFirstname_Click(sender As Object, e As EventArgs) Handles LabelFirstname.Click, Label3.Click

    End Sub
End Class