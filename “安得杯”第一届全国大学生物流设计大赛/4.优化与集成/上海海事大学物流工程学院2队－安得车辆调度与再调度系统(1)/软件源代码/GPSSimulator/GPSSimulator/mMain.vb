Module mMain
    Public gintMap(8, 8), gintInfo(8, 8) As Int16 '地图矩阵，地图信息矩阵
    Public gintPointsNumber, gintRoadsNumber As Int16 '地图节点数，地图道路数
    Public gintNowLabelNumber As Int16 '当前选中的标签在控件组中的编号
    Public gstrPointName(7) As String '地图节点名称
    Public gstrFileName As String '地图交换文件路径与文件名
    Public gAcc As Int16
    Public frmMain As New CfrmMain
    Sub main()
        Application.Run(frmMain)
        End
    End Sub
End Module
