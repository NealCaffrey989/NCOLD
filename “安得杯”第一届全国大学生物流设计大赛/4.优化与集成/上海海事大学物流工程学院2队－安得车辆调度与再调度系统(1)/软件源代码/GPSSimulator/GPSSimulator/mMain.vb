Module mMain
    Public gintMap(8, 8), gintInfo(8, 8) As Int16 '��ͼ���󣬵�ͼ��Ϣ����
    Public gintPointsNumber, gintRoadsNumber As Int16 '��ͼ�ڵ�������ͼ��·��
    Public gintNowLabelNumber As Int16 '��ǰѡ�еı�ǩ�ڿؼ����еı��
    Public gstrPointName(7) As String '��ͼ�ڵ�����
    Public gstrFileName As String '��ͼ�����ļ�·�����ļ���
    Public gAcc As Int16
    Public frmMain As New CfrmMain
    Sub main()
        Application.Run(frmMain)
        End
    End Sub
End Module
