Public Class CfrmTranOrderForms
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
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DBGTranOrderForms As System.Windows.Forms.DataGrid
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSetTranOrderForms As Vehicles_Center.DataSetTranOrderForms
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
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents btnReadXML As System.Windows.Forms.Button
    Friend WithEvents OpenXML As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CfrmTranOrderForms))
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DBGTranOrderForms = New System.Windows.Forms.DataGrid
        Me.DataSetTranOrderForms = New Vehicles_Center.DataSetTranOrderForms
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnQuit = New System.Windows.Forms.Button
        Me.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.btnReadXML = New System.Windows.Forms.Button
        Me.OpenXML = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBGTranOrderForms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTranOrderForms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(64, 522)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(160, 40)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "保存至数据库"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DBGTranOrderForms)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 488)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "运输订单清单"
        '
        'DBGTranOrderForms
        '
        Me.DBGTranOrderForms.DataMember = "TranOrderForm"
        Me.DBGTranOrderForms.DataSource = Me.DataSetTranOrderForms
        Me.DBGTranOrderForms.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBGTranOrderForms.Location = New System.Drawing.Point(8, 24)
        Me.DBGTranOrderForms.Name = "DBGTranOrderForms"
        Me.DBGTranOrderForms.Size = New System.Drawing.Size(760, 456)
        Me.DBGTranOrderForms.TabIndex = 0
        Me.DBGTranOrderForms.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataSetTranOrderForms
        '
        Me.DataSetTranOrderForms.DataSetName = "DataSetTranOrderForms"
        Me.DataSetTranOrderForms.Locale = New System.Globalization.CultureInfo("zh-CN")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DBGTranOrderForms
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TranOrderForm"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "运输订单编号"
        Me.DataGridTextBoxColumn1.MappingName = "TranOrderFormNO"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 90
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "始发地"
        Me.DataGridTextBoxColumn2.MappingName = "InitialPlace"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "目的地"
        Me.DataGridTextBoxColumn3.MappingName = "Destination"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "完成时间"
        Me.DataGridTextBoxColumn4.MappingName = "CmpltTime"
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "运输总量"
        Me.DataGridTextBoxColumn5.MappingName = "TotalQuantity"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "额外服务"
        Me.DataGridTextBoxColumn6.MappingName = "ExtraService"
        Me.DataGridTextBoxColumn6.Width = 150
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "完成情况"
        Me.DataGridTextBoxColumn7.MappingName = "CmpltSituation"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "RFID条码"
        Me.DataGridTextBoxColumn9.MappingName = "RFIDBarCodeNO"
        Me.DataGridTextBoxColumn9.Width = 150
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "备注"
        Me.DataGridTextBoxColumn8.MappingName = "Note"
        Me.DataGridTextBoxColumn8.Width = 120
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(672, 536)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(112, 24)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "退出运输订单管理"
        '
        'OleDbDataAdapter
        '
        Me.OleDbDataAdapter.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TranOrderForm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CmpltSituation", "CmpltSituation"), New System.Data.Common.DataColumnMapping("CmpltTime", "CmpltTime"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("ExtraService", "ExtraService"), New System.Data.Common.DataColumnMapping("InitialPlace", "InitialPlace"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("RFIDBarCodeNO", "RFIDBarCodeNO"), New System.Data.Common.DataColumnMapping("TotalQuantity", "TotalQuantity"), New System.Data.Common.DataColumnMapping("TranOrderFormNO", "TranOrderFormNO")})})
        Me.OleDbDataAdapter.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM TranOrderForm WHERE (TranOrderFormNO = ?) AND (CmpltSituation = ? OR " & _
        "? IS NULL AND CmpltSituation IS NULL) AND (CmpltTime = ? OR ? IS NULL AND CmpltT" & _
        "ime IS NULL) AND (Destination = ? OR ? IS NULL AND Destination IS NULL) AND (Ext" & _
        "raService = ? OR ? IS NULL AND ExtraService IS NULL) AND (InitialPlace = ? OR ? " & _
        "IS NULL AND InitialPlace IS NULL) AND ([Note] = ? OR ? IS NULL AND [Note] IS NUL" & _
        "L) AND (RFIDBarCodeNO = ? OR ? IS NULL AND RFIDBarCodeNO IS NULL) AND (TotalQuan" & _
        "tity = ? OR ? IS NULL AND TotalQuantity IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranOrderFormNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranOrderFormNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltSituation", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltSituation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltSituation1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltSituation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExtraService", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExtraService", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExtraService1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExtraService", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RFIDBarCodeNO", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RFIDBarCodeNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RFIDBarCodeNO1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RFIDBarCodeNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQuantity", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQuantity1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, Nothing))
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
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO TranOrderForm(CmpltSituation, CmpltTime, Destination, ExtraService, I" & _
        "nitialPlace, [Note], RFIDBarCodeNO, TotalQuantity) VALUES (?, ?, ?, ?, ?, ?, ?, " & _
        "?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltSituation", System.Data.OleDb.OleDbType.VarWChar, 16, "CmpltSituation"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, "CmpltTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.VarWChar, 16, "Destination"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExtraService", System.Data.OleDb.OleDbType.VarWChar, 255, "ExtraService"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "InitialPlace"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RFIDBarCodeNO", System.Data.OleDb.OleDbType.VarWChar, 64, "RFIDBarCodeNO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalQuantity", System.Data.OleDb.OleDbType.SmallInt, 0, "TotalQuantity"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CmpltSituation, CmpltTime, Destination, ExtraService, InitialPlace, [Note]" & _
        ", RFIDBarCodeNO, TotalQuantity, TranOrderFormNO FROM TranOrderForm"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE TranOrderForm SET CmpltSituation = ?, CmpltTime = ?, Destination = ?, Extr" & _
        "aService = ?, InitialPlace = ?, [Note] = ?, RFIDBarCodeNO = ?, TotalQuantity = ?" & _
        " WHERE (TranOrderFormNO = ?) AND (CmpltSituation = ? OR ? IS NULL AND CmpltSitua" & _
        "tion IS NULL) AND (CmpltTime = ? OR ? IS NULL AND CmpltTime IS NULL) AND (Destin" & _
        "ation = ? OR ? IS NULL AND Destination IS NULL) AND (ExtraService = ? OR ? IS NU" & _
        "LL AND ExtraService IS NULL) AND (InitialPlace = ? OR ? IS NULL AND InitialPlace" & _
        " IS NULL) AND ([Note] = ? OR ? IS NULL AND [Note] IS NULL) AND (RFIDBarCodeNO = " & _
        "? OR ? IS NULL AND RFIDBarCodeNO IS NULL) AND (TotalQuantity = ? OR ? IS NULL AN" & _
        "D TotalQuantity IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltSituation", System.Data.OleDb.OleDbType.VarWChar, 16, "CmpltSituation"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, "CmpltTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.VarWChar, 16, "Destination"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExtraService", System.Data.OleDb.OleDbType.VarWChar, 255, "ExtraService"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "InitialPlace"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RFIDBarCodeNO", System.Data.OleDb.OleDbType.VarWChar, 64, "RFIDBarCodeNO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalQuantity", System.Data.OleDb.OleDbType.SmallInt, 0, "TotalQuantity"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TranOrderFormNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TranOrderFormNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltSituation", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltSituation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltSituation1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltSituation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CmpltTime1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CmpltTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Destination1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Destination", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExtraService", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExtraService", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExtraService1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExtraService", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InitialPlace1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InitialPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RFIDBarCodeNO", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RFIDBarCodeNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RFIDBarCodeNO1", System.Data.OleDb.OleDbType.VarWChar, 64, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RFIDBarCodeNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQuantity", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQuantity1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, Nothing))
        '
        'btnReadXML
        '
        Me.btnReadXML.Location = New System.Drawing.Point(248, 520)
        Me.btnReadXML.Name = "btnReadXML"
        Me.btnReadXML.Size = New System.Drawing.Size(144, 40)
        Me.btnReadXML.TabIndex = 6
        Me.btnReadXML.Text = "从XML文件读入"
        '
        'OpenXML
        '
        Me.OpenXML.Filter = "XML交换文件|*.xml"
        '
        'CfrmTranOrderForms
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.btnReadXML)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CfrmTranOrderForms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "运输订单管理"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DBGTranOrderForms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTranOrderForms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        OleDbDataAdapter.Update(DataSetTranOrderForms)
        DataSetTranOrderForms.AcceptChanges()
        DataSetTranOrderForms.Clear()
        OleDbDataAdapter.Fill(DataSetTranOrderForms)
        DBGTranOrderForms.Refresh()
        MsgBox("更新数据库成功", , "保存数据")
    End Sub

    Private Sub CfrmTranOrderForms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataSetTranOrderForms.Clear()
        OleDbDataAdapter.Fill(DataSetTranOrderForms)
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub CfrmTranOrderForms_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        frmMain.Enabled = True
    End Sub

    Private Sub btnReadXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadXML.Click
        OpenXML.FileName = ""
        OpenXML.ShowDialog()
        If OpenXML.FileName <> "" Then
            DataSetTranOrderForms.ReadXml(OpenXML.FileName)
            MsgBox("读取XML成功", , "读取XML")
        End If
    End Sub
End Class
