Imports System.Net
Imports System.Threading
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnGPS As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents txtGPS As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.txtSend = New System.Windows.Forms.TextBox
        Me.btnGPS = New System.Windows.Forms.Button
        Me.txtGPS = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSend)
        Me.GroupBox1.Controls.Add(Me.txtSend)
        Me.GroupBox1.Controls.Add(Me.btnGPS)
        Me.GroupBox1.Controls.Add(Me.txtGPS)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "控制面板"
        '
        'btnSend
        '
        Me.btnSend.Enabled = False
        Me.btnSend.Location = New System.Drawing.Point(56, 136)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(248, 24)
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "发送信息"
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(8, 112)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.ReadOnly = True
        Me.txtSend.Size = New System.Drawing.Size(336, 21)
        Me.txtSend.TabIndex = 6
        Me.txtSend.Text = ""
        '
        'btnGPS
        '
        Me.btnGPS.Enabled = False
        Me.btnGPS.Location = New System.Drawing.Point(56, 80)
        Me.btnGPS.Name = "btnGPS"
        Me.btnGPS.Size = New System.Drawing.Size(248, 24)
        Me.btnGPS.TabIndex = 5
        Me.btnGPS.Text = "获取GPS信息"
        '
        'txtGPS
        '
        Me.txtGPS.Location = New System.Drawing.Point(16, 24)
        Me.txtGPS.Multiline = True
        Me.txtGPS.Name = "txtGPS"
        Me.txtGPS.ReadOnly = True
        Me.txtGPS.Size = New System.Drawing.Size(336, 48)
        Me.txtGPS.TabIndex = 0
        Me.txtGPS.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnStop)
        Me.GroupBox2.Controls.Add(Me.btnStart)
        Me.GroupBox2.Controls.Add(Me.txtPort)
        Me.GroupBox2.Controls.Add(Me.txtIP)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 88)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "设置面板"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(232, 56)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(120, 24)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "停止工作"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(232, 24)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(120, 24)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "开始工作"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(96, 56)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(120, 21)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = "8620"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(96, 24)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(120, 21)
        Me.txtIP.TabIndex = 2
        Me.txtIP.Text = "192.168.119.20"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "终端端口："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "终端IP："
        '
        'CfrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(392, 273)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "CfrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GPS车载终端测试程序"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private UDP As Sockets.UdpClient
    Private Local, Remote As IPEndPoint
    Private thRecv As Thread
    Private intCmdType As Int16
    Private Sub CfrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub sRecv()
        Dim bytRecv(127) As Byte
        Dim bytGPS(15) As Byte
        Dim dGPS(1) As Double
        Dim int64GPS(1) As Int64
        Dim i, j As Byte
        Thread.CurrentThread.Sleep(200)
        bytRecv = UDP.Receive(Remote)
        If intCmdType = 0 Then
            For i = 0 To 127
                If bytRecv(i) = &H24 Then
                    Exit For
                End If
            Next
            For j = 0 To 15
                bytGPS(j) = bytRecv(i + j + 20)
            Next
            Buffer.BlockCopy(bytGPS, 0, dGPS, 0, 16)
            For i = 0 To 1
                int64GPS(i) = Int(dGPS(i) * 1000000000000000)
            Next
            txtGPS.Text = "北纬（千万亿分之一度）：" + int64GPS(0).ToString + vbCrLf + "东经（千万亿分之一度）：" + int64GPS(1).ToString
        End If
    End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Local = New IPEndPoint(Dns.GetHostByName(Dns.GetHostName).AddressList(0), Int16.Parse(txtPort.Text))
        Remote = New IPEndPoint(IPAddress.Parse(txtIP.Text), Int16.Parse(txtPort.Text))
        UDP = New Sockets.UdpClient(Local)
        UDP.Connect(Remote)
        txtIP.ReadOnly = True
        txtPort.ReadOnly = True
        txtSend.ReadOnly = False
        btnStart.Enabled = False
        btnStop.Enabled = True
        btnGPS.Enabled = True
        btnSend.Enabled = True
        MsgBox("开始工作成功", , "开始工作")
    End Sub

    Private Sub btnGPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGPS.Click
        Dim bytSend(5) As Byte
        Dim i As Byte
        bytSend(0) = &H23
        bytSend(1) = &H4F
        bytSend(2) = &H4B
        bytSend(3) = &H0
        bytSend(4) = &H9A
        bytSend(5) = &H24
        For i = 1 To 3
            intCmdType = 0
            thRecv = New Thread(AddressOf sRecv)
            thRecv.Start()
            UDP.Send(bytSend, 6)
            Thread.CurrentThread.Sleep(1000)
        Next i
        thRecv.Abort()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim bytCmd(32), bytSend(37) As Byte
        Dim intCheck As Int16
        Dim strSend As String
        Dim i As Int16
        strSend = txtSend.Text
        If strSend.Length > 32 Then
            MsgBox("发送长度过长", , "错误")
            Exit Sub
        End If
        For i = strSend.Length + 1 To 32
            strSend += " "
        Next
        bytCmd = System.Text.Encoding.ASCII.GetBytes(strSend)
        bytSend(0) = &H23
        bytSend(1) = Asc("M")
        bytSend(2) = Asc("0")
        Buffer.BlockCopy(bytCmd, 0, bytSend, 3, 32)
        intCheck = 0
        For i = 1 To 34
            intCheck += bytSend(i)
        Next
        bytSend(35) = intCheck \ 256
        bytSend(36) = intCheck Mod 256
        bytSend(37) = &H24
        intCmdType = 1
        thRecv = New Thread(AddressOf sRecv)
        thRecv.Start()
        UDP.Send(bytSend, 38)
        Thread.CurrentThread.Sleep(1000)
        thRecv.Abort()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        UDP.Close()
        btnStart.Enabled = True
        btnStop.Enabled = False
        btnGPS.Enabled = False
        btnSend.Enabled = False
        txtIP.ReadOnly = False
        txtPort.ReadOnly = False
        txtSend.ReadOnly = True
    End Sub

    Private Sub CfrmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        UDP.Close()
    End Sub
End Class
