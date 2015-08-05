Public Class TranOrderForm
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbOrderForm = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DataSetOrderForm = New Web.DataSetOrderForm
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
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CmpltSituation, CmpltTime, Destination, ExtraService, InitialPlace, [Note]" & _
        ", RFIDBarCodeNO, TotalQuantity, TranOrderFormNO FROM TranOrderForm"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
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
        'DataSetOrderForm
        '
        Me.DataSetOrderForm.DataSetName = "DataSetOrderForm"
        Me.DataSetOrderForm.Locale = New System.Globalization.CultureInfo("zh-CN")
        CType(Me.DataSetOrderForm, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents txtDestination As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTotalQuantity As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCmpltTime As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRFIDBarCodeNO As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtExtraService As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents OleDbOrderForm As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Protected WithEvents DataSetOrderForm As Web.DataSetOrderForm

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
        OleDbOrderForm.Fill(DataSetOrderForm)
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim DataRow As System.Data.DataRow
        Dim RowNum As Int16
        Dim OrderNo As Int16
        DataRow = DataSetOrderForm.Tables(0).NewRow
        DataRow.Item("InitialPlace") = "DC"
        DataRow.Item("Destination") = txtDestination.Text
        DataRow.Item("CmpltTime") = txtCmpltTime.Text
        DataRow.Item("TotalQuantity") = Int16.Parse(txtTotalQuantity.Text)
        DataRow.Item("ExtraService") = txtExtraService.Text
        DataRow.Item("RFIDBarCodeNO") = txtRFIDBarCodeNO.Text
        RowNum = DataSetOrderForm.Tables(0).Rows.Count
        DataSetOrderForm.Tables(0).Rows.Add(DataRow)
        OleDbOrderForm.Update(DataSetOrderForm)
        DataSetOrderForm.AcceptChanges()
        DataSetOrderForm.Clear()
        OleDbOrderForm.Fill(DataSetOrderForm)
        DataRow = DataSetOrderForm.Tables(0).Rows(RowNum)
        OrderNo = DataRow.Item("TranOrderFormNO")
        Response.Redirect("TranOrderFormOK.aspx?OrderNo=" + OrderNo.ToString)
    End Sub
End Class
