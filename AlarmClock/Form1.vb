Imports System.Runtime.CompilerServices
Imports System.Xml

Public Class Form1
    Public Property Buttons As Array
    Public Property Time_Digits As Array
    Public Property Alarm1_Digits As Array
    Public Property Alarm2_Digits As Array
    Public Property Alarm3_Digits As Array
    Public Property SetButtons As Array
    Public Property ResetButtons As Array
    Public Property Digit_Sets As Array
    Public Property Current_Digits As Array
    Public Property AlarmPictureBoxes As Array
    Public Property CurrentOldDigits As Array
    Public Property OldClockAMPMStates As Array
    Public Property CurrentOldAMPM As RadioButton
    Public Property CurrentSetButton As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel.Visible = False
        Buttons = {Button0, Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}
        Time_Digits = {TimePanel.GetHourDigitOne, TimePanel.GetHourDigitTwo, TimePanel.GetMinuteDigitOne, TimePanel.GetMinuteDigitTwo}
        Alarm1_Digits = {AlarmPanel1.TimePanel.GetHourDigitOne, AlarmPanel1.TimePanel.GetHourDigitTwo, AlarmPanel1.TimePanel.GetMinuteDigitOne, AlarmPanel1.TimePanel.GetMinuteDigitTwo}
        Alarm2_Digits = {AlarmPanel2.TimePanel.GetHourDigitOne, AlarmPanel2.TimePanel.GetHourDigitTwo, AlarmPanel2.TimePanel.GetMinuteDigitOne, AlarmPanel2.TimePanel.GetMinuteDigitTwo}
        Alarm3_Digits = {AlarmPanel3.TimePanel.GetHourDigitOne, AlarmPanel3.TimePanel.GetHourDigitTwo, AlarmPanel3.TimePanel.GetMinuteDigitOne, AlarmPanel3.TimePanel.MinuteDigitTwo}
        SetButtons = {TimePanel.GetSetButton, AlarmPanel1.TimePanel.GetSetButton, AlarmPanel2.TimePanel.GetSetButton, AlarmPanel3.TimePanel.GetSetButton}
        ResetButtons = {TimePanel.GetResetButton, AlarmPanel1.TimePanel.GetResetButton, AlarmPanel2.TimePanel.GetResetButton, AlarmPanel3.TimePanel.GetResetButton}
        Digit_Sets = {Time_Digits, Alarm1_Digits, Alarm2_Digits, Alarm3_Digits}
        AlarmPictureBoxes = {AlarmPanel1.PictureBox, AlarmPanel2.PictureBox, AlarmPanel3.PictureBox}
        CurrentOldDigits = {"0", "0", "0", "0"}
        OldClockAMPMStates = {False, False}
        CurrentSetButton = TimePanel.SetButton
        PictureBox1.Image = My.Resources.Earth
        AlarmPanel1.PictureBox.Image = My.Resources.Twister
        AlarmPanel2.PictureBox.Image = My.Resources.Thrushnod
        AlarmPanel3.PictureBox.Image = My.Resources.Bee
    End Sub

    Private Sub Button_Clicks(sender As Object, e As EventArgs) Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click

        Dim button As Button = sender

        For i = 0 To SetButtons.GetUpperBound(0)
            If SetButtons(i) Is CurrentSetButton Then
                Current_Digits = Digit_Sets(i)
                Exit For
            End If
        Next
        For i = 0 To Current_Digits.GetUpperBound(0)
            If Current_Digits(i).GetCanUpdate = True Then

                Current_Digits(i).Text = button.Text
                Current_Digits(i).MakeBlack()
                Current_Digits(i).SetCanUpdate(False)
                Current_Digits((i + 1) Mod Current_Digits.Length).SetCanUpdate(True)
                If Not i + 1 = Current_Digits.Length Then
                    Current_Digits(i + 1).MakeRed()
                End If

                If (i + 1) = Current_Digits.Length Then
                    For j = 0 To Buttons.GetUpperBound(0)
                        Buttons(j).Enabled = False
                    Next
                    OkayButton.Enabled = True
                    Exit For
                ElseIf (i + 1) = 1 Then
                    For j = 0 To Buttons.GetUpperBound(0)
                        If Current_Digits(0).Text = "0" Then
                            If j <= Current_Digits(i + 1).GetMaxDigit() And Not j = 0 Then
                                Buttons(j).Enabled = True
                            Else
                                Buttons(0).Enabled = False
                            End If


                        Else
                            If j = 0 Or j = 1 Or j = 2 Then
                                Buttons(j).Enabled = True
                            Else
                                Buttons(j).Enabled = False
                            End If

                        End If
                    Next


                ElseIf (i + 1) = 2 Then
                    For j = 0 To Buttons.GetUpperBound(0)
                        If j <= Current_Digits(i + 1).GetMaxDigit() Then
                            Buttons(j).Enabled = True
                        Else
                            Buttons(j).Enabled = False
                        End If
                    Next


                ElseIf (i + 1) = 3 Then
                    For j = 0 To Buttons.GetUpperBound(0)
                        If j <= Current_Digits(i + 1).GetMaxDigit() Then
                            Buttons(j).Enabled = True
                        End If
                    Next
                End If
                Exit For
            End If
        Next

    End Sub

    Private Sub OkayButton_Click(sender As Object, e As EventArgs) Handles OkayButton.Click
        For i = 0 To SetButtons.GetUpperBound(0)
            SetButtons(i).Enabled = True
            ResetButtons(i).Enabled = True
        Next
        Panel.Visible = False
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        For i = 0 To SetButtons.GetUpperBound(0)
            If SetButtons(i) Is CurrentSetButton Then
                Current_Digits = Digit_Sets(i)
                Exit For
            End If
        Next

        For i = 0 To Time_Digits.GetUpperBound(0)
            Current_Digits(i).Text = CurrentOldDigits(i)
            Current_Digits(i).MakeBlack()
        Next

        If CurrentSetButton Is TimePanel.SetButton Then
            If CurrentOldAMPM.Text = "AM" And OldClockAMPMStates(1) = True Then
                CurrentOldAMPM.Checked = False
                TimePanel.PM.Checked = True
            ElseIf CurrentOldAMPM.Text = "PM" And OldClockAMPMStates(0) = True Then
                CurrentOldAMPM.Checked = False
                TimePanel.AM.Checked = True
            Else
                CurrentOldAMPM.Checked = True
            End If
        Else
            CurrentOldAMPM.Checked = True
        End If

        For i = 0 To SetButtons.GetUpperBound(0)
            SetButtons(i).Enabled = True
            ResetButtons(i).Enabled = True
        Next
        Panel.Visible = False
    End Sub
    Private Sub Timer_Tick_1(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim selected_sound As String
        Dim currentTime As String
        If CurrentSetButton Is TimePanel.SetButton And CurrentSetButton.Enabled = False Then
            currentTime = CurrentOldDigits(0) + CurrentOldDigits(1) + CurrentOldDigits(2) + CurrentOldDigits(3)
            If currentTime = "1159" Then
                If OldClockAMPMStates(0) = True Then
                    OldClockAMPMStates(0) = False
                    OldClockAMPMStates(1) = True
                Else
                    OldClockAMPMStates(0) = True
                    OldClockAMPMStates(1) = False
                End If
                CurrentOldDigits(0) = "1"
                CurrentOldDigits(1) = "2"
                CurrentOldDigits(2) = "0"
                CurrentOldDigits(3) = "0"

            ElseIf currentTime = "1259" Then
                CurrentOldDigits(0) = "0"
                CurrentOldDigits(1) = "1"
                CurrentOldDigits(2) = "0"
                CurrentOldDigits(3) = "0"

            ElseIf currentTime = "0959" Then
                CurrentOldDigits(0) = "1"
                CurrentOldDigits(1) = "0"
                CurrentOldDigits(2) = "0"
                CurrentOldDigits(3) = "0"

            ElseIf currentTime(2) = "5" And currentTime(3) = "9" Then
                CurrentOldDigits(1) += 1
                CurrentOldDigits(2) = "0"
                CurrentOldDigits(3) = "0"

            ElseIf currentTime(3) = "9" Then
                CurrentOldDigits(2) += 1
                CurrentOldDigits(3) = "0"

            Else
                CurrentOldDigits(3) += 1
            End If

            currentTime = CurrentOldDigits(0) + CurrentOldDigits(1) + CurrentOldDigits(2) + CurrentOldDigits(3)
            If (currentTime = Alarm1_Digits(0).Text + Alarm1_Digits(1).Text + Alarm1_Digits(2).Text + Alarm1_Digits(3).Text And (OldClockAMPMStates(0) = AlarmPanel1.TimePanel.AM.Checked) And (Alarm1OnBox.Checked)) Then
                selected_sound = AlarmPanel1.AlarmSoundSelection.GetItemText(AlarmPanel1.AlarmSoundSelection.SelectedItem)
                AlarmPanel1.PictureBox.Enabled = True
                My.Computer.Audio.Play("SoundEffects/" + selected_sound + ".wav")
                TabControl.SelectedIndex = 1
            End If

            If (currentTime = Alarm2_Digits(0).Text + Alarm2_Digits(1).Text + Alarm2_Digits(2).Text + Alarm2_Digits(3).Text And (OldClockAMPMStates(0) = AlarmPanel2.TimePanel.AM.Checked) And (Alarm2OnBox.Checked)) Then
                selected_sound = AlarmPanel2.AlarmSoundSelection.GetItemText(AlarmPanel2.AlarmSoundSelection.SelectedItem)
                AlarmPanel2.PictureBox.Enabled = True
                My.Computer.Audio.Play("SoundEffects/" + selected_sound + ".wav")
                TabControl.SelectedIndex = 2
            End If

            If (currentTime = Alarm3_Digits(0).Text + Alarm3_Digits(1).Text + Alarm3_Digits(2).Text + Alarm3_Digits(3).Text) And (OldClockAMPMStates(0) = AlarmPanel3.TimePanel.AM.Checked) And (Alarm3OnBox.Checked) Then
                selected_sound = AlarmPanel3.AlarmSoundSelection.GetItemText(AlarmPanel3.AlarmSoundSelection.SelectedItem)
                AlarmPanel3.PictureBox.Enabled = True
                My.Computer.Audio.Play("SoundEffects/" + selected_sound + ".wav")
                TabControl.SelectedIndex = 3
            End If
        Else
            currentTime = Time_Digits(0).Text + Time_Digits(1).Text + Time_Digits(2).Text + Time_Digits(3).Text
            If currentTime = "1159" Then
                If TimePanel.PM.Checked = True Then
                    TimePanel.AM.Checked = True
                    TimePanel.PM.Checked = False
                Else
                    TimePanel.PM.Checked = True
                    TimePanel.AM.Checked = False
                End If
                Time_Digits(0).Text = "1"
                Time_Digits(1).Text = "2"
                Time_Digits(2).Text = "0"
                Time_Digits(3).Text = "0"

            ElseIf currentTime = "1259" Then
                Time_Digits(0).Text = "1"
                Time_Digits(1).Text = "2"
                Time_Digits(2).Text = "0"
                Time_Digits(3).Text = "0"

            ElseIf currentTime = "0959" Then
                Time_Digits(0).Text = "1"
                Time_Digits(1).Text = "2"
                Time_Digits(2).Text = "0"
                Time_Digits(3).Text = "0"

            ElseIf currentTime(2) = "5" And currentTime(3) = "9" Then
                Time_Digits(1).Text += 1
                Time_Digits(2).Text = "0"
                Time_Digits(3).Text = "0"

            ElseIf currentTime(3) = "9" Then
                Time_Digits(2).Text += 1
                Time_Digits(3).Text = "0"

            Else
                Time_Digits(3).Text += 1
            End If

            currentTime = Time_Digits(0).Text + Time_Digits(1).Text + Time_Digits(2).Text + Time_Digits(3).Text
            If (currentTime = Alarm1_Digits(0).Text + Alarm1_Digits(1).Text + Alarm1_Digits(2).Text + Alarm1_Digits(3).Text) And (TimePanel.AM.Checked = AlarmPanel1.TimePanel.AM.Checked) And (Alarm1OnBox.Checked) Then
                selected_sound = AlarmPanel1.AlarmSoundSelection.GetItemText(AlarmPanel1.AlarmSoundSelection.SelectedItem)
                AlarmPanel1.PictureBox.Enabled = True
                My.Computer.Audio.Play("SoundEffects/" + selected_sound + ".wav")
                TabControl.SelectedIndex = 1
            End If

            If (currentTime = Alarm2_Digits(0).Text + Alarm2_Digits(1).Text + Alarm2_Digits(2).Text + Alarm2_Digits(3).Text) And (TimePanel.AM.Checked = AlarmPanel2.TimePanel.AM.Checked) And (Alarm2OnBox.Checked) Then
                selected_sound = AlarmPanel2.AlarmSoundSelection.GetItemText(AlarmPanel2.AlarmSoundSelection.SelectedItem)
                AlarmPanel2.PictureBox.Enabled = True
                My.Computer.Audio.Play("SoundEffects/" + selected_sound + ".wav")
                TabControl.SelectedIndex = 2
            End If

            If (currentTime = Alarm3_Digits(0).Text + Alarm3_Digits(1).Text + Alarm3_Digits(2).Text + Alarm3_Digits(3).Text) And (TimePanel.AM.Checked = AlarmPanel3.TimePanel.AM.Checked) And (Alarm3OnBox.Checked) Then
                selected_sound = AlarmPanel3.AlarmSoundSelection.GetItemText(AlarmPanel3.AlarmSoundSelection.SelectedItem)
                AlarmPanel3.PictureBox.Enabled = True
                My.Computer.Audio.Play("SoundEffects/" + selected_sound + ".wav")
                TabControl.SelectedIndex = 3
            End If
        End If

    End Sub

    Private Sub Alarm1OnButton_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm1OnBox.CheckedChanged
        If sender.Checked = True Then
            AlarmPanel1.OnBox.Checked = True
        Else
            AlarmPanel1.OnBox.Checked = False
        End If
    End Sub

    Private Sub Alarm2OnButton_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm2OnBox.CheckedChanged
        If sender.Checked = True Then
            AlarmPanel2.OnBox.Checked = True
        Else
            AlarmPanel2.OnBox.Checked = False
        End If
    End Sub

    Private Sub Alarm3OnButton_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm3OnBox.CheckedChanged
        If sender.Checked = True Then
            AlarmPanel3.OnBox.Checked = True
        Else
            AlarmPanel3.OnBox.Checked = False
        End If
    End Sub
End Class
