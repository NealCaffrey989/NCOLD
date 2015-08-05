Public Class CfrmAccident
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
    Friend WithEvents lstAccident As System.Windows.Forms.ListBox
    Friend WithEvents lstHandle As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstAccident = New System.Windows.Forms.ListBox
        Me.lstHandle = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lstAccident
        '
        Me.lstAccident.ItemHeight = 12
        Me.lstAccident.Location = New System.Drawing.Point(16, 16)
        Me.lstAccident.Name = "lstAccident"
        Me.lstAccident.Size = New System.Drawing.Size(136, 244)
        Me.lstAccident.TabIndex = 0
        '
        'lstHandle
        '
        Me.lstHandle.ItemHeight = 12
        Me.lstHandle.Location = New System.Drawing.Point(216, 16)
        Me.lstHandle.Name = "lstHandle"
        Me.lstHandle.Size = New System.Drawing.Size(144, 244)
        Me.lstHandle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "---->"
        '
        'CfrmAccident
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(392, 273)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstHandle)
        Me.Controls.Add(Me.lstAccident)
        Me.MaximizeBox = False
        Me.Name = "CfrmAccident"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "����������÷���"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private intPlanNo As Int16
    Private dbDs As New DAO.DBEngine
    Private dbWs As DAO.Workspace
    Private dbDb As DAO.Database
    Private rsVehicles As DAO.Recordset
    Private dbstr As String
    Private Sub CfrmAccident_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstAccident.Items.Add("·��ӵ��")
        lstAccident.Items.Add("������")
        lstAccident.Items.Add("�ͻ������䶯")
        lstAccident.Items.Add("����")
        dbWs = dbDs.Workspaces(0)
        dbDb = dbWs.OpenDatabase("C:\Vehicles_Center.mdb", False, False)
        dbstr = "select * from VehicleInfo"
        rsVehicles = dbDb.OpenRecordset(dbstr, DAO.RecordsetTypeEnum.dbOpenDynaset)
    End Sub

    Private Sub lstAccident_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAccident.SelectedIndexChanged
        Select Case lstAccident.SelectedIndex
            Case 0
                lstHandle.Items.Clear()
                lstHandle.Items.Add("֪ͨ��������")
                lstHandle.Items.Add("֪ͨ����ǰ����·�������")
                lstHandle.Items.Add("֪ͨ����ԭ�صȴ�")
                intPlanNo = 0
            Case 1
                lstHandle.Items.Clear()
                lstHandle.Items.Add("֪ͨ����ԭ�صȴ���������")
                lstHandle.Items.Add("֪ͨ��������Ѱ������")
                intPlanNo = 10
            Case 2
                lstHandle.Items.Clear()
                lstHandle.Items.Add("֪ͨ������һվж������������")
                lstHandle.Items.Add("֪ͨ����ֱ��ǰ��ĳ��")
                intPlanNo = 20
            Case 3
                lstHandle.Items.Clear()
                lstHandle.Items.Add("δ����")
                intPlanNo = 30
        End Select
    End Sub

    Private Sub CfrmAccident_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        frmVehiclesControl.Enabled = True
    End Sub

    Private Sub lstHandle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHandle.SelectedIndexChanged
        Dim VehicleNo As Int16
        Select Case lstHandle.SelectedIndex
            Case 0
                intPlanNo = 10 * (intPlanNo \ 10) + 0
            Case 1
                intPlanNo = 10 * (intPlanNo \ 10) + 1
            Case 2
                intPlanNo = 10 * (intPlanNo \ 10) + 2
        End Select
        Select Case intPlanNo
            Case 0
                frmVehiclesControl.txtSend.Text = "Return DC"
            Case 1
                frmVehiclesControl.txtSend.Text = InputBox("�������·��Ż�������", "�������") + " is blocked"
            Case 2
                frmVehiclesControl.txtSend.Text = "Stay"
            Case 10
                rsVehicles.MoveFirst()
                rsVehicles.FindFirst("IdleSymbol=True")
                If Not rsVehicles.EOF Then
                    VehicleNo = rsVehicles.Fields("VehicleNo").Value
                    frmVehiclesControl.txtSend.Text = "Stay and wait the vichile " + InputBox("���ó�����ţ��Ƽ�ʹ�ó���" + VehicleNo.ToString, "�������", VehicleNo.ToString)
                Else
                    MsgBox("û�п��ó���", , "����")
                End If
            Case 11
                frmVehiclesControl.txtSend.Text = "Repair it"
            Case 20
                frmVehiclesControl.txtSend.Text = "Return at the next destination"
            Case 21
                frmVehiclesControl.txtSend.Text = "Directly to " + InputBox("������Ŀ�ĵ�", "�������")
            Case Else
                MsgBox("û�ж��������", , "����")
        End Select
        Me.Close()
    End Sub
End Class
