Public Class VehicleInfo
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbTranPlan = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DataSetTranPlan = New Web.DataSetTranPlan
        Me.OleDbVehicleInfo = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.DataSetVehicleInfo = New Web.DataSetVehicleInfo
        CType(Me.DataSetTranPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetVehicleInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OleDbTranPlan
        '
        Me.OleDbTranPlan.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbTranPlan.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbTranPlan.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbTranPlan.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TranPlan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CmpltTime", "CmpltTime"), New System.Data.Common.DataColumnMapping("DepartureTime", "DepartureTime"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("InitialPlace", "InitialPlace"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("TranCost", "TranCost"), New System.Data.Common.DataColumnMapping("TranOrderFormNO", "TranOrderFormNO"), New System.Data.Common.DataColumnMapping("TranPlanNO", "TranPlanNO"), New System.Data.Common.DataColumnMapping("TransitRoute", "TransitRoute"), New System.Data.Common.DataColumnMapping("VehicleNO", "VehicleNO")})})
        Me.OleDbTranPlan.UpdateCommand = Me.OleDbUpdateCommand1
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
        'DataSetTranPlan
        '
        Me.DataSetTranPlan.DataSetName = "DataSetTranPlan"
        Me.DataSetTranPlan.Locale = New System.Globalization.CultureInfo("zh-CN")
        '
        'OleDbVehicleInfo
        '
        Me.OleDbVehicleInfo.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbVehicleInfo.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbVehicleInfo.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbVehicleInfo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VehicleInfo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BstBearingCap", "BstBearingCap"), New System.Data.Common.DataColumnMapping("IdleSymbol", "IdleSymbol"), New System.Data.Common.DataColumnMapping("IP", "IP"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("LocationDescription", "LocationDescription"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("OwnershipPlace", "OwnershipPlace"), New System.Data.Common.DataColumnMapping("Port", "Port"), New System.Data.Common.DataColumnMapping("VehicleNO", "VehicleNO")})})
        Me.OleDbVehicleInfo.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM VehicleInfo WHERE (VehicleNO = ?) AND (BstBearingCap = ? OR ? IS NULL" & _
        " AND BstBearingCap IS NULL) AND (IP = ? OR ? IS NULL AND IP IS NULL) AND (IdleSy" & _
        "mbol = ?) AND (Location = ? OR ? IS NULL AND Location IS NULL) AND (LocationDesc" & _
        "ription = ? OR ? IS NULL AND LocationDescription IS NULL) AND ([Note] = ? OR ? I" & _
        "S NULL AND [Note] IS NULL) AND (OwnershipPlace = ? OR ? IS NULL AND OwnershipPla" & _
        "ce IS NULL) AND (Port = ? OR ? IS NULL AND Port IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VehicleNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BstBearingCap", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BstBearingCap", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BstBearingCap1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BstBearingCap", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IP", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IP1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IdleSymbol", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdleSymbol", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LocationDescription", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LocationDescription", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LocationDescription1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LocationDescription", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnershipPlace", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnershipPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnershipPlace1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnershipPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Port", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Port", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Port1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Port", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO VehicleInfo(BstBearingCap, IdleSymbol, IP, Location, LocationDescript" & _
        "ion, [Note], OwnershipPlace, Port) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("BstBearingCap", System.Data.OleDb.OleDbType.SmallInt, 0, "BstBearingCap"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("IdleSymbol", System.Data.OleDb.OleDbType.Boolean, 2, "IdleSymbol"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("IP", System.Data.OleDb.OleDbType.VarWChar, 16, "IP"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Location", System.Data.OleDb.OleDbType.VarWChar, 16, "Location"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LocationDescription", System.Data.OleDb.OleDbType.VarWChar, 255, "LocationDescription"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnershipPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "OwnershipPlace"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Port", System.Data.OleDb.OleDbType.SmallInt, 0, "Port"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT BstBearingCap, IdleSymbol, IP, Location, LocationDescription, [Note], Owne" & _
        "rshipPlace, Port, VehicleNO FROM VehicleInfo"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE VehicleInfo SET BstBearingCap = ?, IdleSymbol = ?, IP = ?, Location = ?, L" & _
        "ocationDescription = ?, [Note] = ?, OwnershipPlace = ?, Port = ? WHERE (VehicleN" & _
        "O = ?) AND (BstBearingCap = ? OR ? IS NULL AND BstBearingCap IS NULL) AND (IP = " & _
        "? OR ? IS NULL AND IP IS NULL) AND (IdleSymbol = ?) AND (Location = ? OR ? IS NU" & _
        "LL AND Location IS NULL) AND (LocationDescription = ? OR ? IS NULL AND LocationD" & _
        "escription IS NULL) AND ([Note] = ? OR ? IS NULL AND [Note] IS NULL) AND (Owners" & _
        "hipPlace = ? OR ? IS NULL AND OwnershipPlace IS NULL) AND (Port = ? OR ? IS NULL" & _
        " AND Port IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("BstBearingCap", System.Data.OleDb.OleDbType.SmallInt, 0, "BstBearingCap"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("IdleSymbol", System.Data.OleDb.OleDbType.Boolean, 2, "IdleSymbol"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("IP", System.Data.OleDb.OleDbType.VarWChar, 16, "IP"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Location", System.Data.OleDb.OleDbType.VarWChar, 16, "Location"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LocationDescription", System.Data.OleDb.OleDbType.VarWChar, 255, "LocationDescription"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnershipPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "OwnershipPlace"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Port", System.Data.OleDb.OleDbType.SmallInt, 0, "Port"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VehicleNO", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VehicleNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BstBearingCap", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BstBearingCap", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BstBearingCap1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BstBearingCap", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IP", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IP1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IdleSymbol", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdleSymbol", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Location1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LocationDescription", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LocationDescription", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LocationDescription1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LocationDescription", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Note1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnershipPlace", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnershipPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnershipPlace1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnershipPlace", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Port", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Port", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Port1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Port", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSetVehicleInfo
        '
        Me.DataSetVehicleInfo.DataSetName = "DataSetVehicleInfo"
        Me.DataSetVehicleInfo.Locale = New System.Globalization.CultureInfo("zh-CN")
        CType(Me.DataSetTranPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetVehicleInfo, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents txtInfo As System.Web.UI.WebControls.TextBox
    Protected WithEvents OleDbTranPlan As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Protected WithEvents DataSetTranPlan As Web.DataSetTranPlan
    Protected WithEvents txtNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents OleDbVehicleInfo As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents DataSetVehicleInfo As Web.DataSetVehicleInfo

    '注意: 以下占位符声明是 Web 窗体设计器所必需的。
    '不要删除或移动它。
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: 此方法调用是 Web 窗体设计器所必需的
        '不要使用代码编辑器修改它。
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '在此处放置初始化页的用户代码
        OleDbTranPlan.Fill(DataSetTranPlan)
        OleDbVehicleInfo.Fill(DataSetVehicleInfo)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim strResult As String
        Dim VehicleNo As Int16
        Dim HaveFound As Boolean
        Dim i As Int16
        HaveFound = False
        For i = 0 To DataSetTranPlan.Tables(0).Rows.Count - 1
            If DataSetTranPlan.Tables(0).Rows(i).Item("TranOrderFormNO") = Int16.Parse(txtNo.Text) Then
                HaveFound = True
                VehicleNo = DataSetTranPlan.Tables(0).Rows(i).Item("VehicleNO")
                Exit For
            End If
        Next
        If HaveFound Then
            For i = 0 To DataSetVehicleInfo.Tables(0).Rows.Count - 1
                If DataSetVehicleInfo.Tables(0).Rows(i).Item("VehicleNO") = VehicleNo Then
                    strResult = DataSetVehicleInfo.Tables(0).Rows(i).Item("LocationDescription")
                    Exit For
                End If
            Next
        Else
            strResult = "订单未找到，您的订单可能正在系统排队中"
        End If
        txtInfo.Text = strResult
    End Sub
End Class
