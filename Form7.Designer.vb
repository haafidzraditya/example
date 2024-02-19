<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DGVB = New DataGridView()
        GroupBox1 = New GroupBox()
        Sabar = New ComboBox()
        Button3 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Kobar = New TextBox()
        Hapus = New Button()
        Button1 = New Button()
        Label5 = New Label()
        Haba = New TextBox()
        Label6 = New Label()
        Staw = New TextBox()
        Label3 = New Label()
        Jubar = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Nabar = New TextBox()
        TextBox2 = New TextBox()
        Button4 = New Button()
        CType(DGVB, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGVB
        ' 
        DGVB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVB.Location = New Point(480, 27)
        DGVB.Margin = New Padding(3, 2, 3, 2)
        DGVB.Name = "DGVB"
        DGVB.RowHeadersWidth = 51
        DGVB.RowTemplate.Height = 29
        DGVB.Size = New Size(388, 327)
        DGVB.TabIndex = 24
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Sabar)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Kobar)
        GroupBox1.Controls.Add(Hapus)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Haba)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Staw)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Jubar)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Nabar)
        GroupBox1.Location = New Point(3, 53)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(436, 301)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        ' 
        ' Sabar
        ' 
        Sabar.FormattingEnabled = True
        Sabar.Items.AddRange(New Object() {"Pcs", "Paket"})
        Sabar.Location = New Point(194, 82)
        Sabar.Margin = New Padding(3, 2, 3, 2)
        Sabar.Name = "Sabar"
        Sabar.Size = New Size(170, 23)
        Sabar.TabIndex = 21
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(214, 204)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(99, 22)
        Button3.TabIndex = 20
        Button3.Text = "EDIT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(318, 204)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 22)
        Button2.TabIndex = 19
        Button2.Text = "KELUAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(82, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 14)
        Label1.TabIndex = 18
        Label1.Text = "Kode Barang"
        ' 
        ' Kobar
        ' 
        Kobar.Location = New Point(194, 25)
        Kobar.Margin = New Padding(3, 2, 3, 2)
        Kobar.Name = "Kobar"
        Kobar.Size = New Size(170, 23)
        Kobar.TabIndex = 17
        ' 
        ' Hapus
        ' 
        Hapus.Location = New Point(109, 204)
        Hapus.Margin = New Padding(3, 2, 3, 2)
        Hapus.Name = "Hapus"
        Hapus.Size = New Size(99, 22)
        Hapus.TabIndex = 16
        Hapus.Text = "HAPUS"
        Hapus.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(5, 204)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 22)
        Button1.TabIndex = 15
        Button1.Text = "SIMPAN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(82, 170)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 14)
        Label5.TabIndex = 14
        Label5.Text = "Harga Barang"
        ' 
        ' Haba
        ' 
        Haba.Location = New Point(194, 170)
        Haba.Margin = New Padding(3, 2, 3, 2)
        Haba.Name = "Haba"
        Haba.Size = New Size(170, 23)
        Haba.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(82, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 14)
        Label6.TabIndex = 12
        Label6.Text = "Stok Awal"
        ' 
        ' Staw
        ' 
        Staw.Location = New Point(194, 141)
        Staw.Margin = New Padding(3, 2, 3, 2)
        Staw.Name = "Staw"
        Staw.Size = New Size(170, 23)
        Staw.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(82, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 14)
        Label3.TabIndex = 10
        Label3.Text = "Jumlah Barang"
        ' 
        ' Jubar
        ' 
        Jubar.Location = New Point(194, 113)
        Jubar.Margin = New Padding(3, 2, 3, 2)
        Jubar.Name = "Jubar"
        Jubar.Size = New Size(170, 23)
        Jubar.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(82, 86)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 14)
        Label4.TabIndex = 8
        Label4.Text = "Satuan Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(82, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 14)
        Label2.TabIndex = 6
        Label2.Text = "Nama Barang"
        ' 
        ' Nabar
        ' 
        Nabar.Location = New Point(194, 53)
        Nabar.Margin = New Padding(3, 2, 3, 2)
        Nabar.Name = "Nabar"
        Nabar.Size = New Size(170, 23)
        Nabar.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.ForeColor = Color.Black
        TextBox2.Location = New Point(3, 27)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(436, 23)
        TextBox2.TabIndex = 22
        TextBox2.Text = "MASUKAN DATA BARANG"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(135, 275)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(200, 22)
        Button4.TabIndex = 22
        Button4.Text = "KEMBALI"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1063, 417)
        Controls.Add(DGVB)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form7"
        Text = "Form7"
        CType(DGVB, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DGVB As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Sabar As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Kobar As TextBox
    Friend WithEvents Hapus As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Haba As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Staw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Jubar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Nabar As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
End Class
