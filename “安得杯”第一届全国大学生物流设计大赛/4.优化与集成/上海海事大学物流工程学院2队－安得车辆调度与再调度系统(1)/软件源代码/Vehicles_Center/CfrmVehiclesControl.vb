Imports System.Threading
Imports System.Net
Imports Microsoft
Public Class CfrmVehiclesControl
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLocalPort As System.Windows.Forms.TextBox
    Friend WithEvents btnStartListen As System.Windows.Forms.Button
    Friend WithEvents btnStopListen As System.Windows.Forms.Button
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ClstVehicles As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnStartComm As System.Windows.Forms.Button
    Friend WithEvents btnStopComm As System.Windows.Forms.Button
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtRecv As System.Windows.Forms.TextBox
    Friend WithEvents OleDbDataAdapterVehicles As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSetVehicles As Vehicles_Center.DataSetVehicles
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents lstHistory As System.Windows.Forms.ListBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DataSetTranPlan As Vehicles_Center.DataSetTranPlan
    Friend WithEvents OleDbDataAdapterTranPlan As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDataAdapterTranOrderForm As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DataSetTranOrderForms As Vehicles_Center.DataSetTranOrderForms
    Friend WithEvents btnAccident As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CfrmVehiclesControl))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstHistory = New System.Windows.Forms.ListBox
        Me.btnStopListen = New System.Windows.Forms.Button
        Me.btnStartListen = New System.Windows.Forms.Button
        Me.txtLocalPort = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.OleDbDataAdapterTranPlan = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnAccident = New System.Windows.Forms.Button
        Me.txtRecv = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.txtSend = New System.Windows.Forms.TextBox
        Me.btnStopComm = New System.Windows.Forms.Button
        Me.btnStartComm = New System.Windows.Forms.Button
        Me.ClstVehicles = New System.Windows.Forms.CheckedListBox
        Me.OleDbDataAdapterVehicles = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.DataSetVehicles = New Vehicles_Center.DataSetVehicles
        Me.DataSetTranPlan = New Vehicles_Center.DataSetTranPlan
        Me.OleDbDataAdapterTranOrderForm = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.DataSetTranOrderForms = New Vehicles_Center.DataSetTranOrderForms
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataSetVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTranPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTranOrderForms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstHistory)
        Me.GroupBox1.Controls.Add(Me.btnStopListen)
        Me.GroupBox1.Controls.Add(Me.btnStartListen)
        Me.GroupBox1.Controls.Add(Me.txtLocalPort)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 272)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "进出货监控"
        '
        'lstHistory
        '
        Me.lstHistory.ItemHeight = 12
        Me.lstHistory.Location = New System.Drawing.Point(8, 64)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.ScrollAlwaysVisible = True
        Me.lstHistory.Size = New System.Drawing.Size(736, 184)
        Me.lstHistory.TabIndex = 8
        '
        'btnStopListen
        '
        Me.btnStopListen.Enabled = False
        Me.btnStopListen.Location = New System.Drawing.Point(528, 24)
        Me.btnStopListen.Name = "btnStopListen"
        Me.btnStopListen.Size = New System.Drawing.Size(112, 24)
        Me.btnStopListen.TabIndex = 7
        Me.btnStopListen.Text = "停止监听"
        '
        'btnStartListen
        '
        Me.btnStartListen.Location = New System.Drawing.Point(288, 24)
        Me.btnStartListen.Name = "btnStartListen"
        Me.btnStartListen.Size = New System.Drawing.Size(112, 24)
        Me.btnStartListen.TabIndex = 6
        Me.btnStartListen.Text = "开始监听"
        '
        'txtLocalPort
        '
        Me.txtLocalPort.Location = New System.Drawing.Point(96, 24)
        Me.txtLocalPort.Name = "txtLocalPort"
        Me.txtLocalPort.Size = New System.Drawing.Size(104, 21)
        Me.txtLocalPort.TabIndex = 5
        Me.txtLocalPort.Text = "8386"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "本地端口："
        '
        'OleDbDataAdapterTranPlan
        '
        Me.OleDbDataAdapterTranPlan.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapterTranPlan.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapterTranPlan.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapterTranPlan.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TranPlan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CmpltTime", "CmpltTime"), New System.Data.Common.DataColumnMapping("DepartureTime", "DepartureTime"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("InitialPlace", "InitialPlace"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("TranCost", "TranCost"), New System.Data.Common.DataColumnMapping("TranOrderFormNO", "TranOrderFormNO"), New System.Data.Common.DataColumnMapping("TranPlanNO", "TranPlanNO"), New System.Data.Common.DataColumnMapping("TransitRoute", "TransitRoute"), New System.Data.Common.DataColumnMapping("VehicleNO", "VehicleNO")})})
        Me.OleDbDataAdapterTranPlan.UpdateCommand = Me.OleDbUpdateCommand1
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
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
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
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""C:\Vehicles_Center.mdb"";Jet OLEDB:Engine Type=5;Provi" & _
        "der=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;per" & _
        "sist security info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Enc" & _
        "rypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy " & _
        "Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=A" & _
        "dmin;Jet OLEDB:Global Bulk Transactions=1"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO TranPlan(CmpltTime, DepartureTime, Destination, InitialPlace, [Note]," & _
        " TranCost, TranOrderFormNO, TransitRoute, VehicleNO) VALUES (?, ?, ?, ?, ?, ?, ?" & _
        ", ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
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
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CmpltTime, DepartureTime, Destination, InitialPlace, [Note], TranCost, Tra" & _
        "nOrderFormNO, TranPlanNO, TransitRoute, VehicleNO FROM TranPlan"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
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
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAccident)
        Me.GroupBox2.Controls.Add(Me.txtRecv)
        Me.GroupBox2.Controls.Add(Me.btnSend)
        Me.GroupBox2.Controls.Add(Me.txtSend)
        Me.GroupBox2.Controls.Add(Me.btnStopComm)
        Me.GroupBox2.Controls.Add(Me.btnStartComm)
        Me.GroupBox2.Controls.Add(Me.ClstVehicles)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 272)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "车辆通讯"
        '
        'btnAccident
        '
        Me.btnAccident.Enabled = False
        Me.btnAccident.Location = New System.Drawing.Point(640, 64)
        Me.btnAccident.Name = "btnAccident"
        Me.btnAccident.Size = New System.Drawing.Size(112, 24)
        Me.btnAccident.TabIndex = 6
        Me.btnAccident.Text = "意外处理"
        '
        'txtRecv
        '
        Me.txtRecv.Location = New System.Drawing.Point(288, 208)
        Me.txtRecv.Name = "txtRecv"
        Me.txtRecv.ReadOnly = True
        Me.txtRecv.Size = New System.Drawing.Size(464, 21)
        Me.txtRecv.TabIndex = 5
        Me.txtRecv.Text = "接收信息"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(664, 152)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(88, 24)
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "发送信息"
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(288, 152)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(360, 21)
        Me.txtSend.TabIndex = 3
        Me.txtSend.Text = "发送信息"
        '
        'btnStopComm
        '
        Me.btnStopComm.Enabled = False
        Me.btnStopComm.Location = New System.Drawing.Point(432, 64)
        Me.btnStopComm.Name = "btnStopComm"
        Me.btnStopComm.Size = New System.Drawing.Size(112, 24)
        Me.btnStopComm.TabIndex = 2
        Me.btnStopComm.Text = "停止通讯"
        '
        'btnStartComm
        '
        Me.btnStartComm.Location = New System.Drawing.Point(296, 64)
        Me.btnStartComm.Name = "btnStartComm"
        Me.btnStartComm.Size = New System.Drawing.Size(112, 24)
        Me.btnStartComm.TabIndex = 1
        Me.btnStartComm.Text = "启动通讯"
        '
        'ClstVehicles
        '
        Me.ClstVehicles.Location = New System.Drawing.Point(8, 24)
        Me.ClstVehicles.Name = "ClstVehicles"
        Me.ClstVehicles.ScrollAlwaysVisible = True
        Me.ClstVehicles.Size = New System.Drawing.Size(264, 228)
        Me.ClstVehicles.TabIndex = 0
        '
        'OleDbDataAdapterVehicles
        '
        Me.OleDbDataAdapterVehicles.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapterVehicles.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapterVehicles.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapterVehicles.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VehicleInfo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BstBearingCap", "BstBearingCap"), New System.Data.Common.DataColumnMapping("IdleSymbol", "IdleSymbol"), New System.Data.Common.DataColumnMapping("IP", "IP"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("OwnershipPlace", "OwnershipPlace"), New System.Data.Common.DataColumnMapping("Port", "Port"), New System.Data.Common.DataColumnMapping("VehicleNO", "VehicleNO")})})
        Me.OleDbDataAdapterVehicles.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM VehicleInfo WHERE (VehicleNO = ?) AND (BstBearingCap = ? OR ? IS NULL" & _
        " AND BstBearingCap IS NULL) AND (IP = ? OR ? IS NULL AND IP IS NULL) AND (IdleSy" & _
        "mbol = ?) AND (Location = ? OR ? IS NULL AND Location IS NULL) AND ([Note] = ? O" & _
        "R ? IS NULL AND [Note] IS NULL) AND (OwnershipPlace = ? OR ? IS NULL AND Ownersh" & _
        "ipPlace IS NULL) AND (Port = ? OR ? IS NULL AND Port IS NULL)"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VehicleNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BstBearingCap", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BstBearingCap", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BstBearingCap1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BstBearingCap", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IP", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IP1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IdleSymbol", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdleSymbol", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnershipPlace", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnershipPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnershipPlace1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnershipPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Port", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Port", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Port1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Port", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO VehicleInfo(BstBearingCap, IdleSymbol, IP, Location, [Note], Ownershi" & _
        "pPlace, Port) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("BstBearingCap", System.Data.OleDb.OleDbType.SmallInt, 0, "BstBearingCap"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("IdleSymbol", System.Data.OleDb.OleDbType.Boolean, 2, "IdleSymbol"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("IP", System.Data.OleDb.OleDbType.VarWChar, 16, "IP"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Location", System.Data.OleDb.OleDbType.VarWChar, 16, "Location"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnershipPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "OwnershipPlace"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Port", System.Data.OleDb.OleDbType.SmallInt, 0, "Port"))
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT BstBearingCap, IdleSymbol, IP, Location, [Note], OwnershipPlace, Port, Veh" & _
        "icleNO FROM VehicleInfo"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE VehicleInfo SET BstBearingCap = ?, IdleSymbol = ?, IP = ?, Location = ?, [" & _
        "Note] = ?, OwnershipPlace = ?, Port = ? WHERE (VehicleNO = ?) AND (BstBearingCap" & _
        " = ? OR ? IS NULL AND BstBearingCap IS NULL) AND (IP = ? OR ? IS NULL AND IP IS " & _
        "NULL) AND (IdleSymbol = ?) AND (Location = ? OR ? IS NULL AND Location IS NULL) " & _
        "AND ([Note] = ? OR ? IS NULL AND [Note] IS NULL) AND (OwnershipPlace = ? OR ? IS" & _
        " NULL AND OwnershipPlace IS NULL) AND (Port = ? OR ? IS NULL AND Port IS NULL)"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("BstBearingCap", System.Data.OleDb.OleDbType.SmallInt, 0, "BstBearingCap"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("IdleSymbol", System.Data.OleDb.OleDbType.Boolean, 2, "IdleSymbol"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("IP", System.Data.OleDb.OleDbType.VarWChar, 16, "IP"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Location", System.Data.OleDb.OleDbType.VarWChar, 16, "Location"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnershipPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "OwnershipPlace"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Port", System.Data.OleDb.OleDbType.SmallInt, 0, "Port"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VehicleNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BstBearingCap", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BstBearingCap", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BstBearingCap1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BstBearingCap", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IP", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IP1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IdleSymbol", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdleSymbol", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnershipPlace", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnershipPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnershipPlace1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnershipPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Port", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Port", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Port1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Port", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSetVehicles
        '
        Me.DataSetVehicles.DataSetName = "DataSetVehicles"
        Me.DataSetVehicles.Locale = New System.Globalization.CultureInfo("zh-CN")
        '
        'DataSetTranPlan
        '
        Me.DataSetTranPlan.DataSetName = "DataSetTranPlan"
        Me.DataSetTranPlan.Locale = New System.Globalization.CultureInfo("zh-CN")
        '
        'OleDbDataAdapterTranOrderForm
        '
        Me.OleDbDataAdapterTranOrderForm.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapterTranOrderForm.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapterTranOrderForm.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapterTranOrderForm.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TranOrderForm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CmpltSituation", "CmpltSituation"), New System.Data.Common.DataColumnMapping("CmpltTime", "CmpltTime"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("ExtraService", "ExtraService"), New System.Data.Common.DataColumnMapping("InitialPlace", "InitialPlace"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("RFIDBarCodeNO", "RFIDBarCodeNO"), New System.Data.Common.DataColumnMapping("TotalQuantity", "TotalQuantity"), New System.Data.Common.DataColumnMapping("TranOrderFormNO", "TranOrderFormNO")})})
        Me.OleDbDataAdapterTranOrderForm.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM TranOrderForm WHERE (TranOrderFormNO = ?) AND (CmpltSituation = ? OR " & _
        "? IS NULL AND CmpltSituation IS NULL) AND (CmpltTime = ? OR ? IS NULL AND CmpltT" & _
        "ime IS NULL) AND (Destination = ? OR ? IS NULL AND Destination IS NULL) AND (Ext" & _
        "raService = ? OR ? IS NULL AND ExtraService IS NULL) AND (InitialPlace = ? OR ? " & _
        "IS NULL AND InitialPlace IS NULL) AND ([Note] = ? OR ? IS NULL AND [Note] IS NUL" & _
        "L) AND (RFIDBarCodeNO = ? OR ? IS NULL AND RFIDBarCodeNO IS NULL) AND (TotalQuan" & _
        "tity = ? OR ? IS NULL AND TotalQuantity IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranOrderFormNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranOrderFormNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltSituation", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltSituation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltSituation1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltSituation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExtraService", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExtraService", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExtraService1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExtraService", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RFIDBarCodeNO", System.Data.OleDb.OleDbType.VarWChar, 32, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RFIDBarCodeNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RFIDBarCodeNO1", System.Data.OleDb.OleDbType.VarWChar, 32, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RFIDBarCodeNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQuantity", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQuantity1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO TranOrderForm(CmpltSituation, CmpltTime, Destination, ExtraService, I" & _
        "nitialPlace, [Note], RFIDBarCodeNO, TotalQuantity) VALUES (?, ?, ?, ?, ?, ?, ?, " & _
        "?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltSituation", System.Data.OleDb.OleDbType.VarWChar, 16, "CmpltSituation"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, "CmpltTime"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.VarWChar, 16, "Destination"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExtraService", System.Data.OleDb.OleDbType.VarWChar, 255, "ExtraService"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "InitialPlace"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("RFIDBarCodeNO", System.Data.OleDb.OleDbType.VarWChar, 32, "RFIDBarCodeNO"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalQuantity", System.Data.OleDb.OleDbType.SmallInt, 0, "TotalQuantity"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT CmpltSituation, CmpltTime, Destination, ExtraService, InitialPlace, [Note]" & _
        ", RFIDBarCodeNO, TotalQuantity, TranOrderFormNO FROM TranOrderForm"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE TranOrderForm SET CmpltSituation = ?, CmpltTime = ?, Destination = ?, Extr" & _
        "aService = ?, InitialPlace = ?, [Note] = ?, RFIDBarCodeNO = ?, TotalQuantity = ?" & _
        " WHERE (TranOrderFormNO = ?) AND (CmpltSituation = ? OR ? IS NULL AND CmpltSitua" & _
        "tion IS NULL) AND (CmpltTime = ? OR ? IS NULL AND CmpltTime IS NULL) AND (Destin" & _
        "ation = ? OR ? IS NULL AND Destination IS NULL) AND (ExtraService = ? OR ? IS NU" & _
        "LL AND ExtraService IS NULL) AND (InitialPlace = ? OR ? IS NULL AND InitialPlace" & _
        " IS NULL) AND ([Note] = ? OR ? IS NULL AND [Note] IS NULL) AND (RFIDBarCodeNO = " & _
        "? OR ? IS NULL AND RFIDBarCodeNO IS NULL) AND (TotalQuantity = ? OR ? IS NULL AN" & _
        "D TotalQuantity IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltSituation", System.Data.OleDb.OleDbType.VarWChar, 16, "CmpltSituation"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, "CmpltTime"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.VarWChar, 16, "Destination"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExtraService", System.Data.OleDb.OleDbType.VarWChar, 255, "ExtraService"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "InitialPlace"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("RFIDBarCodeNO", System.Data.OleDb.OleDbType.VarWChar, 32, "RFIDBarCodeNO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalQuantity", System.Data.OleDb.OleDbType.SmallInt, 0, "TotalQuantity"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranOrderFormNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranOrderFormNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltSituation", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltSituation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltSituation1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltSituation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExtraService", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExtraService", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExtraService1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExtraService", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RFIDBarCodeNO", System.Data.OleDb.OleDbType.VarWChar, 32, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RFIDBarCodeNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RFIDBarCodeNO1", System.Data.OleDb.OleDbType.VarWChar, 32, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RFIDBarCodeNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQuantity", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQuantity1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSetTranOrderForms
        '
        Me.DataSetTranOrderForms.DataSetName = "DataSetTranOrderForms"
        Me.DataSetTranOrderForms.Locale = New System.Globalization.CultureInfo("zh-CN")
        '
        'CfrmVehiclesControl
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CfrmVehiclesControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "车辆进出监视及通讯"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataSetVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTranPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTranOrderForms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private thUDPListen As Thread 'UDP监听线程
    Private blthUDPListenRunning As Boolean 'UDP监听线程运行标志
    Private UDP As Sockets.UdpClient 'UDP对象
    Private Local, Remote As IPEndPoint '本地及终端IP地址与端口
    Private strLocalIp As String '本地IP
    Private dvTemp As DataView '数据库操作对象
    Private VehiclesComm(7) As CVehicleComm '车辆通讯对象
    Private VehiclesNumber As Int16 '车辆数量
    Private VehiclesCommRunning As Boolean = False '车辆通讯运行标志
    Private Sub sUDPlisten() 'UDP监听线程
        Dim bytRecv(21) As Byte '接收到的数据
        Dim intTranOrderFormNO, intVehicleNO As Int16 '运输订单编号，车辆编号
        Dim i, j As Int16
        Dim strRoute As String '车辆运行线路
        Dim strDateTime As String
        Dim strTemp As String '临时字符串
        Dim strDisplay As String '显示字符串
        Dim strVehicleDirection As String
        Dim strCommNO, strOldCommNO As String
        Dim strTag As String
        Do
            bytRecv = UDP.Receive(Local) '接收数据
            '分析数据包
            strTemp = System.Text.Encoding.Default.GetString(bytRecv)
            strVehicleDirection = VisualBasic.Left(strTemp, 1)
            strCommNO = VisualBasic.Mid(strTemp, 3, 2)
            strTag = VisualBasic.Mid(strTemp, 6, 16)
            If strCommNO <> strOldCommNO Then
                strOldCommNO = strCommNO
                strDisplay = ""
                For i = 0 To DataSetTranOrderForms.Tables(0).Rows.Count - 1
                    If strTag = DataSetTranOrderForms.Tables(0).Rows(i).Item("RFIDBarCodeNO") Then
                        intTranOrderFormNO = DataSetTranOrderForms.Tables(0).Rows(i).Item("TranOrderFormNO")
                        Exit For
                    End If
                Next
                If i >= DataSetTranOrderForms.Tables(0).Rows.Count Then
                    strDisplay = "该条码未找到"
                End If
                For i = 0 To DataSetTranPlan.Tables(0).Rows.Count - 1
                    If intTranOrderFormNO = DataSetTranPlan.Tables(0).Rows(i).Item("TranOrderFormNO") Then
                        intVehicleNO = DataSetTranPlan.Tables(0).Rows(i).Item("VehicleNO")
                        strRoute = DataSetTranPlan.Tables(0).Rows(i).Item("TransitRoute")
                        Exit For
                    End If
                Next
                If i >= DataSetTranPlan.Tables(0).Rows.Count Then
                    strDisplay = "信息有误，请确认是否生成运输计划"
                End If
                If strDisplay = "" Then
                    strDisplay = "订单编号：" + intTranOrderFormNO.ToString + "；"
                    strDisplay += "运输车辆编号：" + intVehicleNO.ToString + "；"
                    strDateTime = Now.Year.ToString + "-" + Now.Month.ToString + "-" + Now.Day.ToString + " " + Now.Hour.ToString + "：" + VisualBasic.Right(("0" + Now.Minute.ToString), 2)
                    For i = 0 To DataSetTranOrderForms.Tables(0).Rows.Count - 1
                        If strTag = DataSetTranOrderForms.Tables(0).Rows(i).Item("RFIDBarCodeNO") Then
                            Exit For
                        End If
                    Next
                    If strVehicleDirection = "I" Then
                        strDisplay += "状态：返回配送中心；"
                        DataSetTranPlan.Tables(0).Rows(i).Item("CmpltTime") = strDateTime
                    Else
                        strDisplay += "状态：离开配送中心；"
                        DataSetTranPlan.Tables(0).Rows(i).Item("DepartureTime") = strDateTime
                    End If
                    OleDbDataAdapterTranPlan.Update(DataSetTranPlan)
                    DataSetTranPlan.AcceptChanges()
                    strDisplay += "时间：" + strDateTime
                    If VehiclesCommRunning Then
                        For j = 0 To VehiclesNumber - 1
                            If VehiclesComm(j).intVehicleNO = intVehicleNO Then
                                Exit For
                            End If
                        Next
                        If j < VehiclesNumber Then
                            If ClstVehicles.GetItemChecked(VehiclesComm(j).intClstIndex) Then
                                VehiclesComm(j).sSend("M0" + strRoute, 34)
                            End If
                        End If
                    End If
                    lstHistory.Items.Add(strDisplay)
                End If
            End If
            Thread.CurrentThread.Sleep(10)
        Loop While blthUDPListenRunning
    End Sub
    Private Sub CfrmGoodsMonitorVehiclesComm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        frmMain.Enabled = True
        If blthUDPListenRunning Then
            btnStopListen_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnStartListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartListen.Click
        btnStartListen.Enabled = False
        txtLocalPort.ReadOnly = True
        Local = New IPEndPoint(IPAddress.Parse(strLocalIp), Int16.Parse(txtLocalPort.Text))
        UDP = New Sockets.UdpClient(Local)
        blthUDPListenRunning = True
        thUDPListen = New Thread(AddressOf sUDPlisten)
        thUDPListen.Start()
        btnStopListen.Enabled = True
    End Sub

    Private Sub CfrmGoodsMonitorVehiclesComm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strLocalIp = Dns.GetHostByName(Dns.GetHostName).AddressList(0).ToString
        DataSetTranPlan.Clear()
        OleDbDataAdapterTranPlan.Fill(DataSetTranPlan)
        DataSetVehicles.Clear()
        OleDbDataAdapterVehicles.Fill(DataSetVehicles)
        DataSetTranOrderForms.Clear()
        OleDbDataAdapterTranOrderForm.Fill(DataSetTranOrderForms)
    End Sub

    Private Sub btnStopListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopListen.Click
        btnStopListen.Enabled = False
        thUDPListen.Abort()
        blthUDPListenRunning = False
        UDP.Close()
        btnStartListen.Enabled = True
        txtLocalPort.ReadOnly = False
        btnStartListen.Enabled = True
    End Sub

    Private Sub btnStartComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartComm.Click
        Dim i As Int16
        btnStartComm.Enabled = False
        VehiclesNumber = 0
        '从数据库读取车辆信息，并传递给车辆通讯对象
        For i = 0 To DataSetVehicles.Tables("VehicleInfo").Rows.Count - 1
            VehiclesComm(i) = New CVehicleComm
            VehiclesComm(i).intVehicleNO = DataSetVehicles.Tables("VehicleInfo").Rows(i).Item("VehicleNO")
            VehiclesComm(i).Local = New IPEndPoint(Dns.GetHostByName(Dns.GetHostName).AddressList(0), DataSetVehicles.Tables("VehicleInfo").Rows(i).Item("Port"))
            VehiclesComm(i).Remote = New IPEndPoint(IPAddress.Parse(DataSetVehicles.Tables("VehicleInfo").Rows(i).Item("IP")), DataSetVehicles.Tables("VehicleInfo").Rows(i).Item("Port"))
            ClstVehicles.Items.Add("车辆编号：" + VehiclesComm(i).intVehicleNO.ToString)
            VehiclesComm(i).intClstIndex = ClstVehicles.Items.Count - 1
            VehiclesNumber += 1
        Next
        For i = 0 To VehiclesNumber - 1
            VehiclesComm(i).StartComm()
        Next
        VehiclesCommRunning = True
        btnStopComm.Enabled = True
        txtLocalPort.ReadOnly = False
    End Sub

    Private Sub ClstVehicles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClstVehicles.SelectedIndexChanged
        Dim i As Int16
        For i = 0 To VehiclesNumber - 1
            If VehiclesComm(i).intClstIndex = ClstVehicles.SelectedIndex Then
                VehiclesComm(i).blNowMonitor = True
                btnAccident.Enabled = True
            Else
                VehiclesComm(i).blNowMonitor = False
            End If
        Next
    End Sub

    Private Sub btnStopComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopComm.Click
        Dim i As Int16
        VehiclesCommRunning = False
        btnStopComm.Enabled = False
        For i = 0 To VehiclesNumber - 1
            VehiclesComm(i).StopComm()
        Next
        ClstVehicles.Items.Clear()
        btnStartComm.Enabled = True
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim i As Int16
        '发送自定义信息给车辆
        For i = 0 To VehiclesNumber - 1
            If VehiclesComm(i).intClstIndex = ClstVehicles.SelectedIndex Then
                Exit For
            End If
        Next
        If i < VehiclesNumber Then
            VehiclesComm(i).sSend("M0" + txtSend.Text, 34)
        End If
    End Sub

    Private Sub btnAccident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccident.Click
        frmAccident = New CfrmAccident
        Me.Enabled = False
        frmAccident.Show()
    End Sub
End Class
