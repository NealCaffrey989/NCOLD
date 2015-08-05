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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSettingOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRecv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemoteIP As System.Windows.Forms.TextBox
    Friend WithEvents txtRemotePort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLocalPort As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLocalPort = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRemotePort = New System.Windows.Forms.TextBox
        Me.btnSettingOK = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRemoteIP = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSend = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRecv = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLocalPort)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtRemotePort)
        Me.GroupBox1.Controls.Add(Me.btnSettingOK)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRemoteIP)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "设置"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "本地端口："
        '
        'txtLocalPort
        '
        Me.txtLocalPort.Location = New System.Drawing.Point(88, 56)
        Me.txtLocalPort.Name = "txtLocalPort"
        Me.txtLocalPort.Size = New System.Drawing.Size(72, 21)
        Me.txtLocalPort.TabIndex = 8
        Me.txtLocalPort.Text = "8386"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "远程端口："
        '
        'txtRemotePort
        '
        Me.txtRemotePort.Location = New System.Drawing.Point(280, 24)
        Me.txtRemotePort.Name = "txtRemotePort"
        Me.txtRemotePort.Size = New System.Drawing.Size(72, 21)
        Me.txtRemotePort.TabIndex = 6
        Me.txtRemotePort.Text = "8386"
        '
        'btnSettingOK
        '
        Me.btnSettingOK.Location = New System.Drawing.Point(16, 88)
        Me.btnSettingOK.Name = "btnSettingOK"
        Me.btnSettingOK.Size = New System.Drawing.Size(344, 24)
        Me.btnSettingOK.TabIndex = 5
        Me.btnSettingOK.Text = "设置确定"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "远程IP："
        '
        'txtRemoteIP
        '
        Me.txtRemoteIP.Location = New System.Drawing.Point(80, 24)
        Me.txtRemoteIP.Name = "txtRemoteIP"
        Me.txtRemoteIP.Size = New System.Drawing.Size(120, 21)
        Me.txtRemoteIP.TabIndex = 1
        Me.txtRemoteIP.Text = "127.0.0.1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSend)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSend)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtRecv)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 128)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "信息收发"
        '
        'btnSend
        '
        Me.btnSend.Enabled = False
        Me.btnSend.Location = New System.Drawing.Point(16, 96)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(344, 24)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "发送"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "发送信息："
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(80, 56)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(280, 21)
        Me.txtSend.TabIndex = 3
        Me.txtSend.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "收到信息："
        '
        'txtRecv
        '
        Me.txtRecv.Location = New System.Drawing.Point(80, 24)
        Me.txtRecv.Name = "txtRecv"
        Me.txtRecv.ReadOnly = True
        Me.txtRecv.Size = New System.Drawing.Size(280, 21)
        Me.txtRecv.TabIndex = 1
        Me.txtRecv.Text = ""
        '
        'CfrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(392, 273)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "CfrmMain"
        Me.Text = "UDPDebugger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private UDPClient As New Sockets.UdpClient '定义一个UDP的对象
    Private Local, Remote As IPEndPoint '定义本地和远程终端
    Private strLocalIp As String '本地IP
    Private thRecv As Thread '定义一个线程
    Private blthRecvRunning As Boolean '线程运行标志
    Private Sub CfrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strLocalIp = Dns.GetHostByName(Dns.GetHostName).AddressList(0).ToString '获取本机IP
    End Sub

    Private Sub btnSettingOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettingOK.Click
        Remote = New IPEndPoint(IPAddress.Parse(txtRemoteIP.Text), Int16.Parse(txtRemotePort.Text)) '远程终端
        Local = New IPEndPoint(IPAddress.Parse(strLocalIp), Int16.Parse(txtLocalPort.Text)) '本地终端
        UDPClient = New Sockets.UdpClient(Local) 'UDP对象
        MsgBox("设置成功", , "设置")
        thRecv = New Thread(AddressOf Recv) '接收数据线程对象
        blthRecvRunning = True
        thRecv.Start() '开始上述线程
        btnSend.Enabled = True
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim bytSend() As Byte
        bytSend = System.Text.Encoding.Default.GetBytes(txtSend.Text) '将发送字符串转换为字节数组
        UDPClient.Send(bytSend, bytSend.Length, Remote) '发送
    End Sub

    Private Sub Recv()
        Dim strRecv As String
        Dim bytRecv() As Byte
        Do
            bytRecv = UDPClient.Receive(Remote) '阻塞式接收
            strRecv = System.Text.Encoding.Default.GetString(bytRecv) '将接收到的字节数组转换为字符串
            txtRecv.Text = strRecv '显示接收到的数据
            Thread.CurrentThread.Sleep(100) '延时100ms
        Loop While blthRecvRunning
    End Sub

    Private Sub CfrmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If blthRecvRunning Then '如果接收线程活动，则关闭这条线程
            blthRecvRunning = False
            thRecv.Abort()
        End If
        UDPClient.Close() '关闭UDP
    End Sub
End Class
