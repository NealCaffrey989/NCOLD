Imports dao
Imports Microsoft
Public Class CfrmTranPlan
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
    Friend WithEvents DBGTranPlan As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStartVehiclesNumber As System.Windows.Forms.Button
    Friend WithEvents btnStartTranRoute As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSetTranPlan As Vehicles_Center.DataSetTranPlan
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSavePlan As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnAutoRefresh As System.Windows.Forms.Button
    Friend WithEvents tmrAutoRefresh As System.Windows.Forms.Timer
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CfrmTranPlan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DBGTranPlan = New System.Windows.Forms.DataGrid
        Me.DataSetTranPlan = New Vehicles_Center.DataSetTranPlan
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnStartTranRoute = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnStartVehiclesNumber = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnAutoRefresh = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnSavePlan = New System.Windows.Forms.Button
        Me.tmrAutoRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBGTranPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTranPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DBGTranPlan)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 456)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "运输计划清单"
        '
        'DBGTranPlan
        '
        Me.DBGTranPlan.DataMember = "TranPlan"
        Me.DBGTranPlan.DataSource = Me.DataSetTranPlan
        Me.DBGTranPlan.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBGTranPlan.Location = New System.Drawing.Point(0, 24)
        Me.DBGTranPlan.Name = "DBGTranPlan"
        Me.DBGTranPlan.Size = New System.Drawing.Size(768, 424)
        Me.DBGTranPlan.TabIndex = 0
        Me.DBGTranPlan.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataSetTranPlan
        '
        Me.DataSetTranPlan.DataSetName = "DataSetTranPlan"
        Me.DataSetTranPlan.Locale = New System.Globalization.CultureInfo("zh-CN")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DBGTranPlan
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TranPlan"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "运输计划编号"
        Me.DataGridTextBoxColumn1.MappingName = "TranPlanNO"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 90
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "运输订单编号"
        Me.DataGridTextBoxColumn2.MappingName = "TranOrderFormNO"
        Me.DataGridTextBoxColumn2.Width = 90
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "车辆编号"
        Me.DataGridTextBoxColumn3.MappingName = "VehicleNO"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "始发地"
        Me.DataGridTextBoxColumn6.MappingName = "InitialPlace"
        Me.DataGridTextBoxColumn6.Width = 45
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "目的地"
        Me.DataGridTextBoxColumn7.MappingName = "Destination"
        Me.DataGridTextBoxColumn7.Width = 45
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "运输路线"
        Me.DataGridTextBoxColumn8.MappingName = "TransitRoute"
        Me.DataGridTextBoxColumn8.Width = 120
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "运输总价"
        Me.DataGridTextBoxColumn10.MappingName = "TranCost"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = "yy-mm-dd hh:mm"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "出发时间"
        Me.DataGridTextBoxColumn4.MappingName = "DepartureTime"
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = "yy-mm-dd hh:mm"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "完成时间"
        Me.DataGridTextBoxColumn5.MappingName = "CmpltTime"
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "备注"
        Me.DataGridTextBoxColumn9.MappingName = "Note"
        Me.DataGridTextBoxColumn9.Width = 150
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnStartTranRoute)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnStartVehiclesNumber)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 472)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 96)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "自动生成计划"
        '
        'btnStartTranRoute
        '
        Me.btnStartTranRoute.Enabled = False
        Me.btnStartTranRoute.Location = New System.Drawing.Point(232, 56)
        Me.btnStartTranRoute.Name = "btnStartTranRoute"
        Me.btnStartTranRoute.Size = New System.Drawing.Size(200, 24)
        Me.btnStartTranRoute.TabIndex = 7
        Me.btnStartTranRoute.Text = "开始"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "第二步：自动计算最优路径"
        '
        'btnStartVehiclesNumber
        '
        Me.btnStartVehiclesNumber.Location = New System.Drawing.Point(16, 56)
        Me.btnStartVehiclesNumber.Name = "btnStartVehiclesNumber"
        Me.btnStartVehiclesNumber.Size = New System.Drawing.Size(200, 24)
        Me.btnStartVehiclesNumber.TabIndex = 1
        Me.btnStartVehiclesNumber.Text = "开始"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "第一步：自动计算所需车辆"
        '
        'OleDbDataAdapter
        '
        Me.OleDbDataAdapter.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TranPlan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CmpltTime", "CmpltTime"), New System.Data.Common.DataColumnMapping("DepartureTime", "DepartureTime"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("InitialPlace", "InitialPlace"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("TranCost", "TranCost"), New System.Data.Common.DataColumnMapping("TranOrderFormNO", "TranOrderFormNO"), New System.Data.Common.DataColumnMapping("TranPlanNO", "TranPlanNO"), New System.Data.Common.DataColumnMapping("TransitRoute", "TransitRoute"), New System.Data.Common.DataColumnMapping("VehicleNO", "VehicleNO")})})
        Me.OleDbDataAdapter.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbConnection
        '
        Me.OleDbConnection.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""C:\Vehicles_Center.mdb"";" & _
        "Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=" & _
        """Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extende" & _
        "d Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Cr" & _
        "eate System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLED" & _
        "B:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=" & _
        "False"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAutoRefresh)
        Me.GroupBox3.Controls.Add(Me.btnQuit)
        Me.GroupBox3.Controls.Add(Me.btnSavePlan)
        Me.GroupBox3.Location = New System.Drawing.Point(456, 472)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 96)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "操作"
        '
        'btnAutoRefresh
        '
        Me.btnAutoRefresh.Location = New System.Drawing.Point(192, 24)
        Me.btnAutoRefresh.Name = "btnAutoRefresh"
        Me.btnAutoRefresh.Size = New System.Drawing.Size(128, 24)
        Me.btnAutoRefresh.TabIndex = 13
        Me.btnAutoRefresh.Text = "自动刷新"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(16, 64)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(304, 24)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "退出运输计划"
        '
        'btnSavePlan
        '
        Me.btnSavePlan.Location = New System.Drawing.Point(16, 24)
        Me.btnSavePlan.Name = "btnSavePlan"
        Me.btnSavePlan.Size = New System.Drawing.Size(128, 24)
        Me.btnSavePlan.TabIndex = 11
        Me.btnSavePlan.Text = "保存计划至数据库"
        '
        'tmrAutoRefresh
        '
        Me.tmrAutoRefresh.Interval = 3000
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CmpltTime, DepartureTime, Destination, InitialPlace, [Note], TranCost, Tra" & _
        "nOrderFormNO, TranPlanNO, TransitRoute, VehicleNO FROM TranPlan"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO TranPlan(CmpltTime, DepartureTime, Destination, InitialPlace, [Note]," & _
        " TranCost, TranOrderFormNO, TransitRoute, VehicleNO) VALUES (?, ?, ?, ?, ?, ?, ?" & _
        ", ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, "CmpltTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DepartureTime", System.Data.OleDb.OleDbType.VarWChar, 64, "DepartureTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.VarWChar, 16, "Destination"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "InitialPlace"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TranCost", System.Data.OleDb.OleDbType.Integer, 0, "TranCost"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TranOrderFormNO", System.Data.OleDb.OleDbType.Integer, 0, "TranOrderFormNO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TransitRoute", System.Data.OleDb.OleDbType.VarWChar, 64, "TransitRoute"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, "VehicleNO"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE TranPlan SET CmpltTime = ?, DepartureTime = ?, Destination = ?, InitialPla" & _
        "ce = ?, [Note] = ?, TranCost = ?, TranOrderFormNO = ?, TransitRoute = ?, Vehicle" & _
        "NO = ? WHERE (TranOrderFormNO = ?) AND (TranPlanNO = ?) AND (VehicleNO = ?) AND " & _
        "(CmpltTime = ? OR ? IS NULL AND CmpltTime IS NULL) AND (DepartureTime = ? OR ? I" & _
        "S NULL AND DepartureTime IS NULL) AND (Destination = ? OR ? IS NULL AND Destinat" & _
        "ion IS NULL) AND (InitialPlace = ? OR ? IS NULL AND InitialPlace IS NULL) AND ([" & _
        "Note] = ? OR ? IS NULL AND [Note] IS NULL) AND (TranCost = ? OR ? IS NULL AND Tr" & _
        "anCost IS NULL) AND (TransitRoute = ? OR ? IS NULL AND TransitRoute IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, "CmpltTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DepartureTime", System.Data.OleDb.OleDbType.VarWChar, 64, "DepartureTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.VarWChar, 16, "Destination"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "InitialPlace"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TranCost", System.Data.OleDb.OleDbType.Integer, 0, "TranCost"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TranOrderFormNO", System.Data.OleDb.OleDbType.Integer, 0, "TranOrderFormNO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TransitRoute", System.Data.OleDb.OleDbType.VarWChar, 64, "TransitRoute"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, "VehicleNO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranOrderFormNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranOrderFormNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranPlanNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranPlanNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VehicleNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DepartureTime", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepartureTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DepartureTime1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepartureTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranCost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranCost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranCost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranCost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TransitRoute", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TransitRoute", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TransitRoute1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TransitRoute", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM TranPlan WHERE (TranOrderFormNO = ?) AND (TranPlanNO = ?) AND (Vehicl" & _
        "eNO = ?) AND (CmpltTime = ? OR ? IS NULL AND CmpltTime IS NULL) AND (DepartureTi" & _
        "me = ? OR ? IS NULL AND DepartureTime IS NULL) AND (Destination = ? OR ? IS NULL" & _
        " AND Destination IS NULL) AND (InitialPlace = ? OR ? IS NULL AND InitialPlace IS" & _
        " NULL) AND ([Note] = ? OR ? IS NULL AND [Note] IS NULL) AND (TranCost = ? OR ? I" & _
        "S NULL AND TranCost IS NULL) AND (TransitRoute = ? OR ? IS NULL AND TransitRoute" & _
        " IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranOrderFormNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranOrderFormNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranPlanNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranPlanNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VehicleNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DepartureTime", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepartureTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DepartureTime1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepartureTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranCost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranCost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranCost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranCost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TransitRoute", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TransitRoute", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TransitRoute1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TransitRoute", System.Data.DataRowVersion.Original, Nothing))
        '
        'CfrmTranPlan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CfrmTranPlan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "运输计划"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DBGTranPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTranPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '一些数据库操作对象
    Private dbDs As New DAO.DBEngine
    Private dbWs As DAO.Workspace
    Private dbDb As DAO.Database
    Private rsVehicles, rsTranOrderForms As DAO.Recordset

    Private Sub CfrmTranPlan_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        frmMain.Enabled = True
    End Sub

    Private Sub btnStartVehiclesNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartVehiclesNumber.Click
        Dim i, j, k, m, n, Temp1, Temp2 As Int16
        Dim intVehiclesNumber, intVehicleNO(15), intVehicleCap(15) As Int16
        Dim intGoodsNumber, intGoodsNO(31), intGoodsQuantity(31), intGoodsTotal As Int16
        Dim strGoodsInitialPlace(31), strGoodsDestination(31) As String
        Dim dbstr As String
        Dim PointName As String
        Dim dataRow As Data.DataRow
        dbWs = dbDs.Workspaces(0)
        dbDb = dbWs.OpenDatabase("C:\Vehicles_Center.mdb", False, False)
        For i = 0 To GintPointsNumber - 1
            '读取车辆和货物并排序
            PointName = GstrPointName(i)
            dbstr = "select * from VehicleInfo Where OwnershipPlace=""" + PointName + """ And IdleSymbol=True Order By BstBearingCap"
            rsVehicles = dbDb.OpenRecordset(dbstr, DAO.RecordsetTypeEnum.dbOpenDynaset)
            dbstr = "select * from TranOrderForm Where InitialPlace=""" + PointName + """ Order By TotalQuantity"
            rsTranOrderForms = dbDb.OpenRecordset(dbstr, DAO.RecordsetTypeEnum.dbOpenDynaset)
            intVehiclesNumber = 0
            intGoodsNumber = 0
            While (Not rsVehicles.EOF)
                intVehicleNO(intVehiclesNumber) = rsVehicles.Fields("VehicleNO").Value
                intVehicleCap(intVehiclesNumber) = rsVehicles.Fields("BstBearingCap").Value
                rsVehicles.MoveNext()
                intVehiclesNumber += 1
            End While
            intGoodsTotal = 0
            While (Not rsTranOrderForms.EOF)
                intGoodsNO(intGoodsNumber) = rsTranOrderForms.Fields("TranOrderFormNO").Value
                intGoodsQuantity(intGoodsNumber) = rsTranOrderForms.Fields("TotalQuantity").Value
                strGoodsInitialPlace(intGoodsNumber) = rsTranOrderForms.Fields("InitialPlace").Value
                strGoodsDestination(intGoodsNumber) = rsTranOrderForms.Fields("Destination").Value
                intGoodsTotal += intGoodsQuantity(intGoodsNumber)
                rsTranOrderForms.MoveNext()
                intGoodsNumber += 1
            End While
            '贪心法装货
            Do
                For j = 0 To intVehiclesNumber - 1
                    If intVehicleCap(j) >= intGoodsTotal Then
                        For k = 0 To intGoodsNumber - 1
                            If intGoodsQuantity(k) > 0 Then
                                '保存结果
                                dataRow = DataSetTranPlan.Tables(0).NewRow
                                dataRow.Item("TranOrderFormNO") = intGoodsNO(k)
                                dataRow.Item("InitialPlace") = strGoodsInitialPlace(k)
                                dataRow.Item("Destination") = strGoodsDestination(k)
                                dataRow.Item("VehicleNO") = intVehicleNO(j)
                                DataSetTranPlan.Tables(0).Rows.Add(dataRow)
                                intGoodsTotal = intGoodsTotal - intGoodsQuantity(k)
                                intGoodsQuantity(k) = 0
                            End If
                        Next
                        Exit For
                    End If
                Next
                If Not intGoodsTotal = 0 Then
                    For j = 0 To intGoodsNumber - 1
                        If intGoodsQuantity(j) > 0 Then
                            For k = 0 To intVehiclesNumber - 1
                                If intVehicleCap(k) >= intGoodsQuantity(j) Then
                                    intVehicleCap(k) -= intGoodsQuantity(j)
                                    intGoodsTotal = intGoodsTotal - intGoodsQuantity(j)
                                    intGoodsQuantity(j) = 0
                                    '保存结果
                                    dataRow = DataSetTranPlan.Tables(0).NewRow
                                    dataRow.Item("TranOrderFormNO") = intGoodsNO(j)
                                    dataRow.Item("InitialPlace") = strGoodsInitialPlace(j)
                                    dataRow.Item("Destination") = strGoodsDestination(j)
                                    dataRow.Item("VehicleNO") = intVehicleNO(k)
                                    DataSetTranPlan.Tables(0).Rows.Add(dataRow)
                                    '+++++++++++++++++
                                    rsVehicles.MoveFirst()
                                    rsVehicles.FindFirst("VehicleNO=" + intVehicleNO(k).ToString)
                                    rsVehicles.Edit()
                                    If Not rsVehicles.EOF Then
                                        rsVehicles.Fields("IdleSymbol").Value = False
                                        rsVehicles.Update()
                                    End If
                                    '+++++++++++++++++
                                    '重新排序
                                    Temp1 = intVehicleCap(k)
                                    Temp2 = intVehicleNO(k)
                                    For m = 0 To k
                                        If intVehicleCap(m) >= Temp1 Then Exit For
                                    Next
                                    For n = k To m + 1 Step -1
                                        intVehicleCap(n) = intVehicleCap(n - 1)
                                        intVehicleNO(n) = intVehicleNO(n - 1)
                                    Next
                                    intVehicleCap(m) = Temp1
                                    intVehicleNO(m) = Temp2
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
            Loop Until intGoodsTotal = 0
        Next
        btnStartVehiclesNumber.Enabled = False
        btnStartTranRoute.Enabled = True
    End Sub

    Private Sub btnStartTranRoute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartTranRoute.Click
        Dim dv As DataView
        Dim DataRow, DataRowTemp As DataRow
        Dim i, j, intVehicleNO, intRowsdiffCar(15), intVehiclesNumber As Int16
        Dim Points(15), GotPoints(15), GotPointsOK(15), GotPointsNumberOK, PointsNumber As Int16
        Dim Cost As Int64
        Dim strVehiclePoint, strVehiclePoints, strRoute As String
        Dim FinishedOne As Boolean
        dv = DataSetTranPlan.Tables(0).DefaultView
        dv.Sort = "VehicleNO"
        intVehiclesNumber = 1
        intRowsdiffCar(0) = 0
        intVehicleNO = dv.Table.Rows(0).Item("VehicleNO")
        For i = 1 To dv.Count - 1
            If intVehicleNO <> dv.Table.Rows(i).Item("VehicleNO") Then
                intVehicleNO = dv.Table.Rows(i).Item("VehicleNO")
                intRowsdiffCar(intVehiclesNumber) = i
                intVehiclesNumber += 1
            End If
        Next
        intRowsdiffCar(intVehiclesNumber) = dv.Count
        intVehiclesNumber += 1
        For i = 0 To intVehiclesNumber - 2
            '读取车子
            intVehicleNO = dv.Table.Rows(intRowsdiffCar(i)).Item("VehicleNO")
            strVehiclePoint = dv.Table.Rows(intRowsdiffCar(i)).Item("InitialPlace")
            strVehiclePoints = ""
            For j = intRowsdiffCar(i) To intRowsdiffCar(i + 1) - 1
                DataRow = dv.Table.Rows(j)
                strVehiclePoints += DataRow.Item("Destination") + ";"
            Next
            '进行优化计算
            PointsFinder(strVehiclePoints, Points, PointsNumber)
            Cost = Cost.MaxValue
            '调用回溯算法
            strRoute = RouteFinder(GotPointsOK, GotPointsNumberOK, Cost, Points, PointsNumber, PointFinder(strVehiclePoint), PointFinder(strVehiclePoint), PointFinder(strVehiclePoint), GotPoints, -1)
            strRoute = ""
            For j = 0 To GotPointsNumberOK
                strRoute += "-" + GstrPointName(GotPointsOK(j)).ToString
            Next
            strRoute = strVehiclePoint + strRoute
            For j = 0 To DataSetTranPlan.Tables(0).Rows.Count - 1
                DataRowTemp = DataSetTranPlan.Tables(0).Rows(j)
                If DataRowTemp.Item("VehicleNO") = intVehicleNO Then
                    DataRowTemp.BeginEdit()
                    DataRowTemp.Item("TransitRoute") = strRoute
                    DataRowTemp.Item("TranCost") = Cost
                    DataRowTemp.EndEdit()
                End If
            Next
        Next
        btnStartTranRoute.Enabled = False
    End Sub
    Private Sub PointsFinder(ByVal strVehiclePoints As String, ByRef Points() As Int16, ByRef PointsNumber As Int16) '批量将节点名称转换成节电在控件组中的编号
        Dim i, Begin, j As Int16
        Dim Temp As String
        Dim HaveOne As Boolean
        PointsNumber = 0
        Begin = 0
        For i = 2 To strVehiclePoints.Length
            If VisualBasic.Mid(strVehiclePoints, i, 1) = ";" Then
                Temp = VisualBasic.Mid(strVehiclePoints, Begin + 1, i - Begin - 1)
                Begin = i
                HaveOne = False
                For j = 0 To PointsNumber - 1
                    If Points(j) = PointFinder(Temp) Then
                        HaveOne = True
                        Exit For
                    End If
                Next
                If Not HaveOne Then
                    Points(PointsNumber) = PointFinder(Temp)
                    PointsNumber += 1
                End If
            End If
        Next
    End Sub
    Private Function PointFinder(ByVal strVehiclePoint As String) As Int16 '将节点名称转换成节电在控件组中的编号
        Dim i As Int16
        For i = 0 To GintPointsNumber - 1
            If GstrPointName(i) = strVehiclePoint Then
                Return (i)
            End If
        Next
    End Function
    Private Sub SmallBig(ByRef x As Int16, ByRef y As Int16)
        Dim Temp As Int16
        If x > y Then
            Temp = x
            x = y
            y = Temp
        End If
    End Sub
    Private Sub BigSmall(ByRef x As Int16, ByRef y As Int16)
        Dim Temp As Int16
        If x < y Then
            Temp = x
            x = y
            y = Temp
        End If
    End Sub
    Private Function RouteFinder(ByRef GotPointsOK() As Int16, ByRef GotPointsNumberOK As Int16, ByRef Cost As Int64, ByVal Points() As Int16, ByVal PointsNumber As Int16, _
    ByVal StartPoint As Int16, ByVal LastPoint As Int16, ByVal Point As Int16, ByVal GotPoints() As Int16, ByVal Depth As Int16) As String '回溯算法实现部分
        Dim GotAllPoints, OK, HaveGot As Boolean
        Dim i, j As Int16
        Dim x1, y1, x2, y2 As Int16
        Dim TempCost As Int64
        '判断是否满足条件
        '所有要求结点全部抵达
        OK = True
        If Depth >= 0 Then
            For i = 0 To PointsNumber - 1
                GotAllPoints = False
                For j = 0 To Depth
                    If GotPoints(j) = Points(i) Then
                        GotAllPoints = True
                        Exit For
                    End If
                Next
                If Not GotAllPoints Then
                    OK = False
                    Exit For
                End If
            Next
        Else
            OK = False
        End If
        '计算总价
        If OK Then
            x1 = StartPoint
            x2 = StartPoint
            y1 = GotPoints(0)
            y2 = GotPoints(0)
            BigSmall(x1, y1)
            SmallBig(x2, y2)
            TempCost = GintMap(x1, y1) * GintInfo(x2, y2)
            For i = 1 To Depth
                x1 = GotPoints(i - 1)
                x2 = GotPoints(i - 1)
                y1 = GotPoints(i)
                y2 = GotPoints(i)
                BigSmall(x1, y1)
                SmallBig(x2, y2)
                TempCost += GintMap(x1, y1) * GintInfo(x2, y2)
            Next
        End If
        If Not OK Then
            '递归
            For i = 0 To GintPointsNumber
                HaveGot = False
                For j = 0 To Depth
                    If i = GotPoints(j) Or i = StartPoint Then
                        HaveGot = True
                        Exit For
                    End If
                Next
                x1 = i
                y1 = Point
                SmallBig(x1, y1)
                If GintMap(x1, y1) > 0 And i <> LastPoint And Depth < GintPointsNumber * 2 And (Not HaveGot) Then
                    GotPoints(Depth + 1) = i
                    RouteFinder(GotPointsOK, GotPointsNumberOK, Cost, Points, PointsNumber, StartPoint, Point, i, GotPoints, Depth + 1)
                End If
            Next
        Else
            '最优解保存
            If TempCost < Cost Then
                Cost = TempCost
                For i = 0 To Depth
                    GotPointsOK(i) = GotPoints(i)
                Next
                GotPointsNumberOK = Depth
            End If
        End If
    End Function

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnSavePlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePlan.Click
        OleDbDataAdapter.Update(DataSetTranPlan)
        DataSetTranPlan.AcceptChanges()
        DataSetTranPlan.Clear()
        OleDbDataAdapter.Fill(DataSetTranPlan)
        DBGTranPlan.Refresh()
        MsgBox("更新数据库成功", , "保存数据")
    End Sub

    Private Sub CfrmTranPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataSetTranPlan.Clear()
        OleDbDataAdapter.Fill(DataSetTranPlan)
    End Sub

    Private Sub tmrAutoRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutoRefresh.Tick
        CfrmTranPlan_Load(Nothing, Nothing)
    End Sub

    Private Sub btnAutoRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoRefresh.Click '自动刷新数据库变化
        If btnAutoRefresh.Text = "自动刷新" Then
            tmrAutoRefresh.Enabled = True
            btnAutoRefresh.Text = "关闭刷新"
        Else
            tmrAutoRefresh.Enabled = False
            btnAutoRefresh.Text = "自动刷新"
        End If
    End Sub
End Class
