<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        KodePmk = New TextBox()
        NamaPmk = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        PassPmk = New TextBox()
        Label4 = New Label()
        DGVB = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        StatusPmk = New ComboBox()
        CType(DGVB, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(199, 77)
        TextBox1.Margin = New Padding(6, 4, 6, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(518, 42)
        TextBox1.TabIndex = 0
        TextBox1.Text = "PEMAKAI"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(52, 218)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 34)
        Label1.TabIndex = 2
        Label1.Text = "Kode Pemakai"
        ' 
        ' KodePmk
        ' 
        KodePmk.Location = New Point(290, 205)
        KodePmk.Margin = New Padding(6, 4, 6, 4)
        KodePmk.Name = "KodePmk"
        KodePmk.Size = New Size(427, 39)
        KodePmk.TabIndex = 3
        ' 
        ' NamaPmk
        ' 
        NamaPmk.Location = New Point(290, 286)
        NamaPmk.Margin = New Padding(6, 4, 6, 4)
        NamaPmk.Name = "NamaPmk"
        NamaPmk.Size = New Size(427, 39)
        NamaPmk.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(52, 286)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(235, 34)
        Label2.TabIndex = 4
        Label2.Text = "Nama Pemakai"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(56, 444)
        Label3.Margin = New Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(217, 38)
        Label3.TabIndex = 8
        Label3.Text = "Status Pemakai"
        ' 
        ' PassPmk
        ' 
        PassPmk.Location = New Point(290, 367)
        PassPmk.Margin = New Padding(6, 4, 6, 4)
        PassPmk.Name = "PassPmk"
        PassPmk.Size = New Size(427, 39)
        PassPmk.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(52, 367)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(239, 36)
        Label4.TabIndex = 6
        Label4.Text = "Password Pemakai"
        ' 
        ' DGVB
        ' 
        DGVB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVB.Location = New Point(947, 62)
        DGVB.Margin = New Padding(6, 4, 6, 4)
        DGVB.Name = "DGVB"
        DGVB.RowHeadersWidth = 51
        DGVB.RowTemplate.Height = 29
        DGVB.Size = New Size(748, 474)
        DGVB.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(82, 574)
        Button1.Margin = New Padding(6, 4, 6, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 47)
        Button1.TabIndex = 11
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(262, 574)
        Button2.Margin = New Padding(6, 4, 6, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(152, 47)
        Button2.TabIndex = 12
        Button2.Text = "Hapus"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(449, 574)
        Button3.Margin = New Padding(6, 4, 6, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(152, 47)
        Button3.TabIndex = 13
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(641, 574)
        Button4.Margin = New Padding(6, 4, 6, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(152, 47)
        Button4.TabIndex = 14
        Button4.Text = "Keluar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(StatusPmk)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(KodePmk)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(NamaPmk)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(PassPmk)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(19, 43)
        GroupBox1.Margin = New Padding(6, 4, 6, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(6, 4, 6, 4)
        GroupBox1.Size = New Size(917, 802)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = CStr(ChrW(127))
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(290, 695)
        Button5.Margin = New Padding(6, 4, 6, 4)
        Button5.Name = "Button5"
        Button5.Size = New Size(351, 47)
        Button5.TabIndex = 16
        Button5.Text = "Kembali"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' StatusPmk
        ' 
        StatusPmk.FormattingEnabled = True
        StatusPmk.Items.AddRange(New Object() {"admin", "kasir"})
        StatusPmk.Location = New Point(290, 444)
        StatusPmk.Margin = New Padding(6, 4, 6, 4)
        StatusPmk.Name = "StatusPmk"
        StatusPmk.Size = New Size(427, 40)
        StatusPmk.TabIndex = 15
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2004, 1077)
        Controls.Add(GroupBox1)
        Controls.Add(DGVB)
        Margin = New Padding(6, 4, 6, 4)
        Name = "Form2"
        Text = "Form2"
        CType(DGVB, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents KodePmk As TextBox
    Friend WithEvents NamaPmk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PassPmk As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGVB As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusPmk As ComboBox
    Friend WithEvents Button5 As Button
End Class
