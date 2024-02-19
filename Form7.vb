Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Net.Mime.MediaTypeNames

Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateForm() Then
            Call koneksi()
            Try
                Dim str As String
                str = "INSERT INTO tbl_barang (KodeBrg, NamaBrg, Satuan, JumlahBrg, StokAwal, Harga) VALUES ('" & Kobar.Text & "', '" & Nabar.Text & "', '" & Sabar.Text & "', '" & Jubar.Text & "', '" & Staw.Text & "', '" & Haba.Text & "')"
                CMD = New MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Barang berhasil ditambahkan")
            Catch ex As Exception
                MessageBox.Show("Barang gagal ditambahkan")
            End Try
            Call tampilData()
            Call aturDGV()
        Else
            MessageBox.Show("Semua field harus diisi")
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(Kobar.Text) OrElse
           String.IsNullOrWhiteSpace(Nabar.Text) OrElse
           String.IsNullOrWhiteSpace(Sabar.Text) OrElse
           String.IsNullOrWhiteSpace(Jubar.Text) OrElse
           String.IsNullOrWhiteSpace(Staw.Text) OrElse
           String.IsNullOrWhiteSpace(Haba.Text) Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub tampilData()
        Call koneksi()
        DA = New MySqlDataAdapter("select * from tbl_barang", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_barang")
        DGVB.DataSource = DS.Tables("tbl_barang")
    End Sub

    Sub aturDGV()
        DGVB.Columns(0).HeaderText = "KodeBrg"
        DGVB.Columns(1).HeaderText = "NamaBrg"
        DGVB.Columns(2).HeaderText = "Satuan"
        DGVB.Columns(3).HeaderText = "JumlahBrg"
        DGVB.Columns(4).HeaderText = "StokAwal"
        DGVB.Columns(5).HeaderText = "Harga"
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        If Not String.IsNullOrWhiteSpace(Kobar.Text) Then
            Call hapusbrg()
            Call tampilData()
            Call aturDGV()
        Else
            MessageBox.Show("KodeBrg harus diisi untuk menghapus data")
        End If
    End Sub
    Sub hapusbrg()
        Try
            Call koneksi()
            Dim str As String
            str = "DELETE FROM tbl_barang WHERE KodeBrg = @KodeBrg"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@KodeBrg", Kobar.Text)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
        Catch ex As Exception
            MessageBox.Show("Data barang gagal dihapus. Error: " & ex.Message)
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
            str = "UPDATE tbl_barang SET Satuan = @Satuan, JumlahBrg = @JumlahBrg, StokAwal = @StokAwal, NamaBrg = @NamaBrg, Harga = @Harga WHERE KodeBrg = @KodeBrg"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@Satuan", Sabar.Text)
            CMD.Parameters.AddWithValue("@JumlahBrg", Jubar.Text)
            CMD.Parameters.AddWithValue("@StokAwal", Staw.Text)
            CMD.Parameters.AddWithValue("@NamaBrg", Nabar.Text)
            CMD.Parameters.AddWithValue("@Harga", Haba.Text)
            CMD.Parameters.AddWithValue("@KodeBrg", Kobar.Text)

            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diupdate")
        Catch ex As Exception
            MessageBox.Show("Data barang gagal diupdate. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form10.Show()
    End Sub
End Class