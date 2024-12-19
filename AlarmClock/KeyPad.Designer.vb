<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeyPad
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        OkayButton = New Button()
        CancelButton = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button0 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(OkayButton)
        Panel1.Controls.Add(CancelButton)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button0)
        Panel1.Location = New Point(19, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(464, 246)
        Panel1.TabIndex = 0
        ' 
        ' OkayButton
        ' 
        OkayButton.Location = New Point(368, 0)
        OkayButton.Name = "OkayButton"
        OkayButton.Size = New Size(96, 246)
        OkayButton.TabIndex = 11
        OkayButton.Text = "OKAY"
        OkayButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(0, 165)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(371, 81)
        CancelButton.TabIndex = 10
        CancelButton.Text = "CANCEL"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(294, 83)
        Button9.Name = "Button9"
        Button9.Size = New Size(77, 87)
        Button9.TabIndex = 9
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(222, 83)
        Button8.Name = "Button8"
        Button8.Size = New Size(77, 87)
        Button8.TabIndex = 8
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(148, 83)
        Button7.Name = "Button7"
        Button7.Size = New Size(77, 87)
        Button7.TabIndex = 7
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(74, 83)
        Button6.Name = "Button6"
        Button6.Size = New Size(77, 87)
        Button6.TabIndex = 6
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(0, 83)
        Button5.Name = "Button5"
        Button5.Size = New Size(77, 87)
        Button5.TabIndex = 5
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(294, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(77, 87)
        Button4.TabIndex = 4
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(222, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(77, 87)
        Button3.TabIndex = 3
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(148, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(77, 87)
        Button2.TabIndex = 2
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(74, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(77, 87)
        Button1.TabIndex = 1
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button0
        ' 
        Button0.Location = New Point(0, 0)
        Button0.Name = "Button0"
        Button0.Size = New Size(77, 87)
        Button0.TabIndex = 0
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = True
        ' 
        ' KeyPad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "KeyPad"
        Size = New Size(491, 260)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button0 As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents OkayButton As Button

End Class
