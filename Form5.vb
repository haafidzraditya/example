Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Net.Mime.MediaTypeNames

Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateForm() Then
            Call koneksi()
            Try
                Dim str As String
                str = "INSERT INTO pelanggan (KodePlg, NamaPlg, AlamatPlg, TeleponPlg, EmailPlg, JK) VALUES ('" & KodePlg.Text & "', '" & NamaPlg.Text & "', '" & AlamatPlg.Text & "', '" & TeleponPlg.Text & "', '" & EmailPlg.Text & "', '" & JK.Text & "')"
                CMD = New MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Pelanggan berhasil ditambahkan")
            Catch ex As Exception
                MessageBox.Show("Pelanggan gagal ditambahkan. Error: " & ex.Message)
            End Try
            Call tampilData()
            Call aturDGV()
        Else
            MessageBox.Show("Semua field harus diisi")
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(KodePlg.Text) OrElse
           String.IsNullOrWhiteSpace(NamaPlg.Text) OrElse
           String.IsNullOrWhiteSpace(AlamatPlg.Text) OrElse
           String.IsNullOrWhiteSpace(TeleponPlg.Text) OrElse
           String.IsNullOrWhiteSpace(EmailPlg.Text) OrElse
           String.IsNullOrWhiteSpace(JK.Text) Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub tampilData()
        Call koneksi()
        DA = New MySqlDataAdapter("select * from pelanggan", CONN)
        DS = New DataSet
        DA.Fill(DS, "pelanggan")
        DGVB.DataSource = DS.Tables("pelanggan")
    End Sub

    Sub aturDGV()
        DGVB.Columns(0).HeaderText = "KodePlg"
        DGVB.Columns(1).HeaderText = "NamaPlg"
        DGVB.Columns(2).HeaderText = "AlamatPlg"
        DGVB.Columns(3).HeaderText = "TeleponPlg"
        DGVB.Columns(4).HeaderText = "EmailPlg"
        DGVB.Columns(5).HeaderText = "JK"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not String.IsNullOrWhiteSpace(KodePlg.Text) Then
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
            str = "DELETE FROM pelanggan WHERE KodePlg = @KodePlg"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@KodePlg", KodePlg.Text)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
        Catch ex As Exception
            MessageBox.Show("Data pelanggan gagal dihapus. Error: " & ex.Message)
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
            str = "UPDATE pelanggan SET NamaPlg = @NamaPlg, AlamatPlg = @AlamatPlg, TeleponPlg = @TeleponPlg, EmailPlg = @EmailPlg, JK = @JK WHERE KodePlg = @KodePlg"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@NamaPlg", NamaPlg.Text)
            CMD.Parameters.AddWithValue("@AlamatPlg", AlamatPlg.Text)
            CMD.Parameters.AddWithValue("@TeleponPlg", TeleponPlg.Text)
            CMD.Parameters.AddWithValue("@EmailPlg", EmailPlg.Text)
            CMD.Parameters.AddWithValue("@JK", JK.Text)
            CMD.Parameters.AddWithValue("@KodePlg", KodePlg.Text)

            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diupdate")
        Catch ex As Exception
            MessageBox.Show("Data Pelanggan gagal diupdate. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form10.Show()
    End Sub
End Class