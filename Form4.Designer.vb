<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        TextBox1 = New TextBox()
        DGVB = New DataGridView()
        Label1 = New Label()
        Notem = New TextBox()
        Label4 = New Label()
        Nobon = New TextBox()
        Label5 = New Label()
        Totem = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label3 = New Label()
        Label6 = New Label()
        Button4 = New Button()
        Label2 = New Label()
        Tatem = New DateTimePicker()
        kopenPMS = New ComboBox()
        kopenPMK = New ComboBox()
        Button5 = New Button()
        CType(DGVB, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(10, 32)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(522, 25)
        TextBox1.TabIndex = 0
        TextBox1.Text = "PENERIMAAN"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' DGVB
        ' 
        DGVB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVB.Location = New Point(569, 32)
        DGVB.Margin = New Padding(3, 2, 3, 2)
        DGVB.Name = "DGVB"
        DGVB.RowHeadersWidth = 51
        DGVB.RowTemplate.Height = 29
        DGVB.Size = New Size(364, 284)
        DGVB.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(62, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 17)
        Label1.TabIndex = 0
        Label1.Text = "Nomor Terima"
        ' 
        ' Notem
        ' 
        Notem.Location = New Point(184, 72)
        Notem.Margin = New Padding(3, 2, 3, 2)
        Notem.Name = "Notem"
        Notem.Size = New Size(308, 23)
        Notem.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(62, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 17)
        Label4.TabIndex = 6
        Label4.Text = "Nomor Bon"
        ' 
        ' Nobon
        ' 
        Nobon.Location = New Point(184, 168)
        Nobon.Margin = New Padding(3, 2, 3, 2)
        Nobon.Name = "Nobon"
        Nobon.Size = New Size(308, 23)
        Nobon.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(62, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 17)
        Label5.TabIndex = 8
        Label5.Text = "Total Terima"
        ' 
        ' Totem
        ' 
        Totem.Location = New Point(184, 202)
        Totem.Margin = New Padding(3, 2, 3, 2)
        Totem.Name = "Totem"
        Totem.Size = New Size(308, 23)
        Totem.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(60, 294)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 22)
        Button1.TabIndex = 13
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(165, 294)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(82, 22)
        Button2.TabIndex = 14
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(276, 294)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(82, 22)
        Button3.TabIndex = 15
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(62, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 17)
        Label3.TabIndex = 16
        Label3.Text = "Kode Pms"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(62, 237)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 17)
        Label6.TabIndex = 18
        Label6.Text = "Kode Pmk"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(382, 294)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(82, 22)
        Button4.TabIndex = 21
        Button4.Text = "Keluar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(62, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 17)
        Label2.TabIndex = 22
        Label2.Text = "Tanggal Terima"
        ' 
        ' Tatem
        ' 
        Tatem.Location = New Point(184, 103)
        Tatem.Margin = New Padding(3, 2, 3, 2)
        Tatem.Name = "Tatem"
        Tatem.Size = New Size(308, 23)
        Tatem.TabIndex = 24
        ' 
        ' kopenPMS
        ' 
        kopenPMS.FormattingEnabled = True
        kopenPMS.Location = New Point(184, 136)
        kopenPMS.Margin = New Padding(3, 2, 3, 2)
        kopenPMS.Name = "kopenPMS"
        kopenPMS.Size = New Size(308, 23)
        kopenPMS.TabIndex = 25
        ' 
        ' kopenPMK
        ' 
        kopenPMK.FormattingEnabled = True
        kopenPMK.Location = New Point(184, 237)
        kopenPMK.Margin = New Padding(3, 2, 3, 2)
        kopenPMK.Name = "kopenPMK"
        kopenPMK.Size = New Size(308, 23)
        kopenPMK.TabIndex = 26
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(165, 356)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(193, 22)
        Button5.TabIndex = 27
        Button5.Text = "Kembali"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1012, 436)
        Controls.Add(Button5)
        Controls.Add(kopenPMK)
        Controls.Add(kopenPMS)
        Controls.Add(Tatem)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(DGVB)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(Notem)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Nobon)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(Totem)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form4"
        Text = "Form4"
        CType(DGVB, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DGVB As DataGridView
    Friend WithEvents kodePMK As TextBox
    Friend WithEvents kopenPMS As ComboBox
    Friend WithEvents kodePMS As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Notem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Nobon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Totem As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Tatem As DateTimePicker
    Friend WithEvents kopenPMK As ComboBox
    Friend WithEvents Button5 As Button
End Class
