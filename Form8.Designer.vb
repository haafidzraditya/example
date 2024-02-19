<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(228, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(300, 37)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME ADMIN"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(32, 100)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 42)
        Button1.TabIndex = 1
        Button1.Text = "Form Barang"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(32, 209)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 42)
        Button2.TabIndex = 2
        Button2.Text = "Form Pemakai"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(563, 100)
        Button3.Name = "Button3"
        Button3.Size = New Size(172, 42)
        Button3.TabIndex = 3
        Button3.Text = "Form Pemasok"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(266, 147)
        Button4.Name = "Button4"
        Button4.Size = New Size(246, 42)
        Button4.TabIndex = 4
        Button4.Text = "Form Penerimaan"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(294, 316)
        Button5.Name = "Button5"
        Button5.Size = New Size(176, 42)
        Button5.TabIndex = 5
        Button5.Text = "Keluar"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(563, 209)
        Button6.Name = "Button6"
        Button6.Size = New Size(176, 42)
        Button6.TabIndex = 6
        Button6.Text = "Kembali"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form8"
        Text = "Form8"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
