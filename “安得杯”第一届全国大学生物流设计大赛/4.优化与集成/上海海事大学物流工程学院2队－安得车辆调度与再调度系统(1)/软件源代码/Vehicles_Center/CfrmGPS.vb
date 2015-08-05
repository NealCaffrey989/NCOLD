Imports Microsoft
Public Class CfrmGPS
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSetGPS As Vehicles_Center.DataSetGPS
    Friend WithEvents DBGGPS As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnStartGPS As System.Windows.Forms.Button
    Friend WithEvents btnStopGPS As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents tmrRefresh As System.Windows.Forms.Timer
    Friend WithEvents txtRefreshInterval As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CfrmGPS))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DBGGPS = New System.Windows.Forms.DataGrid
        Me.DataSetGPS = New Vehicles_Center.DataSetGPS
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRefreshInterval = New System.Windows.Forms.TextBox
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnStopGPS = New System.Windows.Forms.Button
        Me.btnStartGPS = New System.Windows.Forms.Button
        Me.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        CType(Me.DBGGPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetGPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DBGGPS)
        Me.GroupBox2.Location = New System.Drawing.Point(584, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 368)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "����������ƻ���Ϣ"
        '
        'DBGGPS
        '
        Me.DBGGPS.DataMember = "TranPlan"
        Me.DBGGPS.DataSource = Me.DataSetGPS
        Me.DBGGPS.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBGGPS.Location = New System.Drawing.Point(8, 24)
        Me.DBGGPS.Name = "DBGGPS"
        Me.DBGGPS.RowHeaderWidth = 15
        Me.DBGGPS.Size = New System.Drawing.Size(384, 336)
        Me.DBGGPS.TabIndex = 0
        Me.DBGGPS.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataSetGPS
        '
        Me.DataSetGPS.DataSetName = "DataSetGPS"
        Me.DataSetGPS.Locale = New System.Globalization.CultureInfo("zh-CN")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DBGGPS
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TranPlan"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.RowHeaderWidth = 15
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "�������"
        Me.DataGridTextBoxColumn1.MappingName = "VehicleNO"
        Me.DataGridTextBoxColumn1.Width = 90
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "��ǰλ��"
        Me.DataGridTextBoxColumn6.MappingName = "Location"
        Me.DataGridTextBoxColumn6.Width = 90
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "����ƻ����"
        Me.DataGridTextBoxColumn2.MappingName = "TranPlanNO"
        Me.DataGridTextBoxColumn2.Width = 90
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "���䶩�����"
        Me.DataGridTextBoxColumn3.MappingName = "TranOrderFormNO"
        Me.DataGridTextBoxColumn3.Width = 90
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Ŀ�ĵ�"
        Me.DataGridTextBoxColumn4.MappingName = "Destination"
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "�г�·��"
        Me.DataGridTextBoxColumn5.MappingName = "TransitRoute"
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtRefreshInterval)
        Me.GroupBox3.Controls.Add(Me.btnQuit)
        Me.GroupBox3.Controls.Add(Me.btnStopGPS)
        Me.GroupBox3.Controls.Add(Me.btnStartGPS)
        Me.GroupBox3.Location = New System.Drawing.Point(584, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 176)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GPS����"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "�Զ�ˢ��ʱ��������λ�����룬���32767��"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRefreshInterval
        '
        Me.txtRefreshInterval.Location = New System.Drawing.Point(24, 72)
        Me.txtRefreshInterval.Name = "txtRefreshInterval"
        Me.txtRefreshInterval.Size = New System.Drawing.Size(168, 21)
        Me.txtRefreshInterval.TabIndex = 3
        Me.txtRefreshInterval.Text = "5000"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(24, 128)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(352, 32)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "�˳�GPS��������"
        '
        'btnStopGPS
        '
        Me.btnStopGPS.Enabled = False
        Me.btnStopGPS.Location = New System.Drawing.Point(208, 64)
        Me.btnStopGPS.Name = "btnStopGPS"
        Me.btnStopGPS.Size = New System.Drawing.Size(168, 32)
        Me.btnStopGPS.TabIndex = 1
        Me.btnStopGPS.Text = "ֹͣGPS����"
        '
        'btnStartGPS
        '
        Me.btnStartGPS.Location = New System.Drawing.Point(208, 32)
        Me.btnStartGPS.Name = "btnStartGPS"
        Me.btnStartGPS.Size = New System.Drawing.Size(168, 32)
        Me.btnStartGPS.TabIndex = 0
        Me.btnStartGPS.Text = "��ʼGPS����"
        '
        'OleDbDataAdapter
        '
        Me.OleDbDataAdapter.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TranPlan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("VehicleNO", "VehicleNO"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("TranPlanNO", "TranPlanNO"), New System.Data.Common.DataColumnMapping("TranOrderFormNO", "TranOrderFormNO"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("LocationDescription", "LocationDescription"), New System.Data.Common.DataColumnMapping("TransitRoute", "TransitRoute"), New System.Data.Common.DataColumnMapping("Destination", "Destination")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT VehicleInfo.VehicleNO, TranPlan.VehicleNO AS Expr1, TranPlan.TranPlanNO, T" & _
        "ranPlan.TranOrderFormNO, VehicleInfo.Location, VehicleInfo.LocationDescription, " & _
        "TranPlan.TransitRoute, TranPlan.Destination FROM (TranPlan INNER JOIN VehicleInf" & _
        "o ON TranPlan.VehicleNO = VehicleInfo.VehicleNO) ORDER BY VehicleInfo.VehicleNO"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""C:\Vehicles_Center.mdb"";" & _
        "Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=" & _
        """Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extende" & _
        "d Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Cr" & _
        "eate System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLED" & _
        "B:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=" & _
        "False"
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 5000
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "��ǰλ������"
        Me.DataGridTextBoxColumn7.MappingName = "LocationDescription"
        Me.DataGridTextBoxColumn7.Width = 360
        '
        'CfrmGPS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(992, 573)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CfrmGPS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GPS��������"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DBGGPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetGPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private WithEvents Btns As New CMappoints(Me) '��ť�ؼ��飬������ʾ�ڵ�
    Private WithEvents Labels As New CMapRoads(Me) '��ǩ�ؼ��飬������ʾ��·��Ϣ
    Private intMap(8, 8), intInfo(8, 8) As Int16 '��ͼ���󣬵�ͼ��Ϣ����
    Private intPointsNumber, intRoadsNumber As Int16 '��ͼ�ڵ�������ͼ��·��
    Private intNowLabelNumber As Int16 '��ǰѡ�еı�ǩ�ڿؼ����еı��
    Private blDraw As Boolean '�Ƿ����ڻ��Ƶ�·��־
    Private intDrawPointNumber1, intDrawPointNumber2 As Int16 '��·���˵İ�ť�ؼ����
    Private strPointName(7) As String '��ͼ�ڵ�����
    Private strFileName As String '��ͼ�����ļ�·�����ļ���
    Private Truck(7) As System.Windows.Forms.PictureBox
    Private TruckNo(7) As System.Windows.Forms.Label
    Private TruckInfo(7) As String
    Protected Overrides Sub onPaint(ByVal e As System.Windows.Forms.PaintEventArgs) '����OnPaint���������ڻ��Ƶ�·
        Dim Pen As New Pen(Color.Red)
        Dim i, j As Int16
        Pen.Width = 3 '���û��ʿ��
        '���ݵ�ͼ������Ƶ�ͼ��·
        For i = 0 To 7
            For j = i To 7
                If intMap(i, j) <> 0 Then
                    e.Graphics.DrawLine(Pen, Btns.Item(i).Left + 20, Btns.Item(i).Top + 20, Btns.Item(j).Left + 20, Btns.Item(j).Top + 20)
                End If
            Next
        Next
    End Sub

    Private Sub CfrmCreateMap_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        frmMain.Enabled = True
    End Sub
    Private Sub CfrmCreateMap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '�����������Զ����ص�ͼ
        Dim i As Int16
        If GstrFileName <> "" Then
            sLoadMap(GstrFileName)
        End If
        For i = 0 To 7
            Truck(i) = New System.Windows.Forms.PictureBox
            TruckNo(i) = New System.Windows.Forms.Label
            Me.Controls.Add(Truck(i))
            Me.Controls.Add(TruckNo(i))
            Truck(i).Visible = False
            TruckNo(i).Visible = False
            Truck(i).Top = 100
            Truck(i).Left = 100
            Truck(i).Height = 20
            Truck(i).Width = 30
            Truck(i).SizeMode = PictureBoxSizeMode.StretchImage
            Truck(i).Image = System.Drawing.Image.FromFile(Application.StartupPath + "\truck.ico")
            TruckNo(i).Top = Truck(i).Top - 10
            TruckNo(i).Left = Truck(i).Left
            TruckNo(i).Height = 10
            TruckNo(i).Width = 30
            TruckNo(i).Text = i.ToString
            TruckNo(i).TextAlign = ContentAlignment.MiddleCenter
        Next
        OleDbDataAdapter.Fill(DataSetGPS)
    End Sub
    Private Sub sLoadMap(ByVal FileName As String) '��ȡ��ͼ����
        Dim i, j As Int16
        Dim strBackground As String
        Btns.ClearAll()
        Labels.ClearAll()
        FileOpen(1, FileName, OpenMode.Input, OpenAccess.Read, OpenShare.Shared, -1)
        '��ȡ�ڵ������·��
        Input(1, intPointsNumber)
        Input(1, intRoadsNumber)
        '��ȡ����
        For i = 0 To intPointsNumber - 1
            For j = 0 To intPointsNumber - 1
                Input(1, intMap(i, j))
            Next
        Next
        For i = 0 To intPointsNumber - 1
            For j = 0 To intPointsNumber - 1
                Input(1, intInfo(i, j))
            Next
        Next
        '��ȡ�ؼ���Ϣ������·��ڵ���Ϣ��
        For i = 0 To intPointsNumber - 1
            Btns.AddItem(100, 100)
            Input(1, Btns.Item(i).Text)
            strPointName(i) = Btns.Item(i).Text
            Input(1, Btns.Item(i).Left)
            Input(1, Btns.Item(i).Top)
        Next
        For i = 0 To intRoadsNumber - 1
            Labels.AddItem(100, 100, "")
            Input(1, Labels.Item(i).Text)
            Input(1, Labels.Item(i).Left)
            Input(1, Labels.Item(i).Top)
            Labels.Item(i).Visible = False
        Next
        strBackground = FileName
        strBackground = VisualBasic.Left(strBackground, strBackground.Length - 3) + "jpg"
        Me.BackgroundImage = System.Drawing.Image.FromFile(strBackground)
        FileClose(1)
        Me.Refresh()
        MsgBox("��ȡ��ͼ�ɹ�", , "��ȡ��ͼ")
        strFileName = FileName
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnStartGPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartGPS.Click
        btnStartGPS.Enabled = False
        txtRefreshInterval.ReadOnly = True
        btnStopGPS.Enabled = True
        '����GPS����
        tmrRefresh.Interval = Int16.Parse(txtRefreshInterval.Text)
        tmrRefresh.Enabled = True
    End Sub

    Private Sub btnStopGPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopGPS.Click
        btnStartGPS.Enabled = True
        txtRefreshInterval.ReadOnly = False
        btnStopGPS.Enabled = False
        '�ر�GPS����
        tmrRefresh.Enabled = False
    End Sub

    Private Sub tmrRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefresh.Tick
        Dim i, j As Int16
        Dim VehiclesNumber As Int16
        Dim LastVehiclesNO, VehiclesNO As Int16
        Dim strLocation, strLocationDescription As String
        Dim X, Y As Int16
        DataSetGPS.Clear()
        LastVehiclesNO = -1
        VehiclesNumber = 0
        OleDbDataAdapter.Fill(DataSetGPS)
        For i = 0 To DataSetGPS.Tables(0).Rows.Count - 1
            VehiclesNO = DataSetGPS.Tables(0).Rows(i).Item("VehicleNO")
            If VehiclesNO <> LastVehiclesNO Then
                LastVehiclesNO = VehiclesNO
                If Not DataSetGPS.Tables(0).Rows(i).IsNull("Location") Then
                    strLocation = DataSetGPS.Tables(0).Rows(i).Item("Location")
                    If Not DataSetGPS.Tables(0).Rows(i).IsNull("LocationDescription") Then
                        strLocationDescription = DataSetGPS.Tables(0).Rows(i).Item("LocationDescription")
                    Else
                        strLocationDescription = "������Ϣ"
                    End If
                    For j = 1 To strLocation.Length
                        If Mid(strLocation, j, 1) = "," Then
                            Exit For
                        End If
                    Next
                    If j < strLocation.Length Then
                        X = Int16.Parse(VisualBasic.Left(strLocation, j - 1))
                        Y = Int16.Parse(VisualBasic.Right(strLocation, strLocation.Length - j))
                        Truck(VehiclesNumber).Left = X
                        Truck(VehiclesNumber).Top = Y
                        TruckNo(VehiclesNumber).Top = Truck(VehiclesNumber).Top - 10
                        TruckNo(VehiclesNumber).Left = Truck(VehiclesNumber).Left
                        TruckNo(VehiclesNumber).Text = VehiclesNO.ToString
                        Truck(VehiclesNumber).Visible = True
                        TruckNo(VehiclesNumber).Visible = True
                        TruckInfo(VehiclesNumber) = strLocationDescription
                        VehiclesNumber += 1
                    End If
                End If
            End If
        Next
    End Sub
End Class

