Public Class TimePanel
    Property Digits As Array
    Private Sub TimePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HourDigitOne.SetMaxDigit(1)
        HourDigitTwo.SetMaxDigit(9)
        MinuteDigitOne.SetMaxDigit(5)
        MinuteDigitTwo.SetMaxDigit(9)
        Digits = {HourDigitOne, HourDigitTwo, MinuteDigitOne, MinuteDigitTwo}
        If sender Is Form1.TimePanel Then
            ResetClockTime()
        Else
            AM.Checked = True
        End If
    End Sub
    Public Function GetHourDigitOne()
        Return HourDigitOne
    End Function
    Public Function GetHourDigitTwo()
        Return HourDigitTwo
    End Function
    Public Function GetMinuteDigitOne()
        Return MinuteDigitOne
    End Function
    Public Function GetMinuteDigitTwo()
        Return MinuteDigitTwo
    End Function
    Public Sub SetHourDigitOne(digit_char As Char)
        HourDigitOne.Text = digit_char
    End Sub
    Public Sub SetHourDigitTwo(digit_char As Char)
        HourDigitTwo.Text = digit_char
    End Sub
    Public Sub SetMinuteDigitOne(digit_char As Char)
        HourDigitOne.Text = digit_char
    End Sub
    Public Sub SetMinuteDigitTwo(digit_char As Char)
        MinuteDigitTwo.Text = digit_char
    End Sub
    Public Function GetResetButton()
        Return ResetButton
    End Function
    Public Function GetSetButton()
        Return SetButton
    End Function

    Private Sub ResetClockTime()
        Dim current_time As String = Format(Now)
        Dim whitespace As Boolean = False
        Dim digits As String = ""
        Dim am_pm As Char = ""
        For i = 0 To current_time.Length - 1
            If whitespace = True Then
                If Char.IsDigit(current_time, i) Then
                    digits &= current_time(i)
                ElseIf current_time(i) = "A" Or current_time(i) = "P" Then
                    am_pm = current_time(i)
                    Exit For
                End If
            ElseIf current_time(i) = " " Then
                whitespace = True
            End If
        Next
        If digits.Length = 5 Then
            HourDigitOne.Text = "0"
            HourDigitTwo.Text = digits(0)
            MinuteDigitOne.Text = digits(1)
            MinuteDigitTwo.Text = digits(2)
        Else
            HourDigitOne.Text = digits(0)
            HourDigitTwo.Text = digits(1)
            MinuteDigitOne.Text = digits(2)
            MinuteDigitTwo.Text = digits(3)
        End If

        If am_pm = "A" Then
            AM.Checked = True
        Else
            PM.Checked = True
            AM.Checked = False
        End If
        Form1.Timer.Enabled = False
        Form1.Timer.Enabled = True
    End Sub



    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        Form1.CurrentSetButton = sender
        If AM.Checked = True Then
            Form1.CurrentOldAMPM = AM
        Else
            Form1.CurrentOldAMPM = PM
        End If

        For i = 0 To Digits.GetUpperBound(0)
            If i = 0 Then
                Digits(0).SetCanUpdate(True)
            Else
                Digits(i).SetCanUpdate(False)
            End If
            Form1.CurrentOldDigits(i) = Digits(i).Text
            Digits(i).Text = "0"
        Next
        If sender Is Form1.TimePanel.SetButton Then
            If AM.Checked = True Then
                Form1.OldClockAMPMStates(0) = True
                Form1.OldClockAMPMStates(1) = False
            Else
                Form1.OldClockAMPMStates(0) = False
                Form1.OldClockAMPMStates(1) = True
            End If
        End If
        Form1.Panel.Visible = True
        AM.Checked = True
        PM.Checked = False
        Form1.OkayButton.Enabled = False

        For i = 0 To Form1.SetButtons.GetUpperBound(0)
            Form1.SetButtons(i).Enabled = False
            Form1.ResetButtons(i).Enabled = False
        Next

        For i = 0 To Form1.Buttons.GetUpperBound(0)
            If i = 0 Or i = 1 Then
                Form1.Buttons(i).Enabled = True
            Else
                Form1.Buttons(i).Enabled = False
            End If
        Next

        HourDigitOne.MakeRed()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If sender Is Form1.TimePanel.ResetButton Then
            ResetClockTime()
        Else
            For i = 0 To Digits.GetUpperBound(0)
                Digits(i).Text = "0"
                Digits(i).MakeBlack()
                AM.Checked = True
                PM.Checked = False
            Next

        End If

    End Sub

End Class
