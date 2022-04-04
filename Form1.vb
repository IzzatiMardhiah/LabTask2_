Public Class Form1
    Private Sub RegistirationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistirationToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This program is design by IzzatiMardhiah Binti Azman,10DDT20F1035,JTMK", MsgBoxStyle.Information, "About Menu Strip")
    End Sub
End Class
