Module mMain
    Public GintMap(8, 8) As Int16 '定义地图矩阵
    Public GintInfo(8, 8) As Int16 '定义地图信息矩阵
    Public GintPointsNumber As Int16 '地图节点数
    Public GintRoadsNumber As Int16 '地图道路数
    Public GstrPointName(8) As String '地图节点名称
    Public GstrFileName As String '地图交换文件路径与文件名
    '各功能窗口定义
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
