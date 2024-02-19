<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Kopempen = New ComboBox()
        Tapen = New DateTimePicker()
        Label2 = New Label()
        Button4 = New Button()
        DGVpenj = New DataGridView()
        Label6 = New Label()
        TextBox1 = New TextBox()
        Faktur = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Topen = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        Label7 = New Label()
        Kembali = New TextBox()
        Kopelpen = New ComboBox()
        Label8 = New Label()
        Item = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Dibayar = New ComboBox()
        CType(DGVpenj, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Kopempen
        ' 
        Kopempen.FormattingEnabled = True
        Kopempen.Location = New Point(197, 226)
        Kopempen.Margin = New Padding(3, 2, 3, 2)
        Kopempen.Name = "Kopempen"
        Kopempen.Size = New Size(308, 23)
        Kopempen.TabIndex = 44
        ' 
        ' Tapen
        ' 
        Tapen.Location = New Point(197, 88)
        Tapen.Margin = New Padding(3, 2, 3, 2)
        Tapen.Name = "Tapen"
        Tapen.Size = New Size(308, 23)
        Tapen.TabIndex = 42
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(75, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 19)
        Label2.TabIndex = 41
        Label2.Text = "Tanggal"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(383, 295)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(82, 22)
        Button4.TabIndex = 40
        Button4.Text = "Kembali"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DGVpenj
        ' 
        DGVpenj.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVpenj.Location = New Point(566, 21)
        DGVpenj.Margin = New Padding(3, 2, 3, 2)
        DGVpenj.Name = "DGVpenj"
        DGVpenj.RowHeadersWidth = 51
        DGVpenj.RowTemplate.Height = 29
        DGVpenj.Size = New Size(448, 296)
        DGVpenj.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(75, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 19)
        Label6.TabIndex = 39
        Label6.Text = "Kode Pmk"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(24, 21)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(522, 27)
        TextBox1.TabIndex = 28
        TextBox1.Text = "PENJUALAN"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Faktur
        ' 
        Faktur.Location = New Point(197, 61)
        Faktur.Margin = New Padding(3, 2, 3, 2)
        Faktur.Name = "Faktur"
        Faktur.Size = New Size(308, 23)
        Faktur.TabIndex = 29
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(75, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 19)
        Label1.TabIndex = 27
        Label1.Text = "Faktur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(75, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 19)
        Label3.TabIndex = 38
        Label3.Text = "Item"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(75, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 19)
        Label4.TabIndex = 31
        Label4.Text = "Total"
        ' 
        ' Topen
        ' 
        Topen.Location = New Point(197, 146)
        Topen.Margin = New Padding(3, 2, 3, 2)
        Topen.Name = "Topen"
        Topen.Size = New Size(308, 23)
        Topen.TabIndex = 32
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(75, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 19)
        Label5.TabIndex = 33
        Label5.Text = "Dibayar"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(71, 295)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 22)
        Button1.TabIndex = 35
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(75, 201)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 19)
        Label7.TabIndex = 45
        Label7.Text = "Kembali"
        ' 
        ' Kembali
        ' 
        Kembali.Location = New Point(197, 201)
        Kembali.Margin = New Padding(3, 2, 3, 2)
        Kembali.Name = "Kembali"
        Kembali.Size = New Size(308, 23)
        Kembali.TabIndex = 46
        ' 
        ' Kopelpen
        ' 
        Kopelpen.FormattingEnabled = True
        Kopelpen.Location = New Point(197, 251)
        Kopelpen.Margin = New Padding(3, 2, 3, 2)
        Kopelpen.Name = "Kopelpen"
        Kopelpen.Size = New Size(308, 23)
        Kopelpen.TabIndex = 48
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(75, 251)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 19)
        Label8.TabIndex = 47
        Label8.Text = "Kode Plg"
        ' 
        ' Item
        ' 
        Item.Location = New Point(197, 114)
        Item.Margin = New Padding(3, 2, 3, 2)
        Item.Name = "Item"
        Item.Size = New Size(308, 23)
        Item.TabIndex = 49
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(178, 295)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(82, 22)
        Button2.TabIndex = 50
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(285, 295)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(82, 22)
        Button3.TabIndex = 51
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Dibayar
        ' 
        Dibayar.FormattingEnabled = True
        Dibayar.Items.AddRange(New Object() {"dibayar", "belum dibayar"})
        Dibayar.Location = New Point(197, 174)
        Dibayar.Margin = New Padding(3, 2, 3, 2)
        Dibayar.Name = "Dibayar"
        Dibayar.Size = New Size(308, 23)
        Dibayar.TabIndex = 52
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1039, 338)
        Controls.Add(Dibayar)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Item)
        Controls.Add(Kopelpen)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Kembali)
        Controls.Add(Kopempen)
        Controls.Add(Tapen)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(DGVpenj)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(Faktur)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Topen)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form6"
        Text = "Form6"
        CType(DGVpenj, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Kopempen As ComboBox
    Friend WithEvents Tapen As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents DGVpenj As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Faktur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Topen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Kembali As TextBox
    Friend WithEvents Kopelpen As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Item As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Dibayar As ComboBox
End Class
