Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Net.Mime.MediaTypeNames

Public Class Form3
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ValidateForm() Then
            Call koneksi()
            Try
                Dim str As String
                str = "INSERT INTO pemasok (KodePms, NamaPms, AlamatPms, TeleponPms, PersonPms, EmailPms) VALUES ('" & Kopem.Text & "', '" & Napem.Text & "', '" & Apem.Text & "', '" & Nopem.Text & "', '" & Pepom.Text & "', '" & Epem.Text & "')"
                CMD = New MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Pemasok berhasil ditambahkan")
            Catch ex As Exception
                MessageBox.Show("Pemasok gagal ditambahkan")
            End Try
            Call tampilData()
            Call aturDGV()
        Else
            MessageBox.Show("Semua field harus diisi")
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(Kopem.Text) OrElse
       String.IsNullOrWhiteSpace(Napem.Text) OrElse
       String.IsNullOrWhiteSpace(Apem.Text) OrElse
       String.IsNullOrWhiteSpace(Nopem.Text) OrElse
       String.IsNullOrWhiteSpace(Pepom.Text) OrElse
       String.IsNullOrWhiteSpace(Epem.Text) Then
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call updatePemasok()
        Call tampilData()
        Call aturDGV()
    End Sub

    Sub updatePemasok()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE pemasok SET NamaPms = @NamaPms, AlamatPms = @AlamatPms, TeleponPms = @TeleponPms, PersonPms = @PersonPms, EmailPms = @EmailPms WHERE KodePms = @KodePms"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@NamaPms", Napem.Text)
            CMD.Parameters.AddWithValue("@AlamatPms", Apem.Text)
            CMD.Parameters.AddWithValue("@TeleponPms", Nopem.Text)
            CMD.Parameters.AddWithValue("@PersonPms", Pepom.Text)
            CMD.Parameters.AddWithValue("@EmailPms", Epem.Text)
            CMD.Parameters.AddWithValue("@KodePms", Kopem.Text)

            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diupdate")
        Catch ex As Exception
            MessageBox.Show("Data pemasok gagal diupdate. Error: " & ex.Message)
        End Try
    End Sub

    Sub aturDGV()
        DGVB.Columns(0).HeaderText = "KodePms"
        DGVB.Columns(1).HeaderText = "NamaPms"
        DGVB.Columns(2).HeaderText = "AlamatPms"
        DGVB.Columns(3).HeaderText = "TeleponPms"
        DGVB.Columns(4).HeaderText = "PersonPms"
        DGVB.Columns(5).HeaderText = "EmailPms"
    End Sub


    Sub tampilData()
        Call koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM pemasok", CONN)
        DS = New DataSet
        DA.Fill(DS, "pemasok")
        DGVB.DataSource = DS.Tables("pemasok")
    End Sub

    Sub hapusPemasok()
        Try
            Call koneksi()
            Dim str As String
            str = "DELETE FROM pemasok WHERE KodePms = @KodePms"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@KodePms", Kopem.Text)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
        Catch ex As Exception
            MessageBox.Show("Data pemasok gagal dihapus. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not String.IsNullOrWhiteSpace(Kopem.Text) Then
            Call hapusPemasok()
            Call tampilData()
            Call aturDGV()
        Else
            MessageBox.Show("KodeBrg harus diisi untuk menghapus data")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Kopem_TextChanged(sender As Object, e As EventArgs) Handles Kopem.TextChanged

    End Sub

    Private Sub DGVB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVB.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form10.Show()
    End Sub
End Class