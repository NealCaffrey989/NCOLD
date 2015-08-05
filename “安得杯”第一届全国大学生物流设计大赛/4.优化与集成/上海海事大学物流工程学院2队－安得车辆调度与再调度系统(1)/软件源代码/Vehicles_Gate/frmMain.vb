Imports System.Net
Public Class frmMain
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtVehicleNO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents LstStatus As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.txtVehicleNO = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSend = New System.Windows.Forms.Button
        Me.LstStatus = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "车辆中心IP："
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(224, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "车辆中心端口："
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(96, 16)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(120, 21)
        Me.txtIP.TabIndex = 2
        Me.txtIP.Text = ""
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(320, 16)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(64, 21)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = ""
        '
        'txtVehicleNO
        '
        Me.txtVehicleNO.Location = New System.Drawing.Point(96, 56)
        Me.txtVehicleNO.Name = "txtVehicleNO"
        Me.txtVehicleNO.Size = New System.Drawing.Size(120, 21)
        Me.txtVehicleNO.TabIndex = 4
        Me.txtVehicleNO.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "车辆编号："
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(304, 56)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(80, 24)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "告知中心"
        '
        'LstStatus
        '
        Me.LstStatus.Items.AddRange(New Object() {"出发", "返回"})
        Me.LstStatus.Location = New System.Drawing.Point(224, 56)
        Me.LstStatus.Name = "LstStatus"
        Me.LstStatus.Size = New System.Drawing.Size(72, 20)
        Me.LstStatus.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(392, 101)
        Me.Controls.Add(Me.LstStatus)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVehicleNO)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "仓库车辆监控"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim UDP As Sockets.UdpClient
        Dim Remote As IPEndPoint
        Dim bytSend(2) As Byte
        Remote = New IPEndPoint(IPAddress.Parse(txtIP.Text), Int16.Parse(txtPort.Text))
        UDP = New Sockets.UdpClient
        bytSend(0) = Int16.Parse(txtVehicleNO.Text) \ 256
        bytSend(1) = Int16.Parse(txtVehicleNO.Text) Mod 256
        bytSend(2) = LstStatus.SelectedIndex
        UDP.Send(bytSend, 3, Remote)
        UDP.Close()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LstStatus.SelectedIndex = 0
    End Sub
End Class
