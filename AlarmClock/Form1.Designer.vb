<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl = New TabControl()
        TabPage1 = New TabPage()
        Alarm2OnBox = New CheckBox()
        Alarm3OnBox = New CheckBox()
        TimePanel = New TimePanel()
        PictureBox1 = New PictureBox()
        Alarm1OnBox = New CheckBox()
        TabPage2 = New TabPage()
        AlarmPanel1 = New AlarmPanel()
        TabPage3 = New TabPage()
        AlarmPanel2 = New AlarmPanel()
        TabPage4 = New TabPage()
        AlarmPanel3 = New AlarmPanel()
        KeyPad1 = New KeyPad()
        KeyPad2 = New KeyPad()
        KeyPad3 = New KeyPad()
        Panel = New Panel()
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
        Timer = New Timer(components)
        TabControl.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabPage1)
        TabControl.Controls.Add(TabPage2)
        TabControl.Controls.Add(TabPage3)
        TabControl.Controls.Add(TabPage4)
        TabControl.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl.Location = New Point(1, 0)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(373, 325)
        TabControl.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Alarm2OnBox)
        TabPage1.Controls.Add(Alarm3OnBox)
        TabPage1.Controls.Add(TimePanel)
        TabPage1.Controls.Add(PictureBox1)
        TabPage1.Controls.Add(Alarm1OnBox)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(365, 297)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Clock"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Alarm2OnBox
        ' 
        Alarm2OnBox.AutoSize = True
        Alarm2OnBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Alarm2OnBox.Location = New Point(184, 209)
        Alarm2OnBox.Name = "Alarm2OnBox"
        Alarm2OnBox.Size = New Size(88, 19)
        Alarm2OnBox.TabIndex = 8
        Alarm2OnBox.Text = "Alarm 2 On"
        Alarm2OnBox.UseVisualStyleBackColor = True
        ' 
        ' Alarm3OnBox
        ' 
        Alarm3OnBox.AutoSize = True
        Alarm3OnBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Alarm3OnBox.Location = New Point(184, 244)
        Alarm3OnBox.Name = "Alarm3OnBox"
        Alarm3OnBox.Size = New Size(88, 19)
        Alarm3OnBox.TabIndex = 9
        Alarm3OnBox.Text = "Alarm 3 On"
        Alarm3OnBox.UseVisualStyleBackColor = True
        ' 
        ' TimePanel
        ' 
        TimePanel.ForeColor = Color.Black
        TimePanel.Location = New Point(-4, 0)
        TimePanel.Name = "TimePanel"
        TimePanel.Size = New Size(369, 153)
        TimePanel.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Enabled = False
        PictureBox1.Location = New Point(28, 159)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(144, 128)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Alarm1OnBox
        ' 
        Alarm1OnBox.AutoSize = True
        Alarm1OnBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Alarm1OnBox.Location = New Point(184, 172)
        Alarm1OnBox.Name = "Alarm1OnBox"
        Alarm1OnBox.Size = New Size(88, 19)
        Alarm1OnBox.TabIndex = 7
        Alarm1OnBox.Text = "Alarm 1 On"
        Alarm1OnBox.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(AlarmPanel1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(192, 72)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Alarm 1"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel1
        ' 
        AlarmPanel1.Location = New Point(-3, 0)
        AlarmPanel1.Name = "AlarmPanel1"
        AlarmPanel1.Size = New Size(369, 294)
        AlarmPanel1.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(AlarmPanel2)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(192, 72)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Alarm 2"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel2
        ' 
        AlarmPanel2.Location = New Point(-4, 3)
        AlarmPanel2.Name = "AlarmPanel2"
        AlarmPanel2.Size = New Size(369, 294)
        AlarmPanel2.TabIndex = 6
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(AlarmPanel3)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(192, 72)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Alarm 3"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel3
        ' 
        AlarmPanel3.Location = New Point(-1, 0)
        AlarmPanel3.Name = "AlarmPanel3"
        AlarmPanel3.Size = New Size(369, 294)
        AlarmPanel3.TabIndex = 1
        ' 
        ' KeyPad1
        ' 
        KeyPad1.Location = New Point(74, 320)
        KeyPad1.Name = "KeyPad1"
        KeyPad1.Size = New Size(536, 260)
        KeyPad1.TabIndex = 2
        ' 
        ' KeyPad2
        ' 
        KeyPad2.Location = New Point(93, 311)
        KeyPad2.Name = "KeyPad2"
        KeyPad2.Size = New Size(508, 251)
        KeyPad2.TabIndex = 3
        ' 
        ' KeyPad3
        ' 
        KeyPad3.Location = New Point(102, 320)
        KeyPad3.Name = "KeyPad3"
        KeyPad3.Size = New Size(474, 257)
        KeyPad3.TabIndex = 4
        ' 
        ' Panel
        ' 
        Panel.Controls.Add(OkayButton)
        Panel.Controls.Add(CancelButton)
        Panel.Controls.Add(Button9)
        Panel.Controls.Add(Button8)
        Panel.Controls.Add(Button7)
        Panel.Controls.Add(Button6)
        Panel.Controls.Add(Button5)
        Panel.Controls.Add(Button4)
        Panel.Controls.Add(Button3)
        Panel.Controls.Add(Button2)
        Panel.Controls.Add(Button1)
        Panel.Controls.Add(Button0)
        Panel.Location = New Point(1, 317)
        Panel.Name = "Panel"
        Panel.Size = New Size(373, 254)
        Panel.TabIndex = 5
        ' 
        ' OkayButton
        ' 
        OkayButton.Location = New Point(173, 170)
        OkayButton.Name = "OkayButton"
        OkayButton.Size = New Size(200, 84)
        OkayButton.TabIndex = 12
        OkayButton.Text = "OKAY"
        OkayButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(0, 170)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(176, 84)
        CancelButton.TabIndex = 11
        CancelButton.Text = "CANCEL"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(296, 85)
        Button9.Name = "Button9"
        Button9.Size = New Size(77, 87)
        Button9.TabIndex = 10
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(222, 85)
        Button8.Name = "Button8"
        Button8.Size = New Size(77, 87)
        Button8.TabIndex = 9
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(148, 85)
        Button7.Name = "Button7"
        Button7.Size = New Size(77, 87)
        Button7.TabIndex = 8
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(74, 85)
        Button6.Name = "Button6"
        Button6.Size = New Size(77, 87)
        Button6.TabIndex = 7
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(0, 85)
        Button5.Name = "Button5"
        Button5.Size = New Size(77, 87)
        Button5.TabIndex = 6
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(296, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(77, 87)
        Button4.TabIndex = 5
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(222, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(77, 87)
        Button3.TabIndex = 4
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(148, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(77, 87)
        Button2.TabIndex = 3
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(74, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(77, 87)
        Button1.TabIndex = 2
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button0
        ' 
        Button0.Location = New Point(0, 0)
        Button0.Name = "Button0"
        Button0.Size = New Size(77, 87)
        Button0.TabIndex = 1
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = True
        ' 
        ' Timer
        ' 
        Timer.Enabled = True
        Timer.Interval = 60000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(376, 571)
        Controls.Add(Panel)
        Controls.Add(KeyPad3)
        Controls.Add(KeyPad2)
        Controls.Add(KeyPad1)
        Controls.Add(TabControl)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alarm Clock App"
        TabControl.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        Panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TimePanel As TimePanel
    Friend WithEvents KeyPad1 As KeyPad
    Friend WithEvents KeyPad2 As KeyPad
    Friend WithEvents KeyPad3 As KeyPad
    Friend WithEvents Panel As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents OkayButton As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Alarm1OnBox As CheckBox
    Friend WithEvents Alarm2OnBox As CheckBox
    Friend WithEvents Alarm3OnBox As CheckBox
    Friend WithEvents AlarmPanel1 As AlarmPanel
    Friend WithEvents AlarmPanel2 As AlarmPanel
    Friend WithEvents AlarmPanel3 As AlarmPanel

End Class
