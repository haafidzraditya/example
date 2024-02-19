Public Class Form10
    Private Sub DATABARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATABARANGToolStripMenuItem.Click
        If GlobalVariables.UserRole = "admin" Then
            Me.Hide()
            Form7.Show()
        Else
            MessageBox.Show("Anda tidak memiliki akses ke fitur ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub DATAPEMASOKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAPEMASOKToolStripMenuItem.Click
        If GlobalVariables.UserRole = "admin" Then
            Me.Hide()
            Form3.Show()
        Else
            MessageBox.Show("Anda tidak memiliki akses ke fitur ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub DATAUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAUSERToolStripMenuItem.Click
        If GlobalVariables.UserRole = "admin" Then
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("Anda tidak memiliki akses ke fitur ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub DATAPENERIMAANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAPENERIMAANToolStripMenuItem.Click
        If GlobalVariables.UserRole = "admin" Then
            Me.Hide()
            Form4.Show()
        Else
            MessageBox.Show("Anda tidak memiliki akses ke fitur ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub DATAPELANGGANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAPELANGGANToolStripMenuItem.Click
        If GlobalVariables.UserRole = "admin" Then
            Me.Hide()
            Form5.Show()
        Else
            MessageBox.Show("Anda tidak memiliki akses ke fitur ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub PENJUALANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PENJUALANToolStripMenuItem.Click
        If GlobalVariables.UserRole = "kasir" Then
            Me.Hide()
            Form6.Show()
        Else
            MessageBox.Show("Anda tidak memiliki akses ke fitur ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class