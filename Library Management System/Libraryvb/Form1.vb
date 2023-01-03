Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "12345" Then
            MessageBox.Show("Welcome to library Management System", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Hide()


        Else
            MessageBox.Show("Invalid Login", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("Thank You For Using library Management System", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
