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
        Me.lbl_WeatherStation_Connected = New System.Windows.Forms.Label()
        Me.lbl_PowerMeter_Connected = New System.Windows.Forms.Label()
        Me.txt_WebServer_ReplyText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_WebServerReplyCounter = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmr_ProcessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_UploadFailCounter = New System.Windows.Forms.Label()
        Me.lbl_CLOCK = New System.Windows.Forms.Label()
        Me.btn_SendWeatherStation_Request = New System.Windows.Forms.Button()
        Me.lbl_WeatherStation_Type = New System.Windows.Forms.Label()
        Me.lbl_Powermeter_Type = New System.Windows.Forms.Label()
        Me.lbl_Temperature = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_P_L1 = New System.Windows.Forms.Label()
        Me.lbl_P_L2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_P_L3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_WeatherStationScanErrCount = New System.Windows.Forms.Label()
        Me.lbl_WeatherStationScanOkCount = New System.Windows.Forms.Label()
        Me.lbl_PowerMeterScanErrorCount = New System.Windows.Forms.Label()
        Me.lbl_PowerMeterScanOkCount = New System.Windows.Forms.Label()
        Me.btn_ConnectWeatherStations = New System.Windows.Forms.Button()
        Me.txt_WeatherStation_IP = New System.Windows.Forms.TextBox()
        Me.tmr_TCP_Receive_TimeOutTick = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_CheckConnectionStatus = New System.Windows.Forms.Timer(Me.components)
        Me.txt_WeatherStationReply = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tmr_Check_WeatherStation_Reply = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_WeatherStation_ConnectionStatus = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_WeatherStation_Exception = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_SunShine = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_WindSpeed = New System.Windows.Forms.Label()
        Me.txt_PowerMeterReply = New System.Windows.Forms.TextBox()
        Me.lbl_PowerMeter_Exception = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_PowerMeter_ConnectionStatus = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_PowerMeter_IP = New System.Windows.Forms.TextBox()
        Me.btn_ConnectPowerMeter = New System.Windows.Forms.Button()
        Me.btn_SendPowerMeter_Request = New System.Windows.Forms.Button()
        Me.tmr_Check_PowerMeter_Reply = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_P_Tot = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_SunShine_Horizontal = New System.Windows.Forms.Label()
        Me.lbl_SunShine_Inclined = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tmr_ReconnectClient = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_Bioland_Pool_Inserted_OK_Count = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Bioland_Plants_Updated_OK_Count = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_Bioland_Plants_Updated_Err_Count = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lbl_Bioland_Pool_Inserted_Err_Count = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_x = New System.Windows.Forms.Label()
        Me.chk_USE_POWER_METER = New System.Windows.Forms.CheckBox()
        Me.chk_USE_WEATHER_STATION = New System.Windows.Forms.CheckBox()
        Me.chk_UPLOAD_TO_WEB = New System.Windows.Forms.CheckBox()
        Me.tmr_UploadWindow = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Option_Inclinded = New System.Windows.Forms.RadioButton()
        Me.OptionHorizontal = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_METER_TYPE = New System.Windows.Forms.Label()
        Me.lbl_URL = New System.Windows.Forms.Label()
        Me.lbl_PROTOCOL = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_WeatherStation_Connected
        '
        Me.lbl_WeatherStation_Connected.AutoSize = True
        Me.lbl_WeatherStation_Connected.Location = New System.Drawing.Point(639, 132)
        Me.lbl_WeatherStation_Connected.Name = "lbl_WeatherStation_Connected"
        Me.lbl_WeatherStation_Connected.Size = New System.Drawing.Size(100, 13)
        Me.lbl_WeatherStation_Connected.TabIndex = 0
        Me.lbl_WeatherStation_Connected.Text = "NOT CONNECTED"
        '
        'lbl_PowerMeter_Connected
        '
        Me.lbl_PowerMeter_Connected.AutoSize = True
        Me.lbl_PowerMeter_Connected.Location = New System.Drawing.Point(636, 286)
        Me.lbl_PowerMeter_Connected.Name = "lbl_PowerMeter_Connected"
        Me.lbl_PowerMeter_Connected.Size = New System.Drawing.Size(103, 13)
        Me.lbl_PowerMeter_Connected.TabIndex = 1
        Me.lbl_PowerMeter_Connected.Text = "NOT_CONNECTED"
        '
        'txt_WebServer_ReplyText
        '
        Me.txt_WebServer_ReplyText.Location = New System.Drawing.Point(15, 38)
        Me.txt_WebServer_ReplyText.Multiline = True
        Me.txt_WebServer_ReplyText.Name = "txt_WebServer_ReplyText"
        Me.txt_WebServer_ReplyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_WebServer_ReplyText.Size = New System.Drawing.Size(555, 82)
        Me.txt_WebServer_ReplyText.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Web Reply"
        '
        'lbl_WebServerReplyCounter
        '
        Me.lbl_WebServerReplyCounter.AutoSize = True
        Me.lbl_WebServerReplyCounter.Location = New System.Drawing.Point(68, 22)
        Me.lbl_WebServerReplyCounter.Name = "lbl_WebServerReplyCounter"
        Me.lbl_WebServerReplyCounter.Size = New System.Drawing.Size(37, 13)
        Me.lbl_WebServerReplyCounter.TabIndex = 4
        Me.lbl_WebServerReplyCounter.Text = "00000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fails:"
        '
        'tmr_ProcessTimer
        '
        Me.tmr_ProcessTimer.Enabled = True
        Me.tmr_ProcessTimer.Interval = 1000
        '
        'lbl_UploadFailCounter
        '
        Me.lbl_UploadFailCounter.AutoSize = True
        Me.lbl_UploadFailCounter.Location = New System.Drawing.Point(165, 22)
        Me.lbl_UploadFailCounter.Name = "lbl_UploadFailCounter"
        Me.lbl_UploadFailCounter.Size = New System.Drawing.Size(31, 13)
        Me.lbl_UploadFailCounter.TabIndex = 7
        Me.lbl_UploadFailCounter.Text = "0000"
        '
        'lbl_CLOCK
        '
        Me.lbl_CLOCK.AutoSize = True
        Me.lbl_CLOCK.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_CLOCK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_CLOCK.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_CLOCK.Location = New System.Drawing.Point(499, 10)
        Me.lbl_CLOCK.Name = "lbl_CLOCK"
        Me.lbl_CLOCK.Size = New System.Drawing.Size(231, 25)
        Me.lbl_CLOCK.TabIndex = 8
        Me.lbl_CLOCK.Text = "0000-00-00 00:00:00"
        '
        'btn_SendWeatherStation_Request
        '
        Me.btn_SendWeatherStation_Request.Location = New System.Drawing.Point(639, 214)
        Me.btn_SendWeatherStation_Request.Name = "btn_SendWeatherStation_Request"
        Me.btn_SendWeatherStation_Request.Size = New System.Drawing.Size(162, 23)
        Me.btn_SendWeatherStation_Request.TabIndex = 9
        Me.btn_SendWeatherStation_Request.Text = "Send Modbus Request"
        Me.btn_SendWeatherStation_Request.UseVisualStyleBackColor = True
        '
        'lbl_WeatherStation_Type
        '
        Me.lbl_WeatherStation_Type.AutoSize = True
        Me.lbl_WeatherStation_Type.Location = New System.Drawing.Point(639, 119)
        Me.lbl_WeatherStation_Type.Name = "lbl_WeatherStation_Type"
        Me.lbl_WeatherStation_Type.Size = New System.Drawing.Size(62, 13)
        Me.lbl_WeatherStation_Type.TabIndex = 10
        Me.lbl_WeatherStation_Type.Text = "VSN800-14"
        '
        'lbl_Powermeter_Type
        '
        Me.lbl_Powermeter_Type.AutoSize = True
        Me.lbl_Powermeter_Type.Location = New System.Drawing.Point(636, 273)
        Me.lbl_Powermeter_Type.Name = "lbl_Powermeter_Type"
        Me.lbl_Powermeter_Type.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Powermeter_Type.TabIndex = 11
        Me.lbl_Powermeter_Type.Text = "PAC 4200"
        '
        'lbl_Temperature
        '
        Me.lbl_Temperature.AutoSize = True
        Me.lbl_Temperature.Location = New System.Drawing.Point(79, 438)
        Me.lbl_Temperature.Name = "lbl_Temperature"
        Me.lbl_Temperature.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Temperature.TabIndex = 12
        Me.lbl_Temperature.Text = "00.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Weather Station Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(176, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "P_L1"
        '
        'lbl_P_L1
        '
        Me.lbl_P_L1.AutoSize = True
        Me.lbl_P_L1.Location = New System.Drawing.Point(176, 438)
        Me.lbl_P_L1.Name = "lbl_P_L1"
        Me.lbl_P_L1.Size = New System.Drawing.Size(32, 13)
        Me.lbl_P_L1.TabIndex = 15
        Me.lbl_P_L1.Text = "P_L1"
        '
        'lbl_P_L2
        '
        Me.lbl_P_L2.AutoSize = True
        Me.lbl_P_L2.Location = New System.Drawing.Point(231, 438)
        Me.lbl_P_L2.Name = "lbl_P_L2"
        Me.lbl_P_L2.Size = New System.Drawing.Size(32, 13)
        Me.lbl_P_L2.TabIndex = 17
        Me.lbl_P_L2.Text = "P_L2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(231, 425)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "P_L2"
        '
        'lbl_P_L3
        '
        Me.lbl_P_L3.AutoSize = True
        Me.lbl_P_L3.Location = New System.Drawing.Point(286, 438)
        Me.lbl_P_L3.Name = "lbl_P_L3"
        Me.lbl_P_L3.Size = New System.Drawing.Size(32, 13)
        Me.lbl_P_L3.TabIndex = 19
        Me.lbl_P_L3.Text = "P_L3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(286, 425)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "P_L3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 477)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "WeatherStation Scan_OK"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 490)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "WeatherStation Scan_Err"
        '
        'lbl_WeatherStationScanErrCount
        '
        Me.lbl_WeatherStationScanErrCount.AutoSize = True
        Me.lbl_WeatherStationScanErrCount.Location = New System.Drawing.Point(142, 490)
        Me.lbl_WeatherStationScanErrCount.Name = "lbl_WeatherStationScanErrCount"
        Me.lbl_WeatherStationScanErrCount.Size = New System.Drawing.Size(43, 13)
        Me.lbl_WeatherStationScanErrCount.TabIndex = 24
        Me.lbl_WeatherStationScanErrCount.Text = "000000"
        '
        'lbl_WeatherStationScanOkCount
        '
        Me.lbl_WeatherStationScanOkCount.AutoSize = True
        Me.lbl_WeatherStationScanOkCount.Location = New System.Drawing.Point(142, 477)
        Me.lbl_WeatherStationScanOkCount.Name = "lbl_WeatherStationScanOkCount"
        Me.lbl_WeatherStationScanOkCount.Size = New System.Drawing.Size(43, 13)
        Me.lbl_WeatherStationScanOkCount.TabIndex = 23
        Me.lbl_WeatherStationScanOkCount.Text = "000000"
        '
        'lbl_PowerMeterScanErrorCount
        '
        Me.lbl_PowerMeterScanErrorCount.AutoSize = True
        Me.lbl_PowerMeterScanErrorCount.Location = New System.Drawing.Point(331, 490)
        Me.lbl_PowerMeterScanErrorCount.Name = "lbl_PowerMeterScanErrorCount"
        Me.lbl_PowerMeterScanErrorCount.Size = New System.Drawing.Size(49, 13)
        Me.lbl_PowerMeterScanErrorCount.TabIndex = 26
        Me.lbl_PowerMeterScanErrorCount.Text = "0000000"
        '
        'lbl_PowerMeterScanOkCount
        '
        Me.lbl_PowerMeterScanOkCount.AutoSize = True
        Me.lbl_PowerMeterScanOkCount.Location = New System.Drawing.Point(331, 477)
        Me.lbl_PowerMeterScanOkCount.Name = "lbl_PowerMeterScanOkCount"
        Me.lbl_PowerMeterScanOkCount.Size = New System.Drawing.Size(49, 13)
        Me.lbl_PowerMeterScanOkCount.TabIndex = 25
        Me.lbl_PowerMeterScanOkCount.Text = "0000000"
        '
        'btn_ConnectWeatherStations
        '
        Me.btn_ConnectWeatherStations.Location = New System.Drawing.Point(639, 185)
        Me.btn_ConnectWeatherStations.Name = "btn_ConnectWeatherStations"
        Me.btn_ConnectWeatherStations.Size = New System.Drawing.Size(162, 23)
        Me.btn_ConnectWeatherStations.TabIndex = 29
        Me.btn_ConnectWeatherStations.Text = "Connect Weather Station"
        Me.btn_ConnectWeatherStations.UseVisualStyleBackColor = True
        '
        'txt_WeatherStation_IP
        '
        Me.txt_WeatherStation_IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_WeatherStation_IP.Location = New System.Drawing.Point(639, 150)
        Me.txt_WeatherStation_IP.Name = "txt_WeatherStation_IP"
        Me.txt_WeatherStation_IP.Size = New System.Drawing.Size(162, 29)
        Me.txt_WeatherStation_IP.TabIndex = 30
        Me.txt_WeatherStation_IP.TabStop = False
        Me.txt_WeatherStation_IP.Text = "192.168.2.133"
        Me.txt_WeatherStation_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmr_TCP_Receive_TimeOutTick
        '
        Me.tmr_TCP_Receive_TimeOutTick.Enabled = True
        '
        'tmr_CheckConnectionStatus
        '
        Me.tmr_CheckConnectionStatus.Interval = 1000
        '
        'txt_WeatherStationReply
        '
        Me.txt_WeatherStationReply.Location = New System.Drawing.Point(9, 150)
        Me.txt_WeatherStationReply.Multiline = True
        Me.txt_WeatherStationReply.Name = "txt_WeatherStationReply"
        Me.txt_WeatherStationReply.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_WeatherStationReply.Size = New System.Drawing.Size(561, 104)
        Me.txt_WeatherStationReply.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Weather Station Reply"
        '
        'tmr_Check_WeatherStation_Reply
        '
        Me.tmr_Check_WeatherStation_Reply.Enabled = True
        Me.tmr_Check_WeatherStation_Reply.Interval = 300
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(174, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Connection Status"
        '
        'lbl_WeatherStation_ConnectionStatus
        '
        Me.lbl_WeatherStation_ConnectionStatus.AutoSize = True
        Me.lbl_WeatherStation_ConnectionStatus.Location = New System.Drawing.Point(274, 134)
        Me.lbl_WeatherStation_ConnectionStatus.Name = "lbl_WeatherStation_ConnectionStatus"
        Me.lbl_WeatherStation_ConnectionStatus.Size = New System.Drawing.Size(79, 13)
        Me.lbl_WeatherStation_ConnectionStatus.TabIndex = 35
        Me.lbl_WeatherStation_ConnectionStatus.Text = "Not Connected"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(378, 134)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Reply Status"
        '
        'lbl_WeatherStation_Exception
        '
        Me.lbl_WeatherStation_Exception.AutoSize = True
        Me.lbl_WeatherStation_Exception.Location = New System.Drawing.Point(451, 134)
        Me.lbl_WeatherStation_Exception.Name = "lbl_WeatherStation_Exception"
        Me.lbl_WeatherStation_Exception.Size = New System.Drawing.Size(67, 13)
        Me.lbl_WeatherStation_Exception.TabIndex = 37
        Me.lbl_WeatherStation_Exception.Text = "Reply Status"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(75, 425)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Temp"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 425)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Sunshine"
        '
        'lbl_SunShine
        '
        Me.lbl_SunShine.AutoSize = True
        Me.lbl_SunShine.Location = New System.Drawing.Point(20, 438)
        Me.lbl_SunShine.Name = "lbl_SunShine"
        Me.lbl_SunShine.Size = New System.Drawing.Size(31, 13)
        Me.lbl_SunShine.TabIndex = 39
        Me.lbl_SunShine.Text = "1000"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(125, 426)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Wind"
        '
        'lbl_WindSpeed
        '
        Me.lbl_WindSpeed.AutoSize = True
        Me.lbl_WindSpeed.Location = New System.Drawing.Point(125, 439)
        Me.lbl_WindSpeed.Name = "lbl_WindSpeed"
        Me.lbl_WindSpeed.Size = New System.Drawing.Size(22, 13)
        Me.lbl_WindSpeed.TabIndex = 41
        Me.lbl_WindSpeed.Text = "9.9"
        '
        'txt_PowerMeterReply
        '
        Me.txt_PowerMeterReply.Location = New System.Drawing.Point(6, 296)
        Me.txt_PowerMeterReply.Multiline = True
        Me.txt_PowerMeterReply.Name = "txt_PowerMeterReply"
        Me.txt_PowerMeterReply.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_PowerMeterReply.Size = New System.Drawing.Size(561, 104)
        Me.txt_PowerMeterReply.TabIndex = 43
        '
        'lbl_PowerMeter_Exception
        '
        Me.lbl_PowerMeter_Exception.AutoSize = True
        Me.lbl_PowerMeter_Exception.Location = New System.Drawing.Point(448, 280)
        Me.lbl_PowerMeter_Exception.Name = "lbl_PowerMeter_Exception"
        Me.lbl_PowerMeter_Exception.Size = New System.Drawing.Size(67, 13)
        Me.lbl_PowerMeter_Exception.TabIndex = 48
        Me.lbl_PowerMeter_Exception.Text = "Reply Status"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(375, 280)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Reply Status"
        '
        'lbl_PowerMeter_ConnectionStatus
        '
        Me.lbl_PowerMeter_ConnectionStatus.AutoSize = True
        Me.lbl_PowerMeter_ConnectionStatus.Location = New System.Drawing.Point(271, 280)
        Me.lbl_PowerMeter_ConnectionStatus.Name = "lbl_PowerMeter_ConnectionStatus"
        Me.lbl_PowerMeter_ConnectionStatus.Size = New System.Drawing.Size(79, 13)
        Me.lbl_PowerMeter_ConnectionStatus.TabIndex = 46
        Me.lbl_PowerMeter_ConnectionStatus.Text = "Not Connected"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(171, 280)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 13)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Connection Status"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 280)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 13)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "Power Meter Reply"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(192, 412)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Power Meter Data"
        '
        'txt_PowerMeter_IP
        '
        Me.txt_PowerMeter_IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_PowerMeter_IP.Location = New System.Drawing.Point(639, 304)
        Me.txt_PowerMeter_IP.Name = "txt_PowerMeter_IP"
        Me.txt_PowerMeter_IP.Size = New System.Drawing.Size(162, 29)
        Me.txt_PowerMeter_IP.TabIndex = 50
        Me.txt_PowerMeter_IP.TabStop = False
        Me.txt_PowerMeter_IP.Text = "192.168.2.133"
        Me.txt_PowerMeter_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_ConnectPowerMeter
        '
        Me.btn_ConnectPowerMeter.Location = New System.Drawing.Point(639, 339)
        Me.btn_ConnectPowerMeter.Name = "btn_ConnectPowerMeter"
        Me.btn_ConnectPowerMeter.Size = New System.Drawing.Size(162, 23)
        Me.btn_ConnectPowerMeter.TabIndex = 52
        Me.btn_ConnectPowerMeter.Text = "Connect Power Meter"
        Me.btn_ConnectPowerMeter.UseVisualStyleBackColor = True
        '
        'btn_SendPowerMeter_Request
        '
        Me.btn_SendPowerMeter_Request.Location = New System.Drawing.Point(639, 368)
        Me.btn_SendPowerMeter_Request.Name = "btn_SendPowerMeter_Request"
        Me.btn_SendPowerMeter_Request.Size = New System.Drawing.Size(162, 23)
        Me.btn_SendPowerMeter_Request.TabIndex = 51
        Me.btn_SendPowerMeter_Request.Text = "Send Modbus Request"
        Me.btn_SendPowerMeter_Request.UseVisualStyleBackColor = True
        '
        'tmr_Check_PowerMeter_Reply
        '
        Me.tmr_Check_PowerMeter_Reply.Enabled = True
        Me.tmr_Check_PowerMeter_Reply.Interval = 300
        '
        'lbl_P_Tot
        '
        Me.lbl_P_Tot.AutoSize = True
        Me.lbl_P_Tot.Location = New System.Drawing.Point(352, 438)
        Me.lbl_P_Tot.Name = "lbl_P_Tot"
        Me.lbl_P_Tot.Size = New System.Drawing.Size(36, 13)
        Me.lbl_P_Tot.TabIndex = 55
        Me.lbl_P_Tot.Text = "P_Tot"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(352, 425)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 13)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "P_Tot"
        '
        'lbl_SunShine_Horizontal
        '
        Me.lbl_SunShine_Horizontal.AutoSize = True
        Me.lbl_SunShine_Horizontal.Location = New System.Drawing.Point(20, 451)
        Me.lbl_SunShine_Horizontal.Name = "lbl_SunShine_Horizontal"
        Me.lbl_SunShine_Horizontal.Size = New System.Drawing.Size(31, 13)
        Me.lbl_SunShine_Horizontal.TabIndex = 56
        Me.lbl_SunShine_Horizontal.Text = "1000"
        '
        'lbl_SunShine_Inclined
        '
        Me.lbl_SunShine_Inclined.AutoSize = True
        Me.lbl_SunShine_Inclined.Location = New System.Drawing.Point(20, 464)
        Me.lbl_SunShine_Inclined.Name = "lbl_SunShine_Inclined"
        Me.lbl_SunShine_Inclined.Size = New System.Drawing.Size(31, 13)
        Me.lbl_SunShine_Inclined.TabIndex = 57
        Me.lbl_SunShine_Inclined.Text = "1000"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 451)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 13)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "H:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 464)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 13)
        Me.Label23.TabIndex = 59
        Me.Label23.Text = "I:"
        '
        'tmr_ReconnectClient
        '
        Me.tmr_ReconnectClient.Enabled = True
        Me.tmr_ReconnectClient.Interval = 1000
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(736, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 21)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbl_Bioland_Pool_Inserted_OK_Count
        '
        Me.lbl_Bioland_Pool_Inserted_OK_Count.AutoSize = True
        Me.lbl_Bioland_Pool_Inserted_OK_Count.Location = New System.Drawing.Point(268, 9)
        Me.lbl_Bioland_Pool_Inserted_OK_Count.Name = "lbl_Bioland_Pool_Inserted_OK_Count"
        Me.lbl_Bioland_Pool_Inserted_OK_Count.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Bioland_Pool_Inserted_OK_Count.TabIndex = 62
        Me.lbl_Bioland_Pool_Inserted_OK_Count.Text = "0000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Inserts:"
        '
        'lbl_Bioland_Plants_Updated_OK_Count
        '
        Me.lbl_Bioland_Plants_Updated_OK_Count.AutoSize = True
        Me.lbl_Bioland_Plants_Updated_OK_Count.Location = New System.Drawing.Point(393, 7)
        Me.lbl_Bioland_Plants_Updated_OK_Count.Name = "lbl_Bioland_Plants_Updated_OK_Count"
        Me.lbl_Bioland_Plants_Updated_OK_Count.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Bioland_Plants_Updated_OK_Count.TabIndex = 64
        Me.lbl_Bioland_Plants_Updated_OK_Count.Text = "0000"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(337, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 13)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Updates:"
        '
        'lbl_Bioland_Plants_Updated_Err_Count
        '
        Me.lbl_Bioland_Plants_Updated_Err_Count.AutoSize = True
        Me.lbl_Bioland_Plants_Updated_Err_Count.Location = New System.Drawing.Point(393, 20)
        Me.lbl_Bioland_Plants_Updated_Err_Count.Name = "lbl_Bioland_Plants_Updated_Err_Count"
        Me.lbl_Bioland_Plants_Updated_Err_Count.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Bioland_Plants_Updated_Err_Count.TabIndex = 68
        Me.lbl_Bioland_Plants_Updated_Err_Count.Text = "0000"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(337, 20)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(34, 13)
        Me.Label27.TabIndex = 67
        Me.Label27.Text = "Errors"
        '
        'lbl_Bioland_Pool_Inserted_Err_Count
        '
        Me.lbl_Bioland_Pool_Inserted_Err_Count.AutoSize = True
        Me.lbl_Bioland_Pool_Inserted_Err_Count.Location = New System.Drawing.Point(268, 22)
        Me.lbl_Bioland_Pool_Inserted_Err_Count.Name = "lbl_Bioland_Pool_Inserted_Err_Count"
        Me.lbl_Bioland_Pool_Inserted_Err_Count.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Bioland_Pool_Inserted_Err_Count.TabIndex = 66
        Me.lbl_Bioland_Pool_Inserted_Err_Count.Text = "0000"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(231, 22)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 65
        Me.Label29.Text = "Errors"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 490)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "PowerMeterScan Err"
        '
        'lbl_x
        '
        Me.lbl_x.AutoSize = True
        Me.lbl_x.Location = New System.Drawing.Point(220, 477)
        Me.lbl_x.Name = "lbl_x"
        Me.lbl_x.Size = New System.Drawing.Size(107, 13)
        Me.lbl_x.TabIndex = 69
        Me.lbl_x.Text = "PowerMeterScan OK"
        '
        'chk_USE_POWER_METER
        '
        Me.chk_USE_POWER_METER.AutoSize = True
        Me.chk_USE_POWER_METER.Checked = True
        Me.chk_USE_POWER_METER.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_USE_POWER_METER.Location = New System.Drawing.Point(639, 397)
        Me.chk_USE_POWER_METER.Name = "chk_USE_POWER_METER"
        Me.chk_USE_POWER_METER.Size = New System.Drawing.Size(133, 17)
        Me.chk_USE_POWER_METER.TabIndex = 71
        Me.chk_USE_POWER_METER.Text = "USE POWER METER"
        Me.chk_USE_POWER_METER.UseVisualStyleBackColor = True
        '
        'chk_USE_WEATHER_STATION
        '
        Me.chk_USE_WEATHER_STATION.AutoSize = True
        Me.chk_USE_WEATHER_STATION.Checked = True
        Me.chk_USE_WEATHER_STATION.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_USE_WEATHER_STATION.Location = New System.Drawing.Point(639, 243)
        Me.chk_USE_WEATHER_STATION.Name = "chk_USE_WEATHER_STATION"
        Me.chk_USE_WEATHER_STATION.Size = New System.Drawing.Size(159, 17)
        Me.chk_USE_WEATHER_STATION.TabIndex = 72
        Me.chk_USE_WEATHER_STATION.Text = "USE WEATHER_STATION"
        Me.chk_USE_WEATHER_STATION.UseVisualStyleBackColor = True
        '
        'chk_UPLOAD_TO_WEB
        '
        Me.chk_UPLOAD_TO_WEB.AutoSize = True
        Me.chk_UPLOAD_TO_WEB.Checked = True
        Me.chk_UPLOAD_TO_WEB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_UPLOAD_TO_WEB.Location = New System.Drawing.Point(617, 44)
        Me.chk_UPLOAD_TO_WEB.Name = "chk_UPLOAD_TO_WEB"
        Me.chk_UPLOAD_TO_WEB.Size = New System.Drawing.Size(116, 17)
        Me.chk_UPLOAD_TO_WEB.TabIndex = 73
        Me.chk_UPLOAD_TO_WEB.Text = "UPLOAD TO WEB"
        Me.chk_UPLOAD_TO_WEB.UseVisualStyleBackColor = True
        '
        'tmr_UploadWindow
        '
        Me.tmr_UploadWindow.Interval = 5000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Option_Inclinded)
        Me.GroupBox1.Controls.Add(Me.OptionHorizontal)
        Me.GroupBox1.Location = New System.Drawing.Point(576, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(57, 71)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solar"
        '
        'Option_Inclinded
        '
        Me.Option_Inclinded.AutoSize = True
        Me.Option_Inclinded.Checked = True
        Me.Option_Inclinded.Location = New System.Drawing.Point(18, 43)
        Me.Option_Inclinded.Name = "Option_Inclinded"
        Me.Option_Inclinded.Size = New System.Drawing.Size(45, 17)
        Me.Option_Inclinded.TabIndex = 1
        Me.Option_Inclinded.TabStop = True
        Me.Option_Inclinded.Text = "Incl."
        Me.Option_Inclinded.UseVisualStyleBackColor = True
        '
        'OptionHorizontal
        '
        Me.OptionHorizontal.AutoSize = True
        Me.OptionHorizontal.Location = New System.Drawing.Point(18, 20)
        Me.OptionHorizontal.Name = "OptionHorizontal"
        Me.OptionHorizontal.Size = New System.Drawing.Size(45, 17)
        Me.OptionHorizontal.TabIndex = 0
        Me.OptionHorizontal.Text = "Hor."
        Me.OptionHorizontal.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(650, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 25)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_METER_TYPE
        '
        Me.lbl_METER_TYPE.AutoSize = True
        Me.lbl_METER_TYPE.Location = New System.Drawing.Point(223, 461)
        Me.lbl_METER_TYPE.Name = "lbl_METER_TYPE"
        Me.lbl_METER_TYPE.Size = New System.Drawing.Size(76, 13)
        Me.lbl_METER_TYPE.TabIndex = 76
        Me.lbl_METER_TYPE.Text = "METER TYPE"
        '
        'lbl_URL
        '
        Me.lbl_URL.AutoSize = True
        Me.lbl_URL.Location = New System.Drawing.Point(12, 526)
        Me.lbl_URL.Name = "lbl_URL"
        Me.lbl_URL.Size = New System.Drawing.Size(45, 13)
        Me.lbl_URL.TabIndex = 77
        Me.lbl_URL.Text = "Label24"
        '
        'lbl_PROTOCOL
        '
        Me.lbl_PROTOCOL.AutoSize = True
        Me.lbl_PROTOCOL.Location = New System.Drawing.Point(739, 45)
        Me.lbl_PROTOCOL.Name = "lbl_PROTOCOL"
        Me.lbl_PROTOCOL.Size = New System.Drawing.Size(66, 13)
        Me.lbl_PROTOCOL.TabIndex = 78
        Me.lbl_PROTOCOL.Text = "PROTOCOL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 683)
        Me.Controls.Add(Me.lbl_PROTOCOL)
        Me.Controls.Add(Me.lbl_URL)
        Me.Controls.Add(Me.lbl_METER_TYPE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chk_UPLOAD_TO_WEB)
        Me.Controls.Add(Me.chk_USE_WEATHER_STATION)
        Me.Controls.Add(Me.chk_USE_POWER_METER)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_x)
        Me.Controls.Add(Me.lbl_Bioland_Plants_Updated_Err_Count)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.lbl_Bioland_Pool_Inserted_Err_Count)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.lbl_Bioland_Plants_Updated_OK_Count)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lbl_Bioland_Pool_Inserted_OK_Count)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lbl_SunShine_Inclined)
        Me.Controls.Add(Me.lbl_SunShine_Horizontal)
        Me.Controls.Add(Me.lbl_P_Tot)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btn_ConnectPowerMeter)
        Me.Controls.Add(Me.btn_SendPowerMeter_Request)
        Me.Controls.Add(Me.txt_PowerMeter_IP)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbl_PowerMeter_Exception)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lbl_PowerMeter_ConnectionStatus)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txt_PowerMeterReply)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lbl_WindSpeed)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbl_SunShine)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbl_WeatherStation_Exception)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_WeatherStation_ConnectionStatus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_WeatherStationReply)
        Me.Controls.Add(Me.txt_WeatherStation_IP)
        Me.Controls.Add(Me.btn_ConnectWeatherStations)
        Me.Controls.Add(Me.lbl_PowerMeterScanErrorCount)
        Me.Controls.Add(Me.lbl_PowerMeterScanOkCount)
        Me.Controls.Add(Me.lbl_WeatherStationScanErrCount)
        Me.Controls.Add(Me.lbl_WeatherStationScanOkCount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_P_L3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_P_L2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_P_L1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Temperature)
        Me.Controls.Add(Me.lbl_Powermeter_Type)
        Me.Controls.Add(Me.lbl_WeatherStation_Type)
        Me.Controls.Add(Me.btn_SendWeatherStation_Request)
        Me.Controls.Add(Me.lbl_CLOCK)
        Me.Controls.Add(Me.lbl_UploadFailCounter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_WebServerReplyCounter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_WebServer_ReplyText)
        Me.Controls.Add(Me.lbl_PowerMeter_Connected)
        Me.Controls.Add(Me.lbl_WeatherStation_Connected)
        Me.Name = "Form1"
        Me.Text = "BIOLAND SCANNER BekeTools 05 Jan 2023"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_WeatherStation_Connected As Label
    Friend WithEvents lbl_PowerMeter_Connected As Label
    Friend WithEvents txt_WebServer_ReplyText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_WebServerReplyCounter As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tmr_ProcessTimer As Timer
    Friend WithEvents lbl_UploadFailCounter As Label
    Friend WithEvents lbl_CLOCK As Label
    Friend WithEvents btn_SendWeatherStation_Request As Button
    Friend WithEvents lbl_WeatherStation_Type As Label
    Friend WithEvents lbl_Powermeter_Type As Label
    Friend WithEvents lbl_Temperature As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_P_L1 As Label
    Friend WithEvents lbl_P_L2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_P_L3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_WeatherStationScanErrCount As Label
    Friend WithEvents lbl_WeatherStationScanOkCount As Label
    Friend WithEvents lbl_PowerMeterScanErrorCount As Label
    Friend WithEvents lbl_PowerMeterScanOkCount As Label
    Friend WithEvents btn_ConnectWeatherStations As Button
    Friend WithEvents txt_WeatherStation_IP As TextBox
    Friend WithEvents tmr_TCP_Receive_TimeOutTick As Timer
    Friend WithEvents tmr_CheckConnectionStatus As Timer
    Friend WithEvents txt_WeatherStationReply As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tmr_Check_WeatherStation_Reply As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_WeatherStation_ConnectionStatus As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_WeatherStation_Exception As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_SunShine As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_WindSpeed As Label
    Friend WithEvents txt_PowerMeterReply As TextBox
    Friend WithEvents lbl_PowerMeter_Exception As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_PowerMeter_ConnectionStatus As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_PowerMeter_IP As TextBox
    Friend WithEvents btn_ConnectPowerMeter As Button
    Friend WithEvents btn_SendPowerMeter_Request As Button
    Friend WithEvents tmr_Check_PowerMeter_Reply As Timer
    Friend WithEvents lbl_P_Tot As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbl_SunShine_Horizontal As Label
    Friend WithEvents lbl_SunShine_Inclined As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents tmr_ReconnectClient As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_Bioland_Pool_Inserted_OK_Count As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_Bioland_Plants_Updated_OK_Count As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_Bioland_Plants_Updated_Err_Count As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lbl_Bioland_Pool_Inserted_Err_Count As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_x As Label
    Friend WithEvents chk_USE_POWER_METER As CheckBox
    Friend WithEvents chk_USE_WEATHER_STATION As CheckBox
    Friend WithEvents chk_UPLOAD_TO_WEB As CheckBox
    Friend WithEvents tmr_UploadWindow As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Option_Inclinded As RadioButton
    Friend WithEvents OptionHorizontal As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_METER_TYPE As Label
    Friend WithEvents lbl_URL As Label
    Friend WithEvents lbl_PROTOCOL As Label
End Class
