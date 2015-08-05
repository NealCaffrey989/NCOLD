Public Class CfrmMain
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д dispose ����������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע��: ���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents MenuInfo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuMaps As System.Windows.Forms.MenuItem
    Friend WithEvents MenuVehicles As System.Windows.Forms.MenuItem
    Friend WithEvents MenuTransportationOrders As System.Windows.Forms.MenuItem
    Friend WithEvents MenuVehiclesCenter As System.Windows.Forms.MenuItem
    Friend WithEvents MenuTranPlan As System.Windows.Forms.MenuItem
    Friend WithEvents MenuSystem As System.Windows.Forms.MenuItem
    Friend WithEvents MenuExit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuGPSVehiclesMonitor As System.Windows.Forms.MenuItem
    Friend WithEvents MenuVehiclesControl As System.Windows.Forms.MenuItem
    Friend WithEvents MenuAbout As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CfrmMain))
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.MenuInfo = New System.Windows.Forms.MenuItem
        Me.MenuMaps = New System.Windows.Forms.MenuItem
        Me.MenuVehicles = New System.Windows.Forms.MenuItem
        Me.MenuTransportationOrders = New System.Windows.Forms.MenuItem
        Me.MenuVehiclesCenter = New System.Windows.Forms.MenuItem
        Me.MenuTranPlan = New System.Windows.Forms.MenuItem
        Me.MenuVehiclesControl = New System.Windows.Forms.MenuItem
        Me.MenuGPSVehiclesMonitor = New System.Windows.Forms.MenuItem
        Me.MenuSystem = New System.Windows.Forms.MenuItem
        Me.MenuAbout = New System.Windows.Forms.MenuItem
        Me.MenuExit = New System.Windows.Forms.MenuItem
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuInfo, Me.MenuVehiclesCenter, Me.MenuSystem})
        '
        'MenuInfo
        '
        Me.MenuInfo.Index = 0
        Me.MenuInfo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuMaps, Me.MenuVehicles, Me.MenuTransportationOrders})
        Me.MenuInfo.Text = "��Ϣ����"
        '
        'MenuMaps
        '
        Me.MenuMaps.Index = 0
        Me.MenuMaps.Text = "��ͼ����"
        '
        'MenuVehicles
        '
        Me.MenuVehicles.Index = 1
        Me.MenuVehicles.Text = "��������"
        '
        'MenuTransportationOrders
        '
        Me.MenuTransportationOrders.Index = 2
        Me.MenuTransportationOrders.Text = "���䶩������"
        '
        'MenuVehiclesCenter
        '
        Me.MenuVehiclesCenter.Index = 1
        Me.MenuVehiclesCenter.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuTranPlan, Me.MenuVehiclesControl, Me.MenuGPSVehiclesMonitor})
        Me.MenuVehiclesCenter.Text = "��������"
        '
        'MenuTranPlan
        '
        Me.MenuTranPlan.Enabled = False
        Me.MenuTranPlan.Index = 0
        Me.MenuTranPlan.Text = "����ƻ�"
        '
        'MenuVehiclesControl
        '
        Me.MenuVehiclesControl.Enabled = False
        Me.MenuVehiclesControl.Index = 1
        Me.MenuVehiclesControl.Text = "�����������Ӽ�ͨѶ"
        '
        'MenuGPSVehiclesMonitor
        '
        Me.MenuGPSVehiclesMonitor.Enabled = False
        Me.MenuGPSVehiclesMonitor.Index = 2
        Me.MenuGPSVehiclesMonitor.Text = "GPS�������"
        '
        'MenuSystem
        '
        Me.MenuSystem.Index = 2
        Me.MenuSystem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuAbout, Me.MenuExit})
        Me.MenuSystem.Text = "ϵͳ"
        '
        'MenuAbout
        '
        Me.MenuAbout.Index = 0
        Me.MenuAbout.Text = "����"
        '
        'MenuExit
        '
        Me.MenuExit.Index = 1
        Me.MenuExit.Text = "�˳�"
        '
        'CfrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(792, 553)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.Name = "CfrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "���ó����������ٵ���ϵͳ V1.0 DEMO"

    End Sub

#End Region

    Private Sub MenuMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMaps.Click
        frmMap = New CfrmMap
        frmMain.Enabled = False
        frmMap.Show()
    End Sub

    Private Sub MenuVehicles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVehicles.Click
        frmVehicles = New CfrmVehicles
        frmMain.Enabled = False
        frmVehicles.Show()
    End Sub

    Private Sub MenuTransportationOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTransportationOrders.Click
        frmTranOrderForms = New CfrmTranOrderForms
        frmMain.Enabled = False
        frmTranOrderForms.Show()
    End Sub

    Private Sub MenuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExit.Click
        Me.Close()
    End Sub

    Private Sub MenuTranPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTranPlan.Click
        frmTranPlan = New CfrmTranPlan
        frmTranPlan.Show()
    End Sub

    Private Sub MenuVehiclesControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVehiclesControl.Click
        frmVehiclesControl = New CfrmVehiclesControl
        frmVehiclesControl.Show()
    End Sub

    Private Sub MenuGPSVehiclesMonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuGPSVehiclesMonitor.Click
        frmGPS = New CfrmGPS
        frmGPS.Show()
    End Sub

    Private Sub CfrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAbout.Click
        frmAbout = New CfrmAbout
        frmMain.Enabled = False
        frmAbout.Show()
    End Sub
End Class
