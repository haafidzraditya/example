Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Net.Mime.MediaTypeNames

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateForm() Then
            Call koneksi()
            Try
                Dim str As String
                str = "INSERT INTO pemakai (KodePmk, NamaPmk, PassPmk, StatusPmk) VALUES ('" & KodePmk.Text & "', '" & NamaPmk.Text & "', '" & PassPmk.Text & "', '" & StatusPmk.Text & "')"
                CMD = New MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Pemakai berhasil ditambahkan")
            Catch ex As Exception
                MessageBox.Show("Pemakai gagal ditambahkan")
            End Try
            Call tampilData()
            Call aturDGV()
        Else
            MessageBox.Show("Semua field harus diisi")
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(KodePmk.Text) OrElse
           String.IsNullOrWhiteSpace(NamaPmk.Text) OrElse
           String.IsNullOrWhiteSpace(PassPmk.Text) OrElse
           String.IsNullOrWhiteSpace(StatusPmk.Text) Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub tampilData()
        Call koneksi()
        DA = New MySqlDataAdapter("select * from pemakai", CONN)
        DS = New DataSet
        DA.Fill(DS, "pemakai")
        DGVB.DataSource = DS.Tables("pemakai")
    End Sub

    Sub aturDGV()
        DGVB.Columns(0).HeaderText = "KodePmk"
        DGVB.Columns(1).HeaderText = "NamaPmk"
        DGVB.Columns(2).HeaderText = "PassPmk"
        DGVB.Columns(3).HeaderText = "StatusPmk"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not String.IsNullOrWhiteSpace(KodePmk.Text) Then
            Call hapusbrg()
            Call tampilData()
            Call aturDGV()
        Else
            MessageBox.Show("Kode Pemakai harus diisi untuk menghapus data")
        End If
    End Sub
    Sub hapusbrg()
        Try
            Call koneksi()
            Dim str As String
            str = "DELETE FROM pemakai WHERE KodePmk = @KodePmk"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@KodePmk", KodePmk.Text)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
        Catch ex As Exception
            MessageBox.Show("Data pemakai gagal dihapus. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call updatebrg()
        Call tampilData()
        Call aturDGV()
    End Sub

    Sub updatebrg()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE pemakai SET NamaPmk = @NamaPmk, PassPmk = @PassPmk, StatusPmk = @StatusPmk WHERE KodePmk = @KodePmk"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@NamaPmk", NamaPmk.Text)
            CMD.Parameters.AddWithValue("@PassPmk", PassPmk.Text)
            CMD.Parameters.AddWithValue("@StatusPmk", StatusPmk.Text)
            CMD.Parameters.AddWithValue("@KodePmk", KodePmk.Text)

            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diupdate")
        Catch ex As Exception
            MessageBox.Show("Data Pemakai gagal diupdate. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub StatusPmk_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form10.Show()
    End Sub
End Class