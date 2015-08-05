Imports System.Threading
Imports Microsoft
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRFIDTag As System.Windows.Forms.TextBox
    Friend WithEvents btnStartRFID As System.Windows.Forms.Button
    Friend WithEvents btnStopRFID As System.Windows.Forms.Button
    Friend WithEvents AxMSComm As AxMSCommLib.AxMSComm
    Friend WithEvents txtCommPort As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStartSend As System.Windows.Forms.Button
    Friend WithEvents btnStopSend As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemoteIp As System.Windows.Forms.TextBox
    Friend WithEvents txtRemotePort As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CfrmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCommPort = New System.Windows.Forms.TextBox
        Me.AxMSComm = New AxMSCommLib.AxMSComm
        Me.btnStopRFID = New System.Windows.Forms.Button
        Me.btnStartRFID = New System.Windows.Forms.Button
        Me.txtRFIDTag = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtRemotePort = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRemoteIp = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnStopSend = New System.Windows.Forms.Button
        Me.btnStartSend = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxMSComm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCommPort)
        Me.GroupBox1.Controls.Add(Me.AxMSComm)
        Me.GroupBox1.Controls.Add(Me.btnStopRFID)
        Me.GroupBox1.Controls.Add(Me.btnStartRFID)
        Me.GroupBox1.Controls.Add(Me.txtRFIDTag)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 448)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RFID读卡器"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "串口号："
        '
        'txtCommPort
        '
        Me.txtCommPort.Location = New System.Drawing.Point(72, 64)
        Me.txtCommPort.Name = "txtCommPort"
        Me.txtCommPort.Size = New System.Drawing.Size(24, 21)
        Me.txtCommPort.TabIndex = 4
        Me.txtCommPort.Text = "4"
        '
        'AxMSComm
        '
        Me.AxMSComm.ContainingControl = Me
        Me.AxMSComm.Enabled = True
        Me.AxMSComm.Location = New System.Drawing.Point(16, 56)
        Me.AxMSComm.Name = "AxMSComm"
        Me.AxMSComm.OcxState = CType(resources.GetObject("AxMSComm.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMSComm.Size = New System.Drawing.Size(38, 38)
        Me.AxMSComm.TabIndex = 3
        '
        'btnStopRFID
        '
        Me.btnStopRFID.Enabled = False
        Me.btnStopRFID.Location = New System.Drawing.Point(224, 64)
        Me.btnStopRFID.Name = "btnStopRFID"
        Me.btnStopRFID.Size = New System.Drawing.Size(120, 24)
        Me.btnStopRFID.TabIndex = 2
        Me.btnStopRFID.Text = "停止RFID读卡器"
        '
        'btnStartRFID
        '
        Me.btnStartRFID.Location = New System.Drawing.Point(104, 64)
        Me.btnStartRFID.Name = "btnStartRFID"
        Me.btnStartRFID.Size = New System.Drawing.Size(120, 24)
        Me.btnStartRFID.TabIndex = 1
        Me.btnStartRFID.Text = "启动RFID读卡器"
        '
        'txtRFIDTag
        '
        Me.txtRFIDTag.Location = New System.Drawing.Point(16, 24)
        Me.txtRFIDTag.Name = "txtRFIDTag"
        Me.txtRFIDTag.Size = New System.Drawing.Size(328, 21)
        Me.txtRFIDTag.TabIndex = 0
        Me.txtRFIDTag.Text = "RFID读卡器停止"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRemotePort)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtRemoteIp)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnStopSend)
        Me.GroupBox2.Controls.Add(Me.btnStartSend)
        Me.GroupBox2.Location = New System.Drawing.Point(416, 448)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "与车辆调度中心通讯"
        '
        'txtRemotePort
        '
        Me.txtRemotePort.Location = New System.Drawing.Point(288, 24)
        Me.txtRemotePort.Name = "txtRemotePort"
        Me.txtRemotePort.Size = New System.Drawing.Size(40, 21)
        Me.txtRemotePort.TabIndex = 5
        Me.txtRemotePort.Text = "8386"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "端口号："
        '
        'txtRemoteIp
        '
        Me.txtRemoteIp.Location = New System.Drawing.Point(120, 24)
        Me.txtRemoteIp.Name = "txtRemoteIp"
        Me.txtRemoteIp.Size = New System.Drawing.Size(104, 21)
        Me.txtRemoteIp.TabIndex = 3
        Me.txtRemoteIp.Text = "192.168.119.250"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "车辆调度中心IP："
        '
        'btnStopSend
        '
        Me.btnStopSend.Enabled = False
        Me.btnStopSend.Location = New System.Drawing.Point(176, 64)
        Me.btnStopSend.Name = "btnStopSend"
        Me.btnStopSend.Size = New System.Drawing.Size(120, 24)
        Me.btnStopSend.TabIndex = 1
        Me.btnStopSend.Text = "停止发送条码信息"
        '
        'btnStartSend
        '
        Me.btnStartSend.Location = New System.Drawing.Point(56, 64)
        Me.btnStartSend.Name = "btnStartSend"
        Me.btnStartSend.Size = New System.Drawing.Size(120, 24)
        Me.btnStartSend.TabIndex = 0
        Me.btnStartSend.Text = "开始发送条码信息"
        '
        'CfrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "CfrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "配送中心管理系统"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AxMSComm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private thRFID As Thread
    Private blthRFIDRunning As Boolean
    Private blSendRFID As Boolean
    Private UDPClient As New Sockets.UdpClient '定义一个UDP的对象
    Private Local, Remote As IPEndPoint '定义本地和远程终端
    Private strLocalIp As String '本地IP

    Private Sub btnStartRFID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartRFID.Click
        btnStartRFID.Enabled = False
        txtCommPort.ReadOnly = True
        AxMSComm.CommPort = Byte.Parse(txtCommPort.Text)
        AxMSComm.PortOpen = True
        blthRFIDRunning = True
        thRFID = New Thread(AddressOf sRFID)
        thRFID.Start()
        btnStopRFID.Enabled = True
    End Sub
    Private Sub sRFID()
        Dim bytCmds(15) As Byte
        Dim bytRecv(1023) As Byte
        Dim intRecvLength As Int16
        Dim bytRFIDTag(7), bytTemp As Byte
        Dim bytUDPSend(31) As Byte
        Dim i, j, k As Int16
        Dim strRFID As String = ""
        bytCmds(0) = &H10
        bytCmds(1) = &H1
        bytCmds(2) = &H7
        bytCmds(3) = &H0
        bytCmds(4) = &H40
        bytCmds(5) = &H0
        bytCmds(6) = &H1
        bytCmds(7) = &H3
        bytCmds(8) = &H2
        bytCmds(9) = &H1
        bytCmds(10) = &H1
        bytCmds(11) = &H3
        bytCmds(12) = &H1C
        bytCmds(13) = &HAB
        bytCmds(14) = &H10
        bytCmds(15) = &H2
        Do
            AxMSComm.Output = bytCmds
            Thread.CurrentThread.Sleep(100)
            intRecvLength = AxMSComm.InBufferCount
            AxMSComm.InputLen = intRecvLength
            bytRecv = AxMSComm.Input
            '数据处理
            k = 0
            If intRecvLength >= 40 Then
                For i = 0 To intRecvLength - 28
                    If bytRecv(i) = &H10 And bytRecv(i + 1) = &H1 And bytRecv(i + 2) = &H7 _
                    And bytRecv(i + 3) = &HFF And bytRecv(i + 4) = &H40 And bytRecv(i + 5) = &H2 _
                    And bytRecv(i + 6) = &H8 And bytRecv(i + 7) = &H80 Then
                        i += 8
                        k = 0
                        strRFID = ""
                        For j = 0 To 7
                            bytTemp = bytRecv(i + k)
                            bytRFIDTag(j) = bytTemp
                            strRFID += VisualBasic.Right("0" + Hex(bytTemp), 2) + " "
                            If bytTemp = &H10 Then
                                k += 2
                            Else
                                k += 1
                            End If
                        Next
                        Exit For
                    End If
                Next
            End If
            If blSendRFID And intRecvLength >= 40 Then
                bytUDPSend = System.Text.Encoding.Default.GetBytes(strRFID)
                UDPClient.Send(bytUDPSend, Len(strRFID))
            End If
            txtRFIDTag.Text = strRFID
        Loop While blthRFIDRunning
    End Sub

    Private Sub btnStopRFID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopRFID.Click
        AxMSComm.PortOpen = False
        txtCommPort.ReadOnly = False
        btnStopRFID.Enabled = False
        blthRFIDRunning = False
        thRFID.Abort()
        btnStartRFID.Enabled = True
        txtRFIDTag.Text = "RFID读卡器停止"
    End Sub

    Private Sub btnStartSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartSend.Click
        Remote = New IPEndPoint(IPAddress.Parse(txtRemoteIp.Text), Int16.Parse(txtRemotePort.Text)) '远程终端
        Local = New IPEndPoint(IPAddress.Parse(strLocalIp), 8386) '本地终端
        UDPClient = New Sockets.UdpClient(Local) 'UDP对象
        UDPClient.Connect(Remote)
        txtRemoteIp.ReadOnly = True
        txtRemotePort.ReadOnly = True
        btnStartSend.Enabled = False
        blSendRFID = True
        btnStopSend.Enabled = True
    End Sub

    Private Sub btnStopSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopSend.Click
        UDPClient.Close()
        txtRemoteIp.ReadOnly = False
        txtRemotePort.ReadOnly = False
        btnStartSend.Enabled = True
        blSendRFID = False
        btnStopSend.Enabled = False
    End Sub

    Private Sub CfrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strLocalIp = Dns.GetHostByName(Dns.GetHostName).AddressList(0).ToString '获取本机IP
    End Sub
End Class
