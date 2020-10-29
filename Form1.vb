Public Class Form1
    Dim fileCount As Integer = 0
    Dim ditherFileCount As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.ComboBoxDither.Items.Count > 0 Then
            Me.ComboBoxDither.SelectedIndex = 0
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        If PHD2Guiding.checkPHD2IsRunning Then
            If PHD2Guiding.checkPHD2IsGuiding Then
                If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                    TextBox1.Text = FolderBrowserDialog1.SelectedPath
                    Me.BtnStart.Enabled = True
                    Me.NumericUpDownTCPPort.Enabled = False
                    Me.BtnDither.Enabled = True
                End If
            Else
                MsgBox("PHD is not guiding")
            End If
        Else
            MsgBox("PHD is not running, check PHD has started, Server in enabled and TCP port is correct")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Me.BtnStart.Enabled = False
        Me.BtnStop.Enabled = True
        Me.NumericUpDown1.Enabled = False
        Me.BtnDither.Enabled = False
        Me.ditherFileCount = Me.NumericUpDown1.Value
        Me.fileCount = System.IO.Directory.GetFiles(TextBox1.Text, "*.*").Count
        Timer1.Interval = Me.NumericUpDownScanSeconds.Value * 1000
        NumericUpDownScanSeconds.Enabled = False
        Me.Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        Me.BtnStart.Enabled = True
        Me.BtnStop.Enabled = False
        Me.BtnDither.Enabled = True
        NumericUpDownScanSeconds.Enabled = True
        Me.Timer1.Stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim localFileCount = System.IO.Directory.GetFiles(TextBox1.Text, "*.*").Count
        If localFileCount > Me.fileCount Then
            Me.fileCount = localFileCount
            ditherFileCount -= 1
            If ditherFileCount = 0 Then
                PHD2Guiding.dither()
                ditherFileCount = NumericUpDown1.Value
            End If
        End If
    End Sub

    Private Sub BtnDither_Click(sender As Object, e As EventArgs) Handles BtnDither.Click
        PHD2Guiding.dither()
    End Sub
End Class
