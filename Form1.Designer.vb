<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnDither = New System.Windows.Forms.Button()
        Me.ToolTipDither = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelTCPPort = New System.Windows.Forms.Label()
        Me.NumericUpDownTCPPort = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxDither = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDownScanSeconds = New System.Windows.Forms.NumericUpDown()
        Me.BtnMount = New System.Windows.Forms.Button()
        Me.TmrControl = New System.Windows.Forms.Timer(Me.components)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTCPPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownScanSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(25, 32)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(103, 23)
        Me.BtnConnect.TabIndex = 0
        Me.BtnConnect.Text = "Connect to PHD"
        Me.ToolTip1.SetToolTip(Me.BtnConnect, "Connect to PHD2 and select scan folder")
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Enabled = False
        Me.BtnStart.Location = New System.Drawing.Point(37, 90)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "Start"
        Me.ToolTipDither.SetToolTip(Me.BtnStart, "Start the dithering loop")
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Enabled = False
        Me.BtnStop.Location = New System.Drawing.Point(37, 119)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(75, 23)
        Me.BtnStop.TabIndex = 2
        Me.BtnStop.Text = "Stop"
        Me.ToolTipDither.SetToolTip(Me.BtnStop, "Stop the dithering loop")
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 22)
        Me.Label1.MaximumSize = New System.Drawing.Size(1000, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Scan Folder"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Location = New System.Drawing.Point(324, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(446, 20)
        Me.TextBox1.TabIndex = 4
        Me.ToolTipDither.SetToolTip(Me.TextBox1, "The folder to scan for images.")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dither every"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(324, 97)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(59, 20)
        Me.NumericUpDown1.TabIndex = 7
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(398, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "images"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Tool Tip"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(37, 148)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Exit"
        Me.ToolTipDither.SetToolTip(Me.Button4, "Exit the program")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BtnDither
        '
        Me.BtnDither.Enabled = False
        Me.BtnDither.Location = New System.Drawing.Point(220, 152)
        Me.BtnDither.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnDither.Name = "BtnDither"
        Me.BtnDither.Size = New System.Drawing.Size(75, 23)
        Me.BtnDither.TabIndex = 10
        Me.BtnDither.Text = "Dither"
        Me.ToolTipDither.SetToolTip(Me.BtnDither, "Send a dither command to PHD. Use this to determine the settle time  for your mou" &
        "nt which you can use to set the time between images.")
        Me.BtnDither.UseVisualStyleBackColor = True
        '
        'ToolTipDither
        '
        Me.ToolTipDither.ToolTipTitle = "PHD2 Dither"
        '
        'LabelTCPPort
        '
        Me.LabelTCPPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTCPPort.Location = New System.Drawing.Point(476, 96)
        Me.LabelTCPPort.Name = "LabelTCPPort"
        Me.LabelTCPPort.Size = New System.Drawing.Size(102, 19)
        Me.LabelTCPPort.TabIndex = 11
        Me.LabelTCPPort.Text = "TCP Port"
        '
        'NumericUpDownTCPPort
        '
        Me.NumericUpDownTCPPort.Location = New System.Drawing.Point(561, 98)
        Me.NumericUpDownTCPPort.Maximum = New Decimal(New Integer() {4399, 0, 0, 0})
        Me.NumericUpDownTCPPort.Minimum = New Decimal(New Integer() {4300, 0, 0, 0})
        Me.NumericUpDownTCPPort.Name = "NumericUpDownTCPPort"
        Me.NumericUpDownTCPPort.Size = New System.Drawing.Size(59, 20)
        Me.NumericUpDownTCPPort.TabIndex = 12
        Me.NumericUpDownTCPPort.Value = New Decimal(New Integer() {4300, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(422, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Dither by"
        '
        'ComboBoxDither
        '
        Me.ComboBoxDither.FormattingEnabled = True
        Me.ComboBoxDither.Items.AddRange(New Object() {"0.5 x dither scale", "1 x dither scale", "2 x dither scale", "3 x dither scale", "4 x dither scale"})
        Me.ComboBoxDither.Location = New System.Drawing.Point(506, 152)
        Me.ComboBoxDither.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxDither.Name = "ComboBoxDither"
        Me.ComboBoxDither.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxDither.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 52)
        Me.Label5.MaximumSize = New System.Drawing.Size(1000, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 30)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Scan every"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(401, 52)
        Me.Label6.MaximumSize = New System.Drawing.Size(1000, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 30)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "seconds"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDownScanSeconds
        '
        Me.NumericUpDownScanSeconds.Location = New System.Drawing.Point(327, 61)
        Me.NumericUpDownScanSeconds.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumericUpDownScanSeconds.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownScanSeconds.Name = "NumericUpDownScanSeconds"
        Me.NumericUpDownScanSeconds.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDownScanSeconds.TabIndex = 19
        Me.NumericUpDownScanSeconds.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BtnMount
        '
        Me.BtnMount.Location = New System.Drawing.Point(25, 61)
        Me.BtnMount.Name = "BtnMount"
        Me.BtnMount.Size = New System.Drawing.Size(103, 23)
        Me.BtnMount.TabIndex = 20
        Me.BtnMount.Text = "Connect to Mount"
        Me.ToolTip1.SetToolTip(Me.BtnMount, "Connect to PHD2 and select scan folder")
        Me.BtnMount.UseVisualStyleBackColor = True
        '
        'TmrControl
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnMount)
        Me.Controls.Add(Me.NumericUpDownScanSeconds)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxDither)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDownTCPPort)
        Me.Controls.Add(Me.LabelTCPPort)
        Me.Controls.Add(Me.BtnDither)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.BtnConnect)
        Me.Name = "Form1"
        Me.Text = "PHDDither"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTCPPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownScanSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnConnect As Button
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button4 As Button
    Friend WithEvents BtnDither As Button
    Friend WithEvents ToolTipDither As ToolTip
    Friend WithEvents LabelTCPPort As Label
    Friend WithEvents NumericUpDownTCPPort As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxDither As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDownScanSeconds As NumericUpDown
    Friend WithEvents BtnMount As Button
    Friend WithEvents TmrControl As Timer
End Class
