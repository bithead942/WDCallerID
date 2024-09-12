Public Class Form1

    Public Structure callData
        Public oLine As String
        Public oIO As String
        Public oSE As String
        Public oDur As String
        Public oCheck As String
        Public oRing As String
        Public oDate As String
        Public oTime As String
        Public oAP As String
        Public oName As String
        Public oPhone As String
        Public iLine As Int32
    End Structure
    Private WithEvents serialPort1 As System.IO.Ports.SerialPort
    Public cd As callData
    Public chkBoxes(10) As CheckBox

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Event_HistoryTableAdapter.InsertQuery("9030")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Event_HistoryTableAdapter.InsertQuery("9029")

        lblIO.Text = ""
        lblCallEnded.Text = ""
        lblDuration.Text = ""
        lblPhoneNumber.Text = ""
        lblName.Text = ""

        lblPort.Text = "COM1"

        If Not COMConnect() Then
            btnStart.Enabled = True
            btnStop.Enabled = False
            Event_HistoryTableAdapter.InsertQuery("9920")
            tReceive.Stop()
        Else
            btnStart.Enabled = False
            btnStop.Enabled = True
            tSerialCheck.Start()
        End If

    End Sub

    Private Function COMConnect() As Boolean
        Try
            serialPort1 = Nothing
            serialPort1 = New System.IO.Ports.SerialPort
            serialPort1.PortName = lblPort.Text
            serialPort1.Open()
            If serialPort1.IsOpen Then
                btnStart.Enabled = False
                btnStop.Enabled = True
                tReceive.Start()
                SendString("C")
                SendString("d")
                SendString("A")  'Start & End
                'SendString("s") 'End only
                SendString("o")
                SendString("T")
                SendString("V")
                lblCOMStatus.Text = "."
                lblCOMCheck.Text = Now.ToString
                Return True
            Else
                MsgBox("Error opening COM Port: " & lblPort.Text & Chr(13) & "Port not open")
                lblCOMStatus.Text = "X"
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error opening COM Port: " & lblPort.Text & Chr(13) & ex.Message)
            lblCOMStatus.Text = "X"
            Return False
        End Try
    End Function

    Private Sub SendHeartbeat()
        Dim dtLastCall As DateTime
        Dim iResult As Integer = 0

        Try
            If lblCallEnded.Text <> "" Then
                dtLastCall = DateTime.Parse(lblCallEnded.Text)
                iResult = DateTime.Compare(Now.AddHours(-1), dtLastCall)
            End If
            If iResult >= 0 Then  'it's been more than 1 hour since the last call, so send heartbeat
                If serialPort1.IsOpen Then
                    tReceive.Stop()
                    SendString("C")
                    SendString("d")
                    SendString("A")  'Start & End
                    'SendString("s") 'End only
                    SendString("o")
                    SendString("T")
                    SendString("V")
                    btnStart.Enabled = False
                    btnStop.Enabled = True
                    lblCOMStatus.Text = "."
                    lblCOMCheck.Text = Now.ToString
                    tReceive.Start()
                Else
                    If Not COMConnect() Then
                        btnStart.Enabled = True
                        btnStop.Enabled = False
                        tReceive.Stop()
                        Event_HistoryTableAdapter.InsertQuery("9920")
                        lblCOMStatus.Text = "X"
                    Else
                        btnStart.Enabled = False
                        btnStop.Enabled = True
                        lblCOMStatus.Text = "-"
                    End If
                End If
            End If

        Catch ex As Exception
            If Not COMConnect() Then
                btnStart.Enabled = True
                btnStop.Enabled = False
                Event_HistoryTableAdapter.InsertQuery("9920")
                lblCOMStatus.Text = "X"
                tReceive.Stop()
            Else
                btnStart.Enabled = False
                btnStop.Enabled = True
                lblCOMStatus.Text = "-"
            End If
        End Try

    End Sub


    Private Sub SendEmail(strMessage As String)
        Dim mySMTPClient As SmtpClient = New SmtpClient
        Dim Message As MailMessage

        Message = New MailMessage("Watchdog@gmail.com", "gspata@cinci.rr.com")
        Message.Subject = "Insteon Error"
        Message.Priority = MailPriority.High
        mySMTPClient.Host = "smtp-server.cinci.rr.com"
        mySMTPClient.Port = 25
        Message.Body = strMessage
        mySMTPClient.Send(Message)
    End Sub

