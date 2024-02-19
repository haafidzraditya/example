Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Net.Mime.MediaTypeNames
Imports Org.BouncyCastle.Utilities.IO
Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Try
            Dim str As String
            str = "INSERT INTO penjualan (Faktur, Tanggal, Item, Total, Dibayar, Kembali, KodePmk, KodePlg) VALUES ('" & Faktur.Text & "', '" & Tapen.Value.ToString("yyyy-MM-dd") & "', '" & Item.Text & "', '" & Topen.Text & "', '" & Dibayar.Text & "', '" & Kembali.Text & "', '" & Kopempen.Text & "', '" & Kopelpen.Text & "')"
            CMD = New MySqlCommand(str, CONN)

            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
            CMD.ExecuteNonQuery()
            MessageBox.Show("Penjualan berhasil ditambahkan")
        Catch ex As Exception
            MessageBox.Show("Penjualan gagal ditambahkan")
        End Try
        Call tampilData()
        Call aturDGV()
    End Sub

    Sub aturDGV()
        DGVpenj.Columns(0).HeaderText = "Faktur"
        DGVpenj.Columns(1).HeaderText = "Tanggal"
        DGVpenj.Columns(2).HeaderText = "Item"
        DGVpenj.Columns(3).HeaderText = "Total"
        DGVpenj.Columns(4).HeaderText = "Dibayar"
        DGVpenj.Columns(5).HeaderText = "Kembali"
        DGVpenj.Columns(6).HeaderText = "KodePmk"
        DGVpenj.Columns(7).HeaderText = "KodePlg"
    End Sub

    Sub tampilData()
        Call koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM penjualan", CONN)
        DS = New DataSet
        DA.Fill(DS, "penjualan")
        DGVpenj.DataSource = DS.Tables("penjualan")
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKodePlgData()
        LoadKodePmkData()
    End Sub

    Private Sub LoadKodePlgData()
        Try
            ' Establish connection
            koneksi()

            ' Define SQL query to fetch kodePMS data
            Dim query As String = "SELECT DISTINCT KodePlg FROM pelanggan"

            ' Create a new command and assign the query and connection
            CMD = New MySqlCommand(query, CONN)

            ' Open the connection
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If

            ' Execute the query and create a data reader
            Dim reader As MySqlDataReader = CMD.ExecuteReader()

            ' Clear existing items in the ComboBox
            Kopelpen.Items.Clear()

            ' Loop through the data reader and add each kodePMS to the ComboBox
            While reader.Read()
                Kopelpen.Items.Add(reader("KodePlg").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading KodePlg data: " & ex.Message)
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
            Kopempen.Items.Clear()

            ' Loop through the data reader and add each kodePMS to the ComboBox
            While reader.Read()
                Kopempen.Items.Add(reader("KodePmk").ToString())
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call updatePenjualan()
        Call tampilData()
        Call aturDGV()
    End Sub
    Sub updatePenjualan()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE penjualan SET Tanggal = @Tanggal, Item = @Item, Total = @Total, Dibayar = @Dibayar, Kembali = @Kembali, KodePmk = @KodePmk, KodePlg = @KodePlg WHERE Faktur = @Faktur"

            Console.WriteLine("SQL Query: " & str)

            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@Tanggal", Tapen.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("@Item", Item.Text)
            CMD.Parameters.AddWithValue("@Total", Topen.Text)
            CMD.Parameters.AddWithValue("@Dibayar", Dibayar.Text)
            CMD.Parameters.AddWithValue("@Kembali", Kembali.Text)
            CMD.Parameters.AddWithValue("@KodePmk", Kopempen.Text)
            CMD.Parameters.AddWithValue("@KodePlg", Kopelpen.Text)
            CMD.Parameters.AddWithValue("@Faktur", Faktur.Text)

            CMD.ExecuteNonQuery()
            MessageBox.Show("Data penjualan berhasil diupdate")
        Catch ex As Exception
            MessageBox.Show("Data penjualan gagal diupdate. Error: " & ex.Message)
        End Try
    End Sub

    Sub hapusPelanggan()
        Try
            Call koneksi()
            Dim str As String
            str = "DELETE FROM penjualan WHERE Faktur = @Faktur"
            CMD = New MySqlCommand(str, CONN)
            CMD.Parameters.AddWithValue("@Faktur", Faktur.Text)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data pelanggan berhasil dihapus")
        Catch ex As Exception
            MessageBox.Show("Data pelanggan gagal dihapus. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not String.IsNullOrWhiteSpace(Faktur.Text) Then
            Call hapusPelanggan()
            Call tampilData()
            Call aturDGV()
        Else
            MessageBox.Show("KodeBrg harus diisi untuk menghapus data")
        End If
    End Sub

End Class