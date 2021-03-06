﻿Imports System.IO
Imports System.Net.Sockets

Public Class PHD2Guiding
    Public Shared tcpConnected As Boolean = False
    Public Shared tcpConnection As New TcpClient()
    Public Shared tcpNetworkStream As NetworkStream
    Public Shared tcpBinaryReader As BinaryReader
    Public Shared tcpBinaryWriter As BinaryWriter

    ''' <summary>
    ''' Pause guiding. Camera exposures continue to loop if they are already looping. <br/><b>Response</b> 0.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_PAUSE() As Byte
        Get
            Return 1
        End Get
    End Property

    ''' <summary>
    ''' Resume guiding if it was paused, otherwise no effect. <br/><b>Response</b> 0.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_RESUME() As Byte
        Get
            Return 2
        End Get
    End Property

    ''' <summary>
    ''' Dither a random amount, up to +/- 0.5 x dither_scale. <br/><b>Response</b> Camera exposure time in seconds, but not less than 1.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_MOVE1() As Byte
        Get
            Return 3
        End Get
    End Property

    ''' <summary>
    ''' Dither a random amount, up to +/- 1.0 x dither_scale. <br/><b>Response</b> Camera exposure time in seconds, but not less than 1.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_MOVE2() As Byte
        Get
            Return 4
        End Get
    End Property

    ''' <summary>
    ''' Dither a random amount, up to +/- 2.0 x dither_scale. <br/><b>Response</b> Camera exposure time in seconds, but not less than 1.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_MOVE3() As Byte
        Get
            Return 5
        End Get
    End Property

    ''' <summary>
    ''' not currently implemented in PHD2. <br/><b>Response</b> 1.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_IMAGE() As Byte
        Get
            Return 6
        End Get
    End Property

    ''' <summary>
    ''' not currently implemented in PHD2. <br/><b>Response</b> 1.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_GUIDE() As Byte
        Get
            Return 7
        End Get
    End Property

    ''' <summary>
    ''' not currently implemented in PHD2. <br/><b>Response</b> 1.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_CAMCONNECT() As Byte
        Get
            Return 8
        End Get
    End Property

    ''' <summary>
    ''' not currently implemented in PHD2. <br/><b>Response</b> 1.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_CAMDISCONNECT() As Byte
        Get
            Return 9
        End Get
    End Property

    ''' <summary>
    ''' Request guide error distance. <br/><b>Response</b> The current guide error distance in units of 1/100 pixel. Values > 255 are reported as 255.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_REQDIST() As Byte
        Get
            Return 10
        End Get
    End Property


    ''' <summary>
    ''' not currently implemented in PHD2. <br/><b>Response</b> 1.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_REQFRAME() As Byte
        Get
            Return 11
        End Get
    End Property

    ''' <summary>
    ''' Dither a random amount, up to +/- 3.0 x dither_scale. <br/><b>Response</b> Camera exposure time in seconds, but not less than 1.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_MOVE4() As Byte
        Get
            Return 12
        End Get
    End Property

    ''' <summary>
    ''' Dither a random amount, up to +/- 4.0 x dither_scale. <br/><b>Response</b> Camera exposure time in seconds, but not less than 1.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_MOVE5() As Byte
        Get
            Return 13
        End Get
    End Property

    ''' <summary>
    ''' Auto-select a guide star. <br/><b>Response</b> 1 if a star was selected, 0 if not.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_AUTOFINDSTAR() As Byte
        Get
            Return 14
        End Get
    End Property

    ''' <summary>
    ''' Read 2 16-bit integers, x and y,from the socket and set the lock position to (x,y). <br/><b>Response</b> 0.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_SETLOCKPOSITION() As Byte
        Get
            Return 15
        End Get
    End Property

    ''' <summary>
    ''' Flip RA calibration data. <br/><b>Response</b> 1 if RA calibration data was flipped, 0 otherwise.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_FLIPRACAL() As Byte
        Get
            Return 16
        End Get
    End Property

    ''' <summary>
    ''' Get a value describing the state of PHD. <br/><b>Response</b> <br/>
    ''' 0: not paused, looping, or guiding<br/>
    ''' 1: capture active And star selected<br/>
    ''' 2: calibrating<br/>
    ''' 3: guiding And locked on star<br/>
    ''' 4: guiding but star lost<br/>
    ''' 100: paused<br/>
    ''' 101: looping but no star selected.<br/>
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_GETSTATUS() As Byte
        Get
            Return 17
        End Get
    End Property

    ''' <summary>
    ''' Stop looping exposures or guiding. <br/><b>Response</b> 0. Client should poll with MSG_GETSTATUS to check that looping/guiding has actually stopped.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_STOP() As Byte
        Get
            Return 18
        End Get
    End Property

    ''' <summary>
    ''' Start looping exposures. <br/><b>Response</b> 0 if request to start looping was accepted, non-zero otherwise (like when looping was already active). Client should poll with MSG_GETSTATUS to see if looping actually started.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_LOOP() As Byte
        Get
            Return 19
        End Get
    End Property

    ''' <summary>
    ''' Start guiding. <br/><b>Response</b> 0. Client should poll with MSG_GETSTATUS to see if guiding has actually started.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_STARTGUIDING() As Byte
        Get
            Return 20
        End Get
    End Property

    ''' <summary>
    ''' Get the current frame counter value. <br/><b>Response</b> 0 if not looping or guiding. Otherwise, the current frame counter value (capped at 255). The frame counter is incremented for each camera exposure when looping or guiding.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_LOOPFRAMECOUNT() As Byte
        Get
            Return 21
        End Get
    End Property

    ''' <summary>
    ''' Clear calibration data (force re-calibration). <br/><b>Response</b> 0.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_CLEARCAL() As Byte
        Get
            Return 22
        End Get
    End Property

    ''' <summary>
    ''' When the camera simulator is active, simulate a scope meridian flip. <br/><b>Response</b> 0.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_FLIP_SIM_CAMERA() As Byte
        Get
            Return 23
        End Get
    End Property

    ''' <summary>
    ''' De-select the currently selected guide star. If subframes are enabled, switch to full frames. This command should be sent before sending MSG_AUTOFINDSTAR to ensure a full frame is captured. For example, the following sequence could be used to select a guide star: MSG_STOP, MSG_DESELECT, MSG_LOOP, MSG_LOOPFRAMECOUNT, MSG_AUTOFINDSTAR. <br/><b>Response</b> 0.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property MSG_DESELECT() As Byte
        Get
            Return 24
        End Get
    End Property

    Public Function initTcpConnection() As Boolean
        If PHD2Guiding.tcpConnected = False Then
            tcpConnected = True
            Try
                tcpConnection.Connect("127.0.0.1", Form1.NumericUpDownTCPPort.Value)
            Catch ex As Exception
                tcpConnected = False
                Return tcpConnected
            End Try

            tcpNetworkStream = tcpConnection.GetStream
            tcpBinaryReader = New BinaryReader(tcpNetworkStream)
            tcpBinaryWriter = New BinaryWriter(tcpNetworkStream)
        End If

        Return tcpConnected
    End Function

    Public Function SendMessage(message As Byte) As Byte
        Dim retval As Byte = vbNull
        If initTcpConnection() = False Then Return retval

        ' Write a value to server 
        tcpBinaryWriter.Write(message)
        ' Read a value from server with message box 
        retval = tcpBinaryReader.ReadByte()
        'MsgBox("Read String " + retval.ToString)

        Return retval
    End Function

    Public Function checkPHD2IsRunning() As Boolean
        Return initTcpConnection()
    End Function

    Public Function checkPHD2IsGuiding() As Boolean
        Dim isPHD2Guiding As Boolean = True

        Dim phdStatus As Byte = SendMessage(PHD2Guiding.MSG_GETSTATUS)

        If phdStatus <> 3 Then
            isPHD2Guiding = False
        End If

        Return isPHD2Guiding
    End Function

    Public Sub dither()
        If SendMessage(PHD2Guiding.MSG_GETSTATUS) = 3 Then
            SendMessage(getDitherMove())
        End If
    End Sub

    Public Sub stopGuiding()
        If SendMessage(PHD2Guiding.MSG_GETSTATUS) = 3 Then
            SendMessage(PHD2Guiding.MSG_STOP)
        End If
    End Sub

    Public Sub startGuiding()
        If SendMessage(PHD2Guiding.MSG_GETSTATUS) = 0 Then
            SendMessage(PHD2Guiding.MSG_LOOP)
        End If

        waitUntilStatusWithTimeOut(0, 100)

        If SendMessage(PHD2Guiding.MSG_GETSTATUS) = 3 Then
            SendMessage(PHD2Guiding.MSG_LOOP)
            SendMessage(PHD2Guiding.MSG_AUTOFINDSTAR)
            SendMessage(PHD2Guiding.MSG_STARTGUIDING)
        End If
        If SendMessage(PHD2Guiding.MSG_GETSTATUS) = 3 Then
            SendMessage(PHD2Guiding.MSG_LOOP)
            SendMessage(PHD2Guiding.MSG_AUTOFINDSTAR)
            SendMessage(PHD2Guiding.MSG_STARTGUIDING)
        End If
    End Sub

    Private Function waitUntilStatusWithTimeOut(status As Integer, timeOut As Long) As Boolean
        Dim retval As Boolean
        Dim locStopWatch As Stopwatch
        Dim locStatus As Byte
        Dim continueLoop As Boolean

        continueLoop = True
        locStopWatch = Stopwatch.StartNew()
        Do
            locStatus = SendMessage(PHD2Guiding.MSG_GETSTATUS)
            If locStatus = status Then
                retval = True
                continueLoop = False
            ElseIf locStopWatch.ElapsedMilliseconds > timeOut Then
                retval = False
                continueLoop = False
            End If
        Loop While continueLoop

        Return retval
    End Function


    Public Shared Function getDitherMove() As Byte
        Dim ditherMove As Byte = PHD2Guiding.MSG_MOVE1

        If Form1.ComboBoxDither.SelectedIndex = 0 Then
            ditherMove = PHD2Guiding.MSG_MOVE1
        ElseIf Form1.ComboBoxDither.SelectedIndex = 1 Then
            ditherMove = PHD2Guiding.MSG_MOVE2
        ElseIf Form1.ComboBoxDither.SelectedIndex = 2 Then
            ditherMove = PHD2Guiding.MSG_MOVE3
        ElseIf Form1.ComboBoxDither.SelectedIndex = 3 Then
            ditherMove = PHD2Guiding.MSG_MOVE4
        ElseIf Form1.ComboBoxDither.SelectedIndex = 4 Then
            ditherMove = PHD2Guiding.MSG_MOVE5
        End If

        Return ditherMove
    End Function

End Class
