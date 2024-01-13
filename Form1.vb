Imports WinHttp
Imports System
Imports System.IO
Imports System.Net
Imports System.Drawing.Printing
Imports System.Diagnostics
Imports Renci.SshNet
Imports System.ComponentModel.Design







Public Class Form1

    'Data from PLC is read in floating point format
    'the conversion is done using
    'Public Function BytesToFloat(Reading As Byte(), ParmPos As Byte) As Single

    'When reading the power, the data consists of one single (4 bytes)
    'PowerMeter_Readings.P_Tot = 1000.0 * BytesToFloat(ReplyData, 9)

    'When reading the weather, the data consists of three singles (12 bytes)
    ' Sunshine_Inclined = Int(BytesToFloat(ReplyData, 9))
    ' WeatherStation_Readings.rTemperature = BytesToFloat(ReplyData, 13)
    ' WeatherStation_Readings.rWindSpeed = BytesToFloat(ReplyData, 17)

    ' The results of kW and w/m2 are returned as integer values for uploading

    'MAPPED VSN800 EXPECTS THE DATA TO BE PLACED IN ADDRESS %MD5,  AND 7
    'MAPPED SCADA CONNECTION EXPECTS THE POWER DATA TO BE PLACED IN %MD0


    Const CrLf = Chr(13) & Chr(10)

    '---------- GENERAL -------------
    Public SiteName As String
    Public CONTROL_SCHEME As Integer
    Public CAPACITY As Integer
    Public INVERTER_COUNT As Integer
    Public ASDU As Integer
    Public PROTOCOL_IDENTIFIER As String

    Public ThisSecond As String = "1"


    '---------- HTTP Requests --------

    Public ThisParkData As ParkData

    Public PARK_NAME As String
    Public URL As String
    Public PostData As String
    Public WebServerReplyCounter As Integer
    Public Upload2WebServer_done As Boolean
    Public Upload2WebServer_FailCounter As Integer

    Public Bioland_Pool_Inserted_OK As Boolean = False
    Public Bioland_Plants_Updated_OK As Boolean = False
    Public Bioland_Pool_Inserted_OK_Count As Integer = 0
    Public Bioland_Plants_Updated_OK_Count As Integer = 0
    Public Bioland_Pool_Inserted_Err_Count As Integer = 0
    Public Bioland_Plants_Updated_Err_Count As Integer = 0

    Public UploadString As String

    '========TCP CLIENTS =========
    Public PLC_IP As String

    '----------WEATHER STATION ------------
    Public WeatherStation_Type As String
    Public WeatherStation_Connected As Boolean
    Public WeatherStationScanOkCount As Integer
    Public WeatherStationScanErrorCount As Integer
    Public WeatherStationData() As Integer
    Public WeatherStation_IP As String
    Public WeatherStation_ID As Byte
    Public WithEvents TCP_WeatherStationClient As Sockets.TcpClient
    Public TCP_WeatherStationStream As Sockets.NetworkStream
    Public WeatherData_Reply_Exception As Byte
    Public Class WEATHER_DATA
        Public SunShine As Integer
        Public Temperature As Integer
        Public WindSpeed As Integer
        Public rSunShine As Single
        Public rTemperature As Single
        Public rWindSpeed As Single
    End Class
    Public WeatherStation_Readings As New WEATHER_DATA


    '---------- FIELD IMAGE ------------
    Public FieldImage_Type As String
    Public FieldImage_Connected As Boolean
    Public FieldImageScanOkCount As Integer
    Public FieldImageScanErrorCount As Integer
    Public FieldImageData() As Integer
    Public FieldImage_IP As String
    Public FieldImage_ID As Byte
    Public WithEvents TCP_FieldImageClient As Sockets.TcpClient
    Public TCP_FieldImageStream As Sockets.NetworkStream
    Public FieldImageData_Reply_Exception As Byte

    Public OperatingState() As String = {"ON  ", "OFF  ", "SLEEP", "START", "MPPT ", "THROTTLE", "SHUT_DN", "FAULT", "STD-BY"}

    Public rPARMS(15) As Single
    Public udiPARM As ULong
    Public iPARMS As Integer

    Public Class InverterReadings
        Public CONNECTION As Byte
        Public STATUS As Byte
        Public ACTIVE_POWER As Int16
        Public REACTIVE_POWER As Int16
        Public POWER_FACTOR As Single
        Public POWER_LIM As Int16
        Public KVAR_FIX As Int16
    End Class

    '------------ BREAKER STATUS DISPLAY -----------
    Public ACB_States As New ImageList()


    Public Class PLC_DATA
        Public PLC_DATA_ARRAY(256) As Byte
    End Class
    Public FieldImage_Readings As New PLC_DATA

    '----------POWER METER ------------
    Public PowerMeter_Type As String
    Public PowerMeter_Connected As Boolean
    Public PowerMeterScanOkCount As Integer
    Public PowerMeterScanErrorCount As Integer
    Public PowerMeterData() As Integer
    Public PowerMeter_IP As String
    Public Powermeter_ID As Byte
    Public WithEvents TCP_PowerMeterClient As Sockets.TcpClient
    Public TCP_PowerMeterStream As Sockets.NetworkStream
    Public PowerMeterData_Reply_Exception As Byte

    Public Class POWER_DATA
        Public P_L1 As Integer
        Public P_L2 As Integer
        Public P_L3 As Integer
        Public P_Tot As Integer
    End Class
    Public PowerMeter_Readings As New POWER_DATA

    '------------ timestamp ---------------------
    Public MySQL_timestamp As String

    '------------ PARK DATA ---------------------
    Public ParkData(1023) As Byte


    '----------- FIELD IMAGE PARAMETERS ----------
    Public ACB_OPEND As Boolean
    Public ACB_CLOSED As Boolean
    Public ACB_TRIPPED As Boolean
    Public LOCAL_STATUS As Boolean
    Public DI_5 As Boolean
    Public DI_6 As Boolean
    Public DI_7 As Boolean
    Public DI_8 As Boolean

    Public DigitalInput(1, 7) As String

    'Public DigitalInputlabel(1, 7) As Label

    Public PLC_BYTES() As Byte

    '----------- INVERTERS ------------------------

    Public InverterControlDisplay() As InverterControl

    'Public InverterParms(7) As Label
    Public myLibTester As New ClassLibrary2.MyLibrary()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ACB_States.ImageSize = New Size(70, 30)
        ACB_States.Images.Add("ACB_xopen", My.Resources.acb_xopen)
        ACB_States.Images.Add("ACB_open", My.Resources.acb_open)
        ACB_States.Images.Add("ACB_closed", My.Resources.acb_closed)
        ACB_States.Images.Add("ACB_xclosed", My.Resources.acb_xclosed)


        Dim MW30_Request As MeterParms = New MeterParms()
        Dim PAC4200_Request As MeterParms = New MeterParms()
        Dim MAPPED_SICAM_Request As New MeterParms()
        Dim VSN800_Request As New MeterParms()
        Dim SIMATIC_7SJ80_Request As New MeterParms()
        Dim MAPPED_SCADA_Request As New MeterParms()
        Dim MAPPED_VSN800_Request As New MeterParms()

        MW30_Request.ModbusRequest = {172, 54, 0, 0, 0, 6, 1, 3, 0, 110, 0, 2}          '  HR ID=1 start=   110 len =  2
        VSN800_Request.ModbusRequest = {172, 51, 0, 0, 0, 6, 60, 3, 0, 71, 0, 22}       '  HR ID=1 start=    71 len = 22
        PAC4200_Request.ModbusRequest = {172, 52, 0, 0, 0, 6, 1, 3, 0, 1, 0, 42}        '  HR ID=1 start=     1 len = 42
        MAPPED_SICAM_Request.ModbusRequest = {172, 53, 0, 0, 0, 6, 1, 3, 48, 2, 0, 2}   '  HR ID=1 start= 12290 len =  2
        SIMATIC_7SJ80_Request.ModbusRequest = {172, 55, 0, 0, 0, 6, 62, 4, 0, 11, 0, 1} '  HR ID=1 start=    11 len =  1
        MAPPED_SCADA_Request.ModbusRequest = {172, 56, 0, 0, 0, 6, 1, 3, 48, 0, 0, 2}   '  HR ID=1 start= 12288 len =  2
        MAPPED_VSN800_Request.ModbusRequest = {172, 56, 0, 0, 0, 6, 1, 3, 48, 10, 0, 6} '  HR ID=1 start= 12298 len =  6

        'VSN800
        'READ_DATA[0] 071 : Ambient temperature
        'READ_DATA[1] 072 : RH ( Not abvailable )
        'READ_DATA[2] 073 : Pressure ( Not Available)
        'READ_DATA[3] 074 : Wind Speed 
        'READ_DATA[4] 075 : Wind Direction Degr
        ' ---
        'READ_DATA[13] 084 : Horizontal Irradiation W/m2
        'READ_DATA[14] 085 : In Plane Irradiation W/m2


        MW30_Request.ModbusReplyLength = 13
        VSN800_Request.ModbusReplyLength = 53
        PAC4200_Request.ModbusReplyLength = 93
        MAPPED_SICAM_Request.ModbusReplyLength = 13
        MAPPED_SCADA_Request.ModbusReplyLength = 13


        txt_WeatherStationReply.Text = "Weather Station Not Connected "
        lbl_WeatherStation_ConnectionStatus.Text = "NOT CONNECTED"
        lbl_WeatherStation_Connected.Text = "NOT CONNECTED"
        tmr_Check_WeatherStation_Reply.Stop()
        tmr_Check_PowerMeter_Reply.Stop()

        txt_FieldImageReply.Text = "Waiting for connection"
        lbl_FieldImage_Connected.Text = "Not yet connected"
        lbl_FieldImage_ConnectionStatus.Text = "Not Connected"
        tmr_Check_FieldImage_Reply.Stop()

        tmr_ReconnectClient.Start()

        'tmr_CheckConnectionStatus.Start()

        tmr_TCP_Receive_TimeOutTick.Stop()
        tmr_ProcessTimer.Start()



        tmr_ProcessTimer.Interval = 1000
        tmr_ProcessTimer.Enabled = True
        tmr_ProcessTimer.Start()

        ReadSiteConfig()

        Console.WriteLine("Waiting")
    End Sub

    '============= S M S ===========
    Public Sub SendSMS()
        Dim sshClient = New SshClient("10.20.72.202", "root", "admin")
        sshClient.Connect()
        Dim CommandString As String
        CommandString = "sendsms 97770185 " & Chr(34) & "Hello Beke" & Chr(34)
        Dim commandResult = sshClient.RunCommand(CommandString)
        txt_PowerMeterReply.Text = "CommandID executed" & vbCrLf & commandResult.Result
        sshClient.Disconnect()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Hello")
        SendSMS()
    End Sub
    '-------------------------


    Private Sub ReadSiteConfig()
        Dim i As Integer

        Dim ConnectionCounter As Integer = -1

        Dim ParmVals() As String
        Dim ParmName As String
        Dim ParmValue As String
        Dim ParmCheck As Int16 = 0

        Console.WriteLine("START_UP STEP 1 - READ CONFIG FILE  C:\Users\Beke\Tools\BiolandSiteConfig.ini")
        PROTOCOL_IDENTIFIER = "http"
        For Each line As String In File.ReadLines("C:\Users\Beke\Tools\BiolandSiteConfig.ini")
            'Code here to read each line
            Console.WriteLine(line)
            If Mid(line, 1, 1) <> "#" Then
                If InStr(line, "=") > 0 Then
                    ParmVals = Split(line, "=")
                    ParmName = Trim(ParmVals(0))
                    ParmValue = Trim(ParmVals(1))

                    If ParmName = "SiteName" Then
                        SiteName = Trim(ParmValue)
                        ParmCheck = ParmCheck Or 1
                    End If

                    If ParmName = "CAPACITY" Then
                        CAPACITY = Int(Val(Trim(ParmValue)))
                        ParmCheck = ParmCheck Or 2
                    End If

                    If ParmName = "INVERTER_COUNT" Then
                        INVERTER_COUNT = Int(Val(Trim(ParmValue)))

                        ParmCheck = ParmCheck Or 4

                        INVERTER_COUNT = 10
                        ReDim InverterControlDisplay(INVERTER_COUNT - 1)
                        InverterControlDisplay(0) = InverterControl1
                        InverterControlDisplay(1) = InverterControl2
                        InverterControlDisplay(2) = InverterControl3
                        InverterControlDisplay(3) = InverterControl4
                        InverterControlDisplay(4) = InverterControl5
                        InverterControlDisplay(5) = InverterControl6
                        InverterControlDisplay(6) = InverterControl7
                        InverterControlDisplay(7) = InverterControl8
                        InverterControlDisplay(8) = InverterControl9
                        InverterControlDisplay(9) = InverterControl10
                    End If

                    If ParmName = "ASDU" Then
                        ASDU = Int(Val(Trim(ParmValue)))
                        ParmCheck = ParmCheck Or 8
                    End If

                    If ParmName = "PLC_IP" Then
                        PLC_IP = Trim(ParmValue)
                        ParmCheck = ParmCheck Or 16
                    End If

                    If ParmName = "WeatherStation_Type" Then
                        WeatherStation_Type = Trim(ParmValue)
                        ParmCheck = ParmCheck Or 32
                    End If

                    If ParmName = "Inclination" Then
                        If Trim(ParmValue) = "H" Then
                            OptionHorizontal.Checked = True
                        End If
                    End If

                    If ParmName = "WeatherStation_IP" Then
                        WeatherStation_IP = Trim(ParmValue)
                        ParmCheck = ParmCheck Or 64
                    End If

                    If ParmName = "WeatherStation_ID" Then
                        WeatherStation_ID = Int(Val(Trim(ParmValue)))
                        ParmCheck = ParmCheck Or 128
                    End If

                    If ParmName = "PowerMeter_Type" Then
                        PowerMeter_Type = Trim(ParmValue)
                        ParmCheck = ParmCheck Or 256
                    End If

                    If ParmName = "PowerMeter_IP" Then
                        PowerMeter_IP = Trim(ParmValue)
                        ParmCheck = ParmCheck Or 512
                    End If

                    If ParmName = "PowerMeter_ID" Then
                        Powermeter_ID = Int(Val(Trim(ParmValue)))
                        ParmCheck = ParmCheck Or 1024
                    End If

                    If ParmName = "CONTROL_SCHEME" Then
                        CONTROL_SCHEME = Int(Val(Trim(ParmValue)))
                        ParmCheck = ParmCheck Or 2048
                    End If

                    If ParmName = "PROTOCOL" Then
                        PROTOCOL_IDENTIFIER = Trim(ParmValue)
                    End If
                    If ParmName = "PLC_TYPE" Then
                        FieldImage_Type = Trim(ParmValue)
                        ParmCheck = ParmCheck Or 64
                    End If

                End If
            End If
        Next line

        FieldImage_Type = "WAGO"

        DigitalInputs_161.DI_01.Text = "ACB OPEN"
        DigitalInputs_161.DI_02.Text = "ACB CLOSED"
        DigitalInputs_161.DI_03.Text = "ACB TRIP"
        DigitalInputs_161.DI_04.Text = "LOCAL"
        DigitalInputs_161.DI_05.Text = "SPARE DI5"
        DigitalInputs_161.DI_06.Text = "SPARE DI6"
        DigitalInputs_161.DI_07.Text = "SPARE DI7"
        DigitalInputs_161.DI_08.Text = "CTRL_ERROR"
        DigitalInputs_161.DI_09.Text = "OVER_FREQ"
        DigitalInputs_161.DI_10.Text = "UNDER_FREQ"
        DigitalInputs_161.DI_11.Text = "OVER_VOLT"
        DigitalInputs_161.DI_12.Text = "UNDER_VOLT"
        DigitalInputs_161.DI_13.Text = "ROCOF"
        DigitalInputs_161.DI_14.Text = "ACB OPEN"
        DigitalInputs_161.DI_15.Text = "ACB OPEN"
        DigitalInputs_161.DI_16.Text = "ACB OPEN"

        For i = 1 To 10
            InverterControlDisplay(i - 1).InverterControlBox.Text = "INV " & i.ToString
        Next i

        Me.lbl_PROTOCOL.Text = PROTOCOL_IDENTIFIER

        Dim CheckResult As Int16 = ParmCheck And 4095
        If CheckResult <> 4095 Then
            MsgBox("Init File Error (C:\Users\Beke\Tools\BiolandSiteConfig.ini ParmCheck is ), " & ParmCheck & " Instead of 4095  Program aborted")
            End
        End If

        lbl_Powermeter_Type.Text = PowerMeter_Type
        txt_PowerMeter_IP.Text = PowerMeter_IP
        txt_WeatherStation_IP.Text = WeatherStation_IP
        lbl_WeatherStation_Type.Text = WeatherStation_Type
        txt_FieldImage_IP.Text = PLC_IP
        ConnectFieldImage()
        ConnectWeatherStation()
        ConnectPowerMeter()
    End Sub



    Public Sub Upload2WebServer(MyMessage As String)
        Dim NewHttpRequest As New WinHttpRequest
        Dim HttpRequestStatus As Integer
        Dim MyPostReply As String
        Dim ThisUSR As String = "wijnand"
        Dim ThisPAS As String = "MEPwsm49"
        Dim HTTPREQUEST_SETCREDENTIALS_FOR_SERVER As Byte = 0
        Dim ThisURL As String

        If Not chk_UPLOAD_TO_WEB.Checked Then Exit Sub

        'NewHttpRequest.Open("POST", "https://i2bs.net/PARX/BIOLAND/BIOLAND_DATA_PUSHER.php", False)
        ThisURL = PROTOCOL_IDENTIFIER & "://i2bs.net/PARX/BIOLAND/BIOLAND_DATA_PUSHER.php"
        Me.lbl_URL.Text = ThisURL
        NewHttpRequest.Open("POST", ThisURL, False)

        NewHttpRequest.SetRequestHeader("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0)")
        If ThisUSR <> "" Then
            NewHttpRequest.SetCredentials(ThisUSR, ThisPAS, HTTPREQUEST_SETCREDENTIALS_FOR_SERVER)
        End If
        Upload2WebServer_done = False
        Try
            NewHttpRequest.Send(MyMessage)
            HttpRequestStatus = NewHttpRequest.Status
            If HttpRequestStatus = 200 Then
                txt_WebServer_ReplyText.Text = HttpRequestStatus.ToString & CrLf
                MyPostReply = NewHttpRequest.ResponseText
                Call Me.ProcessWebReply(MyPostReply)
                txt_WebServer_ReplyText.Text += MyPostReply
                WebServerReplyCounter += 1
                lbl_WebServerReplyCounter.Text = WebServerReplyCounter
                Upload2WebServer_done = True
                Console.WriteLine("Reply Status: " & HttpRequestStatus.ToString & CrLf & "REPLY_TEXT->:" & MyPostReply & ":<-END WEB_REPLY")
            Else
                txt_WebServer_ReplyText.Text = HttpRequestStatus.ToString & CrLf
                MyPostReply = NewHttpRequest.ResponseText
                txt_WebServer_ReplyText.Text += MyPostReply
                Upload2WebServer_FailCounter += 1
                lbl_UploadFailCounter.Text = Upload2WebServer_FailCounter.ToString
            End If
        Catch ex As Exception
            NewHttpRequest = Nothing
            Upload2WebServer_FailCounter += 1
            lbl_UploadFailCounter.Text = Upload2WebServer_FailCounter.ToString()
            txt_WebServer_ReplyText.Text = Upload2WebServer_FailCounter.ToString() & " HttpRequest Fails" & CrLf & ex.Message
        End Try
        'ShowDigitals()
    End Sub


    Private Sub tmr_ProcessTimer_Tick(sender As Object, e As EventArgs) Handles tmr_ProcessTimer.Tick
        Static PreviousSecond As Integer
        Dim MyMessage As String
        MySQL_timestamp = VS2MySQL_Date(Now())
        lbl_CLOCK.Text = MySQL_timestamp
        lbl_Clock2.Text = MySQL_timestamp
        ThisSecond = Mid(MySQL_timestamp, 18, 2)

        If PreviousSecond <> ThisSecond Then
            If ThisSecond = "15" Or ThisSecond = "45" Then
                GetWeatherStationData()
            End If

            If ThisSecond = "16" Or ThisSecond = "46" Then
                GetPowerMeterData()
            End If


            If CInt(ThisSecond) Mod 5 = 0 Then
                GetFieldImageData()
            End If

            If ThisSecond = "00" Or ThisSecond = "30" Then
                MyMessage = MySQL_timestamp & "," & SiteName & "," & WeatherStation_Readings.SunShine.ToString & "," & PowerMeter_Readings.P_Tot.ToString
                Me.UploadString = MyMessage
                tmr_UploadWindow.Interval = 5000
                tmr_UploadWindow.Enabled = True
                tmr_UploadWindow.Start()
                'Upload2WebServer(MyMessage)
            End If
            PreviousSecond = ThisSecond
            End If
    End Sub
    Private Sub tmr_UploadWindow_Tick(sender As Object, e As EventArgs) Handles tmr_UploadWindow.Tick
        tmr_UploadWindow.Stop()
        Upload2WebServer(Me.UploadString)
    End Sub
    Public Sub Process_WeatherStationData(ReplyData As Byte(), ReceivedBytesCount As Integer)
        Dim ReplyString As String = ""
        Dim ParmValue As Integer
        Dim ParmReadings As String
        Dim Sunshine_Horizontal As Integer
        Dim Sunshine_Inclined As Integer

        If ReceivedBytesCount < 10 Then
            WeatherStationScanOkCount += 1

            If ReplyData(7) = 131 Then
                WeatherData_Reply_Exception = ReplyData(8)
                lbl_WeatherStation_Exception.Text = "Exception " & WeatherData_Reply_Exception.ToString
                txt_WeatherStationReply.Text &= CrLf & "Exception " & WeatherData_Reply_Exception.ToString & " Received"
                WeatherStationScanErrorCount += 1
                lbl_WeatherStationScanErrCount.Text = WeatherStationScanErrorCount.ToString
                If WeatherData_Reply_Exception Then
                    GetWeatherStationData()
                End If
            End If
        Else
            Select Case WeatherStation_Type
                Case "VSN800-14"
                    If ReceivedBytesCount = 53 Then
                        WeatherData_Reply_Exception = 0
                        lbl_WeatherStation_Exception.Text = "Reply OK"
                        WeatherStationScanOkCount += 1
                        lbl_WeatherStationScanOkCount.Text = WeatherStationScanOkCount.ToString
                        Sunshine_Horizontal = 256 * ReplyData(35) + ReplyData(36)
                        lbl_SunShine_Horizontal.Text = Sunshine_Horizontal
                        Sunshine_Inclined = 256 * ReplyData(37) + ReplyData(38)
                        lbl_SunShine_Inclined.Text = Sunshine_Inclined
                        If Option_Inclinded.Checked Then
                            WeatherStation_Readings.SunShine = Sunshine_Inclined
                        Else
                            WeatherStation_Readings.SunShine = Sunshine_Horizontal
                        End If
                        WeatherStation_Readings.Temperature = 256 * ReplyData(9) + ReplyData(10)
                        WeatherStation_Readings.WindSpeed = 256 * ReplyData(15) + ReplyData(16)

                        lbl_SunShine.Text = WeatherStation_Readings.SunShine.ToString
                        lbl_Temperature.Text = (WeatherStation_Readings.Temperature / 10).ToString
                        lbl_WindSpeed.Text = (0.1 * WeatherStation_Readings.WindSpeed).ToString

                        ParmReadings = ""
                        For j = 9 To 53 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_WeatherStationReply.Text &= CrLf & ParmReadings
                    Else
                        WeatherStationScanErrorCount += 1
                        lbl_WeatherStationScanErrCount.Text = WeatherStationScanErrorCount.ToString
                        txt_WeatherStationReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 53"
                    End If

                Case "MAPPED_VSN800"
                    'SendBytes = {172, 56, 0, 0, 0, 6, 1, 3, 48, 10, 0, 6} '  HR ID=1 start= 12298 len =  6
                    If ReceivedBytesCount = 21 Then
                        WeatherData_Reply_Exception = 0
                        lbl_WeatherStation_Exception.Text = "Reply OK"
                        WeatherStationScanOkCount += 1
                        lbl_WeatherStationScanOkCount.Text = WeatherStationScanOkCount.ToString
                        lbl_SunShine_Horizontal.Text = "N/A"
                        Sunshine_Inclined = Int(BytesToFloat(ReplyData, 9))
                        lbl_SunShine_Inclined.Text = Sunshine_Inclined

                        lbl_SunShine_Inclined.Text = Sunshine_Inclined
                        If Option_Inclinded.Checked Then
                            WeatherStation_Readings.SunShine = Sunshine_Inclined
                        Else
                            WeatherStation_Readings.SunShine = Sunshine_Horizontal
                        End If

                        WeatherStation_Readings.rTemperature = BytesToFloat(ReplyData, 13)
                        WeatherStation_Readings.rWindSpeed = BytesToFloat(ReplyData, 17)

                        lbl_SunShine.Text = WeatherStation_Readings.SunShine.ToString
                        lbl_Temperature.Text = WeatherStation_Readings.rTemperature.ToString
                        lbl_WindSpeed.Text = WeatherStation_Readings.rWindSpeed.ToString

                        ParmReadings = ""
                        For j = 9 To 20 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_WeatherStationReply.Text &= CrLf & ParmReadings
                    Else
                        WeatherStationScanErrorCount += 1
                        lbl_WeatherStationScanErrCount.Text = WeatherStationScanErrorCount.ToString
                        txt_WeatherStationReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 53"
                    End If

                Case "MAPPED_VSN800_12500"
                    'SendBytes = {172, 56, 0, 0, 0, 6, 1, 3, 48, 212, 0, 6} '  HR ID=1 start= 12298 len =  2
                    If ReceivedBytesCount = 13 Then
                        WeatherData_Reply_Exception = 0
                        lbl_WeatherStation_Exception.Text = "Reply OK"
                        WeatherStationScanOkCount += 1
                        lbl_WeatherStationScanOkCount.Text = WeatherStationScanOkCount.ToString
                        lbl_SunShine_Horizontal.Text = "N/A"
                        Sunshine_Inclined = Int(BytesToFloat(ReplyData, 9))
                        lbl_SunShine_Inclined.Text = Sunshine_Inclined

                        lbl_SunShine_Inclined.Text = Sunshine_Inclined
                        If Option_Inclinded.Checked Then
                            WeatherStation_Readings.SunShine = Sunshine_Inclined
                        Else
                            WeatherStation_Readings.SunShine = Sunshine_Horizontal
                        End If

                        WeatherStation_Readings.rTemperature = 0
                        WeatherStation_Readings.rWindSpeed = 0

                        lbl_SunShine.Text = WeatherStation_Readings.SunShine.ToString
                        lbl_Temperature.Text = WeatherStation_Readings.rTemperature.ToString
                        lbl_WindSpeed.Text = WeatherStation_Readings.rWindSpeed.ToString

                        ParmReadings = ""
                        For j = 9 To 12 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_WeatherStationReply.Text &= CrLf & ParmReadings
                    Else
                        WeatherStationScanErrorCount += 1
                        lbl_WeatherStationScanErrCount.Text = WeatherStationScanErrorCount.ToString
                        txt_WeatherStationReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 53"
                    End If

            End Select

        End If
    End Sub


    Public Function VS2MySQL_Date(vs_date As Date) As String
        Dim ConvertedString As String
        Dim cYear As String = Format(Year(vs_date), "0000")
        Dim cMonth As String = Format(Month(vs_date), "00")
        Dim cDay As String = Format(Microsoft.VisualBasic.DateAndTime.Day(vs_date), "00")
        Dim cHour As String = Format(Hour(vs_date), "00")
        Dim cMinute As String = Format(Minute(vs_date), "00")
        Dim cSecond As String = Format(Second(vs_date), "00")

        ConvertedString = cYear & "-" & cMonth & "-" & cDay & " " & cHour & ":" & cMinute & ":" & cSecond
        Return ConvertedString
    End Function

    Public Function VS2MySQL_Time(vs_date As Date) As String

        Dim ConvertedString As String
        Dim cHour As String = Format(Hour(vs_date), "00")
        Dim cMinute As String = Format(Minute(vs_date), "00")
        Dim cSecond As String = Format(Second(vs_date), "00")
        ConvertedString = cHour & ":" & cMinute & ":" & cSecond
        Return ConvertedString
    End Function

    Public ClientConnected As Boolean = False
    Public NotAbleToConnect As Boolean = False
    'CONNECT CLIENT
    Private Sub btn_ConnectWeatherStation_Click(sender As Object, e As EventArgs) Handles btn_ConnectWeatherStations.Click
        ConnectWeatherStation()
    End Sub
    Public Sub ConnectWeatherStation()
        Try
            TCP_WeatherStationClient = New Sockets.TcpClient(txt_WeatherStation_IP.Text, 502)
            TCP_WeatherStationStream = New Sockets.NetworkStream(TCP_WeatherStationClient.Client)
            WeatherStation_Connected = True
            lbl_WeatherStation_ConnectionStatus.Text = "CONNECTED"
            txt_WeatherStationReply.Text = "WEATHER STATION CONNECTED"
            lbl_WeatherStation_Connected.Text = "CONNECTED"
            GetWeatherStationData()

        Catch ex As Exception
            WeatherStation_Connected = False
            txt_WeatherStationReply.Text = "Cannot Connect to Weather Station"
            lbl_WeatherStation_ConnectionStatus.Text = "COULD NOT CONNECT TO WEATHER STATION"
            lbl_WeatherStation_Connected.Text = "NOT CONNECTED"
        End Try
    End Sub
    'SEND MESSSAGGE
    Private Sub btn_SendWeatherStation_Request_Click(sender As Object, e As EventArgs) Handles btn_SendWeatherStation_Request.Click
        GetWeatherStationData()
    End Sub
    Public Sub GetWeatherStationData()
        Dim SendBytes() As Byte = {}

        If Not chk_USE_WEATHER_STATION.Checked Then Exit Sub

        Select Case WeatherStation_Type
            Case "VSN800-14"
                SendBytes = {172, 51, 0, 0, 0, 6, 60, 3, 0, 71, 0, 22}
            Case "MAPPED_VSN800"
                SendBytes = {172, 56, 0, 0, 0, 6, 1, 3, 48, 10, 0, 6} '  HR ID=1 start= 12298 len =  6
            Case "MAPPED_VSN800_10"
                SendBytes = {172, 56, 0, 0, 0, 6, 1, 3, 48, 10, 0, 6} '  HR ID=1 start= 12298 len =  6 Read Start Offset 10
            Case "MAPPED_VSN800_12500"
                SendBytes = {172, 56, 0, 0, 0, 6, 1, 3, 48, 212, 0, 2} '  HR ID=1 start= 12500 len =  2 Read Start Offset 0
        End Select
        txt_WeatherStationReply.Text = ""
        If WeatherStation_Connected Then
            Try
                If TCP_WeatherStationClient.Client.Connected Then
                    TCP_WeatherStationClient.Client.Send(SendBytes)
                    tmr_Check_WeatherStation_Reply.Interval = 300
                    tmr_Check_WeatherStation_Reply.Enabled = True
                    tmr_Check_WeatherStation_Reply.Start()
                Else
                    tmr_Check_WeatherStation_Reply.Stop()
                    txt_WeatherStationReply.Text = "Weather Station Not Connected "
                    lbl_WeatherStation_ConnectionStatus.Text = "NOT CONNECTED"
                    lbl_WeatherStation_Connected.Text = "CONNECTED"
                End If
            Catch ex1 As Exception
                tmr_Check_WeatherStation_Reply.Stop()
                WeatherStation_Connected = False
                Console.WriteLine("403: " & ex1.Message)
            End Try
        Else
            txt_WeatherStationReply.Text = "Weather Station Not Connected "
            lbl_WeatherStation_ConnectionStatus.Text = "NOT CONNECTED"
            lbl_WeatherStation_Connected.Text = "NOT CONNECTED"
        End If
    End Sub

    'CHECK FOR REPLY FROM WEATHER STATION   
    Private Sub tmr_Check_WeatherStation_Reply_Tick(sender As Object, e As EventArgs) Handles tmr_Check_WeatherStation_Reply.Tick

        Dim rcvbytes(65535) As Byte
        Dim i As Integer
        Dim BytesReceived As Integer
        Dim buffer As String = ""
        If WeatherStation_Connected Then
            Try
                If TCP_WeatherStationStream.DataAvailable Then
                    BytesReceived = CInt(TCP_WeatherStationClient.Client.Available)
                    TCP_WeatherStationStream.Read(rcvbytes, 0, BytesReceived)
                    buffer = "Received " & BytesReceived & " Bytes" & CrLf
                    For i = 0 To BytesReceived - 1
                        buffer &= "[" & rcvbytes(i).ToString & "]"
                    Next
                    txt_WeatherStationReply.Text = buffer
                    Process_WeatherStationData(rcvbytes, BytesReceived)
                    WeatherStationClient_IdleCounter = 0
                End If
            Catch ex As Exception
                WeatherStationScanErrorCount += 1
                lbl_WeatherStationScanErrCount.Text = WeatherStationScanErrorCount.ToString
                WeatherStation_Connected = False
                txt_WeatherStationReply.Text = ex.Message
                tmr_Check_WeatherStation_Reply.Stop()
            End Try

        Else

        End If
    End Sub

    Private Sub btn_ConnectPowerMeter_Click(sender As Object, e As EventArgs) Handles btn_ConnectPowerMeter.Click
        ConnectPowerMeter()
    End Sub

    Private Sub btn_ConnectFieldImage_Click(sender As Object, e As EventArgs) Handles btn_ConnectFieldImage.Click
        ConnectFieldImage()
    End Sub
    Public Sub ConnectFieldImage()
        Try
            TCP_FieldImageClient = New Sockets.TcpClient(txt_FieldImage_IP.Text, 502)
            TCP_FieldImageStream = New Sockets.NetworkStream(TCP_FieldImageClient.Client)
            FieldImage_Connected = True
            lbl_FieldImage_ConnectionStatus.Text = "CONNECTED"
            txt_FieldImageReply.Text = "FIELD IMAGE CONNECTED"
            lbl_FieldImage_Connected.Text = "CONNECTED"
            GetFieldImageData()
        Catch ex As Exception
            FieldImage_Connected = False
            txt_FieldImageReply.Text = "Cannot Connect to Field Image"
            lbl_FieldImage_ConnectionStatus.Text = "COULD CONNECT TO FIELD IMAGE"
            lbl_FieldImage_Connected.Text = "NOT CONNECTED"
        End Try
    End Sub
    Private Sub btn_SendFieldImage_Request_Click(sender As Object, e As EventArgs) Handles btn_SendFieldImage_Request.Click
        GetFieldImageData()
    End Sub

    Public Sub GetFieldImageData()
        Dim SendBytes() As Byte = {}
        If Not chk_USE_FIELD_IMAGE.Checked Then Exit Sub
        Select Case FieldImage_Type
            Case "WAGO"
                SendBytes = {172, 53, 0, 0, 0, 6, 1, 3, 48, 0, 0, 123} ' HR ID=1 start= 12288 len = 123
            Case Else
                ' Not specified
        End Select


        If FieldImage_Connected Then
            txt_FieldImageReply.Text = "Trying to Send Message to PLC"
            Try
                If TCP_FieldImageClient.Client.Connected Then
                    TCP_FieldImageClient.Client.Send(SendBytes)
                    txt_FieldImageReply.Text = "Message to PLC has been sent"
                    tmr_Check_FieldImage_Reply.Interval = 300
                    tmr_Check_FieldImage_Reply.Enabled = True
                    tmr_Check_FieldImage_Reply.Start()
                Else
                    tmr_Check_FieldImage_Reply.Stop()
                    txt_FieldImageReply.Text = "FieldImage Not Connected "
                    lbl_FieldImage_ConnectionStatus.Text = "NOT CONNECTED"
                    lbl_FieldImage_Connected.Text = "CONNECTED"
                End If
            Catch ex1 As Exception
                tmr_Check_FieldImage_Reply.Stop()
                FieldImage_Connected = False
                txt_FieldImageReply.Text = "Error when reading FieldImage : " & ex1.Message
                Console.WriteLine("497: " & ex1.Message)
            End Try
        Else
            txt_FieldImageReply.Text = "FieldImage Not Connected "
            lbl_FieldImage_ConnectionStatus.Text = "NOT CONNECTED"
            lbl_FieldImage_Connected.Text = "NOT CONNECTED"
        End If
    End Sub

    Private Sub tmr_CheckFieldImage_Reply_Tick(sender As Object, e As EventArgs) Handles tmr_Check_FieldImage_Reply.Tick
        Dim rcvbytes(65535) As Byte
        Dim i As Integer
        Dim BytesReceived As Integer
        Dim buffer As String = ""
        If FieldImage_Connected Then
            Try
                If TCP_FieldImageStream.DataAvailable Then
                    BytesReceived = CInt(TCP_FieldImageClient.Client.Available)
                    TCP_FieldImageStream.Read(rcvbytes, 0, BytesReceived)
                    buffer = "Received " & BytesReceived & " Bytes" & CrLf
                    For i = 0 To BytesReceived - 1
                        buffer &= "[" & rcvbytes(i).ToString & "]"
                    Next
                    txt_FieldImageReply.Text = buffer
                    Console.WriteLine("519: Process_FieldImageData(rcvbytes, BytesReceived) ")
                    Process_FieldImageData(rcvbytes, BytesReceived)
                    FieldImageClient_IdleCounter = 0

                End If
            Catch ex As Exception
                FieldImage_Connected = False
                txt_FieldImageReply.Text = ex.Message
                tmr_Check_FieldImage_Reply.Stop()
                FieldImageScanErrorCount += 1
                lbl_FieldImageScanErrCount.Text = FieldImageScanErrorCount.ToString
            End Try

        Else

        End If
    End Sub

    Public Sub Process_FieldImageData(ReplyData As Byte(), ReceivedBytesCount As Integer)

        Dim ReplyString As String = ""
        Dim DigitalInputs(15) As Boolean
        Dim BOOLEANS(15) As Boolean

        lbl_PLC_TYPE.Text = FieldImage_Type

        If ReceivedBytesCount < 10 Then
            FieldImageScanErrorCount += 1
            lbl_FieldImageScanErrCount.Text = FieldImageScanErrorCount.ToString
            If ReplyData(7) = 131 Then
                FieldImageData_Reply_Exception = ReplyData(8)
                lbl_FieldImage_Exception.Text = "Exception " & FieldImageData_Reply_Exception.ToString
                txt_FieldImageReply.Text &= CrLf & "Exception " & FieldImageData_Reply_Exception.ToString & " Received"
                If FieldImageData_Reply_Exception = 11 Then
                    GetFieldImageData()
                End If
            End If
        Else
            lbl_PLC_TYPE.Text = FieldImage_Type
            Select Case FieldImage_Type

                Case "WAGO"
                    lbl_PLC_TYPE.Text = "WAGO"
                    If ReceivedBytesCount = 255 Then 'TOTAL DATA BYTES IS 255 - 10 (FIRST USED AS MODBUS HEADER LATER AS TIMESTAMP AND ASDU ID) 
                        FieldImageScanOkCount += 1
                        lbl_FieldImageScanOkCount.Text = FieldImageScanOkCount.ToString
                        FieldImageData_Reply_Exception = 0
                        lbl_FieldImage_Exception.Text = "Reply OK"

                        FieldImage_Readings.PLC_DATA_ARRAY = ReplyData

                        'B00.0 := D_IN.ACB_OPENED ; 		(* ReplyData[10] bit 0  ->  And 1   DigitalInputs(0) *)
                        'B00.1 := D_IN.ACB_CLOSED ; 		(* ReplyData[10] bit 1  ->  And 2   DigitalInputs(1) *)
                        'B00.2 := sp_105_ACB_TRIPPED ; 	    (* ReplyData[10] bit 2  ->  And 4   DigitalInputs(2) *)
                        'B00.3 := sp_101_LOCAL_REMOTE ;     (* ReplyData[10] bit 3  ->  And 8   DigitalInputs(3) *)
                        'B00.4 :=D_IN.SPARE_DI_5; 			(* ReplyData[10] bit 4  ->  And 16  DigitalInputs(4) *)
                        'B00.5 := D_IN.SPARE_DI_6 ; 		(* ReplyData[10] bit 5  ->  And 32  DigitalInputs(5) *)
                        'B00.6 := D_IN.SPARE_DI_7 ; 		(* ReplyData[10] bit 6  ->  And 64  DigitalInputs(6) *)
                        'B00.7 := D_IN.SPARE_DI_8 ; 		(* ReplyData[10] bit 7  ->  And 128 DigitalInputs(7) *)

                        'B00.8  := sp_106_CTRL_ERROR ;	    (* ReplyData[9] bit 0  	->  And 1   DigitalInputs(8) *)
                        'B00.9  := sp_107_OVER_FREQ ;	    (* ReplyData[9] bit 1  	->  And 2   DigitalInputs(9) *)
                        'B00.10 := sp_108_UNDER_FREQ ;	    (* ReplyData[9] bit 2  	->  And 4   DigitalInputs(10)*)
                        'B00.11 := sp_109_OVER_VOLT ;		(* ReplyData[9] bit 3  	->  And 8   DigitalInputs(11)*)
                        'B00.12 := sp_110_UNDER_VOLT  ;	    (* ReplyData[9] bit 4   ->  And 16  DigitalInputs(12)*)
                        'B00.13 := sp_111_ROCOF ;			(* ReplyData[9] bit 5   ->  And 32  DigitalInputs(13)*)
                        'B00.14 := D_IN.SPARE_DI_15 ;		(* ReplyData[9] bit 6   ->  And 64  DigitalInputs(14)*)
                        'B00.15 := D_IN.SPARE_DI_16;		(* ReplyData[9] bit 7   ->  And 128 DigitalInputs(15)*)


                        For i = 0 To 7
                            DigitalInputs(i) = (ReplyData(10) And Math.Pow(2, i)) <> 0
                        Next
                        If DigitalInputs(0) Then
                            DigitalInputs_161.DI_01.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_01.BackColor = Color.Transparent
                        End If
                        If DigitalInputs(1) Then
                            DigitalInputs_161.DI_02.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_02.BackColor = Color.Transparent
                        End If

                        If DigitalInputs(2) Then
                            DigitalInputs_161.DI_03.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_03.BackColor = Color.Transparent
                        End If
                        If DigitalInputs(3) Then
                            DigitalInputs_161.DI_04.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_04.BackColor = Color.Transparent
                        End If

                        If DigitalInputs(4) Then
                            DigitalInputs_161.DI_05.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_05.BackColor = Color.Transparent
                        End If
                        If DigitalInputs(5) Then
                            DigitalInputs_161.DI_06.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_06.BackColor = Color.Transparent
                        End If

                        If DigitalInputs(6) Then
                            DigitalInputs_161.DI_07.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_07.BackColor = Color.Transparent
                        End If
                        If DigitalInputs(7) Then
                            DigitalInputs_161.DI_08.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_08.BackColor = Color.Transparent
                        End If


                        '-------------------------
                        For i = 0 To 7
                            DigitalInputs(i + 8) = (ReplyData(9) And Math.Pow(2, i)) <> 0
                            'SetDigitalIndicator(DigitalInputlabel(1, i), DigitalInputs(i + 8))
                        Next
                        If DigitalInputs(8) Then
                            DigitalInputs_161.DI_09.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_09.BackColor = Color.Transparent
                        End If
                        If DigitalInputs(9) Then
                            DigitalInputs_161.DI_10.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_10.BackColor = Color.Transparent
                        End If

                        If DigitalInputs(10) Then
                            DigitalInputs_161.DI_11.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_11.BackColor = Color.Transparent
                        End If
                        If DigitalInputs(11) Then
                            DigitalInputs_161.DI_12.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_12.BackColor = Color.Transparent
                        End If

                        If DigitalInputs(12) Then
                            DigitalInputs_161.DI_13.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_13.BackColor = Color.Transparent
                        End If
                        If DigitalInputs(13) Then
                            DigitalInputs_161.DI_14.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_14.BackColor = Color.Transparent
                        End If

                        If DigitalInputs(14) Then
                            DigitalInputs_161.DI_15.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_15.BackColor = Color.Transparent
                        End If
                        If DigitalInputs(15) Then
                            DigitalInputs_161.DI_16.BackColor = Color.Yellow
                        Else
                            DigitalInputs_161.DI_16.BackColor = Color.Transparent
                        End If




                        ' MAIN ACB TRIP
                        If DigitalInputs(2) Then
                            Group_ACB.BackColor = Color.Red
                        Else
                            Group_ACB.BackColor = Color.Transparent
                        End If

                        'REMOTE / LOCAL
                        If DigitalInputs(3) Then
                            lbl_RemoteLocal.BackColor = Color.Yellow
                            lbl_RemoteLocal.Text = "LOCAL"
                        Else
                            lbl_RemoteLocal.BackColor = Color.Transparent
                            lbl_RemoteLocal.Text = "REMOTE"
                        End If



                        For i = 0 To 7
                            BOOLEANS(i) = (ReplyData(12) And Math.Pow(2, i)) <> 0
                        Next
                        For i = 0 To 7
                            BOOLEANS(i + 8) = (ReplyData(11) And Math.Pow(2, i)) <> 0
                        Next

                        If (Not DigitalInputs(0)) And (Not DigitalInputs(1)) Then
                            PictureBox3.Image = ACB_States.Images(0)
                            lbl_ACB_Status.Text = "UNDEFINED"
                        Else
                            If DigitalInputs(0) And (Not DigitalInputs(1)) Then
                                PictureBox3.Image = ACB_States.Images(1)
                                lbl_ACB_Status.Text = "OPEN"
                            Else
                                If (Not DigitalInputs(0)) And DigitalInputs(1) Then
                                    PictureBox3.Image = ACB_States.Images(2)
                                    lbl_ACB_Status.Text = "CLOSED"
                                Else
                                    PictureBox3.Image = ACB_States.Images(3)
                                    lbl_ACB_Status.Text = "UNDEFINED"
                                End If
                            End If
                        End If

                        'B00.16 := dp_121_CURTAIL_FB_100_ON ;	(* ReplyData[12] bit 0  ->  And 1    BOOLEANS(0) *)
                        'B00.17 := dp_122_CURTAIL_60_FB_ON ;	(* ReplyData[12] bit 1  ->  And 2    BOOLEANS(1) *)
                        'B00.18 := dp_123_CURTAIL_30_FB_ON ;	(* ReplyData[12] bit 3  ->  And 4    BOOLEANS(2) *)
                        'B00.19 := dp_124_CURTAIL_0_FB_ON ;	    (* ReplyData[12] bit 3  ->  And 8    BOOLEANS(3) *)

                        If BOOLEANS(0) Then
                            btn_100_ON.BackColor = Color.Yellow
                        Else
                            btn_100_ON.BackColor = Color.Transparent
                        End If
                        If BOOLEANS(1) Then
                            btn_060_ON.BackColor = Color.Yellow
                        Else
                            btn_060_ON.BackColor = Color.Transparent
                        End If
                        If BOOLEANS(2) Then
                            btn_030_ON.BackColor = Color.Yellow
                        Else
                            btn_030_ON.BackColor = Color.Transparent
                        End If
                        If BOOLEANS(3) Then
                            btn_000_ON.BackColor = Color.Yellow
                        Else
                            btn_000_ON.BackColor = Color.Transparent
                        End If

                        'B00.20 := dp_125_CURTAIL_ENABLE_FB_ON ;(* ReplyData[12] bit 4  ->  And 16   BOOLEANS(4) *)
                        'B00.21 := dp_126_FIX_KVAR_ENABLE_FB_ON ;(* ReplyData12] bit 5  ->  And 32   BOOLEANS(5) *)

                        If BOOLEANS(4) Then
                            lbl_Curtail_kW.BackColor = Color.Yellow
                        Else
                            lbl_Curtail_kW.BackColor = Color.Transparent
                        End If
                        If BOOLEANS(5) Then
                            lbl_Fix_kVAr.BackColor = Color.Yellow
                        Else
                            lbl_Fix_kVAr.BackColor = Color.Transparent
                        End If

                        'B00.22 := dp_127_PRODMAN_ON            ;(* ReplyData[12] bit 6  ->  And 64   BOOLEANS(6)  *)
                        'B00.23 := RTU_CONNECTED                ;(* ReplyData[12] bit 7  ->  And 128  BOOLEANS(7)  *)
                        'B00.24 := DEV1_CONNECTED               ;(* ReplyData[11] bit 0  ->  And 1    BOOLEANS(8)  *)
                        'B00.25 := WEATHER_STATION.xERROR = 0   ;(* ReplyData[11] bit 1  ->  And 2    BOOLEANS(9)  *)
                        'B00.26 := BOOL_26                      ;(* ReplyData[11] bit 3  ->  And 4    BOOLEANS(10) *)
                        'B00.27 := BOOL_27                      ;(* ReplyData[11] bit 4  ->  And 8    BOOLEANS(11) *)
                        'B00.28 := BOOL_28                      ;(* ReplyData[11] bit 5  ->  And 16   BOOLEANS(12) *)
                        'B00.29 := BOOL_29                      ;(* ReplyData[11] bit 5  ->  And 32   BOOLEANS(13) *)
                        'B00.30 := BOOL_30                      ;(* ReplyData[11] bit 5  ->  And 64   BOOLEANS(14) *)
                        'B00.31 := BOOL_31                      ;(* ReplyData[11] bit 5  ->  And 128  BOOLEANS(15) *)

                        If BOOLEANS(6) Then
                            Group_PRODMAN.BackColor = Color.Yellow
                        Else
                            Group_PRODMAN.BackColor = Color.Transparent
                        End If

                        If BOOLEANS(7) Then
                            Group_RTU_Connection.BackColor = Color.Yellow
                            Group_RTU_Connection.Text = "RTU CONNECTED"
                        Else
                            Group_RTU_Connection.BackColor = Color.Red
                            Group_RTU_Connection.Text = "RTU NOT CONNECTED"
                        End If

                        If BOOLEANS(8) Then
                            Group_P855.BackColor = Color.Yellow
                        Else
                            Group_P855.BackColor = Color.Transparent
                        End If

                        If BOOLEANS(9) Then
                            Group_WEATHER.BackColor = Color.Yellow
                        Else
                            Group_WEATHER.BackColor = Color.Transparent
                        End If


                        'using ReplyData(17 .. 80 for 16 Single Reals standard measurements and control feedback)
                        For k = 0 To 15
                            rPARMS(k) = BytesToFloat(ReplyData, 17 + 4 * k)
                        Next


                        ' Starting from addres 12292 returned in ReplyData[17]
                        '=============================================================
                        'rPARMS[0] := r_Phase2PhaseVoltage ;    (* ReplyData[17..20] *)
                        'rPARMS[1] := ME13_501_OuputActivePower;(* ReplyData[21..24] *)
                        'rPARMS[2] := ME13_502_ReactivePower;   (* ReplyData[25..28] *)
                        'rPARMS[3] := r_GridPowerFactor;        (* ReplyData[29..32] *)
                        'rPARMS[4] := REAL_04;                  (* ReplyData[33..36] *)

                        'rPARMS[5] := PLANT_TOTAL_CAPACITY;     (* ReplyData[37..40] *)
                        'rPARMS[6] := i_MaxAllowedCurtailValue; (* ReplyData[41..44] *)
                        'rPARMS[7] := i_030_KW_CURTAIL_VALUE;   (* ReplyData[45..48] *)
                        'rPARMS[8] := i_030_KW_CURTAIL_REQ_VALUE;(* ReplyData[49..52] *)
                        'rPARMS[9] := i_031_KVAR_FIX_VALUE;     (* ReplyData[53..56] *)



                        'rPARMS[10] := ME13_505_PV_Plant_Availablitiy;  (* ReplyData[57..60] *)
                        'rPARMS[11] := ME13_506_Sunshine;               (* ReplyData[61..64] *)
                        'rPARMS[12] := ME13_507_Temperature;            (* ReplyData[65..68] *)
                        'rPARMS[13] := ME13_508_WindSpeed;              (* ReplyData[69..72] *)
                        'rPARMS[14] :=  REAL_14;                        (* ReplyData[73..76] *)
                        'rPARMS[15] :=  REAL_15;                        (* ReplyData[77..80] *)

                        lbl_kV.Text = rPARMS(0).ToString
                        lbl_ExportPower.Text = rPARMS(1).ToString
                        lbl_kVAr.Text = rPARMS(2).ToString
                        lbl_PF.Text = rPARMS(3).ToString
                        lbl_REAL_04.Text = rPARMS(4).ToString


                        lbl_PlantCapacity.Text = rPARMS(5).ToString
                        lbl_MaxAllowed.Text = rPARMS(6).ToString
                        lbl_Curtail_kW.Text = rPARMS(7).ToString
                        lbl_Fix_kVAr.Text = rPARMS(9).ToString
                        lbl_Availability.Text = rPARMS(10).ToString
                        lbl_SOLAR.Text = rPARMS(11).ToString
                        lbl_Ambient.Text = rPARMS(12).ToString
                        lbl_Speed.Text = rPARMS(13).ToString

                        Dim InverterInfo As New InverterReadings
                        '
                        Dim q As Byte = 85
                        For k = 0 To 9 ' Data for 10 Inverters using a total of 10 * 12 = 120 data bytes 85..204 (leaving 51 bytes spare) 
                            InverterInfo.CONNECTION = ReplyData(q + k * 12 + 1)
                            InverterInfo.STATUS = ReplyData(q + k * 12)
                            InverterInfo.ACTIVE_POWER = TwoBytesToInt16(ReplyData, q + k * 12 + 2)
                            InverterInfo.REACTIVE_POWER = TwoBytesToInt16(ReplyData, q + k * 12 + 4)
                            InverterInfo.POWER_FACTOR = 0.001 * TwoBytesToInt16(ReplyData, q + k * 12 + 6)
                            InverterInfo.POWER_LIM = TwoBytesToInt16(ReplyData, q + k * 12 + 8)
                            InverterInfo.KVAR_FIX = TwoBytesToInt16(ReplyData, q + k * 12 + 10)

                            If InverterInfo.CONNECTION = 1 Then
                                InverterControlDisplay(k).InverterControlBox.BackColor = Color.Transparent
                            Else
                                InverterControlDisplay(k).InverterControlBox.BackColor = Color.Red
                            End If

                            InverterControlDisplay(k).lbl_Active_Power.Text = InverterInfo.ACTIVE_POWER
                            InverterControlDisplay(k).lbl_ReactivePower.Text = InverterInfo.REACTIVE_POWER
                            InverterControlDisplay(k).lbl_PowerFactor.Text = InverterInfo.POWER_FACTOR
                            InverterControlDisplay(k).lbl_Max_Output.Text = InverterInfo.POWER_LIM
                            InverterControlDisplay(k).lbl_kVAr_Fixing.Text = InverterInfo.KVAR_FIX
                            InverterControlDisplay(k).lbl_State.Text = InverterInfo.STATUS
                            If InverterInfo.STATUS >= 0 And InverterInfo.STATUS < 9 Then
                                InverterControlDisplay(k).lbl_State.Text = OperatingState(InverterInfo.STATUS)
                            Else
                                InverterControlDisplay(k).lbl_State.Text = InverterInfo.STATUS.ToString
                            End If
                        Next

                        ' ADDING THE UPLOAD HEADER YY MM DD HH MM SS ASDU_MSB ASDU_LSB SPARE1 SPARE2
                        ' ASDU WILL BE USED AS THE SOURCE IDENTIFICATION

                        If ThisSecond = "00" Or ThisSecond = "30" Then
                            ReplyData(0) = CInt(Mid(MySQL_timestamp, 3, 2))
                            ReplyData(1) = CInt(Mid(MySQL_timestamp, 6, 2))
                            ReplyData(2) = CInt(Mid(MySQL_timestamp, 9, 2))
                            ReplyData(3) = CInt(Mid(MySQL_timestamp, 12, 2))
                            ReplyData(4) = CInt(Mid(MySQL_timestamp, 15, 2))
                            ReplyData(5) = CInt(Mid(MySQL_timestamp, 18, 2))
                            ReplyData(6) = Int(ASDU / 256)
                            ReplyData(7) = ASDU - 256 * ReplyData(6)
                            ReplyData(8) = 0
                            ReplyData(9) = 0
                            UpLoad(ReplyData, ReceivedBytesCount)
                        End If
                    Else
                        FieldImageScanErrorCount += 1
                        lbl_FieldImageScanErrCount.Text = FieldImageScanErrorCount.ToString
                        txt_FieldImageReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 53"
                    End If

                Case Else
                    ' Not deffined
            End Select
        End If
    End Sub
    Function TwoBytesToInt16(SourceArray, Offset)
        Dim Byte1 As Byte
        Dim Byte2 As Byte

        Byte1 = SourceArray(Offset)
        Byte2 = SourceArray(Offset + 1)

        Dim bytes() As Byte = {Byte2, Byte1}


        Dim result As Int16 = BitConverter.ToInt16(bytes, 0)
        Return result
    End Function
    Private Sub SetDigitalIndicator(ByVal control As Control, Status As Boolean)
        If Status = True Then
            control.BackColor = Color.Yellow
            control.ForeColor = Color.Black
        Else
            control.BackColor = Color.LightGray
            control.ForeColor = Color.Teal
        End If
    End Sub




    Public Sub ConnectPowerMeter()
        Try
            TCP_PowerMeterClient = New Sockets.TcpClient(txt_PowerMeter_IP.Text, 502)
            TCP_PowerMeterStream = New Sockets.NetworkStream(TCP_PowerMeterClient.Client)
            PowerMeter_Connected = True
            lbl_PowerMeter_ConnectionStatus.Text = "CONNECTED"
            txt_PowerMeterReply.Text = "POWER METER CONNECTED"
            lbl_PowerMeter_Connected.Text = "CONNECTED"
            GetPowerMeterData()
        Catch ex As Exception
            PowerMeter_Connected = False
            txt_PowerMeterReply.Text = "Cannot Connect to Power Meter"
            lbl_PowerMeter_ConnectionStatus.Text = "COULD CONNECT TO POWER METER"
            lbl_PowerMeter_Connected.Text = "NOT CONNECTED"
        End Try
    End Sub
    Private Sub btn_SendPowerMeter_Request_Click(sender As Object, e As EventArgs) Handles btn_SendPowerMeter_Request.Click
        GetPowerMeterData()
    End Sub
    Public Sub GetPowerMeterData()
        Dim SendBytes() As Byte = {}
        If Not chk_USE_POWER_METER.Checked Then Exit Sub
        Select Case PowerMeter_Type
            Case "PAC4200"
                SendBytes = {172, 52, 0, 0, 0, 6, 1, 3, 0, 1, 0, 42} ' HR ID=1 start= 1 len = 42
            Case "MAPPED_SICAM"
                SendBytes = {172, 53, 0, 0, 0, 6, 1, 3, 48, 2, 0, 2} ' HR ID=1 start= 12290 len = 2
            Case "WM30"
                SendBytes = {172, 54, 0, 0, 0, 6, 1, 3, 0, 110, 0, 2} 'HR ID=1 start= 110 len = 2
            Case "SIMATIC_7SJ80"
                SendBytes = {172, 55, 0, 0, 0, 6, 62, 4, 0, 11, 0, 1} 'IR ID=62 start= 11 len = 1
            Case "MAPPED_SCADA"
                SendBytes = {172, 53, 0, 0, 0, 6, 1, 3, 48, 0, 0, 2} ' HR ID=1 start= 12288 len = 2
            Case "MAPPED_HR12299"
                SendBytes = {172, 53, 0, 0, 0, 6, 1, 3, 48, 10, 0, 2} ' HR12299 ID=1 start= 12298 len = 2
            Case "MAPPED_SCADA_12390"
                SendBytes = {172, 53, 0, 0, 0, 6, 1, 3, 48, 102, 0, 2} ' HR ID=1 start= 12390 len = 2 Forwarding point 501 P855_MMXU1_TotW AT %MW102 : REAL; (* 412391*)

            Case "MAPPED_SCADA_12490"
                SendBytes = {172, 53, 0, 0, 0, 6, 1, 3, 48, 202, 0, 2} ' HR ID=1 start= 12490 len = 2 Forwarding point sfp_501_KW via rPARM_01_12490: REAL; (* 12490*)
        End Select

        txt_PowerMeterReply.Text = ""
        If PowerMeter_Connected Then
            Try
                If TCP_PowerMeterClient.Client.Connected Then
                    TCP_PowerMeterClient.Client.Send(SendBytes)
                    tmr_Check_PowerMeter_Reply.Interval = 300
                    tmr_Check_PowerMeter_Reply.Enabled = True
                    tmr_Check_PowerMeter_Reply.Start()
                Else
                    tmr_Check_PowerMeter_Reply.Stop()
                    txt_PowerMeterReply.Text = "PowerMeter Not Connected "
                    lbl_PowerMeter_ConnectionStatus.Text = "NOT CONNECTED"
                    lbl_PowerMeter_Connected.Text = "CONNECTED"
                End If
            Catch ex1 As Exception
                tmr_Check_PowerMeter_Reply.Stop()
                PowerMeter_Connected = False
                Console.WriteLine("497: " & ex1.Message)
            End Try
        Else
            txt_PowerMeterReply.Text = "PowerMeter Not Connected "
            lbl_PowerMeter_ConnectionStatus.Text = "NOT CONNECTED"
            lbl_PowerMeter_Connected.Text = "NOT CONNECTED"
        End If
    End Sub

    Private Sub tmr_CheckPowerMeter_Reply_Tick(sender As Object, e As EventArgs) Handles tmr_Check_PowerMeter_Reply.Tick
        Dim rcvbytes(65535) As Byte
        Dim i As Integer
        Dim BytesReceived As Integer
        Dim buffer As String = ""
        If PowerMeter_Connected Then
            Try
                If TCP_PowerMeterStream.DataAvailable Then
                    Console.WriteLine("511: Received " & TCP_PowerMeterClient.Client.Available & " Bytes")
                    BytesReceived = CInt(TCP_PowerMeterClient.Client.Available)
                    TCP_PowerMeterStream.Read(rcvbytes, 0, BytesReceived)
                    buffer = "Received " & BytesReceived & " Bytes" & CrLf
                    For i = 0 To BytesReceived - 1
                        buffer &= "[" & rcvbytes(i).ToString & "]"
                    Next
                    txt_PowerMeterReply.Text = buffer
                    Console.WriteLine("519: Process_PowerMeterData(rcvbytes, BytesReceived) ")
                    Process_PowerMeterData(rcvbytes, BytesReceived)
                    PowerMeterClient_IdleCounter = 0

                End If
            Catch ex As Exception
                PowerMeter_Connected = False
                txt_PowerMeterReply.Text = ex.Message
                tmr_Check_PowerMeter_Reply.Stop()
                PowerMeterScanErrorCount += 1
                lbl_PowerMeterScanErrorCount.Text = PowerMeterScanErrorCount.ToString
            End Try

        Else

        End If
    End Sub
    Public Sub Process_PowerMeterData(ReplyData As Byte(), ReceivedBytesCount As Integer)

        Dim ReplyString As String = ""
        Dim ParmValue As Integer
        Dim ParmReadings As String

        lbl_METER_TYPE.Text = PowerMeter_Type

        If ReceivedBytesCount < 10 Then
            PowerMeterScanErrorCount += 1
            lbl_PowerMeterScanErrorCount.Text = PowerMeterScanErrorCount.ToString
            If ReplyData(7) = 131 Then
                WeatherData_Reply_Exception = ReplyData(8)
                lbl_PowerMeter_Exception.Text = "Exception " & WeatherData_Reply_Exception.ToString
                txt_PowerMeterReply.Text &= CrLf & "Exception " & WeatherData_Reply_Exception.ToString & " Received"
                If WeatherData_Reply_Exception = 11 Then
                    GetPowerMeterData()
                End If
            End If
        Else
            lbl_METER_TYPE.Text = PowerMeter_Type
            Select Case PowerMeter_Type

                Case "PAC4200"
                    lbl_METER_TYPE.Text = "PAC4200"
                    If ReceivedBytesCount = 93 Then
                        PowerMeterScanOkCount += 1
                        lbl_PowerMeterScanOkCount.Text = PowerMeterScanOkCount.ToString
                        WeatherData_Reply_Exception = 0
                        lbl_PowerMeter_Exception.Text = "Reply OK"
                        PowerMeter_Readings.P_L1 = BytesToSwappedFloat(ReplyData, 57)
                        PowerMeter_Readings.P_L2 = BytesToSwappedFloat(ReplyData, 61)
                        PowerMeter_Readings.P_L3 = BytesToSwappedFloat(ReplyData, 65)

                        PowerMeter_Readings.P_Tot = PowerMeter_Readings.P_L1 + PowerMeter_Readings.P_L2 + PowerMeter_Readings.P_L3

                        lbl_P_L1.Text = PowerMeter_Readings.P_L1
                        lbl_P_L2.Text = PowerMeter_Readings.P_L2
                        lbl_P_L3.Text = PowerMeter_Readings.P_L3
                        lbl_P_Tot.Text = PowerMeter_Readings.P_Tot

                        PowerMeterScanOkCount += 1
                        lbl_PowerMeterScanOkCount.Text = PowerMeterScanOkCount.ToString

                        ParmReadings = ""
                        For j = 9 To 93 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_PowerMeterReply.Text &= CrLf & ParmReadings
                    Else
                        txt_PowerMeterReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 53"
                    End If

                Case "MAPPED_SICAM"
                    lbl_METER_TYPE.Text = "MAPPED_SICAM"
                    Console.WriteLine(" Case MAPPED_SICAM")
                    If ReceivedBytesCount = 13 Then
                        PowerMeterScanOkCount += 1
                        lbl_PowerMeterScanOkCount.Text = PowerMeterScanOkCount.ToString
                        WeatherData_Reply_Exception = 0
                        lbl_PowerMeter_Exception.Text = "Reply OK"
                        Try
                            PowerMeter_Readings.P_Tot = BytesToFloat(ReplyData, 9)
                            lbl_P_Tot.Text = PowerMeter_Readings.P_Tot
                        Catch ex As Exception
                            PowerMeter_Readings.P_Tot = 0
                            lbl_P_Tot.Text = "Overflow"
                        End Try

                        lbl_P_L1.Text = ""
                        lbl_P_L2.Text = ""
                        lbl_P_L3.Text = ""


                        ParmReadings = ""
                        For j = 9 To 12 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_PowerMeterReply.Text &= CrLf & ParmReadings
                    Else
                        txt_PowerMeterReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 53"
                    End If

                Case "MAPPED_SCADA"
                    lbl_METER_TYPE.Text = "MAPPED_SCADA"
                    Console.WriteLine(" Case MAPPED_SCADA")
                    If ReceivedBytesCount = 13 Then
                        PowerMeterScanOkCount += 1
                        lbl_PowerMeterScanOkCount.Text = PowerMeterScanOkCount.ToString
                        WeatherData_Reply_Exception = 0
                        lbl_PowerMeter_Exception.Text = "Reply OK"
                        Try
                            PowerMeter_Readings.P_Tot = 1000.0 * BytesToFloat(ReplyData, 9)
                            lbl_P_Tot.Text = PowerMeter_Readings.P_Tot
                        Catch ex As Exception
                            PowerMeter_Readings.P_Tot = 0
                            lbl_P_Tot.Text = "Overflow"
                        End Try

                        lbl_P_L1.Text = ""
                        lbl_P_L2.Text = ""
                        lbl_P_L3.Text = ""


                        ParmReadings = ""
                        For j = 9 To 12 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_PowerMeterReply.Text &= CrLf & ParmReadings
                    Else
                        txt_PowerMeterReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 13"
                    End If

                Case "MAPPED_HR12299"
                    Console.WriteLine(" Case MAPPED_HR12299")
                    lbl_METER_TYPE.Text = "MAPPED_HR12299"
                    If ReceivedBytesCount = 13 Then
                        PowerMeterScanOkCount += 1
                        lbl_PowerMeterScanOkCount.Text = PowerMeterScanOkCount.ToString
                        WeatherData_Reply_Exception = 0
                        lbl_PowerMeter_Exception.Text = "Reply OK"
                        Try
                            PowerMeter_Readings.P_Tot = BytesToFloat(ReplyData, 9)
                            lbl_P_Tot.Text = PowerMeter_Readings.P_Tot
                        Catch ex As Exception
                            PowerMeter_Readings.P_Tot = 0
                            lbl_P_Tot.Text = "Overflow"
                        End Try

                        lbl_P_L1.Text = ""
                        lbl_P_L2.Text = ""
                        lbl_P_L3.Text = ""


                        ParmReadings = ""
                        For j = 9 To 12 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_PowerMeterReply.Text &= CrLf & ParmReadings
                    Else
                        txt_PowerMeterReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 13"
                    End If

                Case "MAPPED_SCADA_12390"
                    Console.WriteLine(" Case MAPPED_SCADA_12390")
                    lbl_METER_TYPE.Text = "MAPPED_SCADA_12390"
                    If ReceivedBytesCount = 13 Then
                        PowerMeterScanOkCount += 1
                        lbl_PowerMeterScanOkCount.Text = PowerMeterScanOkCount.ToString
                        WeatherData_Reply_Exception = 0
                        lbl_PowerMeter_Exception.Text = "Reply OK"
                        Try
                            PowerMeter_Readings.P_Tot = 1.0 * BytesToFloat(ReplyData, 9)
                            lbl_P_Tot.Text = PowerMeter_Readings.P_Tot
                        Catch ex As Exception
                            PowerMeter_Readings.P_Tot = 0
                            lbl_P_Tot.Text = "Overflow"
                        End Try

                        lbl_P_L1.Text = ""
                        lbl_P_L2.Text = ""
                        lbl_P_L3.Text = ""


                        ParmReadings = ""
                        For j = 9 To 12 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_PowerMeterReply.Text &= CrLf & ParmReadings
                    Else
                        txt_PowerMeterReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 13"
                    End If



                Case "MAPPED_SCADA_12490"
                    lbl_METER_TYPE.Text = "MAPPED_SCADA_12490"
                    Console.WriteLine(" Case MAPPED_SCADA_12490")
                    If ReceivedBytesCount = 13 Then
                        PowerMeterScanOkCount += 1
                        lbl_PowerMeterScanOkCount.Text = PowerMeterScanOkCount.ToString
                        WeatherData_Reply_Exception = 0
                        lbl_PowerMeter_Exception.Text = "Reply OK"
                        Try
                            PowerMeter_Readings.P_Tot = 1000.0 * BytesToFloat(ReplyData, 9)
                            lbl_P_Tot.Text = PowerMeter_Readings.P_Tot
                        Catch ex As Exception
                            PowerMeter_Readings.P_Tot = 0
                            lbl_P_Tot.Text = "Overflow"
                        End Try

                        lbl_P_L1.Text = ""
                        lbl_P_L2.Text = ""
                        lbl_P_L3.Text = ""


                        ParmReadings = ""
                        For j = 9 To 12 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_PowerMeterReply.Text &= CrLf & ParmReadings
                    Else
                        txt_PowerMeterReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 13"
                    End If



                Case "WM30"
                    lbl_METER_TYPE.Text = "WM30"
                    Console.WriteLine(" Case WM30")
                    If ReceivedBytesCount = 13 Then
                        PowerMeterScanOkCount += 1
                        lbl_PowerMeterScanOkCount.Text = PowerMeterScanOkCount.ToString
                        WeatherData_Reply_Exception = 0
                        lbl_PowerMeter_Exception.Text = "Reply OK"
                        Try
                            PowerMeter_Readings.P_Tot = BytesToFloat(ReplyData, 9)
                            lbl_P_Tot.Text = PowerMeter_Readings.P_Tot
                        Catch ex As Exception
                            PowerMeter_Readings.P_Tot = 0
                            lbl_P_Tot.Text = "Overflow"
                        End Try

                        lbl_P_L1.Text = ""
                        lbl_P_L2.Text = ""
                        lbl_P_L3.Text = ""


                        ParmReadings = ""
                        For j = 9 To 12 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_PowerMeterReply.Text &= CrLf & ParmReadings
                    Else
                        txt_PowerMeterReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 53"
                    End If

                Case "SIMATIC_7SJ80"
                    lbl_METER_TYPE.Text = "SIMATIC_7880"
                    Console.WriteLine(" Case SIMATIC_7SJ80")
                    If ReceivedBytesCount = 11 Then
                        PowerMeterScanOkCount += 1
                        lbl_PowerMeterScanOkCount.Text = PowerMeterScanOkCount.ToString
                        WeatherData_Reply_Exception = 0
                        lbl_PowerMeter_Exception.Text = "Reply OK"
                        Try
                            PowerMeter_Readings.P_Tot = 1000 * (256 * ReplyData(9) + ReplyData(10))
                            lbl_P_Tot.Text = PowerMeter_Readings.P_Tot
                        Catch ex As Exception
                            PowerMeter_Readings.P_Tot = 0
                            lbl_P_Tot.Text = "Error"
                        End Try

                        lbl_P_L1.Text = "X"
                        lbl_P_L2.Text = "X"
                        lbl_P_L3.Text = "X"


                        ParmReadings = ""
                        For j = 9 To 10 Step 2
                            ParmValue = ReplyData(j) * 256 + ReplyData(j + 1)
                            ParmReadings &= j.ToString & " " & ParmValue & CrLf
                        Next
                        txt_PowerMeterReply.Text &= CrLf & ParmReadings
                    Else
                        txt_PowerMeterReply.Text &= CrLf & "Error ByteCount " & ReceivedBytesCount.ToString & " instead of 53"
                    End If



            End Select
        End If
    End Sub
    Public Function BytesToFloat(Reading As Byte(), ParmPos As Byte) As Single
        Dim FloatConversion As Single
        Dim b(3) As Byte
        b(1) = Reading(ParmPos)
        b(0) = Reading(ParmPos + 1)
        b(3) = Reading(ParmPos + 2)
        b(2) = Reading(ParmPos + 3)
        FloatConversion = BitConverter.ToSingle(b, 0)
        Return FloatConversion
    End Function

    Public Function BytesToSwappedFloat(Reading As Byte(), ParmPos As Byte) As Single
        Dim FloatConversion As Single
        Dim b(3) As Byte
        b(3) = Reading(ParmPos)
        b(2) = Reading(ParmPos + 1)
        b(1) = Reading(ParmPos + 2)
        b(0) = Reading(ParmPos + 3)
        FloatConversion = BitConverter.ToSingle(b, 0)
        Return FloatConversion
    End Function
    Public WeatherStationWatchDog As Integer = 0
    Public PowerMeterWatchDog As Integer = 0
    Public FieldImageWatchDog As Integer = 0

    Private Sub tmr_ReconnectClient_Tick(sender As Object, e As EventArgs) Handles tmr_ReconnectClient.Tick
        If (PowerMeter_Connected = False) And (chk_USE_POWER_METER.Checked = True) Then
            PowerMeterWatchDog += 1
            lbl_PowerMeterWatchDog.Text = PowerMeterWatchDog.ToString
            If PowerMeterWatchDog > 5 Then
                PowerMeterWatchDog = 0
                ConnectPowerMeter()
            End If
        End If
        If (WeatherStation_Connected) = False And (chk_USE_POWER_METER.Checked = True) Then
            WeatherStationWatchDog += 1
            lbl_WeatherStationWatchDog.Text = WeatherStationWatchDog.ToString
            If WeatherStationWatchDog > 5 Then
                WeatherStationWatchDog = 0
                ConnectWeatherStation()
            End If
        End If
        If (FieldImage_Connected = False) And (chk_USE_FIELD_IMAGE.Checked = True) Then
            FieldImageWatchDog += 1
            lbl_FieldImageWatchDog.Text = FieldImageWatchDog.ToString
            If FieldImageWatchDog > 5 Then
                FieldImageWatchDog = 0
                ConnectFieldImage()
            End If
        End If
    End Sub
    Public FieldImageClient_IdleCounter As Integer
    Public WeatherStationClient_IdleCounter As Integer
    Public PowerMeterClient_IdleCounter As String
    Private Sub tmr_CheckConnectionStatus_Tick(sender As Object, e As EventArgs) Handles tmr_CheckConnectionStatus.Tick
        WeatherStationClient_IdleCounter += 1
        PowerMeterClient_IdleCounter += 1
        If WeatherStationClient_IdleCounter > 60 Then
            TCP_WeatherStationClient.Close()
            ConnectWeatherStation()
        End If
        If PowerMeterClient_IdleCounter > 60 Then
            TCP_PowerMeterClient.Close()
            ConnectPowerMeter()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Console.Beep()
    End Sub

    Private Sub ProcessWebReply(replyMesage As String)
        If InStr(replyMesage, "Inserted OK") Then
            Bioland_Pool_Inserted_OK = True
            Bioland_Pool_Inserted_OK_Count += 1
        Else
            Bioland_Pool_Inserted_OK = False
            Bioland_Pool_Inserted_Err_Count += 1

        End If
        If InStr(replyMesage, "Updated OK") Then
            Bioland_Plants_Updated_OK = True
            Bioland_Plants_Updated_OK_Count += 1
        Else
            Bioland_Plants_Updated_OK = False
            Bioland_Plants_Updated_Err_Count += 1
        End If
        lbl_Bioland_Pool_Inserted_OK_Count.Text = Bioland_Pool_Inserted_OK_Count.ToString
        lbl_Bioland_Pool_Inserted_Err_Count.Text = Bioland_Pool_Inserted_Err_Count.ToString
        lbl_Bioland_Plants_Updated_OK_Count.Text = Bioland_Plants_Updated_OK_Count.ToString
        lbl_Bioland_Plants_Updated_Err_Count.Text = Bioland_Plants_Updated_Err_Count.ToString
    End Sub

    Private Sub chk_USE_POWER_METER_CheckedChanged(sender As Object, e As EventArgs) Handles chk_USE_POWER_METER.CheckedChanged

    End Sub

    Private Sub OptionHorizontal_CheckedChanged(sender As Object, e As EventArgs) Handles OptionHorizontal.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wrUpload As FtpWebRequest = DirectCast(WebRequest.Create("ftp://i2bs.net/public_ftp/testfile.txt"), FtpWebRequest)
        wrUpload.Credentials = New NetworkCredential("bekecom", "MEPwsm2022]!")
        wrUpload.Method = WebRequestMethods.Ftp.UploadFile
        Dim btfile() As Byte = File.ReadAllBytes("c:\temp\file.txt")
        Dim strFile As Stream = wrUpload.GetRequestStream()
        strFile.Write(btfile, 0, btfile.Length)
        strFile.Close()
        strFile.Dispose()
    End Sub

    Private Sub cmd_LibTest_Click(sender As Object, e As EventArgs) Handles cmd_LibTest.Click
        Dim myLib As New ClassLibrary2.MyLibrary()
        Dim result As String = myLib.HelloWorld()
        Me.lbl_LibTest.Text = result
    End Sub

    Private Sub UpLoad(AllBytes As Byte(), DataLen As Integer)
        Dim myLib As New ClassLibrary2.MyLibrary()
        Dim result As String = myLib.WebConnect(AllBytes, DataLen)
        Me.txt_WebReply.Text = result
    End Sub

    Private Sub TestPublicLib(AllBytes As Byte(), DataLen As Integer)
        Dim result As String = myLibTester.WebConnect(AllBytes, DataLen)
    End Sub

    Private Sub btn_WebTest_Click(sender As Object, e As EventArgs) Handles btn_WebTest.Click
        Dim myLib As New ClassLibrary2.MyLibrary()
        Dim MyDataString As String
        MyDataString = "Here" & Chr(9) & "There and" & Chr(5) & " Everywhere"

        Dim MW30_Request As MeterParms = New MeterParms()

        'Dim MyDataBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(MyDataString)

        'ThisParkData = New ParkData



        Dim ThisParkData As New ParkData()

        ThisParkData.Production(0) = 1
        ThisParkData.Production(1) = 2
        ThisParkData.Production(2) = 2
        ThisParkData.Production(3) = 4

        ThisParkData.powerFactor(0) = 10
        ThisParkData.powerFactor(1) = 20
        ThisParkData.powerFactor(2) = 30
        ThisParkData.powerFactor(3) = 40

        ThisParkData.ASDU(0) = 100
        ThisParkData.ASDU(1) = 101
        ThisParkData.ASDU(3) = 102
        ThisParkData.ASDU(4) = 103

        Dim i, j, k As Byte
        Dim SingleFloatBytes() As Byte
        Dim IntegerBytes() As Byte
        Dim SingleByte As Byte



        Dim StringOfDataBytes(35) As Byte
        k = 0
        'StringOfDataBytes 0 .. 15
        For i = 0 To 3
            IntegerBytes = System.BitConverter.GetBytes(ThisParkData.Production(i))
            For j = 0 To 3
                StringOfDataBytes(k) = IntegerBytes(j)
                k += 1
            Next
        Next

        'StringOfDataBytes 16 .. 31
        For i = 0 To 3
            SingleFloatBytes = System.BitConverter.GetBytes(ThisParkData.powerFactor(i))
            For j = 0 To 3
                StringOfDataBytes(k) = SingleFloatBytes(j)
                k += 1
            Next
        Next

        'StringOfDataBytes 32 .. 35
        For i = 0 To 3
            SingleByte = ThisParkData.ASDU(i)
            StringOfDataBytes(k) = SingleByte
            k += 1
        Next




        Dim result As String = myLib.WebConnect(StringOfDataBytes, 35)
        Me.txt_LibWebReply.Text = result




    End Sub



    Private Sub MyCircle()
        'Dim bmp As Bitmap = New Bitmap("C:\Users\Beke\Tools\LittleSun.bmp")
        Dim myGraphics As Graphics = PictureBox2.CreateGraphics
        Dim myPen = New Pen(Brushes.DarkMagenta, 1)
        Dim PrevPoint As Point
        Dim NextPoint As Point
        Dim x As Integer
        PrevPoint.X = 0
        PrevPoint.Y = 100
        For x = 0 To 400
            NextPoint.X = x
            NextPoint.Y = 100 - 100 * Math.Sin(x / 50)
            myGraphics.DrawLine(myPen, PrevPoint, NextPoint)
            PrevPoint = NextPoint
        Next

        'myGraphics.DrawImage(bmp, New Rectangle(0, 0, 100, 100), New Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel)

        myGraphics.DrawLine(myPen, 60, 180, 220, 50)
    End Sub

    Private Sub btn_Graphics_Click(sender As Object, e As EventArgs) Handles btn_Graphics.Click
        Call MyCircle()
    End Sub

    Private Sub btn_ClearGraphics_Click(sender As Object, e As EventArgs) Handles btn_ClearGraphics.Click
        PictureBox1.Invalidate()
    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        Dim current As TabPage = DirectCast(sender, TabControl).SelectedTab
        ' Validate the current page.
        ' To cancel the select, use:
        ' e.Cancel = True
        Me.lbl_ChecVisibility.Text = current.Name
        If current.Name = "TabPage3" Then
            Me.lbl_ChecVisibility.Text = "Visible"
        Else
            Me.lbl_ChecVisibility.Text = "Not Visible"
        End If
    End Sub
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.DoubleClick
        'Me.lbl_ChecVisibility.Text = "Not Visible"
    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        ' Me.lbl_ChecVisibility.Text = "Not Visible"
    End Sub
    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        ' Me.lbl_ChecVisibility.Text = "Visible"
    End Sub

    Private Sub Btn_PLC_CONNECT_Click(sender As Object, e As EventArgs) Handles Btn_PLC_CONNECT.Click
        Dim myLib As New ClassLibrary2.MyLibrary()
        Dim ReplyReceived As Boolean

        ReplyReceived = myLib.GetPLC_Data

        If ReplyReceived Then
            Btn_PLC_CONNECT.Text = "CONNECTED"
        Else
            Btn_PLC_CONNECT.Text = "OFF"
        End If
    End Sub

    Private WithEvents instance As New InstanceClass

    Private Sub HandleLogicalCondition(ByVal num1 As Integer, ByVal num2 As Integer) Handles instance.LogicalConditionMet
        MsgBox("Logical condition met: " & num1 & " > " & num2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call instance.CheckLogicalCondition(3, 2)
    End Sub

    Private Sub PrintForm()
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
        Dim pd As New PrintDocument
        AddHandler pd.PrintPage, Sub(sender As Object, e As PrintPageEventArgs)
                                     e.Graphics.DrawImage(bmp, 0, 0)
                                 End Sub
        pd.Print()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintForm()
    End Sub


End Class

Public Class InstanceClass
    Public Event LogicalConditionMet(ByVal num1 As Integer, ByVal num2 As Integer)

    Public Sub CheckLogicalCondition(num1 As Integer, num2 As Integer)
        If num1 > num2 Then
            RaiseEvent LogicalConditionMet(num1, num2)
        End If
    End Sub
End Class

Public Class MeterParms

    Public ModbusRequest As Byte()
    Public ModbusReplyLength As Integer

End Class

<Serializable>
Public Class ParkData
    Public Production(4) As Integer
    Public powerFactor(4) As Single
    Public ASDU(4) As Byte

End Class


