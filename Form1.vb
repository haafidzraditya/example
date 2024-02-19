Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Net.Mime.MediaTypeNames

Module GlobalVariables
    Public UserRole As String
End Module
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If username.Text = "" Or password.Text = "" Then
            MessageBox.Show("Harap isi Username dan Password terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Call koneksi()
                CMD = New MySqlCommand("SELECT * FROM pemakai WHERE NamaPmk = @NamaPmk AND PassPmk = @PassPmk", CONN)
                CMD.Parameters.AddWithValue("@NamaPmk", username.Text)
                CMD.Parameters.AddWithValue("@PassPmk", password.Text)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows Then
                    If RD("StatusPmk").ToString = "admin" Then
                        'Login sebagai Admin
                        UserRole = "admin"
                        Form10.Show()
                        Me.Hide()
                        username.Focus()
                        password.Clear()
                    ElseIf RD("StatusPmk").ToString = "kasir" Then
                        'Login sebagai Kasir
                        UserRole = "kasir"
                        Form10.Show()
                        Me.Hide()
                        username.Focus()
                        password.Clear()
                    Else
                        MessageBox.Show("Role tidak tersedia", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Periksa kembali Username dan Password", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    username.Focus()
                    password.Clear()
                End If


                RD.Close()
            Catch ex As Exception
                MessageBox.Show("Periksa kembali Username dan Password", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                username.Focus()
                password.Clear()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class