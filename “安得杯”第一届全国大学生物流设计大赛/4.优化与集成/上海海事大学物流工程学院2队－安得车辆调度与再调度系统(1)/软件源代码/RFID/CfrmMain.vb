Imports Microsoft
Imports System.Threading
Imports System.Net
Public Class CfrmMain
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerialPort As System.Windows.Forms.TextBox
    Friend WithEvents btnStartRFID As System.Windows.Forms.Button
    Friend WithEvents btnStopRFID As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnStartComm As System.Windows.Forms.Button
    Friend WithEvents btnStopComm As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInAnt As System.Windows.Forms.TextBox
    Friend WithEvents txtOutAnt As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstResult = New System.Windows.Forms.ListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtInAnt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOutAnt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnStopRFID = New System.Windows.Forms.Button
        Me.btnStartRFID = New System.Windows.Forms.Button
        Me.txtSerialPort = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnStopComm = New System.Windows.Forms.Button
        Me.btnStartComm = New System.Windows.Forms.Button
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnQuit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstResult
        '
        Me.lstResult.ItemHeight = 12
        Me.lstResult.Location = New System.Drawing.Point(8, 8)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(368, 436)
        Me.lstResult.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInAnt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtOutAnt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnStopRFID)
        Me.GroupBox1.Controls.Add(Me.btnStartRFID)
        Me.GroupBox1.Controls.Add(Me.txtSerialPort)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(384, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 208)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RFID"
        '
        'txtInAnt
        '
        Me.txtInAnt.Location = New System.Drawing.Point(104, 88)
        Me.txtInAnt.Name = "txtInAnt"
        Me.txtInAnt.Size = New System.Drawing.Size(80, 21)
        Me.txtInAnt.TabIndex = 7
        Me.txtInAnt.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "仓库入口天线："
        '
        'txtOutAnt
        '
        Me.txtOutAnt.Location = New System.Drawing.Point(104, 56)
        Me.txtOutAnt.Name = "txtOutAnt"
        Me.txtOutAnt.Size = New System.Drawing.Size(80, 21)
        Me.txtOutAnt.TabIndex = 5
        Me.txtOutAnt.Text = "3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "仓库出口天线："
        '
        'btnStopRFID
        '
        Me.btnStopRFID.Enabled = False
        Me.btnStopRFID.Location = New System.Drawing.Point(16, 168)
        Me.btnStopRFID.Name = "btnStopRFID"
        Me.btnStopRFID.Size = New System.Drawing.Size(208, 24)
        Me.btnStopRFID.TabIndex = 3
        Me.btnStopRFID.Text = "停止RFID"
        '
        'btnStartRFID
        '
        Me.btnStartRFID.Location = New System.Drawing.Point(16, 136)
        Me.btnStartRFID.Name = "btnStartRFID"
        Me.btnStartRFID.Size = New System.Drawing.Size(208, 24)
        Me.btnStartRFID.TabIndex = 2
        Me.btnStartRFID.Text = "开启RFID"
        '
        'txtSerialPort
        '
        Me.txtSerialPort.Location = New System.Drawing.Point(104, 24)
        Me.txtSerialPort.Name = "txtSerialPort"
        Me.txtSerialPort.Size = New System.Drawing.Size(80, 21)
        Me.txtSerialPort.TabIndex = 1
        Me.txtSerialPort.Text = "COM2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "串口名称："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnStopComm)
        Me.GroupBox2.Controls.Add(Me.btnStartComm)
        Me.GroupBox2.Controls.Add(Me.txtPort)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtIP)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 168)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "车辆调度于再调度系统通讯"
        '
        'btnStopComm
        '
        Me.btnStopComm.Enabled = False
        Me.btnStopComm.Location = New System.Drawing.Point(16, 128)
        Me.btnStopComm.Name = "btnStopComm"
        Me.btnStopComm.Size = New System.Drawing.Size(208, 24)
        Me.btnStopComm.TabIndex = 7
        Me.btnStopComm.Text = "停止通讯"
        '
        'btnStartComm
        '
        Me.btnStartComm.Location = New System.Drawing.Point(16, 88)
        Me.btnStartComm.Name = "btnStartComm"
        Me.btnStartComm.Size = New System.Drawing.Size(208, 24)
        Me.btnStartComm.TabIndex = 6
        Me.btnStartComm.Text = "开始通讯"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(104, 56)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(120, 21)
        Me.txtPort.TabIndex = 5
        Me.txtPort.Text = "8386"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "远程端口："
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(104, 24)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(120, 21)
        Me.txtIP.TabIndex = 3
        Me.txtIP.Text = "192.168.119.251"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "远程IP："
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnQuit)
        Me.GroupBox3.Location = New System.Drawing.Point(384, 384)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 64)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "控制面板"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(16, 24)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(208, 24)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "退出"
        '
        'CfrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstResult)
        Me.MaximizeBox = False
        Me.Name = "CfrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RFID仓库车辆监控系统"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private thRFID As Thread
    Private UDP As Sockets.UdpClient
    Private Remote As IPEndPoint
    Private blUDPFlag As Boolean
    Private Sub sRFID()
        Dim int32Temp As Int32
        Dim bytTemp(31) As Byte
        Dim strTemp As String
        Dim strTagID As String
        Dim strTagAnt As String
        Dim strVehicleDirection As String
        Dim i As Int32
        Dim strOldTag As String = ""
        Dim strOldTagAnt As String = ""
        Dim bytCommNO As Byte = 0
        Dim strSend As String = ""
        Dim bytSend(21) As Byte
        Do
            int32Temp = ReadTagID()
            For i = 1 To int32Temp
                GetIDByIndex(i, bytTemp)
                strTagID = System.Text.Encoding.Default.GetString(bytTemp)
                strTagID = VisualBasic.Left(strTagID, InStr(strTagID, Chr(0)) - 1)
                GetAntByIndex(i, bytTemp)
                strTagAnt = System.Text.Encoding.Default.GetString(bytTemp)
                strTagAnt = VisualBasic.Left(strTagAnt, InStr(strTagAnt, Chr(0)) - 1)
                If strTagAnt = txtInAnt.Text Then
                    strVehicleDirection = "返回"
                    strSend = "I"
                End If
                If strTagAnt = txtOutAnt.Text Then
                    strVehicleDirection = "出发"
                    strSend = "O"
                End If
                If strOldTag <> strTagID Then
                    strTemp = strTagID + "，车辆方向：" + strVehicleDirection + vbCrLf
                    lstResult.Items.Add(strTemp)
                    strOldTag = strTagID
                    strOldTagAnt = strTagAnt
                    If blUDPFlag Then
                        bytCommNO += 1
                        strSend += ";" + VisualBasic.Right("0" + Hex(bytCommNO), 2) + ";" + strTagID + "."
                        bytSend = System.Text.Encoding.Default.GetBytes(strSend)
                        UDP.Send(bytSend, 22, Remote)
                        Thread.CurrentThread.Sleep(100)
                        UDP.Send(bytSend, 22, Remote)
                    End If
                End If
            Next
            Thread.CurrentThread.Sleep(500)
        Loop
    End Sub

    Private Sub btnStartRFID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartRFID.Click
        Dim OK1, OK2, OK3, OK4 As Boolean
        OK1 = SetRdrPort(txtSerialPort.Text)
        OK2 = SetReadMaxTags(1)
        OK3 = SetReadLen(32)
        OK4 = OpenRdr()
        If OK1 And OK2 And OK3 And OK4 Then
            thRFID = New Thread(AddressOf sRFID)
            thRFID.Start()
            btnStartRFID.Enabled = False
            txtSerialPort.ReadOnly = True
            txtInAnt.ReadOnly = True
            txtOutAnt.ReadOnly = True
            btnStopRFID.Enabled = True
        Else
            MsgBox("有错误产生", , "错误")
        End If
    End Sub

    Private Sub btnStopRFID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopRFID.Click
        Dim OK As Boolean
        btnStopRFID.Enabled = False
        thRFID.Abort()
        OK = CloseRdr()
        If OK Then
            btnStartRFID.Enabled = True
            txtSerialPort.ReadOnly = False
            txtInAnt.ReadOnly = False
            txtOutAnt.ReadOnly = False
        Else
            MsgBox("有错误产生", , "错误")
        End If

    End Sub

    Private Sub CfrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        blUDPFlag = False
    End Sub

    Private Sub btnStartComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartComm.Click
        btnStartComm.Enabled = False
        txtIP.ReadOnly = True
        txtPort.ReadOnly = True
        Remote = New IPEndPoint(IPAddress.Parse(txtIP.Text), Int16.Parse(txtPort.Text))
        UDP = New Sockets.UdpClient
        btnStopComm.Enabled = True
        blUDPFlag = True
    End Sub

    Private Sub btnStopComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopComm.Click
        blUDPFlag = False
        btnStopComm.Enabled = False
        UDP.Close()
        btnStartComm.Enabled = True
        txtIP.ReadOnly = False
        txtPort.ReadOnly = False
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub CfrmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

    End Sub
End Class
