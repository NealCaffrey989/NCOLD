Imports Microsoft
Imports System.Threading
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnStopGPS As System.Windows.Forms.Button
    Friend WithEvents btnStartGPS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DBGGPS As System.Windows.Forms.DataGrid
    Friend WithEvents OleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSetVehicles As GPSSimulator.DataSetVehicles
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents OpenMap As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnNewVehicle As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAcc As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtAcc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnNewVehicle = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnStopGPS = New System.Windows.Forms.Button
        Me.btnStartGPS = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DBGGPS = New System.Windows.Forms.DataGrid
        Me.DataSetVehicles = New GPSSimulator.DataSetVehicles
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OpenMap = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DBGGPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAcc)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnNewVehicle)
        Me.GroupBox3.Controls.Add(Me.btnQuit)
        Me.GroupBox3.Controls.Add(Me.btnStopGPS)
        Me.GroupBox3.Controls.Add(Me.btnStartGPS)
        Me.GroupBox3.Location = New System.Drawing.Point(584, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 254)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GPS����"
        '
        'txtAcc
        '
        Me.txtAcc.Location = New System.Drawing.Point(120, 96)
        Me.txtAcc.Name = "txtAcc"
        Me.txtAcc.Size = New System.Drawing.Size(72, 21)
        Me.txtAcc.TabIndex = 5
        Me.txtAcc.Text = "50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "������ٱ�����"
        '
        'btnNewVehicle
        '
        Me.btnNewVehicle.Location = New System.Drawing.Point(24, 32)
        Me.btnNewVehicle.Name = "btnNewVehicle"
        Me.btnNewVehicle.Size = New System.Drawing.Size(168, 32)
        Me.btnNewVehicle.TabIndex = 3
        Me.btnNewVehicle.Text = "�½�����"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(24, 208)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(168, 32)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "�˳�GPS����"
        '
        'btnStopGPS
        '
        Me.btnStopGPS.Enabled = False
        Me.btnStopGPS.Location = New System.Drawing.Point(24, 168)
        Me.btnStopGPS.Name = "btnStopGPS"
        Me.btnStopGPS.Size = New System.Drawing.Size(168, 32)
        Me.btnStopGPS.TabIndex = 1
        Me.btnStopGPS.Text = "ֹͣGPS����"
        '
        'btnStartGPS
        '
        Me.btnStartGPS.Location = New System.Drawing.Point(24, 128)
        Me.btnStartGPS.Name = "btnStartGPS"
        Me.btnStartGPS.Size = New System.Drawing.Size(168, 32)
        Me.btnStartGPS.TabIndex = 0
        Me.btnStartGPS.Text = "��ʼGPS����"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DBGGPS)
        Me.GroupBox2.Location = New System.Drawing.Point(584, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 288)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "����������ƻ���Ϣ"
        '
        'DBGGPS
        '
        Me.DBGGPS.DataMember = "VehicleInfo"
        Me.DBGGPS.DataSource = Me.DataSetVehicles
        Me.DBGGPS.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBGGPS.Location = New System.Drawing.Point(8, 24)
        Me.DBGGPS.Name = "DBGGPS"
        Me.DBGGPS.Size = New System.Drawing.Size(184, 256)
        Me.DBGGPS.TabIndex = 0
        Me.DBGGPS.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataSetVehicles
        '
        Me.DataSetVehicles.DataSetName = "DataSetVehicles"
        Me.DataSetVehicles.Locale = New System.Globalization.CultureInfo("zh-CN")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DBGGPS
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "VehicleInfo"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "�������"
        Me.DataGridTextBoxColumn1.MappingName = "VehicleNO"
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "��ǰλ��"
        Me.DataGridTextBoxColumn2.MappingName = "Location"
        Me.DataGridTextBoxColumn2.Width = 90
        '
        'OleDbDataAdapter
        '
        Me.OleDbDataAdapter.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VehicleInfo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("VehicleNO", "VehicleNO"), New System.Data.Common.DataColumnMapping("LocationDescription", "LocationDescription")})})
        Me.OleDbDataAdapter.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM VehicleInfo WHERE (VehicleNO = ?) AND (Location = ? OR ? IS NULL AND " & _
        "Location IS NULL) AND (LocationDescription = ? OR ? IS NULL AND LocationDescript" & _
        "ion IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VehicleNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LocationDescription", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LocationDescription", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LocationDescription1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LocationDescription", System.Data.DataRowVersion.Original, Nothing))
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
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO VehicleInfo(Location, LocationDescription) VALUES (?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Location", System.Data.OleDb.OleDbType.VarWChar, 16, "Location"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LocationDescription", System.Data.OleDb.OleDbType.VarWChar, 255, "LocationDescription"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Location, VehicleNO, LocationDescription FROM VehicleInfo"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE VehicleInfo SET Location = ?, LocationDescription = ? WHERE (VehicleNO = ?" & _
        ") AND (Location = ? OR ? IS NULL AND Location IS NULL) AND (LocationDescription " & _
        "= ? OR ? IS NULL AND LocationDescription IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Location", System.Data.OleDb.OleDbType.VarWChar, 16, "Location"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LocationDescription", System.Data.OleDb.OleDbType.VarWChar, 255, "LocationDescription"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VehicleNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LocationDescription", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LocationDescription", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LocationDescription1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LocationDescription", System.Data.DataRowVersion.Original, Nothing))
        '
        'OpenMap
        '
        Me.OpenMap.Filter = "��ͼ�ļ�|*.Map"
        '
        'CfrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "CfrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GPS������"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DBGGPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private WithEvents Btns As New CMappoints(Me) '��ť�ؼ��飬������ʾ�ڵ�
    Private WithEvents Labels As New CMapRoads(Me) '��ǩ�ؼ��飬������ʾ��·��Ϣ
    Private VehiclesNumber As Int16
    Private Vehicle(7) As CVehicles
    Private thRefresh As Thread
    Protected Overrides Sub onPaint(ByVal e As System.Windows.Forms.PaintEventArgs) '����OnPaint���������ڻ��Ƶ�·
        Dim Pen As New Pen(Color.Red)
        Dim i, j As Int16
        Pen.Width = 3 '���û��ʿ��
        '���ݵ�ͼ������Ƶ�ͼ��·
        For i = 0 To 7
            For j = i To 7
                If gintMap(i, j) <> 0 Then
                    e.Graphics.DrawLine(Pen, Btns.Item(i).Left + 20, Btns.Item(i).Top + 20, Btns.Item(j).Left + 20, Btns.Item(j).Top + 20)
                End If
            Next
        Next
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Do
            OpenMap.ShowDialog()
            If OpenMap.FileName <> "" Then
                sLoadMap(OpenMap.FileName)
            End If
        Loop Until OpenMap.FileName <> ""
        OleDbDataAdapter.Fill(DataSetVehicles)
        VehiclesNumber = 0
    End Sub
    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
    Private Sub sLoadMap(ByVal FileName As String) '��ȡ��ͼ����
        Dim i, j As Int16
        Dim strBackGroundFile As String
        Btns.ClearAll()
        Labels.ClearAll()
        FileOpen(1, FileName, OpenMode.Input, OpenAccess.Read, OpenShare.Shared, -1)
        '��ȡ�ڵ������·��
        Input(1, gintPointsNumber)
        Input(1, gintRoadsNumber)
        '��ȡ����
        For i = 0 To gintPointsNumber - 1
            For j = 0 To gintPointsNumber - 1
                Input(1, gintMap(i, j))
            Next
        Next
        For i = 0 To gintPointsNumber - 1
            For j = 0 To gintPointsNumber - 1
                Input(1, gintInfo(i, j))
            Next
        Next
        '��ȡ�ؼ���Ϣ������·��ڵ���Ϣ��
        For i = 0 To gintPointsNumber - 1
            Btns.AddItem(100, 100)
            Input(1, Btns.Item(i).Text)
            gstrPointName(i) = Btns.Item(i).Text
            Input(1, Btns.Item(i).Left)
            Input(1, Btns.Item(i).Top)
        Next
        For i = 0 To gintRoadsNumber - 1
            Labels.AddItem(100, 100, "")
            Input(1, Labels.Item(i).Text)
            Input(1, Labels.Item(i).Left)
            Input(1, Labels.Item(i).Top)
        Next
        strBackGroundFile = VisualBasic.Left(FileName, FileName.Length - 3)
        strBackGroundFile += "jpg"
        Me.BackgroundImage = System.Drawing.Image.FromFile(strBackGroundFile)
        FileClose(1)
        Me.Refresh()
        MsgBox("��ȡ��ͼ�ɹ�", , "��ȡ��ͼ")
        gstrFileName = FileName
    End Sub

    Private Sub btnStartGPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartGPS.Click
        Dim i As Int16
        btnStartGPS.Enabled = False
        btnStopGPS.Enabled = True
        For i = 0 To VehiclesNumber - 1
            Vehicle(i).StartRun()
        Next
        Thread.CurrentThread.Sleep(5000)
        gAcc = Int16.Parse(txtAcc.Text)
        thRefresh = New Thread(AddressOf sRefresh)
        thRefresh.Start()
    End Sub

    Private Sub btnStopGPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopGPS.Click
        Dim i As Int16
        For i = 0 To VehiclesNumber - 1
            Vehicle(i).stopRun()
            Vehicle(i) = Nothing
        Next
        thRefresh.Abort()
        thRefresh = Nothing
        btnStartGPS.Enabled = True
        btnStopGPS.Enabled = False

    End Sub

    Private Sub btnNewVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewVehicle.Click
        Vehicle(VehiclesNumber) = New CVehicles
        Vehicle(VehiclesNumber).No = Int16.Parse(InputBox("�����복�����", "�½�����"))
        Vehicle(VehiclesNumber).V = Int16.Parse(InputBox("�����복��", "�½�����"))
        Vehicle(VehiclesNumber).Route = InputBox("������·������ʽ���� DC-A-B", "�½�����")
        VehiclesNumber += 1
    End Sub

    Private Sub sRefresh()
        Dim i, j As Int16
        Dim strTemp As String
        Dim x, y As Int16
        Do
            For i = 0 To DataSetVehicles.Tables(0).Rows.Count - 1
                For j = 0 To VehiclesNumber - 1
                    If Vehicle(j).No = DataSetVehicles.Tables(0).Rows(i).Item("VehicleNO") Then
                        Exit For
                    End If
                Next
                If j < VehiclesNumber Then
                    x = Btns.Item(Vehicle(j).NowStartPoint).Location.X + Int((Btns.Item(Vehicle(j).NowEndPoint).Location.X - Btns.Item(Vehicle(j).NowStartPoint).Location.X) * Vehicle(j).NowFinishedRate)
                    y = Btns.Item(Vehicle(j).NowStartPoint).Location.Y + Int((Btns.Item(Vehicle(j).NowEndPoint).Location.Y - Btns.Item(Vehicle(j).NowStartPoint).Location.Y) * Vehicle(j).NowFinishedRate)
                    DataSetVehicles.Tables(0).Rows(i).BeginEdit()
                    DataSetVehicles.Tables(0).Rows(i).Item("Location") = x.ToString + "," + y.ToString
                    DataSetVehicles.Tables(0).Rows(i).Item("LocationDescription") = Vehicle(j).NowLocationDescription
                    DataSetVehicles.Tables(0).Rows(i).EndEdit()
                End If
            Next
            OleDbDataAdapter.Update(DataSetVehicles)
            DataSetVehicles.AcceptChanges()
            Thread.CurrentThread.Sleep(5000)
        Loop

    End Sub

End Class
