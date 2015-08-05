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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnStopGPS As System.Windows.Forms.Button
    Friend WithEvents btnStartGPS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DBGGPS As System.Windows.Forms.DataGrid
    Friend WithEvents OleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSetVehicles As GPSSimulator.DataSetVehicles
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents OpenMap As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tmrRefresh As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
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
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DBGGPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnQuit)
        Me.GroupBox3.Controls.Add(Me.btnStopGPS)
        Me.GroupBox3.Controls.Add(Me.btnStartGPS)
        Me.GroupBox3.Location = New System.Drawing.Point(584, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 174)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GPS操作"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(24, 128)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(168, 32)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "退出GPS仿真"
        '
        'btnStopGPS
        '
        Me.btnStopGPS.Enabled = False
        Me.btnStopGPS.Location = New System.Drawing.Point(24, 80)
        Me.btnStopGPS.Name = "btnStopGPS"
        Me.btnStopGPS.Size = New System.Drawing.Size(168, 32)
        Me.btnStopGPS.TabIndex = 1
        Me.btnStopGPS.Text = "停止GPS仿真"
        '
        'btnStartGPS
        '
        Me.btnStartGPS.Location = New System.Drawing.Point(24, 32)
        Me.btnStartGPS.Name = "btnStartGPS"
        Me.btnStartGPS.Size = New System.Drawing.Size(168, 32)
        Me.btnStartGPS.TabIndex = 0
        Me.btnStartGPS.Text = "开始GPS仿真"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DBGGPS)
        Me.GroupBox2.Location = New System.Drawing.Point(584, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 368)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "车辆及运输计划信息"
        '
        'DBGGPS
        '
        Me.DBGGPS.DataMember = "VehicleInfo"
        Me.DBGGPS.DataSource = Me.DataSetVehicles
        Me.DBGGPS.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBGGPS.Location = New System.Drawing.Point(8, 24)
        Me.DBGGPS.Name = "DBGGPS"
        Me.DBGGPS.Size = New System.Drawing.Size(184, 336)
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
        Me.DataGridTextBoxColumn1.HeaderText = "车辆编号"
        Me.DataGridTextBoxColumn1.MappingName = "VehicleNO"
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "当前位置"
        Me.DataGridTextBoxColumn2.MappingName = "Location"
        Me.DataGridTextBoxColumn2.Width = 90
        '
        'OleDbDataAdapter
        '
        Me.OleDbDataAdapter.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VehicleInfo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("VehicleNO", "VehicleNO")})})
        Me.OleDbDataAdapter.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM VehicleInfo WHERE (VehicleNO = ?) AND (Location = ? OR ? IS NULL AND " & _
        "Location IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VehicleNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO VehicleInfo(Location) VALUES (?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Location", System.Data.OleDb.OleDbType.VarWChar, 16, "Location"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Location, VehicleNO FROM VehicleInfo"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE VehicleInfo SET Location = ? WHERE (VehicleNO = ?) AND (Location = ? OR ? " & _
        "IS NULL AND Location IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Location", System.Data.OleDb.OleDbType.VarWChar, 16, "Location"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VehicleNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        '
        'OpenMap
        '
        Me.OpenMap.Filter = "地图文件|*.Map"
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "GPS仿真器"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DBGGPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private WithEvents Btns As New CMappoints(Me) '按钮控件组，用于显示节点
    Private WithEvents Labels As New CMapRoads(Me) '标签控件组，用于显示道路信息
    Private intMap(8, 8), intInfo(8, 8) As Int16 '地图矩阵，地图信息矩阵
    Private intPointsNumber, intRoadsNumber As Int16 '地图节点数，地图道路数
    Private intNowLabelNumber As Int16 '当前选中的标签在控件组中的编号
    Private blRun As Boolean
    Private intDrawPointNumber1, intDrawPointNumber2 As Int16 '道路两端的按钮控件编号
    Private strPointName(7) As String '地图节点名称
    Private strFileName As String '地图交换文件路径与文件名
    Private intVehiclesNumber As Int16 = 0
    Private intVehicleNO(7) As Int16
    Private sgnVehicleBegin(7, 1), sgnVehicleEnd(7, 1), sgnVehicleNow(7, 1), sgnVehicleSetp(7, 1) As Single
    Private intTempx1, intTempy1, intTempx2, intTempy2 As Int16
    Protected Overrides Sub onPaint(ByVal e As System.Windows.Forms.PaintEventArgs) '重载OnPaint方法，用于绘制道路
        Dim Pen As New Pen(Color.Red)
        Dim i, j As Int16
        Pen.Width = 3 '设置画笔宽度
        '根据地图矩阵绘制地图道路
        For i = 0 To 7
            For j = i To 7
                If intMap(i, j) <> 0 Then
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
    End Sub
    Private Sub btns_Click(ByVal ItemNumber As Int16) Handles Btns.Click
        If Not blRun Then
            blRun = True
            intTempx1 = Btns(ItemNumber).Left
            intTempy1 = Btns(ItemNumber).Top
        Else
            intVehicleNO(intVehiclesNumber) = InputBox("请输入车辆编号", "GPS仿真")
            intTempx2 = Btns(ItemNumber).Left
            intTempy2 = Btns(ItemNumber).Top
            sgnVehicleBegin(intVehiclesNumber, 0) = intTempx1
            sgnVehicleBegin(intVehiclesNumber, 1) = intTempy1
            sgnVehicleEnd(intVehiclesNumber, 0) = intTempx2
            sgnVehicleEnd(intVehiclesNumber, 1) = intTempy2
            sgnVehicleNow(intVehiclesNumber, 0) = intTempx1
            sgnVehicleNow(intVehiclesNumber, 1) = intTempy1
            sgnVehicleSetp(intVehiclesNumber, 0) = (intTempx2 - intTempx1) / 250
            sgnVehicleSetp(intVehiclesNumber, 1) = (intTempy2 - intTempy1) / 250
            intVehiclesNumber += 1
            blRun = False
        End If
    End Sub
    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
    Private Sub sLoadMap(ByVal FileName As String) '读取地图函数
        Dim i, j As Int16
        Btns.ClearAll()
        Labels.ClearAll()
        FileOpen(1, FileName, OpenMode.Input, OpenAccess.Read, OpenShare.Shared, -1)
        '读取节点数与道路数
        Input(1, intPointsNumber)
        Input(1, intRoadsNumber)
        '读取矩阵
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
        '读取控件信息（即道路与节点信息）
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
        Next
        FileClose(1)
        Me.Refresh()
        MsgBox("读取地图成功", , "读取地图")
        strFileName = FileName
    End Sub

    Private Sub tmrRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefresh.Tick
        Dim i, j As Int16
        For i = 0 To DataSetVehicles.Tables(0).Rows.Count - 1
            For j = 0 To intVehiclesNumber - 1
                If intVehicleNO(j) = DataSetVehicles.Tables(0).Rows(i).Item("VehicleNO") Then
                    Exit For
                End If
            Next
            If j < intVehiclesNumber Then
                DataSetVehicles.Tables(0).Rows(i).BeginEdit()
                DataSetVehicles.Tables(0).Rows(i).Item("Location") = (Int(sgnVehicleNow(j, 0))).ToString + "," + (Int(sgnVehicleNow(j, 1))).ToString
                DataSetVehicles.Tables(0).Rows(i).EndEdit()
                sgnVehicleNow(j, 0) += sgnVehicleSetp(j, 0)
                sgnVehicleNow(j, 1) += sgnVehicleSetp(j, 1)
            End If
        Next
        OleDbDataAdapter.Update(DataSetVehicles)
        DataSetVehicles.AcceptChanges()
    End Sub

    Private Sub btnStartGPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartGPS.Click
        btnStartGPS.Enabled = False
        tmrRefresh.Enabled = True
        btnStopGPS.Enabled = True
    End Sub

    Private Sub btnStopGPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopGPS.Click
        btnStartGPS.Enabled = True
        tmrRefresh.Enabled = False
        btnStopGPS.Enabled = False
        intVehiclesNumber = 0
    End Sub
End Class
