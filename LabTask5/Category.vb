Public Class Category
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LabelFirstname.Text = Login.Nama
            'LabelLasName.Text = Login.Last
        Catch ex As Exception
            ' Handle the exception here
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


End Class