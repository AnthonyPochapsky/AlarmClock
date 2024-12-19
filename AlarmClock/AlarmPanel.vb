Imports System.IO
Imports System.Net.Security

Public Class AlarmPanel
    Private Sub OnBox_CheckedChanged(sender As Object, e As EventArgs) Handles OnBox.CheckedChanged
        If sender Is Form1.AlarmPanel1.OnBox Then
            If sender.Checked = True Then
                Form1.Alarm1OnBox.Checked = True
            Else
                Form1.Alarm1OnBox.Checked = False
            End If

        ElseIf sender Is Form1.AlarmPanel2.OnBox Then
            If sender.Checked = True Then
                Form1.Alarm2OnBox.Checked = True
            Else
                Form1.Alarm2OnBox.Checked = False

            End If
        Else
            If sender.Checked = True Then
                Form1.Alarm3OnBox.Checked = True
            Else
                Form1.Alarm3OnBox.Checked = False

            End If
        End If

    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox.Click
        If sender.Enabled = True Then
            My.Computer.Audio.Stop()
            sender.Enabled = False
        End If
    End Sub

    Private Sub AlarmSoundSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AlarmSoundSelection.SelectedIndexChanged
    End Sub

    Private Sub AlarmPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AlarmSoundSelection.SetSelected(0, True)
    End Sub
End Class