#Region "Buttons"
    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        If Not COMConnect() Then
            btnStart.Enabled = True
            btnStop.Enabled = False
            tReceive.Stop()
        Else
            btnStart.Enabled = False
            btnStop.Enabled = True
        End If
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        btnStart.Enabled = True
        btnStop.Enabled = False
        tReceive.Stop()
        serialPort1.Close()
    End Sub

#End Region

#Region "Parse Data"
    Private Sub ParseData(ByVal data As String)
        Dim sd As Int32
        Dim popflag As Boolean

        popflag = False
        'Dim sendBytes As [Byte]()

        If data.EndsWith("OUT-OF-AREA") Then     'data is OUT-OF-AREA call
            'with OUT-OF-AREA calls, the string is not right-padded, so we must now pad it
            data = data + "    "
        ElseIf data.EndsWith("PRIVATE") Then     'data is PRIVATE call
            'with PRIVATE calls, the string is not right-padded, so we must now pad it
            data = data + "        "
        End If

        data = trimChars(data) ' remove extra chars from beginning/end of string
        sd = data.Length()

        If sd - data.LastIndexOf(":") = 3 Then          'data is a version string
            parseVersion(data)
        ElseIf sd - data.LastIndexOf("/") = 43 Then     'data is comprehensive format
            parseCompRev(data)
            recordCallData()
        ElseIf sd - data.LastIndexOf(":") = 48 Then     'data is limited format
            parseLimited(data)
            recordCallData()
        End If

    End Sub

    Private Sub recordCallData()
        Dim strName As String

        Try
            If cd.oIO = "I" Then  'Inbound
                If cd.oSE = "S" Then  'Start of Call
                    'Event_HistoryTableAdapter.InsertQuery("5004")
                    If cd.oPhone.Substring(0, 1) <> "*" Then
                        strName = Call_LookupTableAdapter1.GetCallerName(cd.oPhone)
                        If strName = "" Then
                            If cd.oName = "" Then
                                Call_CurrentTableAdapter1.InsertCall("An Unknown Caller")
                            Else
                                Call_CurrentTableAdapter1.InsertCall(cd.oName)
                            End If
                        Else
                            Call_CurrentTableAdapter1.InsertCall(strName)
                        End If
                    End If
                    lblIO.Text = cd.oIO
                    lblCallEnded.Text = Now.ToString
                    lblPhoneNumber.Text = cd.oPhone
                    lblDuration.Text = cd.oDur
                    lblName.Text = cd.oName
                Else   'End of Call
                    lblIO.Text = cd.oIO
                    lblCallEnded.Text = Now.ToString
                    lblPhoneNumber.Text = cd.oPhone
                    lblDuration.Text = cd.oDur
                    lblName.Text = cd.oName

                    Call_HistoryTableAdapter1.Record_Call(cd.oPhone, cd.oName, cd.oDur, cd.oIO)
                End If
                End If
                If cd.oIO = "O" Then   'Outbound
                    If cd.oSE = "S" Then  'Start of Call
                        lblIO.Text = cd.oIO
                        lblCallEnded.Text = Now.ToString
                        lblPhoneNumber.Text = cd.oPhone
                        lblDuration.Text = cd.oDur
                        lblName.Text = cd.oName
                    Else  'End of Call
                        lblIO.Text = cd.oIO
                        lblCallEnded.Text = Now.ToString
                        lblPhoneNumber.Text = cd.oPhone
                        lblDuration.Text = cd.oDur
                        lblName.Text = cd.oName
                        Call_HistoryTableAdapter1.Record_Call(cd.oPhone, cd.oName, cd.oDur, cd.oIO)
                    End If
                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Function trimChars(ByVal str As String) As String
        ' This process strips out ?,$, and # characters from the
        ' START of a string. See notes on "ABOUT PARSING WHOZZ 
        ' CALLING? UNIT DATA" below

        If str.StartsWith("?") Then
            str =  str.Substring(1)
        ElseIf str.StartsWith("$") Then
            str = str.Substring(1)
        ElseIf str.StartsWith("#") Then
            str = trimChars(str.Substring(1))
        End If
        If str.EndsWith(Chr(10)) Or str.EndsWith(Chr(13)) Then
            str = str.Substring(0, str.Length - 2)
        End If
        Return str
    End Function

    Private Sub parseVersion(ByVal data As String)
        Dim sd As Int32
        sd = data.Length
        Try
            cd.oLine = data.Substring(sd - 17, 2)
            cd.oIO = "V"
            cd.oSE = "V"
            cd.oDur = ""
            cd.oCheck = data.Substring(sd - 35, 3)
            cd.oRing = ""
            cd.oDate = data.Substring(sd - 14, 5)
            cd.oTime = data.Substring(sd - 8, 8)
            cd.oAP = data.Substring(sd - 3, 2)
            cd.oPhone = data.Substring(sd - 31, 11)
            cd.oName = data
        Catch ex As Exception
        End Try
    End Sub

    Private Sub parseComp(ByVal data As String)
        Try
            cd.oLine = data.Substring(0, 2)
            cd.oIO = data.Substring(3, 1)
            cd.oSE = data.Substring(5, 1)
            cd.oDur = data.Substring(7, 4)
            cd.oCheck = data.Substring(12, 1)
            cd.oRing = data.Substring(14, 2)
            cd.oDate = data.Substring(17, 5)
            cd.oTime = data.Substring(23, 5)
            cd.oAP = data.Substring(29, 2)
            cd.oPhone = data.Substring(32, 15)
            cd.oName = data.Substring(47, 15)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub parseCompRev(ByVal data As String)
        Dim sd As Int32
        sd = data.Length
        Try
            cd.oLine = data.Substring(sd - 62, 2)
            cd.oIO = data.Substring(sd - 59, 1)
            cd.oSE = data.Substring(sd - 57, 1)
            cd.oDur = data.Substring(sd - 55, 4)
            cd.oCheck = data.Substring(sd - 50, 1)
            cd.oRing = data.Substring(sd - 48, 2)
            cd.oDate = data.Substring(sd - 45, 5)
            cd.oTime = data.Substring(sd - 39, 5)
            cd.oAP = data.Substring(sd - 33, 2)
            cd.oPhone = data.Substring(sd - 30, 15)
            cd.oName = data.Substring(sd - 15, 15)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub parseLimited(ByVal data As String)
        Dim sd As Int32
        sd = data.Length
        Try
            cd.oLine = data.Substring(sd - 70, 2)
            cd.oIO = data.Substring(sd - 21, 1)
            cd.oSE = ""
            cd.oDur = ""
            cd.oCheck = ""
            cd.oRing = ""
            cd.oDate = data.Substring(sd - 63, 5)
            cd.oTime = data.Substring(sd - 53, 5)
            cd.oAP = data.Substring(sd - 47, 2)
            cd.oPhone = data.Substring(sd - 38, 15)
            cd.oName = data.Substring(sd - 16, 15)
        Catch ex As Exception
        End Try
    End Sub

