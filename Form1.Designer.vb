<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.cmd_LibTest = New System.Windows.Forms.Button()
        Me.lbl_LibTest = New System.Windows.Forms.Label()
        Me.btn_WebTest = New System.Windows.Forms.Button()
        Me.txt_LibWebReply = New System.Windows.Forms.TextBox()
        Me.txt_FieldImageReply = New System.Windows.Forms.TextBox()
        Me.tmr_Check_FieldImage_Reply = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_FieldImage_ConnectionStatus = New System.Windows.Forms.Label()
        Me.lbl_FieldImage_Connected = New System.Windows.Forms.Label()
        Me.btn_SendFieldImage_Request = New System.Windows.Forms.Button()
        Me.lbl_PLC_TYPE = New System.Windows.Forms.Label()
        Me.lbl_FieldImage_Exception = New System.Windows.Forms.Label()
        Me.lbl_FieldImageScanErrCount = New System.Windows.Forms.Label()
        Me.lbl_FieldImageScanOkCount = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_FieldImage_IP = New System.Windows.Forms.TextBox()
        Me.chk_USE_FIELD_IMAGE = New System.Windows.Forms.CheckBox()
        Me.btn_ConnectFieldImage = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_WeatherStationWatchDog = New System.Windows.Forms.Label()
        Me.lbl_PowerMeterWatchDog = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_WebReply = New System.Windows.Forms.TextBox()
        Me.lbl_FieldImageWatchDog = New System.Windows.Forms.Label()
        Me.lbl_Clock2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lbl_MaxAllowed = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lbl_Availability = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lbl_PlantCapacity = New System.Windows.Forms.Label()
        Me.Group_ACB = New System.Windows.Forms.GroupBox()
        Me.lbl_RemoteLocal = New System.Windows.Forms.Label()
        Me.lbl_ACB_Status = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Group_WEATHER = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbl_SOLAR = New System.Windows.Forms.Label()
        Me.lbl_Speed = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lbl_Ambient = New System.Windows.Forms.Label()
        Me.Group_P855 = New System.Windows.Forms.GroupBox()
        Me.Group_RTU_Connection = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_ClearGraphics = New System.Windows.Forms.Button()
        Me.btn_Graphics = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Group_PRODMAN = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lbl_Fix_kVAr = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.lbl_Curtail_kW = New System.Windows.Forms.Label()
        Me.Group_ExportPower = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lbl_kV = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lbl_PF = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_kVAr = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lbl_ExportPower = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_000_ON = New System.Windows.Forms.Button()
        Me.btn_030_ON = New System.Windows.Forms.Button()
        Me.btn_060_ON = New System.Windows.Forms.Button()
        Me.btn_100_ON = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ACB_STATUS_IMAGES = New System.Windows.Forms.ImageList(Me.components)
        Me.lbl_REAL_04 = New System.Windows.Forms.Label()
        Me.lbl_ChecVisibility = New System.Windows.Forms.Label()
        Me.Btn_PLC_CONNECT = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.InverterControl3 = New BIOLAND.InverterControl()
        Me.InverterControl10 = New BIOLAND.InverterControl()
        Me.InverterControl1 = New BIOLAND.InverterControl()
        Me.InverterControl9 = New BIOLAND.InverterControl()
        Me.InverterControl2 = New BIOLAND.InverterControl()
        Me.InverterControl8 = New BIOLAND.InverterControl()
        Me.InverterControl4 = New BIOLAND.InverterControl()
        Me.InverterControl7 = New BIOLAND.InverterControl()
        Me.InverterControl5 = New BIOLAND.InverterControl()
        Me.InverterControl6 = New BIOLAND.InverterControl()
        Me.DigitalInputs_161 = New BIOLAND.DigitalInputs_16()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Group_ACB.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_WEATHER.SuspendLayout()
        Me.Group_RTU_Connection.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Group_ExportPower.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_WeatherStation_Connected
        '
        Me.lbl_WeatherStation_Connected.AutoSize = True
        Me.lbl_WeatherStation_Connected.Location = New System.Drawing.Point(583, 137)
        Me.lbl_WeatherStation_Connected.Name = "lbl_WeatherStation_Connected"
        Me.lbl_WeatherStation_Connected.Size = New System.Drawing.Size(100, 13)
        Me.lbl_WeatherStation_Connected.TabIndex = 0
        Me.lbl_WeatherStation_Connected.Text = "NOT CONNECTED"
        '
        'lbl_PowerMeter_Connected
        '
        Me.lbl_PowerMeter_Connected.AutoSize = True
        Me.lbl_PowerMeter_Connected.Location = New System.Drawing.Point(593, 305)
        Me.lbl_PowerMeter_Connected.Name = "lbl_PowerMeter_Connected"
        Me.lbl_PowerMeter_Connected.Size = New System.Drawing.Size(103, 13)
        Me.lbl_PowerMeter_Connected.TabIndex = 1
        Me.lbl_PowerMeter_Connected.Text = "NOT_CONNECTED"
        '
        'txt_WebServer_ReplyText
        '
        Me.txt_WebServer_ReplyText.Location = New System.Drawing.Point(11, 43)
        Me.txt_WebServer_ReplyText.Multiline = True
        Me.txt_WebServer_ReplyText.Name = "txt_WebServer_ReplyText"
        Me.txt_WebServer_ReplyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_WebServer_ReplyText.Size = New System.Drawing.Size(555, 82)
        Me.txt_WebServer_ReplyText.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Web Reply"
        '
        'lbl_WebServerReplyCounter
        '
        Me.lbl_WebServerReplyCounter.AutoSize = True
        Me.lbl_WebServerReplyCounter.Location = New System.Drawing.Point(75, 27)
        Me.lbl_WebServerReplyCounter.Name = "lbl_WebServerReplyCounter"
        Me.lbl_WebServerReplyCounter.Size = New System.Drawing.Size(37, 13)
        Me.lbl_WebServerReplyCounter.TabIndex = 4
        Me.lbl_WebServerReplyCounter.Text = "00000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 27)
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
        Me.lbl_UploadFailCounter.Location = New System.Drawing.Point(172, 27)
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
        Me.lbl_CLOCK.Location = New System.Drawing.Point(854, 25)
        Me.lbl_CLOCK.Name = "lbl_CLOCK"
        Me.lbl_CLOCK.Size = New System.Drawing.Size(231, 25)
        Me.lbl_CLOCK.TabIndex = 8
        Me.lbl_CLOCK.Text = "0000-00-00 00:00:00"
        '
        'btn_SendWeatherStation_Request
        '
        Me.btn_SendWeatherStation_Request.Location = New System.Drawing.Point(583, 219)
        Me.btn_SendWeatherStation_Request.Name = "btn_SendWeatherStation_Request"
        Me.btn_SendWeatherStation_Request.Size = New System.Drawing.Size(162, 23)
        Me.btn_SendWeatherStation_Request.TabIndex = 9
        Me.btn_SendWeatherStation_Request.Text = "Send Modbus Request"
        Me.btn_SendWeatherStation_Request.UseVisualStyleBackColor = True
        '
        'lbl_WeatherStation_Type
        '
        Me.lbl_WeatherStation_Type.AutoSize = True
        Me.lbl_WeatherStation_Type.Location = New System.Drawing.Point(583, 124)
        Me.lbl_WeatherStation_Type.Name = "lbl_WeatherStation_Type"
        Me.lbl_WeatherStation_Type.Size = New System.Drawing.Size(62, 13)
        Me.lbl_WeatherStation_Type.TabIndex = 10
        Me.lbl_WeatherStation_Type.Text = "VSN800-14"
        '
        'lbl_Powermeter_Type
        '
        Me.lbl_Powermeter_Type.AutoSize = True
        Me.lbl_Powermeter_Type.Location = New System.Drawing.Point(593, 292)
        Me.lbl_Powermeter_Type.Name = "lbl_Powermeter_Type"
        Me.lbl_Powermeter_Type.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Powermeter_Type.TabIndex = 11
        Me.lbl_Powermeter_Type.Text = "PAC 4200"
        '
        'lbl_Temperature
        '
        Me.lbl_Temperature.AutoSize = True
        Me.lbl_Temperature.Location = New System.Drawing.Point(114, 466)
        Me.lbl_Temperature.Name = "lbl_Temperature"
        Me.lbl_Temperature.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Temperature.TabIndex = 12
        Me.lbl_Temperature.Text = "00.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Weather Station Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 453)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "P_L1"
        '
        'lbl_P_L1
        '
        Me.lbl_P_L1.AutoSize = True
        Me.lbl_P_L1.Location = New System.Drawing.Point(211, 466)
        Me.lbl_P_L1.Name = "lbl_P_L1"
        Me.lbl_P_L1.Size = New System.Drawing.Size(32, 13)
        Me.lbl_P_L1.TabIndex = 15
        Me.lbl_P_L1.Text = "P_L1"
        '
        'lbl_P_L2
        '
        Me.lbl_P_L2.AutoSize = True
        Me.lbl_P_L2.Location = New System.Drawing.Point(266, 466)
        Me.lbl_P_L2.Name = "lbl_P_L2"
        Me.lbl_P_L2.Size = New System.Drawing.Size(32, 13)
        Me.lbl_P_L2.TabIndex = 17
        Me.lbl_P_L2.Text = "P_L2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(266, 453)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "P_L2"
        '
        'lbl_P_L3
        '
        Me.lbl_P_L3.AutoSize = True
        Me.lbl_P_L3.Location = New System.Drawing.Point(321, 466)
        Me.lbl_P_L3.Name = "lbl_P_L3"
        Me.lbl_P_L3.Size = New System.Drawing.Size(32, 13)
        Me.lbl_P_L3.TabIndex = 19
        Me.lbl_P_L3.Text = "P_L3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(321, 453)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "P_L3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 505)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "WeatherStation Scan_OK"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 518)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "WeatherStation Scan_Err"
        '
        'lbl_WeatherStationScanErrCount
        '
        Me.lbl_WeatherStationScanErrCount.AutoSize = True
        Me.lbl_WeatherStationScanErrCount.Location = New System.Drawing.Point(177, 518)
        Me.lbl_WeatherStationScanErrCount.Name = "lbl_WeatherStationScanErrCount"
        Me.lbl_WeatherStationScanErrCount.Size = New System.Drawing.Size(43, 13)
        Me.lbl_WeatherStationScanErrCount.TabIndex = 24
        Me.lbl_WeatherStationScanErrCount.Text = "000000"
        '
        'lbl_WeatherStationScanOkCount
        '
        Me.lbl_WeatherStationScanOkCount.AutoSize = True
        Me.lbl_WeatherStationScanOkCount.Location = New System.Drawing.Point(177, 505)
        Me.lbl_WeatherStationScanOkCount.Name = "lbl_WeatherStationScanOkCount"
        Me.lbl_WeatherStationScanOkCount.Size = New System.Drawing.Size(43, 13)
        Me.lbl_WeatherStationScanOkCount.TabIndex = 23
        Me.lbl_WeatherStationScanOkCount.Text = "000000"
        '
        'lbl_PowerMeterScanErrorCount
        '
        Me.lbl_PowerMeterScanErrorCount.AutoSize = True
        Me.lbl_PowerMeterScanErrorCount.Location = New System.Drawing.Point(366, 518)
        Me.lbl_PowerMeterScanErrorCount.Name = "lbl_PowerMeterScanErrorCount"
        Me.lbl_PowerMeterScanErrorCount.Size = New System.Drawing.Size(49, 13)
        Me.lbl_PowerMeterScanErrorCount.TabIndex = 26
        Me.lbl_PowerMeterScanErrorCount.Text = "0000000"
        '
        'lbl_PowerMeterScanOkCount
        '
        Me.lbl_PowerMeterScanOkCount.AutoSize = True
        Me.lbl_PowerMeterScanOkCount.Location = New System.Drawing.Point(366, 505)
        Me.lbl_PowerMeterScanOkCount.Name = "lbl_PowerMeterScanOkCount"
        Me.lbl_PowerMeterScanOkCount.Size = New System.Drawing.Size(49, 13)
        Me.lbl_PowerMeterScanOkCount.TabIndex = 25
        Me.lbl_PowerMeterScanOkCount.Text = "0000000"
        '
        'btn_ConnectWeatherStations
        '
        Me.btn_ConnectWeatherStations.Location = New System.Drawing.Point(583, 190)
        Me.btn_ConnectWeatherStations.Name = "btn_ConnectWeatherStations"
        Me.btn_ConnectWeatherStations.Size = New System.Drawing.Size(162, 23)
        Me.btn_ConnectWeatherStations.TabIndex = 29
        Me.btn_ConnectWeatherStations.Text = "Connect Weather Station"
        Me.btn_ConnectWeatherStations.UseVisualStyleBackColor = True
        '
        'txt_WeatherStation_IP
        '
        Me.txt_WeatherStation_IP.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_WeatherStation_IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_WeatherStation_IP.ForeColor = System.Drawing.Color.Black
        Me.txt_WeatherStation_IP.Location = New System.Drawing.Point(583, 155)
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
        Me.txt_WeatherStationReply.Location = New System.Drawing.Point(11, 155)
        Me.txt_WeatherStationReply.Multiline = True
        Me.txt_WeatherStationReply.Name = "txt_WeatherStationReply"
        Me.txt_WeatherStationReply.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_WeatherStationReply.Size = New System.Drawing.Size(555, 104)
        Me.txt_WeatherStationReply.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 139)
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
        Me.Label12.Location = New System.Drawing.Point(181, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Connection Status"
        '
        'lbl_WeatherStation_ConnectionStatus
        '
        Me.lbl_WeatherStation_ConnectionStatus.AutoSize = True
        Me.lbl_WeatherStation_ConnectionStatus.Location = New System.Drawing.Point(281, 139)
        Me.lbl_WeatherStation_ConnectionStatus.Name = "lbl_WeatherStation_ConnectionStatus"
        Me.lbl_WeatherStation_ConnectionStatus.Size = New System.Drawing.Size(79, 13)
        Me.lbl_WeatherStation_ConnectionStatus.TabIndex = 35
        Me.lbl_WeatherStation_ConnectionStatus.Text = "Not Connected"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(385, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Reply Status"
        '
        'lbl_WeatherStation_Exception
        '
        Me.lbl_WeatherStation_Exception.AutoSize = True
        Me.lbl_WeatherStation_Exception.Location = New System.Drawing.Point(458, 139)
        Me.lbl_WeatherStation_Exception.Name = "lbl_WeatherStation_Exception"
        Me.lbl_WeatherStation_Exception.Size = New System.Drawing.Size(67, 13)
        Me.lbl_WeatherStation_Exception.TabIndex = 37
        Me.lbl_WeatherStation_Exception.Text = "Reply Status"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(110, 453)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Temp"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(47, 453)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Sunshine"
        '
        'lbl_SunShine
        '
        Me.lbl_SunShine.AutoSize = True
        Me.lbl_SunShine.Location = New System.Drawing.Point(55, 466)
        Me.lbl_SunShine.Name = "lbl_SunShine"
        Me.lbl_SunShine.Size = New System.Drawing.Size(31, 13)
        Me.lbl_SunShine.TabIndex = 39
        Me.lbl_SunShine.Text = "1000"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(160, 454)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Wind"
        '
        'lbl_WindSpeed
        '
        Me.lbl_WindSpeed.AutoSize = True
        Me.lbl_WindSpeed.Location = New System.Drawing.Point(160, 467)
        Me.lbl_WindSpeed.Name = "lbl_WindSpeed"
        Me.lbl_WindSpeed.Size = New System.Drawing.Size(22, 13)
        Me.lbl_WindSpeed.TabIndex = 41
        Me.lbl_WindSpeed.Text = "9.9"
        '
        'txt_PowerMeterReply
        '
        Me.txt_PowerMeterReply.Location = New System.Drawing.Point(11, 301)
        Me.txt_PowerMeterReply.Multiline = True
        Me.txt_PowerMeterReply.Name = "txt_PowerMeterReply"
        Me.txt_PowerMeterReply.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_PowerMeterReply.Size = New System.Drawing.Size(555, 104)
        Me.txt_PowerMeterReply.TabIndex = 43
        '
        'lbl_PowerMeter_Exception
        '
        Me.lbl_PowerMeter_Exception.AutoSize = True
        Me.lbl_PowerMeter_Exception.Location = New System.Drawing.Point(455, 285)
        Me.lbl_PowerMeter_Exception.Name = "lbl_PowerMeter_Exception"
        Me.lbl_PowerMeter_Exception.Size = New System.Drawing.Size(67, 13)
        Me.lbl_PowerMeter_Exception.TabIndex = 48
        Me.lbl_PowerMeter_Exception.Text = "Reply Status"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(382, 285)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Reply Status"
        '
        'lbl_PowerMeter_ConnectionStatus
        '
        Me.lbl_PowerMeter_ConnectionStatus.AutoSize = True
        Me.lbl_PowerMeter_ConnectionStatus.Location = New System.Drawing.Point(278, 285)
        Me.lbl_PowerMeter_ConnectionStatus.Name = "lbl_PowerMeter_ConnectionStatus"
        Me.lbl_PowerMeter_ConnectionStatus.Size = New System.Drawing.Size(79, 13)
        Me.lbl_PowerMeter_ConnectionStatus.TabIndex = 46
        Me.lbl_PowerMeter_ConnectionStatus.Text = "Not Connected"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(178, 285)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 13)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Connection Status"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 285)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 13)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "Power Meter Reply"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(227, 440)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Power Meter Data"
        '
        'txt_PowerMeter_IP
        '
        Me.txt_PowerMeter_IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_PowerMeter_IP.Location = New System.Drawing.Point(583, 321)
        Me.txt_PowerMeter_IP.Name = "txt_PowerMeter_IP"
        Me.txt_PowerMeter_IP.Size = New System.Drawing.Size(162, 29)
        Me.txt_PowerMeter_IP.TabIndex = 50
        Me.txt_PowerMeter_IP.TabStop = False
        Me.txt_PowerMeter_IP.Text = "192.168.2.133"
        Me.txt_PowerMeter_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_ConnectPowerMeter
        '
        Me.btn_ConnectPowerMeter.Location = New System.Drawing.Point(583, 356)
        Me.btn_ConnectPowerMeter.Name = "btn_ConnectPowerMeter"
        Me.btn_ConnectPowerMeter.Size = New System.Drawing.Size(162, 23)
        Me.btn_ConnectPowerMeter.TabIndex = 52
        Me.btn_ConnectPowerMeter.Text = "Connect Power Meter"
        Me.btn_ConnectPowerMeter.UseVisualStyleBackColor = True
        '
        'btn_SendPowerMeter_Request
        '
        Me.btn_SendPowerMeter_Request.Location = New System.Drawing.Point(583, 384)
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
        Me.lbl_P_Tot.Location = New System.Drawing.Point(387, 466)
        Me.lbl_P_Tot.Name = "lbl_P_Tot"
        Me.lbl_P_Tot.Size = New System.Drawing.Size(36, 13)
        Me.lbl_P_Tot.TabIndex = 55
        Me.lbl_P_Tot.Text = "P_Tot"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(387, 453)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 13)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "P_Tot"
        '
        'lbl_SunShine_Horizontal
        '
        Me.lbl_SunShine_Horizontal.AutoSize = True
        Me.lbl_SunShine_Horizontal.Location = New System.Drawing.Point(55, 479)
        Me.lbl_SunShine_Horizontal.Name = "lbl_SunShine_Horizontal"
        Me.lbl_SunShine_Horizontal.Size = New System.Drawing.Size(31, 13)
        Me.lbl_SunShine_Horizontal.TabIndex = 56
        Me.lbl_SunShine_Horizontal.Text = "1000"
        '
        'lbl_SunShine_Inclined
        '
        Me.lbl_SunShine_Inclined.AutoSize = True
        Me.lbl_SunShine_Inclined.Location = New System.Drawing.Point(55, 492)
        Me.lbl_SunShine_Inclined.Name = "lbl_SunShine_Inclined"
        Me.lbl_SunShine_Inclined.Size = New System.Drawing.Size(31, 13)
        Me.lbl_SunShine_Inclined.TabIndex = 57
        Me.lbl_SunShine_Inclined.Text = "1000"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(41, 479)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 13)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "H:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(41, 492)
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
        Me.Button2.Location = New System.Drawing.Point(711, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 21)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbl_Bioland_Pool_Inserted_OK_Count
        '
        Me.lbl_Bioland_Pool_Inserted_OK_Count.AutoSize = True
        Me.lbl_Bioland_Pool_Inserted_OK_Count.Location = New System.Drawing.Point(275, 13)
        Me.lbl_Bioland_Pool_Inserted_OK_Count.Name = "lbl_Bioland_Pool_Inserted_OK_Count"
        Me.lbl_Bioland_Pool_Inserted_OK_Count.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Bioland_Pool_Inserted_OK_Count.TabIndex = 62
        Me.lbl_Bioland_Pool_Inserted_OK_Count.Text = "0000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Inserts:"
        '
        'lbl_Bioland_Plants_Updated_OK_Count
        '
        Me.lbl_Bioland_Plants_Updated_OK_Count.AutoSize = True
        Me.lbl_Bioland_Plants_Updated_OK_Count.Location = New System.Drawing.Point(398, 13)
        Me.lbl_Bioland_Plants_Updated_OK_Count.Name = "lbl_Bioland_Plants_Updated_OK_Count"
        Me.lbl_Bioland_Plants_Updated_OK_Count.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Bioland_Plants_Updated_OK_Count.TabIndex = 64
        Me.lbl_Bioland_Plants_Updated_OK_Count.Text = "0000"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(343, 13)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 13)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Updates:"
        '
        'lbl_Bioland_Plants_Updated_Err_Count
        '
        Me.lbl_Bioland_Plants_Updated_Err_Count.AutoSize = True
        Me.lbl_Bioland_Plants_Updated_Err_Count.Location = New System.Drawing.Point(400, 27)
        Me.lbl_Bioland_Plants_Updated_Err_Count.Name = "lbl_Bioland_Plants_Updated_Err_Count"
        Me.lbl_Bioland_Plants_Updated_Err_Count.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Bioland_Plants_Updated_Err_Count.TabIndex = 68
        Me.lbl_Bioland_Plants_Updated_Err_Count.Text = "0000"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(344, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(34, 13)
        Me.Label27.TabIndex = 67
        Me.Label27.Text = "Errors"
        '
        'lbl_Bioland_Pool_Inserted_Err_Count
        '
        Me.lbl_Bioland_Pool_Inserted_Err_Count.AutoSize = True
        Me.lbl_Bioland_Pool_Inserted_Err_Count.Location = New System.Drawing.Point(275, 27)
        Me.lbl_Bioland_Pool_Inserted_Err_Count.Name = "lbl_Bioland_Pool_Inserted_Err_Count"
        Me.lbl_Bioland_Pool_Inserted_Err_Count.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Bioland_Pool_Inserted_Err_Count.TabIndex = 66
        Me.lbl_Bioland_Pool_Inserted_Err_Count.Text = "0000"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(238, 27)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 65
        Me.Label29.Text = "Errors"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "PowerMeterScan Err"
        '
        'lbl_x
        '
        Me.lbl_x.AutoSize = True
        Me.lbl_x.Location = New System.Drawing.Point(255, 505)
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
        Me.chk_USE_POWER_METER.Location = New System.Drawing.Point(586, 413)
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
        Me.chk_USE_WEATHER_STATION.Location = New System.Drawing.Point(583, 248)
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
        Me.chk_UPLOAD_TO_WEB.Location = New System.Drawing.Point(583, 82)
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
        Me.GroupBox1.Location = New System.Drawing.Point(751, 171)
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
        Me.Button1.Location = New System.Drawing.Point(656, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 25)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_METER_TYPE
        '
        Me.lbl_METER_TYPE.AutoSize = True
        Me.lbl_METER_TYPE.Location = New System.Drawing.Point(258, 489)
        Me.lbl_METER_TYPE.Name = "lbl_METER_TYPE"
        Me.lbl_METER_TYPE.Size = New System.Drawing.Size(76, 13)
        Me.lbl_METER_TYPE.TabIndex = 76
        Me.lbl_METER_TYPE.Text = "METER TYPE"
        '
        'lbl_URL
        '
        Me.lbl_URL.AutoSize = True
        Me.lbl_URL.Location = New System.Drawing.Point(44, 533)
        Me.lbl_URL.Name = "lbl_URL"
        Me.lbl_URL.Size = New System.Drawing.Size(45, 13)
        Me.lbl_URL.TabIndex = 77
        Me.lbl_URL.Text = "Label24"
        '
        'lbl_PROTOCOL
        '
        Me.lbl_PROTOCOL.AutoSize = True
        Me.lbl_PROTOCOL.Location = New System.Drawing.Point(583, 66)
        Me.lbl_PROTOCOL.Name = "lbl_PROTOCOL"
        Me.lbl_PROTOCOL.Size = New System.Drawing.Size(66, 13)
        Me.lbl_PROTOCOL.TabIndex = 78
        Me.lbl_PROTOCOL.Text = "PROTOCOL"
        '
        'cmd_LibTest
        '
        Me.cmd_LibTest.Location = New System.Drawing.Point(656, 450)
        Me.cmd_LibTest.Name = "cmd_LibTest"
        Me.cmd_LibTest.Size = New System.Drawing.Size(89, 20)
        Me.cmd_LibTest.TabIndex = 79
        Me.cmd_LibTest.Text = "LibTest"
        Me.cmd_LibTest.UseVisualStyleBackColor = True
        '
        'lbl_LibTest
        '
        Me.lbl_LibTest.AutoSize = True
        Me.lbl_LibTest.Location = New System.Drawing.Point(561, 454)
        Me.lbl_LibTest.Name = "lbl_LibTest"
        Me.lbl_LibTest.Size = New System.Drawing.Size(75, 13)
        Me.lbl_LibTest.TabIndex = 80
        Me.lbl_LibTest.Text = "LibTest Result"
        '
        'btn_WebTest
        '
        Me.btn_WebTest.Location = New System.Drawing.Point(564, 475)
        Me.btn_WebTest.Name = "btn_WebTest"
        Me.btn_WebTest.Size = New System.Drawing.Size(84, 20)
        Me.btn_WebTest.TabIndex = 81
        Me.btn_WebTest.Text = "WebTest"
        Me.btn_WebTest.UseVisualStyleBackColor = True
        '
        'txt_LibWebReply
        '
        Me.txt_LibWebReply.Location = New System.Drawing.Point(564, 502)
        Me.txt_LibWebReply.Multiline = True
        Me.txt_LibWebReply.Name = "txt_LibWebReply"
        Me.txt_LibWebReply.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_LibWebReply.Size = New System.Drawing.Size(204, 61)
        Me.txt_LibWebReply.TabIndex = 82
        Me.txt_LibWebReply.Text = "LibWebReply"
        '
        'txt_FieldImageReply
        '
        Me.txt_FieldImageReply.Location = New System.Drawing.Point(20, 29)
        Me.txt_FieldImageReply.Multiline = True
        Me.txt_FieldImageReply.Name = "txt_FieldImageReply"
        Me.txt_FieldImageReply.Size = New System.Drawing.Size(645, 105)
        Me.txt_FieldImageReply.TabIndex = 83
        Me.txt_FieldImageReply.Text = " txt_FieldImageReply"
        '
        'tmr_Check_FieldImage_Reply
        '
        '
        'lbl_FieldImage_ConnectionStatus
        '
        Me.lbl_FieldImage_ConnectionStatus.AutoSize = True
        Me.lbl_FieldImage_ConnectionStatus.Location = New System.Drawing.Point(398, 10)
        Me.lbl_FieldImage_ConnectionStatus.Name = "lbl_FieldImage_ConnectionStatus"
        Me.lbl_FieldImage_ConnectionStatus.Size = New System.Drawing.Size(91, 13)
        Me.lbl_FieldImage_ConnectionStatus.TabIndex = 84
        Me.lbl_FieldImage_ConnectionStatus.Text = "ConnectionStatus"
        '
        'lbl_FieldImage_Connected
        '
        Me.lbl_FieldImage_Connected.AutoSize = True
        Me.lbl_FieldImage_Connected.Location = New System.Drawing.Point(491, 10)
        Me.lbl_FieldImage_Connected.Name = "lbl_FieldImage_Connected"
        Me.lbl_FieldImage_Connected.Size = New System.Drawing.Size(56, 13)
        Me.lbl_FieldImage_Connected.TabIndex = 85
        Me.lbl_FieldImage_Connected.Text = "Undefined"
        '
        'btn_SendFieldImage_Request
        '
        Me.btn_SendFieldImage_Request.Location = New System.Drawing.Point(711, 60)
        Me.btn_SendFieldImage_Request.Name = "btn_SendFieldImage_Request"
        Me.btn_SendFieldImage_Request.Size = New System.Drawing.Size(62, 58)
        Me.btn_SendFieldImage_Request.TabIndex = 86
        Me.btn_SendFieldImage_Request.Text = "GET FIELD IMAGE"
        Me.btn_SendFieldImage_Request.UseVisualStyleBackColor = True
        '
        'lbl_PLC_TYPE
        '
        Me.lbl_PLC_TYPE.AutoSize = True
        Me.lbl_PLC_TYPE.Location = New System.Drawing.Point(50, 10)
        Me.lbl_PLC_TYPE.Name = "lbl_PLC_TYPE"
        Me.lbl_PLC_TYPE.Size = New System.Drawing.Size(58, 13)
        Me.lbl_PLC_TYPE.TabIndex = 87
        Me.lbl_PLC_TYPE.Text = "PLC TYPE"
        '
        'lbl_FieldImage_Exception
        '
        Me.lbl_FieldImage_Exception.AutoSize = True
        Me.lbl_FieldImage_Exception.Location = New System.Drawing.Point(342, 10)
        Me.lbl_FieldImage_Exception.Name = "lbl_FieldImage_Exception"
        Me.lbl_FieldImage_Exception.Size = New System.Drawing.Size(54, 13)
        Me.lbl_FieldImage_Exception.TabIndex = 88
        Me.lbl_FieldImage_Exception.Text = "Exception"
        '
        'lbl_FieldImageScanErrCount
        '
        Me.lbl_FieldImageScanErrCount.AutoSize = True
        Me.lbl_FieldImageScanErrCount.Location = New System.Drawing.Point(224, 137)
        Me.lbl_FieldImageScanErrCount.Name = "lbl_FieldImageScanErrCount"
        Me.lbl_FieldImageScanErrCount.Size = New System.Drawing.Size(82, 13)
        Me.lbl_FieldImageScanErrCount.TabIndex = 89
        Me.lbl_FieldImageScanErrCount.Text = "ScanErrorCount"
        '
        'lbl_FieldImageScanOkCount
        '
        Me.lbl_FieldImageScanOkCount.AutoSize = True
        Me.lbl_FieldImageScanOkCount.Location = New System.Drawing.Point(69, 137)
        Me.lbl_FieldImageScanOkCount.Name = "lbl_FieldImageScanOkCount"
        Me.lbl_FieldImageScanOkCount.Size = New System.Drawing.Size(49, 13)
        Me.lbl_FieldImageScanOkCount.TabIndex = 90
        Me.lbl_FieldImageScanOkCount.Text = "OkCount"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(21, 137)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 13)
        Me.Label24.TabIndex = 91
        Me.Label24.Text = "OkCount"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(143, 137)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 13)
        Me.Label26.TabIndex = 92
        Me.Label26.Text = "ScanErrorCount"
        '
        'txt_FieldImage_IP
        '
        Me.txt_FieldImage_IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txt_FieldImage_IP.Location = New System.Drawing.Point(200, 5)
        Me.txt_FieldImage_IP.Name = "txt_FieldImage_IP"
        Me.txt_FieldImage_IP.Size = New System.Drawing.Size(117, 22)
        Me.txt_FieldImage_IP.TabIndex = 93
        Me.txt_FieldImage_IP.TabStop = False
        Me.txt_FieldImage_IP.Text = "XXX.XXX.XXX.XXX"
        Me.txt_FieldImage_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chk_USE_FIELD_IMAGE
        '
        Me.chk_USE_FIELD_IMAGE.AutoSize = True
        Me.chk_USE_FIELD_IMAGE.Checked = True
        Me.chk_USE_FIELD_IMAGE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_USE_FIELD_IMAGE.Location = New System.Drawing.Point(681, 24)
        Me.chk_USE_FIELD_IMAGE.Name = "chk_USE_FIELD_IMAGE"
        Me.chk_USE_FIELD_IMAGE.Size = New System.Drawing.Size(140, 30)
        Me.chk_USE_FIELD_IMAGE.TabIndex = 94
        Me.chk_USE_FIELD_IMAGE.Text = "ENABLE READING OF " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FIELD IMAGE"
        Me.chk_USE_FIELD_IMAGE.UseVisualStyleBackColor = True
        '
        'btn_ConnectFieldImage
        '
        Me.btn_ConnectFieldImage.Location = New System.Drawing.Point(681, 4)
        Me.btn_ConnectFieldImage.Name = "btn_ConnectFieldImage"
        Me.btn_ConnectFieldImage.Size = New System.Drawing.Size(122, 19)
        Me.btn_ConnectFieldImage.TabIndex = 95
        Me.btn_ConnectFieldImage.Text = "CONNECT TO PLC"
        Me.btn_ConnectFieldImage.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(24, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 13)
        Me.Label28.TabIndex = 96
        Me.Label28.Text = "PLC:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(171, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(23, 13)
        Me.Label30.TabIndex = 97
        Me.Label30.Text = "IP :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(10, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(843, 623)
        Me.TabControl1.TabIndex = 98
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lbl_WeatherStationWatchDog)
        Me.TabPage1.Controls.Add(Me.lbl_PowerMeterWatchDog)
        Me.TabPage1.Controls.Add(Me.txt_WebServer_ReplyText)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lbl_WebServerReplyCounter)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.lbl_UploadFailCounter)
        Me.TabPage1.Controls.Add(Me.txt_WeatherStationReply)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.lbl_WeatherStation_ConnectionStatus)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.lbl_WeatherStation_Exception)
        Me.TabPage1.Controls.Add(Me.txt_PowerMeterReply)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.lbl_PowerMeter_ConnectionStatus)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txt_LibWebReply)
        Me.TabPage1.Controls.Add(Me.lbl_PowerMeter_Exception)
        Me.TabPage1.Controls.Add(Me.btn_WebTest)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lbl_LibTest)
        Me.TabPage1.Controls.Add(Me.lbl_Bioland_Pool_Inserted_OK_Count)
        Me.TabPage1.Controls.Add(Me.cmd_LibTest)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.lbl_URL)
        Me.TabPage1.Controls.Add(Me.lbl_PROTOCOL)
        Me.TabPage1.Controls.Add(Me.lbl_METER_TYPE)
        Me.TabPage1.Controls.Add(Me.lbl_Bioland_Plants_Updated_OK_Count)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.lbl_x)
        Me.TabPage1.Controls.Add(Me.lbl_Bioland_Pool_Inserted_Err_Count)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.chk_USE_WEATHER_STATION)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.lbl_SunShine_Inclined)
        Me.TabPage1.Controls.Add(Me.chk_USE_POWER_METER)
        Me.TabPage1.Controls.Add(Me.lbl_SunShine_Horizontal)
        Me.TabPage1.Controls.Add(Me.lbl_Bioland_Plants_Updated_Err_Count)
        Me.TabPage1.Controls.Add(Me.lbl_P_Tot)
        Me.TabPage1.Controls.Add(Me.chk_UPLOAD_TO_WEB)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.btn_SendWeatherStation_Request)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.lbl_WeatherStation_Connected)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.lbl_PowerMeter_Connected)
        Me.TabPage1.Controls.Add(Me.lbl_WindSpeed)
        Me.TabPage1.Controls.Add(Me.lbl_WeatherStation_Type)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.lbl_Powermeter_Type)
        Me.TabPage1.Controls.Add(Me.lbl_SunShine)
        Me.TabPage1.Controls.Add(Me.btn_ConnectWeatherStations)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txt_WeatherStation_IP)
        Me.TabPage1.Controls.Add(Me.lbl_PowerMeterScanErrorCount)
        Me.TabPage1.Controls.Add(Me.btn_ConnectPowerMeter)
        Me.TabPage1.Controls.Add(Me.lbl_PowerMeterScanOkCount)
        Me.TabPage1.Controls.Add(Me.txt_PowerMeter_IP)
        Me.TabPage1.Controls.Add(Me.lbl_WeatherStationScanErrCount)
        Me.TabPage1.Controls.Add(Me.btn_SendPowerMeter_Request)
        Me.TabPage1.Controls.Add(Me.lbl_WeatherStationScanOkCount)
        Me.TabPage1.Controls.Add(Me.lbl_P_L2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.lbl_Temperature)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.lbl_P_L3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.lbl_P_L1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(835, 597)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Power&Solar"
        Me.TabPage1.ToolTipText = "View the production"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lbl_WeatherStationWatchDog
        '
        Me.lbl_WeatherStationWatchDog.AutoSize = True
        Me.lbl_WeatherStationWatchDog.Location = New System.Drawing.Point(725, 135)
        Me.lbl_WeatherStationWatchDog.Name = "lbl_WeatherStationWatchDog"
        Me.lbl_WeatherStationWatchDog.Size = New System.Drawing.Size(13, 13)
        Me.lbl_WeatherStationWatchDog.TabIndex = 84
        Me.lbl_WeatherStationWatchDog.Text = "0"
        '
        'lbl_PowerMeterWatchDog
        '
        Me.lbl_PowerMeterWatchDog.AutoSize = True
        Me.lbl_PowerMeterWatchDog.Location = New System.Drawing.Point(732, 305)
        Me.lbl_PowerMeterWatchDog.Name = "lbl_PowerMeterWatchDog"
        Me.lbl_PowerMeterWatchDog.Size = New System.Drawing.Size(13, 13)
        Me.lbl_PowerMeterWatchDog.TabIndex = 83
        Me.lbl_PowerMeterWatchDog.Text = "0"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt_WebReply)
        Me.TabPage2.Controls.Add(Me.lbl_FieldImageWatchDog)
        Me.TabPage2.Controls.Add(Me.lbl_Clock2)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.txt_FieldImageReply)
        Me.TabPage2.Controls.Add(Me.lbl_FieldImage_ConnectionStatus)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.lbl_FieldImage_Connected)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.btn_SendFieldImage_Request)
        Me.TabPage2.Controls.Add(Me.btn_ConnectFieldImage)
        Me.TabPage2.Controls.Add(Me.lbl_PLC_TYPE)
        Me.TabPage2.Controls.Add(Me.chk_USE_FIELD_IMAGE)
        Me.TabPage2.Controls.Add(Me.lbl_FieldImage_Exception)
        Me.TabPage2.Controls.Add(Me.txt_FieldImage_IP)
        Me.TabPage2.Controls.Add(Me.lbl_FieldImageScanErrCount)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.lbl_FieldImageScanOkCount)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(835, 597)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "FIELD IMAGE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_WebReply
        '
        Me.txt_WebReply.Location = New System.Drawing.Point(20, 197)
        Me.txt_WebReply.Multiline = True
        Me.txt_WebReply.Name = "txt_WebReply"
        Me.txt_WebReply.Size = New System.Drawing.Size(645, 337)
        Me.txt_WebReply.TabIndex = 100
        Me.txt_WebReply.Text = "WebReply"
        '
        'lbl_FieldImageWatchDog
        '
        Me.lbl_FieldImageWatchDog.AutoSize = True
        Me.lbl_FieldImageWatchDog.Location = New System.Drawing.Point(809, 5)
        Me.lbl_FieldImageWatchDog.Name = "lbl_FieldImageWatchDog"
        Me.lbl_FieldImageWatchDog.Size = New System.Drawing.Size(13, 13)
        Me.lbl_FieldImageWatchDog.TabIndex = 99
        Me.lbl_FieldImageWatchDog.Text = "0"
        '
        'lbl_Clock2
        '
        Me.lbl_Clock2.AutoSize = True
        Me.lbl_Clock2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_Clock2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_Clock2.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_Clock2.Location = New System.Drawing.Point(19, 160)
        Me.lbl_Clock2.Name = "lbl_Clock2"
        Me.lbl_Clock2.Size = New System.Drawing.Size(231, 25)
        Me.lbl_Clock2.TabIndex = 98
        Me.lbl_Clock2.Text = "0000-00-00 00:00:00"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage3.Controls.Add(Me.GroupBox7)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.Group_ACB)
        Me.TabPage3.Controls.Add(Me.Group_WEATHER)
        Me.TabPage3.Controls.Add(Me.Group_P855)
        Me.TabPage3.Controls.Add(Me.Group_RTU_Connection)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.btn_ClearGraphics)
        Me.TabPage3.Controls.Add(Me.btn_Graphics)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.Group_ExportPower)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.DigitalInputs_161)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(835, 597)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "HMI"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label48)
        Me.GroupBox7.Controls.Add(Me.Label47)
        Me.GroupBox7.Controls.Add(Me.Label46)
        Me.GroupBox7.Controls.Add(Me.Label45)
        Me.GroupBox7.Controls.Add(Me.Label43)
        Me.GroupBox7.Controls.Add(Me.Label40)
        Me.GroupBox7.Controls.Add(Me.InverterControl3)
        Me.GroupBox7.Controls.Add(Me.InverterControl10)
        Me.GroupBox7.Controls.Add(Me.InverterControl1)
        Me.GroupBox7.Controls.Add(Me.InverterControl9)
        Me.GroupBox7.Controls.Add(Me.InverterControl2)
        Me.GroupBox7.Controls.Add(Me.InverterControl8)
        Me.GroupBox7.Controls.Add(Me.InverterControl4)
        Me.GroupBox7.Controls.Add(Me.InverterControl7)
        Me.GroupBox7.Controls.Add(Me.InverterControl5)
        Me.GroupBox7.Controls.Add(Me.InverterControl6)
        Me.GroupBox7.Location = New System.Drawing.Point(118, 210)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(645, 132)
        Me.GroupBox7.TabIndex = 137
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "INVERTERS"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(3, 107)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(81, 13)
        Me.Label48.TabIndex = 142
        Me.Label48.Text = "Operating State"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(3, 92)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(70, 13)
        Me.Label47.TabIndex = 141
        Me.Label47.Text = "Power Factor"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(3, 77)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(76, 13)
        Me.Label46.TabIndex = 140
        Me.Label46.Text = "Reactive kVAr"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(3, 61)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(77, 13)
        Me.Label45.TabIndex = 139
        Me.Label45.Text = "Fix Reactive %"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(3, 46)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(73, 13)
        Me.Label43.TabIndex = 138
        Me.Label43.Text = "Produced kW"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(3, 31)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(71, 13)
        Me.Label40.TabIndex = 137
        Me.Label40.Text = "Max Power %"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.lbl_MaxAllowed)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.lbl_Availability)
        Me.GroupBox5.Controls.Add(Me.Label42)
        Me.GroupBox5.Controls.Add(Me.lbl_PlantCapacity)
        Me.GroupBox5.Location = New System.Drawing.Point(409, 53)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(129, 151)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PLANT CAPACITY"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Blue
        Me.Label44.Location = New System.Drawing.Point(78, 109)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(34, 20)
        Me.Label44.TabIndex = 7
        Me.Label44.Text = "kW"
        '
        'lbl_MaxAllowed
        '
        Me.lbl_MaxAllowed.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_MaxAllowed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_MaxAllowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_MaxAllowed.Location = New System.Drawing.Point(17, 106)
        Me.lbl_MaxAllowed.Name = "lbl_MaxAllowed"
        Me.lbl_MaxAllowed.Size = New System.Drawing.Size(56, 26)
        Me.lbl_MaxAllowed.TabIndex = 6
        Me.lbl_MaxAllowed.Text = "0000"
        Me.lbl_MaxAllowed.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(6, 84)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(100, 19)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "MAX ALLOWED"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Blue
        Me.Label37.Location = New System.Drawing.Point(79, 58)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(44, 20)
        Me.Label37.TabIndex = 3
        Me.Label37.Text = "%Av"
        '
        'lbl_Availability
        '
        Me.lbl_Availability.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Availability.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Availability.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_Availability.Location = New System.Drawing.Point(18, 55)
        Me.lbl_Availability.Name = "lbl_Availability"
        Me.lbl_Availability.Size = New System.Drawing.Size(56, 26)
        Me.lbl_Availability.TabIndex = 2
        Me.lbl_Availability.Text = "0000"
        Me.lbl_Availability.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Blue
        Me.Label42.Location = New System.Drawing.Point(79, 26)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(34, 20)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "kW"
        '
        'lbl_PlantCapacity
        '
        Me.lbl_PlantCapacity.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_PlantCapacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_PlantCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_PlantCapacity.Location = New System.Drawing.Point(18, 23)
        Me.lbl_PlantCapacity.Name = "lbl_PlantCapacity"
        Me.lbl_PlantCapacity.Size = New System.Drawing.Size(56, 26)
        Me.lbl_PlantCapacity.TabIndex = 0
        Me.lbl_PlantCapacity.Text = "0000"
        Me.lbl_PlantCapacity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Group_ACB
        '
        Me.Group_ACB.Controls.Add(Me.lbl_RemoteLocal)
        Me.Group_ACB.Controls.Add(Me.lbl_ACB_Status)
        Me.Group_ACB.Controls.Add(Me.PictureBox3)
        Me.Group_ACB.Location = New System.Drawing.Point(22, 53)
        Me.Group_ACB.Name = "Group_ACB"
        Me.Group_ACB.Size = New System.Drawing.Size(105, 110)
        Me.Group_ACB.TabIndex = 125
        Me.Group_ACB.TabStop = False
        Me.Group_ACB.Text = "MAIN BREAKER"
        '
        'lbl_RemoteLocal
        '
        Me.lbl_RemoteLocal.Location = New System.Drawing.Point(19, 23)
        Me.lbl_RemoteLocal.Name = "lbl_RemoteLocal"
        Me.lbl_RemoteLocal.Size = New System.Drawing.Size(68, 13)
        Me.lbl_RemoteLocal.TabIndex = 125
        Me.lbl_RemoteLocal.Text = "REMOTE"
        Me.lbl_RemoteLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ACB_Status
        '
        Me.lbl_ACB_Status.Location = New System.Drawing.Point(18, 83)
        Me.lbl_ACB_Status.Name = "lbl_ACB_Status"
        Me.lbl_ACB_Status.Size = New System.Drawing.Size(70, 13)
        Me.lbl_ACB_Status.TabIndex = 124
        Me.lbl_ACB_Status.Text = "UNDEFINED"
        Me.lbl_ACB_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(18, 43)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(70, 30)
        Me.PictureBox3.TabIndex = 123
        Me.PictureBox3.TabStop = False
        '
        'Group_WEATHER
        '
        Me.Group_WEATHER.Controls.Add(Me.Label31)
        Me.Group_WEATHER.Controls.Add(Me.lbl_SOLAR)
        Me.Group_WEATHER.Controls.Add(Me.lbl_Speed)
        Me.Group_WEATHER.Controls.Add(Me.Label38)
        Me.Group_WEATHER.Controls.Add(Me.Label36)
        Me.Group_WEATHER.Controls.Add(Me.lbl_Ambient)
        Me.Group_WEATHER.Location = New System.Drawing.Point(683, 53)
        Me.Group_WEATHER.Name = "Group_WEATHER"
        Me.Group_WEATHER.Size = New System.Drawing.Size(133, 120)
        Me.Group_WEATHER.TabIndex = 122
        Me.Group_WEATHER.TabStop = False
        Me.Group_WEATHER.Text = "WEATHER"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Blue
        Me.Label31.Location = New System.Drawing.Point(83, 85)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 20)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "m/s"
        '
        'lbl_SOLAR
        '
        Me.lbl_SOLAR.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_SOLAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_SOLAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_SOLAR.Location = New System.Drawing.Point(6, 23)
        Me.lbl_SOLAR.Name = "lbl_SOLAR"
        Me.lbl_SOLAR.Size = New System.Drawing.Size(61, 26)
        Me.lbl_SOLAR.TabIndex = 8
        Me.lbl_SOLAR.Text = "0000"
        Me.lbl_SOLAR.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Speed
        '
        Me.lbl_Speed.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Speed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_Speed.Location = New System.Drawing.Point(6, 83)
        Me.lbl_Speed.Name = "lbl_Speed"
        Me.lbl_Speed.Size = New System.Drawing.Size(61, 26)
        Me.lbl_Speed.TabIndex = 12
        Me.lbl_Speed.Text = "0.0"
        Me.lbl_Speed.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Blue
        Me.Label38.Location = New System.Drawing.Point(80, 25)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(54, 20)
        Me.Label38.TabIndex = 9
        Me.Label38.Text = "W/m2"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Blue
        Me.Label36.Location = New System.Drawing.Point(80, 57)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(27, 20)
        Me.Label36.TabIndex = 11
        Me.Label36.Text = "°C"
        '
        'lbl_Ambient
        '
        Me.lbl_Ambient.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Ambient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Ambient.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_Ambient.Location = New System.Drawing.Point(6, 54)
        Me.lbl_Ambient.Name = "lbl_Ambient"
        Me.lbl_Ambient.Size = New System.Drawing.Size(61, 26)
        Me.lbl_Ambient.TabIndex = 10
        Me.lbl_Ambient.Text = "00.0"
        Me.lbl_Ambient.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Group_P855
        '
        Me.Group_P855.Location = New System.Drawing.Point(259, 23)
        Me.Group_P855.Name = "Group_P855"
        Me.Group_P855.Size = New System.Drawing.Size(138, 24)
        Me.Group_P855.TabIndex = 121
        Me.Group_P855.TabStop = False
        Me.Group_P855.Text = " P855 CONNECTED"
        '
        'Group_RTU_Connection
        '
        Me.Group_RTU_Connection.Controls.Add(Me.GroupBox3)
        Me.Group_RTU_Connection.Location = New System.Drawing.Point(14, 23)
        Me.Group_RTU_Connection.Name = "Group_RTU_Connection"
        Me.Group_RTU_Connection.Size = New System.Drawing.Size(149, 24)
        Me.Group_RTU_Connection.TabIndex = 120
        Me.Group_RTU_Connection.TabStop = False
        Me.Group_RTU_Connection.Text = " RTU NOT CONNECTED"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(0, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(119, 24)
        Me.GroupBox3.TabIndex = 121
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RTU CONNECTION"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(494, 348)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(309, 221)
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'btn_ClearGraphics
        '
        Me.btn_ClearGraphics.Location = New System.Drawing.Point(418, 543)
        Me.btn_ClearGraphics.Name = "btn_ClearGraphics"
        Me.btn_ClearGraphics.Size = New System.Drawing.Size(64, 26)
        Me.btn_ClearGraphics.TabIndex = 9
        Me.btn_ClearGraphics.Text = "Clear"
        Me.btn_ClearGraphics.UseVisualStyleBackColor = True
        '
        'btn_Graphics
        '
        Me.btn_Graphics.Location = New System.Drawing.Point(418, 511)
        Me.btn_Graphics.Name = "btn_Graphics"
        Me.btn_Graphics.Size = New System.Drawing.Size(64, 26)
        Me.btn_Graphics.TabIndex = 8
        Me.btn_Graphics.Text = "Graphics"
        Me.btn_Graphics.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Group_PRODMAN)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Controls.Add(Me.lbl_Fix_kVAr)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.lbl_Curtail_kW)
        Me.GroupBox4.Location = New System.Drawing.Point(546, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(129, 120)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CURTAIL / FIX"
        '
        'Group_PRODMAN
        '
        Me.Group_PRODMAN.Location = New System.Drawing.Point(18, 85)
        Me.Group_PRODMAN.Name = "Group_PRODMAN"
        Me.Group_PRODMAN.Size = New System.Drawing.Size(93, 19)
        Me.Group_PRODMAN.TabIndex = 4
        Me.Group_PRODMAN.TabStop = False
        Me.Group_PRODMAN.Text = "PRODMAN"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Blue
        Me.Label39.Location = New System.Drawing.Point(79, 58)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(48, 20)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "kVAr"
        '
        'lbl_Fix_kVAr
        '
        Me.lbl_Fix_kVAr.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Fix_kVAr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Fix_kVAr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_Fix_kVAr.Location = New System.Drawing.Point(18, 55)
        Me.lbl_Fix_kVAr.Name = "lbl_Fix_kVAr"
        Me.lbl_Fix_kVAr.Size = New System.Drawing.Size(56, 26)
        Me.lbl_Fix_kVAr.TabIndex = 2
        Me.lbl_Fix_kVAr.Text = "0000"
        Me.lbl_Fix_kVAr.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Blue
        Me.Label41.Location = New System.Drawing.Point(79, 26)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(34, 20)
        Me.Label41.TabIndex = 1
        Me.Label41.Text = "kW"
        '
        'lbl_Curtail_kW
        '
        Me.lbl_Curtail_kW.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Curtail_kW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Curtail_kW.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_Curtail_kW.Location = New System.Drawing.Point(18, 23)
        Me.lbl_Curtail_kW.Name = "lbl_Curtail_kW"
        Me.lbl_Curtail_kW.Size = New System.Drawing.Size(56, 26)
        Me.lbl_Curtail_kW.TabIndex = 0
        Me.lbl_Curtail_kW.Text = "0000"
        Me.lbl_Curtail_kW.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Group_ExportPower
        '
        Me.Group_ExportPower.Controls.Add(Me.Label34)
        Me.Group_ExportPower.Controls.Add(Me.lbl_kV)
        Me.Group_ExportPower.Controls.Add(Me.Label35)
        Me.Group_ExportPower.Controls.Add(Me.lbl_PF)
        Me.Group_ExportPower.Controls.Add(Me.Label33)
        Me.Group_ExportPower.Controls.Add(Me.PictureBox1)
        Me.Group_ExportPower.Controls.Add(Me.lbl_kVAr)
        Me.Group_ExportPower.Controls.Add(Me.Label32)
        Me.Group_ExportPower.Controls.Add(Me.lbl_ExportPower)
        Me.Group_ExportPower.Location = New System.Drawing.Point(259, 53)
        Me.Group_ExportPower.Name = "Group_ExportPower"
        Me.Group_ExportPower.Size = New System.Drawing.Size(138, 151)
        Me.Group_ExportPower.TabIndex = 1
        Me.Group_ExportPower.TabStop = False
        Me.Group_ExportPower.Text = "EXPORT POWER"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Blue
        Me.Label34.Location = New System.Drawing.Point(80, 20)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 20)
        Me.Label34.TabIndex = 9
        Me.Label34.Text = "kV"
        '
        'lbl_kV
        '
        Me.lbl_kV.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_kV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_kV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_kV.Location = New System.Drawing.Point(6, 17)
        Me.lbl_kV.Name = "lbl_kV"
        Me.lbl_kV.Size = New System.Drawing.Size(61, 26)
        Me.lbl_kV.TabIndex = 8
        Me.lbl_kV.Text = "0000"
        Me.lbl_kV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.Location = New System.Drawing.Point(83, 110)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(31, 20)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "PF"
        '
        'lbl_PF
        '
        Me.lbl_PF.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_PF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_PF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_PF.Location = New System.Drawing.Point(6, 107)
        Me.lbl_PF.Name = "lbl_PF"
        Me.lbl_PF.Size = New System.Drawing.Size(61, 26)
        Me.lbl_PF.TabIndex = 4
        Me.lbl_PF.Text = "-0.00"
        Me.lbl_PF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Blue
        Me.Label33.Location = New System.Drawing.Point(80, 82)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(48, 20)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "kVAr"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-192, 377)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 117)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lbl_kVAr
        '
        Me.lbl_kVAr.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_kVAr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_kVAr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_kVAr.Location = New System.Drawing.Point(6, 78)
        Me.lbl_kVAr.Name = "lbl_kVAr"
        Me.lbl_kVAr.Size = New System.Drawing.Size(61, 26)
        Me.lbl_kVAr.TabIndex = 2
        Me.lbl_kVAr.Text = "0000"
        Me.lbl_kVAr.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Blue
        Me.Label32.Location = New System.Drawing.Point(80, 50)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(34, 20)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "kW"
        '
        'lbl_ExportPower
        '
        Me.lbl_ExportPower.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_ExportPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ExportPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbl_ExportPower.Location = New System.Drawing.Point(6, 47)
        Me.lbl_ExportPower.Name = "lbl_ExportPower"
        Me.lbl_ExportPower.Size = New System.Drawing.Size(61, 26)
        Me.lbl_ExportPower.TabIndex = 0
        Me.lbl_ExportPower.Text = "0000"
        Me.lbl_ExportPower.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_000_ON)
        Me.GroupBox2.Controls.Add(Me.btn_030_ON)
        Me.GroupBox2.Controls.Add(Me.btn_060_ON)
        Me.GroupBox2.Controls.Add(Me.btn_100_ON)
        Me.GroupBox2.Location = New System.Drawing.Point(151, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(97, 133)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EXPORT LIMIT"
        '
        'btn_000_ON
        '
        Me.btn_000_ON.Location = New System.Drawing.Point(12, 95)
        Me.btn_000_ON.Name = "btn_000_ON"
        Me.btn_000_ON.Size = New System.Drawing.Size(68, 25)
        Me.btn_000_ON.TabIndex = 6
        Me.btn_000_ON.Text = "0%"
        Me.btn_000_ON.UseVisualStyleBackColor = False
        '
        'btn_030_ON
        '
        Me.btn_030_ON.Location = New System.Drawing.Point(12, 70)
        Me.btn_030_ON.Name = "btn_030_ON"
        Me.btn_030_ON.Size = New System.Drawing.Size(68, 25)
        Me.btn_030_ON.TabIndex = 4
        Me.btn_030_ON.Text = "30%"
        Me.btn_030_ON.UseVisualStyleBackColor = False
        '
        'btn_060_ON
        '
        Me.btn_060_ON.Location = New System.Drawing.Point(12, 45)
        Me.btn_060_ON.Name = "btn_060_ON"
        Me.btn_060_ON.Size = New System.Drawing.Size(68, 25)
        Me.btn_060_ON.TabIndex = 2
        Me.btn_060_ON.Text = "60%"
        Me.btn_060_ON.UseVisualStyleBackColor = False
        '
        'btn_100_ON
        '
        Me.btn_100_ON.Location = New System.Drawing.Point(12, 20)
        Me.btn_100_ON.Name = "btn_100_ON"
        Me.btn_100_ON.Size = New System.Drawing.Size(68, 25)
        Me.btn_100_ON.TabIndex = 0
        Me.btn_100_ON.Text = "100%"
        Me.btn_100_ON.UseVisualStyleBackColor = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(859, 153)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 19)
        Me.CheckedListBox1.TabIndex = 99
        '
        'ACB_STATUS_IMAGES
        '
        Me.ACB_STATUS_IMAGES.ImageStream = CType(resources.GetObject("ACB_STATUS_IMAGES.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ACB_STATUS_IMAGES.TransparentColor = System.Drawing.Color.Transparent
        Me.ACB_STATUS_IMAGES.Images.SetKeyName(0, "acb_xopen.bmp")
        Me.ACB_STATUS_IMAGES.Images.SetKeyName(1, "acb_open.bmp")
        Me.ACB_STATUS_IMAGES.Images.SetKeyName(2, "acb_closed.bmp")
        Me.ACB_STATUS_IMAGES.Images.SetKeyName(3, "acb_xclosed.bmp")
        '
        'lbl_REAL_04
        '
        Me.lbl_REAL_04.AutoSize = True
        Me.lbl_REAL_04.Location = New System.Drawing.Point(876, 83)
        Me.lbl_REAL_04.Name = "lbl_REAL_04"
        Me.lbl_REAL_04.Size = New System.Drawing.Size(69, 13)
        Me.lbl_REAL_04.TabIndex = 100
        Me.lbl_REAL_04.Text = "lbl_REAL_04"
        '
        'lbl_ChecVisibility
        '
        Me.lbl_ChecVisibility.AutoSize = True
        Me.lbl_ChecVisibility.Location = New System.Drawing.Point(896, 216)
        Me.lbl_ChecVisibility.Name = "lbl_ChecVisibility"
        Me.lbl_ChecVisibility.Size = New System.Drawing.Size(57, 13)
        Me.lbl_ChecVisibility.TabIndex = 101
        Me.lbl_ChecVisibility.Text = "Not Visible"
        '
        'Btn_PLC_CONNECT
        '
        Me.Btn_PLC_CONNECT.Location = New System.Drawing.Point(903, 108)
        Me.Btn_PLC_CONNECT.Name = "Btn_PLC_CONNECT"
        Me.Btn_PLC_CONNECT.Size = New System.Drawing.Size(110, 23)
        Me.Btn_PLC_CONNECT.TabIndex = 102
        Me.Btn_PLC_CONNECT.Text = "PLC_CONNECT"
        Me.Btn_PLC_CONNECT.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(890, 386)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 22)
        Me.Button3.TabIndex = 103
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(896, 439)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 25)
        Me.Button4.TabIndex = 104
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1014, 302)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 23)
        Me.Button5.TabIndex = 105
        Me.Button5.Text = "SSH"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'InverterControl3
        '
        Me.InverterControl3.BackColor = System.Drawing.Color.White
        Me.InverterControl3.Location = New System.Drawing.Point(194, 16)
        Me.InverterControl3.Name = "InverterControl3"
        Me.InverterControl3.Size = New System.Drawing.Size(60, 110)
        Me.InverterControl3.TabIndex = 129
        '
        'InverterControl10
        '
        Me.InverterControl10.BackColor = System.Drawing.Color.White
        Me.InverterControl10.Location = New System.Drawing.Point(579, 16)
        Me.InverterControl10.Name = "InverterControl10"
        Me.InverterControl10.Size = New System.Drawing.Size(60, 110)
        Me.InverterControl10.TabIndex = 136
        '
        'InverterControl1
        '
        Me.InverterControl1.BackColor = System.Drawing.Color.White
        Me.InverterControl1.Location = New System.Drawing.Point(84, 16)
        Me.InverterControl1.Name = "InverterControl1"
        Me.InverterControl1.Size = New System.Drawing.Size(60, 110)
        Me.InverterControl1.TabIndex = 126
        '
        'InverterControl9
        '
        Me.InverterControl9.BackColor = System.Drawing.Color.White
        Me.InverterControl9.Location = New System.Drawing.Point(525, 16)
        Me.InverterControl9.Name = "InverterControl9"
        Me.InverterControl9.Size = New System.Drawing.Size(60, 110)
        Me.InverterControl9.TabIndex = 135
        '
        'InverterControl2
        '
        Me.InverterControl2.BackColor = System.Drawing.Color.White
        Me.InverterControl2.Location = New System.Drawing.Point(139, 16)
        Me.InverterControl2.Name = "InverterControl2"
        Me.InverterControl2.Size = New System.Drawing.Size(60, 110)
        Me.InverterControl2.TabIndex = 127
        '
        'InverterControl8
        '
        Me.InverterControl8.BackColor = System.Drawing.Color.White
        Me.InverterControl8.Location = New System.Drawing.Point(469, 16)
        Me.InverterControl8.Name = "InverterControl8"
        Me.InverterControl8.Size = New System.Drawing.Size(60, 110)
        Me.InverterControl8.TabIndex = 134
        '
        'InverterControl4
        '
        Me.InverterControl4.BackColor = System.Drawing.Color.White
        Me.InverterControl4.Location = New System.Drawing.Point(304, 16)
        Me.InverterControl4.Name = "InverterControl4"
        Me.InverterControl4.Size = New System.Drawing.Size(60, 110)
        Me.InverterControl4.TabIndex = 130
        '
        'InverterControl7
        '
        Me.InverterControl7.BackColor = System.Drawing.Color.White
        Me.InverterControl7.Location = New System.Drawing.Point(414, 16)
        Me.InverterControl7.Name = "InverterControl7"
        Me.InverterControl7.Size = New System.Drawing.Size(60, 110)
        Me.InverterControl7.TabIndex = 133
        '
        'InverterControl5
        '
        Me.InverterControl5.BackColor = System.Drawing.Color.White
        Me.InverterControl5.Location = New System.Drawing.Point(359, 16)
        Me.InverterControl5.Name = "InverterControl5"
        Me.InverterControl5.Size = New System.Drawing.Size(60, 110)
        Me.InverterControl5.TabIndex = 131
        '
        'InverterControl6
        '
        Me.InverterControl6.BackColor = System.Drawing.Color.White
        Me.InverterControl6.Location = New System.Drawing.Point(249, 16)
        Me.InverterControl6.Name = "InverterControl6"
        Me.InverterControl6.Size = New System.Drawing.Size(60, 110)
        Me.InverterControl6.TabIndex = 132
        '
        'DigitalInputs_161
        '
        Me.DigitalInputs_161.Location = New System.Drawing.Point(3, 210)
        Me.DigitalInputs_161.Name = "DigitalInputs_161"
        Me.DigitalInputs_161.Size = New System.Drawing.Size(109, 274)
        Me.DigitalInputs_161.TabIndex = 128
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 652)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Btn_PLC_CONNECT)
        Me.Controls.Add(Me.lbl_ChecVisibility)
        Me.Controls.Add(Me.lbl_REAL_04)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.lbl_CLOCK)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "BIOLAND SCANNER BekeTools 10Dec 2023"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Group_ACB.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_WEATHER.ResumeLayout(False)
        Me.Group_WEATHER.PerformLayout()
        Me.Group_RTU_Connection.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Group_ExportPower.ResumeLayout(False)
        Me.Group_ExportPower.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents cmd_LibTest As Button
    Friend WithEvents lbl_LibTest As Label
    Friend WithEvents btn_WebTest As Button
    Friend WithEvents txt_LibWebReply As TextBox
    Friend WithEvents txt_FieldImageReply As TextBox
    Friend WithEvents tmr_Check_FieldImage_Reply As Timer
    Friend WithEvents lbl_FieldImage_ConnectionStatus As Label
    Friend WithEvents lbl_FieldImage_Connected As Label
    Friend WithEvents btn_SendFieldImage_Request As Button
    Friend WithEvents lbl_PLC_TYPE As Label
    Friend WithEvents lbl_FieldImage_Exception As Label
    Friend WithEvents lbl_FieldImageScanErrCount As Label
    Friend WithEvents lbl_FieldImageScanOkCount As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_FieldImage_IP As TextBox
    Friend WithEvents chk_USE_FIELD_IMAGE As CheckBox
    Friend WithEvents btn_ConnectFieldImage As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbl_Clock2 As Label
    Friend WithEvents lbl_FieldImageWatchDog As Label
    Friend WithEvents lbl_PowerMeterWatchDog As Label
    Friend WithEvents lbl_WeatherStationWatchDog As Label
    Friend WithEvents txt_WebReply As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_000_ON As Button
    Friend WithEvents btn_030_ON As Button
    Friend WithEvents btn_060_ON As Button
    Friend WithEvents btn_100_ON As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label39 As Label
    Friend WithEvents lbl_Fix_kVAr As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents lbl_Curtail_kW As Label
    Friend WithEvents Group_ExportPower As GroupBox
    Friend WithEvents Label35 As Label
    Friend WithEvents lbl_PF As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lbl_kVAr As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents lbl_ExportPower As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Graphics As Button
    Friend WithEvents btn_ClearGraphics As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Group_WEATHER As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents lbl_SOLAR As Label
    Friend WithEvents lbl_Speed As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents lbl_Ambient As Label
    Friend WithEvents Group_P855 As GroupBox
    Friend WithEvents Group_RTU_Connection As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Group_PRODMAN As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ACB_STATUS_IMAGES As ImageList
    Friend WithEvents lbl_ACB_Status As Label
    Friend WithEvents lbl_REAL_04 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lbl_kV As Label
    Friend WithEvents Group_ACB As GroupBox
    Friend WithEvents lbl_RemoteLocal As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label44 As Label
    Friend WithEvents lbl_MaxAllowed As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label37 As Label
    Friend WithEvents lbl_Availability As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents lbl_PlantCapacity As Label
    Friend WithEvents InverterControl2 As InverterControl
    Friend WithEvents InverterControl1 As InverterControl
    Friend WithEvents DigitalInputs_161 As DigitalInputs_16
    Friend WithEvents InverterControl9 As InverterControl
    Friend WithEvents InverterControl8 As InverterControl
    Friend WithEvents InverterControl7 As InverterControl
    Friend WithEvents InverterControl6 As InverterControl
    Friend WithEvents InverterControl5 As InverterControl
    Friend WithEvents InverterControl4 As InverterControl
    Friend WithEvents InverterControl3 As InverterControl
    Friend WithEvents InverterControl10 As InverterControl
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents lbl_ChecVisibility As Label
    Friend WithEvents Btn_PLC_CONNECT As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
