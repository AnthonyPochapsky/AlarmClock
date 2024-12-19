<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmPanel
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
        PictureBox = New PictureBox()
        AlarmSoundSelection = New ListBox()
        OnBox = New CheckBox()
        TimePanel = New TimePanel()
        CType(PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox
        ' 
        PictureBox.Enabled = False
        PictureBox.Location = New Point(25, 176)
        PictureBox.Name = "PictureBox"
        PictureBox.Size = New Size(117, 107)
        PictureBox.TabIndex = 1
        PictureBox.TabStop = False
        ' 
        ' AlarmSoundSelection
        ' 
        AlarmSoundSelection.FormattingEnabled = True
        AlarmSoundSelection.ItemHeight = 15
        AlarmSoundSelection.Items.AddRange(New Object() {"Crickets", "Bird", "Cow", "DrumRoll", "BoatHorn", "Fanfare", "Train"})
        AlarmSoundSelection.Location = New Point(148, 176)
        AlarmSoundSelection.Name = "AlarmSoundSelection"
        AlarmSoundSelection.Size = New Size(139, 79)
        AlarmSoundSelection.TabIndex = 2
        ' 
        ' OnBox
        ' 
        OnBox.AutoSize = True
        OnBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        OnBox.Location = New Point(169, 264)
        OnBox.Name = "OnBox"
        OnBox.Size = New Size(78, 19)
        OnBox.TabIndex = 3
        OnBox.Text = "Alarm On"
        OnBox.UseVisualStyleBackColor = True
        ' 
        ' TimePanel
        ' 
        TimePanel.Location = New Point(3, 3)
        TimePanel.Name = "TimePanel"
        TimePanel.Size = New Size(367, 157)
        TimePanel.TabIndex = 4
        ' 
        ' AlarmPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TimePanel)
        Controls.Add(OnBox)
        Controls.Add(AlarmSoundSelection)
        Controls.Add(PictureBox)
        Name = "AlarmPanel"
        Size = New Size(366, 293)
        CType(PictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents AlarmSoundSelection As ListBox
    Friend WithEvents OnBox As CheckBox
    Friend WithEvents TimePanel As TimePanel

End Class