#End Region

    Public Sub SendString(ByVal sTx As String)
        Try
            SerialPort1.Write(sTx & Chr(13))
            Thread.Sleep(50)
        Catch ex As Exception
            MessageBox.Show("Error while trying to send on " & serialPort1.PortName & Chr(13) & ex.Message)
        End Try
    End Sub

#Region "Timers"
    Private Sub tReceive_Tick(sender As System.Object, e As System.EventArgs) Handles tReceive.Tick
        'Runs once every 700ms
        Dim myBuffer() As Char
        Dim strBuffer As String
        Dim iBytes As Integer

        Try
            iBytes = serialPort1.BytesToRead
            If iBytes > 0 Then
                ReDim myBuffer(iBytes - 1)
                serialPort1.Read(myBuffer, 0, iBytes)

                strBuffer = ""
                For i = 0 To iBytes - 1
                    strBuffer = strBuffer & myBuffer(i)
                Next
                ParseData(strBuffer)
            End If
            lblCOMStatus.Text = "."

        Catch ex As Exception
            serialPort1.DiscardInBuffer()
            btnStart.Enabled = True
            btnStop.Enabled = False
            tReceive.Stop()
            lblCOMStatus.Text = "X"
            Event_HistoryTableAdapter.InsertQuery("9920")
        End Try
    End Sub

    Private Sub tSerialCheck_Tick(sender As Object, e As EventArgs) Handles tSerialCheck.Tick
        'Runs once per hour
        SendHeartbeat()
        If Now.Hour = 10 Then
            If lblCOMStatus.Text = "X" Then
                SendEmail("WDCallerID Error Detected - manual intervention required.")
            End If
        End If

    End Sub

#End Region


End Class
