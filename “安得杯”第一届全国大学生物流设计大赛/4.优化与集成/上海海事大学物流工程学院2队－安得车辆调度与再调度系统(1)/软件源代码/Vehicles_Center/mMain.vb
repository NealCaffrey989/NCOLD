Module mMain
    Public GintMap(8, 8) As Int16 '�����ͼ����
    Public GintInfo(8, 8) As Int16 '�����ͼ��Ϣ����
    Public GintPointsNumber As Int16 '��ͼ�ڵ���
    Public GintRoadsNumber As Int16 '��ͼ��·��
    Public GstrPointName(8) As String '��ͼ�ڵ�����
    Public GstrFileName As String '��ͼ�����ļ�·�����ļ���
    '�����ܴ��ڶ���
    Public frmMain As CfrmMain
    Public frmMap As CfrmMap
    Public frmVehicles As CfrmVehicles
    Public frmTranOrderForms As CfrmTranOrderForms
    Public frmTranPlan As CfrmTranPlan
    Public frmVehiclesControl As CfrmVehiclesControl
    Public frmGPS As CfrmGPS
    Public frmAbout As CfrmAbout
    Public frmStart As CfrmStart
    Public frmAccident As CfrmAccident

    Sub Main()
        frmStart = New CfrmStart
        Application.Run(frmStart)
        frmMain = New CfrmMain
        Application.Run(frmMain)
        End
    End Sub
End Module
