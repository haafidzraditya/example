<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        EmailPlg = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        KodePlg = New TextBox()
        Button2 = New Button()
        Label2 = New Label()
        Button1 = New Button()
        NamaPlg = New TextBox()
        Label4 = New Label()
        TeleponPlg = New TextBox()
        AlamatPlg = New TextBox()
        Label3 = New Label()
        DGVB = New DataGridView()
        JK = New ComboBox()
        Button5 = New Button()
        CType(DGVB, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EmailPlg
        ' 
        EmailPlg.Location = New Point(180, 225)
        EmailPlg.Margin = New Padding(3, 2, 3, 2)
        EmailPlg.Name = "EmailPlg"
        EmailPlg.Size = New Size(232, 23)
        EmailPlg.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(31, 227)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 17)
        Label6.TabIndex = 17
        Label6.Text = "Email Pelanggan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(31, 259)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 17)
        Label5.TabIndex = 15
        Label5.Text = "Jenis Kelamin"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(43, 26)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(281, 25)
        TextBox1.TabIndex = 0
        TextBox1.Text = "PELANGGAN"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(345, 297)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(82, 22)
        Button4.TabIndex = 14
        Button4.Text = "Keluar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(29, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 17)
        Label1.TabIndex = 2
        Label1.Text = "Kode Pelanggan"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(257, 297)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(82, 22)
        Button3.TabIndex = 13
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' KodePlg
        ' 
        KodePlg.Location = New Point(180, 86)
        KodePlg.Margin = New Padding(3, 2, 3, 2)
        KodePlg.Name = "KodePlg"
        KodePlg.Size = New Size(232, 23)
        KodePlg.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(156, 297)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(82, 22)
        Button2.TabIndex = 12
        Button2.Text = "Hapus"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(29, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 17)
        Label2.TabIndex = 4
        Label2.Text = "Nama Pelanggan"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(59, 297)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 22)
        Button1.TabIndex = 11
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' NamaPlg
        ' 
        NamaPlg.Location = New Point(180, 123)
        NamaPlg.Margin = New Padding(3, 2, 3, 2)
        NamaPlg.Name = "NamaPlg"
        NamaPlg.Size = New Size(232, 23)
        NamaPlg.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(29, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 17)
        Label4.TabIndex = 6
        Label4.Text = "Alamat Pelanggan"
        ' 
        ' TeleponPlg
        ' 
        TeleponPlg.Location = New Point(182, 192)
        TeleponPlg.Margin = New Padding(3, 2, 3, 2)
        TeleponPlg.Name = "TeleponPlg"
        TeleponPlg.Size = New Size(232, 23)
        TeleponPlg.TabIndex = 9
        ' 
        ' AlamatPlg
        ' 
        AlamatPlg.Location = New Point(180, 157)
        AlamatPlg.Margin = New Padding(3, 2, 3, 2)
        AlamatPlg.Name = "AlamatPlg"
        AlamatPlg.Size = New Size(232, 23)
        AlamatPlg.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(29, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 17)
        Label3.TabIndex = 8
        Label3.Text = "Telepon Pelanggan"
        ' 
        ' DGVB
        ' 
        DGVB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVB.Location = New Point(461, 26)
        DGVB.Margin = New Padding(3, 2, 3, 2)
        DGVB.Name = "DGVB"
        DGVB.RowHeadersWidth = 51
        DGVB.RowTemplate.Height = 29
        DGVB.Size = New Size(413, 232)
        DGVB.TabIndex = 17
        ' 
        ' JK
        ' 
        JK.FormattingEnabled = True
        JK.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        JK.Location = New Point(180, 258)
        JK.Margin = New Padding(3, 2, 3, 2)
        JK.Name = "JK"
        JK.Size = New Size(232, 23)
        JK.TabIndex = 19
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(192, 342)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(97, 29)
        Button5.TabIndex = 20
        Button5.Text = "Kembali"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1199, 416)
        Controls.Add(Button5)
        Controls.Add(JK)
        Controls.Add(DGVB)
        Controls.Add(EmailPlg)
        Controls.Add(Label6)
        Controls.Add(Button4)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(AlamatPlg)
        Controls.Add(TeleponPlg)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(NamaPlg)
        Controls.Add(KodePlg)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form5"
        Text = "Form5"
        CType(DGVB, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents KodePlg As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents NamaPlg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TeleponPlg As TextBox
    Friend WithEvents AlamatPlg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVB As DataGridView
    Friend WithEvents EmailPlg As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents JK As ComboBox
    Friend WithEvents Button5 As Button
End Class
