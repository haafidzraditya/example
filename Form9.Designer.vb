<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(455, 45)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(586, 75)
        Label1.TabIndex = 1
        Label1.Text = "WELCOME KASIR"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(71, 203)
        Button1.Margin = New Padding(6, 6, 6, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(337, 90)
        Button1.TabIndex = 2
        Button1.Text = "Form Penjualan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(420, 203)
        Button2.Margin = New Padding(6, 6, 6, 6)
        Button2.Name = "Button2"
        Button2.Size = New Size(361, 90)
        Button2.TabIndex = 3
        Button2.Text = "Form Pelanggan"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(1144, 203)
        Button3.Margin = New Padding(6, 6, 6, 6)
        Button3.Name = "Button3"
        Button3.Size = New Size(319, 90)
        Button3.TabIndex = 4
        Button3.Text = "Keluar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(793, 203)
        Button4.Margin = New Padding(6, 6, 6, 6)
        Button4.Name = "Button4"
        Button4.Size = New Size(319, 90)
        Button4.TabIndex = 5
        Button4.Text = "Kembali"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1486, 960)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Margin = New Padding(6, 6, 6, 6)
        Name = "Form9"
        Text = "Form9"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
