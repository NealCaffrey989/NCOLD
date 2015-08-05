Public Class TranOrderFormOK
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbOrderForm = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbVehicleInfo = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.DataSetVehicleInfo = New Web.DataSetVehicleInfo
        Me.DataSetOrderForm = New Web.DataSetOrderForm
        CType(Me.DataSetVehicleInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOrderForm, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OleDbOrderForm
        '
        Me.OleDbOrderForm.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbOrderForm.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbOrderForm.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbOrderForm.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TranOrderForm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CmpltSituation", "CmpltSituation"), New System.Data.Common.DataColumnMapping("CmpltTime", "CmpltTime"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("ExtraService", "ExtraService"), New System.Data.Common.DataColumnMapping("InitialPlace", "InitialPlace"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("RFIDBarCodeNO", "RFIDBarCodeNO"), New System.Data.Common.DataColumnMapping("TotalQuantity", "TotalQuantity"), New System.Data.Common.DataColumnMapping("TranOrderFormNO", "TranOrderFormNO")})})
        Me.OleDbOrderForm.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CmpltSituation, CmpltTime, Destination, ExtraService, InitialPlace, [Note]" & _
        ", RFIDBarCodeNO, TotalQuantity, TranOrderFormNO FROM TranOrderForm"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO TranOrderForm(CmpltSituation, CmpltTime, Destination, ExtraService, I" & _
        "nitialPlace, [Note], RFIDBarCodeNO, TotalQuantity) VALUES (?, ?, ?, ?, ?, ?, ?, " & _
        "?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltSituation", System.Data.OleDb.OleDbType.VarWChar, 16, "CmpltSituation"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CmpltTime", System.Data.OleDb.OleDbType.VarWChar, 64, "CmpltTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.VarWChar, 16, "Destination"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExtraService", System.Data.OleDb.OleDbType.VarWChar, 255, "ExtraService"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("InitialPlace", System.Data.OleDb.OleDbType.VarWChar, 16, "InitialPlace"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Note", System.Data.OleDb.OleDbType.VarWChar, 255, "Note"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RFIDBarCodeNO", System.Data.OleDb.OleDbType.VarWChar, 64, "RFIDBarCodeNO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalQuantity", System.Data.OleDb.OleDbType.SmallInt, 0, "TotalQuantity"))
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
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
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
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM TranOrderForm WHERE (TranOrderFormNO = ?) AND (CmpltSituation = ? OR " & _
        "? IS NULL AND CmpltSituation IS NULL) AND (CmpltTime = ? OR ? IS NULL AND CmpltT" & _
        "ime IS NULL) AND (Destination = ? OR ? IS NULL AND Destination IS NULL) AND (Ext" & _
        "raService = ? OR ? IS NULL AND ExtraService IS NULL) AND (InitialPlace = ? OR ? " & _
        "IS NULL AND InitialPlace IS NULL) AND ([Note] = ? OR ? IS NULL AND [Note] IS NUL" & _
        "L) AND (RFIDBarCodeNO = ? OR ? IS NULL AND RFIDBarCodeNO IS NULL) AND (TotalQuan" & _
        "tity = ? OR ? IS NULL AND TotalQuantity IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
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
        'OleDbVehicleInfo
        '
        Me.OleDbVehicleInfo.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbVehicleInfo.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbVehicleInfo.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbVehicleInfo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VehicleInfo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BstBearingCap", "BstBearingCap"), New System.Data.Common.DataColumnMapping("IdleSymbol", "IdleSymbol"), New System.Data.Common.DataColumnMapping("IP", "IP"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("LocationDescription", "LocationDescription"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("OwnershipPlace", "OwnershipPlace"), New System.Data.Common.DataColumnMapping("Port", "Port"), New System.Data.Common.DataColumnMapping("VehicleNO", "VehicleNO")})})
        Me.OleDbVehicleInfo.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT BstBearingCap, IdleSymbol, IP, Location, LocationDescription, [Note], Owne" & _
        "rshipPlace, Port, VehicleNO FROM VehicleInfo"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
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
        'DataSetVehicleInfo
        '
        Me.DataSetVehicleInfo.DataSetName = "DataSetVehicleInfo"
        Me.DataSetVehicleInfo.Locale = New System.Globalization.CultureInfo("zh-CN")
        '
        'DataSetOrderForm
        '
        Me.DataSetOrderForm.DataSetName = "DataSetOrderForm"
        Me.DataSetOrderForm.Locale = New System.Globalization.CultureInfo("zh-CN")
        CType(Me.DataSetVehicleInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOrderForm, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents txtDestination As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents txtTotalQuantity As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCmpltTime As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRFIDBarCodeNO As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtExtraService As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtTranOrderFormNO As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents txtInitialPlace As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents btnOK As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Protected WithEvents OleDbVehicleInfo As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents DataSetVehicleInfo As Web.DataSetVehicleInfo
    Protected WithEvents DataSetOrderForm As Web.DataSetOrderForm
    Protected WithEvents OleDbOrderForm As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents txtVehicleTurn As System.Web.UI.WebControls.TextBox

    '注意: 以下占位符声明是 Web 窗体设计器所必需的。
    '不要删除或移动它。
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: 此方法调用是 Web 窗体设计器所必需的
        '不要使用代码编辑器修改它。
        InitializeComponent()
    End Sub

#End Region
    Private OrderNo As Int16
    Private DataRow As System.Data.DataRow
    Private TotalVehicleQuantity, TotalOrderFormQuantity As Int16
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '在此处放置初始化页的用户代码
        Dim i As Int16
        OleDbOrderForm.Fill(DataSetOrderForm)
        OleDbVehicleInfo.Fill(DataSetVehicleInfo)
        OrderNo = Int16.Parse(Request.QueryString("OrderNo"))
        For i = 0 To DataSetOrderForm.Tables(0).Rows.Count - 1
            If DataSetOrderForm.Tables(0).Rows(i).Item("TranOrderFormNO") = OrderNo Then
                DataRow = DataSetOrderForm.Tables(0).Rows(i)
                Exit For
            End If
        Next
        If Not DataRow Is Nothing Then
            txtTranOrderFormNO.Text = DataRow.Item("TranOrderFormNO")
            txtInitialPlace.Text = DataRow.Item("InitialPlace")
            txtDestination.Text = DataRow.Item("Destination")
            txtTotalQuantity.Text = DataRow.Item("TotalQuantity")
            txtCmpltTime.Text = DataRow.Item("CmpltTime")
            txtRFIDBarCodeNO.Text = DataRow.Item("RFIDBarCodeNO")
            txtExtraService.Text = DataRow.Item("ExtraService")
            TotalVehicleQuantity = 0
            TotalOrderFormQuantity = 0
            For i = 0 To DataSetVehicleInfo.Tables(0).Rows.Count - 1
                TotalVehicleQuantity += DataSetVehicleInfo.Tables(0).Rows(i).Item("BstBearingCap")
            Next
            For i = 0 To DataSetOrderForm.Tables(0).Rows.Count - 1
                TotalOrderFormQuantity += DataSetOrderForm.Tables(0).Rows(i).Item("TotalQuantity")
            Next
            txtVehicleTurn.Text = "第" + Int(TotalOrderFormQuantity / TotalVehicleQuantity + 1).ToString + "批次"
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Response.Redirect("index.htm")
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DataRow.Delete()
        OleDbOrderForm.Update(DataSetOrderForm)
        DataSetOrderForm.AcceptChanges()
        OleDbOrderForm.Fill(DataSetOrderForm)
        OleDbVehicleInfo.Fill(DataSetVehicleInfo)
        Response.Redirect("TranOrderForm.aspx")
    End Sub
End Class
