Public Class Form2

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Thank You", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Application.Exit()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub DeveloperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BookBorrowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookBorrowToolStripMenuItem.Click
        Borrow.ShowDialog()
    End Sub

    Private Sub BookReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PendingReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendingReturnToolStripMenuItem.Click
        report.ShowDialog()

    End Sub

    Private Sub BookEntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookEntryToolStripMenuItem1.Click
        Book_Entry.ShowDialog()
    End Sub

    Private Sub BookDeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub BookUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub StudentEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentEntryToolStripMenuItem.Click
        student.ShowDialog()


    End Sub
End Class