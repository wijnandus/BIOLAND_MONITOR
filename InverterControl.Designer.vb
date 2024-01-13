<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InverterControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbl_Max_Output = New System.Windows.Forms.Label()
        Me.lbl_Active_Power = New System.Windows.Forms.Label()
        Me.lbl_kVAr_Fixing = New System.Windows.Forms.Label()
        Me.lbl_ReactivePower = New System.Windows.Forms.Label()
        Me.InverterControlBox = New System.Windows.Forms.GroupBox()
        Me.lbl_State = New System.Windows.Forms.Label()
        Me.lbl_PowerFactor = New System.Windows.Forms.Label()
        Me.InverterControlBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Max_Output
        '
        Me.lbl_Max_Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Max_Output.Location = New System.Drawing.Point(6, 15)
        Me.lbl_Max_Output.Name = "lbl_Max_Output"
        Me.lbl_Max_Output.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Max_Output.TabIndex = 0
        Me.lbl_Max_Output.Text = "Max kW"
        Me.lbl_Max_Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Active_Power
        '
        Me.lbl_Active_Power.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Active_Power.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Active_Power.Location = New System.Drawing.Point(6, 30)
        Me.lbl_Active_Power.Name = "lbl_Active_Power"
        Me.lbl_Active_Power.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Active_Power.TabIndex = 1
        Me.lbl_Active_Power.Text = "kW"
        Me.lbl_Active_Power.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_kVAr_Fixing
        '
        Me.lbl_kVAr_Fixing.BackColor = System.Drawing.Color.Transparent
        Me.lbl_kVAr_Fixing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_kVAr_Fixing.Location = New System.Drawing.Point(6, 45)
        Me.lbl_kVAr_Fixing.Name = "lbl_kVAr_Fixing"
        Me.lbl_kVAr_Fixing.Size = New System.Drawing.Size(50, 13)
        Me.lbl_kVAr_Fixing.TabIndex = 2
        Me.lbl_kVAr_Fixing.Text = "Fix Rea"
        Me.lbl_kVAr_Fixing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_ReactivePower
        '
        Me.lbl_ReactivePower.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ReactivePower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ReactivePower.Location = New System.Drawing.Point(6, 60)
        Me.lbl_ReactivePower.Name = "lbl_ReactivePower"
        Me.lbl_ReactivePower.Size = New System.Drawing.Size(50, 13)
        Me.lbl_ReactivePower.TabIndex = 3
        Me.lbl_ReactivePower.Text = "kVAr"
        Me.lbl_ReactivePower.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InverterControlBox
        '
        Me.InverterControlBox.Controls.Add(Me.lbl_State)
        Me.InverterControlBox.Controls.Add(Me.lbl_PowerFactor)
        Me.InverterControlBox.Controls.Add(Me.lbl_Max_Output)
        Me.InverterControlBox.Controls.Add(Me.lbl_ReactivePower)
        Me.InverterControlBox.Controls.Add(Me.lbl_Active_Power)
        Me.InverterControlBox.Controls.Add(Me.lbl_kVAr_Fixing)
        Me.InverterControlBox.Location = New System.Drawing.Point(0, 0)
        Me.InverterControlBox.Name = "InverterControlBox"
        Me.InverterControlBox.Size = New System.Drawing.Size(65, 110)
        Me.InverterControlBox.TabIndex = 4
        Me.InverterControlBox.TabStop = False
        Me.InverterControlBox.Text = "    INV 10"
        '
        'lbl_State
        '
        Me.lbl_State.BackColor = System.Drawing.Color.Transparent
        Me.lbl_State.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_State.Font = New System.Drawing.Font("Ebrima", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_State.Location = New System.Drawing.Point(6, 90)
        Me.lbl_State.Name = "lbl_State"
        Me.lbl_State.Size = New System.Drawing.Size(50, 13)
        Me.lbl_State.TabIndex = 5
        Me.lbl_State.Text = "UNKNOWN"
        Me.lbl_State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_PowerFactor
        '
        Me.lbl_PowerFactor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PowerFactor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_PowerFactor.Location = New System.Drawing.Point(6, 75)
        Me.lbl_PowerFactor.Name = "lbl_PowerFactor"
        Me.lbl_PowerFactor.Size = New System.Drawing.Size(50, 13)
        Me.lbl_PowerFactor.TabIndex = 4
        Me.lbl_PowerFactor.Text = "PF"
        Me.lbl_PowerFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InverterControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.InverterControlBox)
        Me.Name = "InverterControl"
        Me.Size = New System.Drawing.Size(65, 112)
        Me.InverterControlBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_Max_Output As Label
    Friend WithEvents lbl_Active_Power As Label
    Friend WithEvents lbl_kVAr_Fixing As Label
    Friend WithEvents lbl_ReactivePower As Label
    Friend WithEvents InverterControlBox As GroupBox
    Friend WithEvents lbl_State As Label
    Friend WithEvents lbl_PowerFactor As Label
End Class
