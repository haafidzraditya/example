Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Net.Mime.MediaTypeNames
Imports Org.BouncyCastle.Utilities.IO

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Try
            Dim str As String
            str = "INSERT INTO penerimaan (NomorTrm, TanggalTrm, KodePms, NomorBon, TotalTrm, KodePmk) VALUES ('" & Notem.Text & "', '" & Tatem.Value.ToString("yyyy-MM-dd") & "', '" & kopenPMS.Text & "', '" & Nobon.Text & "', '" & Totem.Text & "', '" & kopenPMK.Text & "')"
            CMD = New MySqlCommand(str, CONN)

            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
            CMD.ExecuteNonQuery()
            MessageBox.Show("Penerimaan berhasil ditambahkan")
        Catch ex As Exception
            MessageBox.Show("Penerimaan gagal ditambahkan")
        End Try
        Call tampilData()
        Call aturDGV()
    End Sub

    Sub aturDGV()
        DGVB.Columns(0).HeaderText = "NomorTrm"
        DGVB.Columns(1).HeaderText = "TanggalTrm"
        DGVB.Columns(2).HeaderText = "KodePms"
        DGVB.Columns(3).HeaderText = "NomorBon"
        DGVB.Columns(4).HeaderText = "TotalTrm"
        DGVB.Columns(5).HeaderText = "KodePmk"
    End Sub

    Sub hapusPenerimaan()
        Try
            Call koneksi()
            Dim str As String
            str = "DELETE FROM penerimaan WHERE NomorTrm = @NomorTrm"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@NomorTrm", Notem.Text)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
        Catch ex As Exception
            MessageBox.Show("Data penerimaan gagal dihapus. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKodePmsData()
        LoadKodePmkData()
    End Sub

    Private Sub LoadKodePmsData()
        Try
            ' Establish connection
            koneksi()

            ' Define SQL query to fetch kodePMS data
            Dim query As String = "SELECT DISTINCT KodePms FROM pemasok"

            ' Create a new command and assign the query and connection
            CMD = New MySqlCommand(query, CONN)

            ' Open the connection
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If

            ' Execute the query and create a data reader
            Dim reader As MySqlDataReader = CMD.ExecuteReader()

            ' Clear existing items in the ComboBox
            kopenPMS.Items.Clear()

            ' Loop through the data reader and add each kodePMS to the ComboBox
            While reader.Read()
                kopenPMS.Items.Add(reader("KodePms").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading KodePms data: " & ex.Message)
        Finally
            ' Close the connection
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Private Sub LoadKodePmkData()
        Try
            ' Establish connection
            koneksi()

            ' Define SQL query to fetch kodePMS data
            Dim query As String = "SELECT DISTINCT KodePmk FROM pemakai"

            ' Create a new command and assign the query and connection
            CMD = New MySqlCommand(query, CONN)

            ' Open the connection
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If

            ' Execute the query and create a data reader
            Dim reader As MySqlDataReader = CMD.ExecuteReader()

            ' Clear existing items in the ComboBox
            kopenPMK.Items.Clear()

            ' Loop through the data reader and add each kodePMS to the ComboBox
            While reader.Read()
                kopenPMK.Items.Add(reader("KodePmk").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading KodePmk data: " & ex.Message)
        Finally
            ' Close the connection
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kopenPMS.SelectedIndexChanged

    End Sub

    Sub tampilData()
        Call koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM penerimaan", CONN)
        DS = New DataSet
        DA.Fill(DS, "penerimaan")
        DGVB.DataSource = DS.Tables("penerimaan")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        hapusPenerimaan()
        tampilData()
        aturDGV()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updatePenerimaan()
        tampilData()
        aturDGV()
    End Sub

    Sub updatePenerimaan()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE penerimaan SET NomorTrm = @NomorTrm, TanggalTrm = @TanggalTrm, KodePms = @KodePms, NomorBon = @NomorBon, TotalTrm = @TotalTrm, KodePmk = @KodePmk WHERE NomorTrm = @NomorTrm"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@NomorTrm", Notem.Text)
            CMD.Parameters.AddWithValue("@TanggalTrm", Tatem.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("@KodePms", kopenPMS.Text)
            CMD.Parameters.AddWithValue("@NomorBon", Nobon.Text)
            CMD.Parameters.AddWithValue("@TotalTrm", Totem.Text)
            CMD.Parameters.AddWithValue("@KodePmk", kopenPMK.Text)

            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diupdate")
        Catch ex As Exception
            MessageBox.Show("Data pemasok gagal diupdate. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Notem_TextChanged(sender As Object, e As EventArgs) Handles Notem.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form10.Show()
    End Sub
End Class