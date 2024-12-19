<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimePanel
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
        ResetButton = New Button()
        AM = New RadioButton()
        PM = New RadioButton()
        SetButton = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        HourDigitOne = New DigitLED()
        HourDigitTwo = New DigitLED()
        MinuteDigitOne = New DigitLED()
        MinuteDigitTwo = New DigitLED()
        Colon = New Label()
        Hour_label = New Label()
        Minute_label = New Label()
        SuspendLayout()
        ' 
        ' ResetButton
        ' 
        ResetButton.Location = New Point(175, 109)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(103, 36)
        ResetButton.TabIndex = 0
        ResetButton.Text = "RESET"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' AM
        ' 
        AM.AutoSize = True
        AM.Location = New Point(310, 56)
        AM.Name = "AM"
        AM.Size = New Size(44, 19)
        AM.TabIndex = 2
        AM.TabStop = True
        AM.Text = "AM"
        AM.UseVisualStyleBackColor = True
        ' 
        ' PM
        ' 
        PM.AutoSize = True
        PM.Location = New Point(310, 93)
        PM.Name = "PM"
        PM.Size = New Size(43, 19)
        PM.TabIndex = 3
        PM.TabStop = True
        PM.Text = "PM"
        PM.UseVisualStyleBackColor = True
        ' 
        ' SetButton
        ' 
        SetButton.Location = New Point(19, 109)
        SetButton.Name = "SetButton"
        SetButton.Size = New Size(103, 36)
        SetButton.TabIndex = 4
        SetButton.Text = "SET"
        SetButton.UseVisualStyleBackColor = True
        ' 
        ' HourDigitOne
        ' 
        HourDigitOne.AutoSize = True
        HourDigitOne.BorderStyle = BorderStyle.FixedSingle
        HourDigitOne.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        HourDigitOne.Location = New Point(30, 20)
        HourDigitOne.MaxDigit = 0
        HourDigitOne.Name = "HourDigitOne"
        HourDigitOne.Size = New Size(27, 32)
        HourDigitOne.TabIndex = 5
        HourDigitOne.Text = "0"
        ' 
        ' HourDigitTwo
        ' 
        HourDigitTwo.AutoSize = True
        HourDigitTwo.BorderStyle = BorderStyle.FixedSingle
        HourDigitTwo.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        HourDigitTwo.Location = New Point(95, 20)
        HourDigitTwo.MaxDigit = 0
        HourDigitTwo.Name = "HourDigitTwo"
        HourDigitTwo.Size = New Size(27, 32)
        HourDigitTwo.TabIndex = 6
        HourDigitTwo.Text = "0"
        ' 
        ' MinuteDigitOne
        ' 
        MinuteDigitOne.AutoSize = True
        MinuteDigitOne.BorderStyle = BorderStyle.FixedSingle
        MinuteDigitOne.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        MinuteDigitOne.Location = New Point(189, 20)
        MinuteDigitOne.MaxDigit = 0
        MinuteDigitOne.Name = "MinuteDigitOne"
        MinuteDigitOne.Size = New Size(27, 32)
        MinuteDigitOne.TabIndex = 7
        MinuteDigitOne.Text = "0"
        ' 
        ' MinuteDigitTwo
        ' 
        MinuteDigitTwo.AutoSize = True
        MinuteDigitTwo.BorderStyle = BorderStyle.FixedSingle
        MinuteDigitTwo.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        MinuteDigitTwo.Location = New Point(251, 21)
        MinuteDigitTwo.MaxDigit = 0
        MinuteDigitTwo.Name = "MinuteDigitTwo"
        MinuteDigitTwo.Size = New Size(27, 32)
        MinuteDigitTwo.TabIndex = 8
        MinuteDigitTwo.Text = "0"
        ' 
        ' Colon
        ' 
        Colon.AutoSize = True
        Colon.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Colon.Location = New Point(150, 15)
        Colon.Name = "Colon"
        Colon.Size = New Size(23, 37)
        Colon.TabIndex = 9
        Colon.Text = ":"
        ' 
        ' Hour_label
        ' 
        Hour_label.AutoSize = True
        Hour_label.Location = New Point(128, 37)
        Hour_label.Name = "Hour_label"
        Hour_label.Size = New Size(16, 15)
        Hour_label.TabIndex = 10
        Hour_label.Text = "H"
        ' 
        ' Minute_label
        ' 
        Minute_label.AutoSize = True
        Minute_label.Location = New Point(284, 38)
        Minute_label.Name = "Minute_label"
        Minute_label.Size = New Size(18, 15)
        Minute_label.TabIndex = 11
        Minute_label.Text = "M"
        ' 
        ' TimePanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Minute_label)
        Controls.Add(Hour_label)
        Controls.Add(Colon)
        Controls.Add(MinuteDigitTwo)
        Controls.Add(MinuteDigitOne)
        Controls.Add(HourDigitTwo)
        Controls.Add(HourDigitOne)
        Controls.Add(SetButton)
        Controls.Add(PM)
        Controls.Add(AM)
        Controls.Add(ResetButton)
        Name = "TimePanel"
        Size = New Size(359, 160)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ResetButton As Button
    Friend WithEvents AM As RadioButton
    Friend WithEvents PM As RadioButton
    Friend WithEvents SetButton As Button
    Friend WithEvents HourDigitTwo As DigitLED
    Friend WithEvents MinuteDigitOne As DigitLED
    Friend WithEvents MinuteDigitTwo As DigitLED
    Friend WithEvents Digitled4 As DigitLED
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents HourDigitOne As DigitLED
    Friend WithEvents Colon As Label
    Friend WithEvents Hour_label As Label
    Friend WithEvents Minute_label As Label

End Class
