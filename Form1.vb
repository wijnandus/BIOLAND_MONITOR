Imports WinHttp
Imports System
Imports System.IO
Imports System.Net


Public Class Form1


    Const CrLf = Chr(13) & Chr(10)

    '---------- GENERAL -------------
    Public SiteName As String
    Public CONTROL_SCHEME As Integer
    Public CAPACITY As Integer
    Public INVERTER_COUNT As Integer
    Public ASDU As Integer
    Public PROTOCOL_IDENTIFIER As String


    '---------- HTTP Requests --------
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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load


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
    Private Sub ReadSiteConfig()

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


                End If
            End If
        Next line
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
        Dim ThisSecond As String = Mid(MySQL_timestamp, 18, 2)

        If PreviousSecond <> ThisSecond Then
            If ThisSecond = "15" Or ThisSecond = "45" Then
                GetWeatherStationData()
                GetPowerMeterData()
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
    Private Sub tmr_ReconnectClient_Tick(sender As Object, e As EventArgs) Handles tmr_ReconnectClient.Tick
        If (PowerMeter_Connected = False) And (chk_USE_POWER_METER.Checked = True) Then
            PowerMeterWatchDog += 1
            If PowerMeterWatchDog > 5 Then
                PowerMeterWatchDog = 0
                ConnectPowerMeter()
            End If
        End If
        If (WeatherStation_Connected) = False And (chk_USE_POWER_METER.Checked = True) Then
            WeatherStationWatchDog += 1
            If WeatherStationWatchDog > 5 Then
                WeatherStationWatchDog = 0
                ConnectWeatherStation()
            End If
        End If
    End Sub
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

End Class

Public Class MeterParms

    Public ModbusRequest As Byte()
    Public ModbusReplyLength As Integer

End Class


