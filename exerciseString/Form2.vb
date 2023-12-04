Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelWelcome.Text = Form1.Nama
        LabelFirstname.Text = Form1.First
        LabelLasName.Text = Form1.Last

    End Sub

    Private Sub LabelFirstname_Click(sender As Object, e As EventArgs) Handles LabelFirstname.Click

    End Sub
End Class