Imports Microsoft
Imports System.Threading
Public Class CVehicles
    Public No As Int16
    Public Route As String
    Public V As Int16
    Public NowStartPoint, NowEndPoint As Int16
    Public NowLocation, NowLength, NowFinishedRate, NowV As Double
    Public NowLocationDescription As String
    Public FinishedPointsNumber As Int16
    Private thRefresh As Thread
    Public Sub StartRun()
        thRefresh = New Thread(AddressOf sRefresh)
        thRefresh.Start()
    End Sub
    Public Sub stopRun()
        thRefresh.Abort()
        thRefresh = Nothing
    End Sub
    Private Sub sRefresh()
        Dim PointsNumber As Int16
        Dim PointNo(7) As Int16
        Dim strTemp As String
        Dim i, j, k As Int16
        Dim blFinished As Boolean
        Randomize()
        Route += "-"
        PointsNumber = 0
        j = 1
        For i = 1 To Route.Length
            If VisualBasic.Mid(Route, i, 1) = "-" Then
                strTemp = VisualBasic.Mid(Route, j, i - j)
                j = i + 1
                For k = 0 To 7
                    If gstrPointName(k) = strTemp Then
                        PointNo(PointsNumber) = k
                        Exit For
                    End If
                Next
                PointsNumber += 1
            End If
        Next
        blFinished = False
        NowLocation = 0
        FinishedPointsNumber = 0
        NowStartPoint = PointNo(0)
        NowEndPoint = PointNo(1)
        i = NowStartPoint
        j = NowEndPoint
        NowLength = gintMap(i, j)
        If i < j Then
            NowLength = gintMap(j, i)
        End If
        Do
            NowV = V * (1 + (Rnd() * 10 - 5) / 10)
            NowLocation += NowV * gAcc / 720
            If NowLocation >= NowLength Then
                FinishedPointsNumber += 1
                If FinishedPointsNumber < PointsNumber - 1 Then
                    NowStartPoint = PointNo(FinishedPointsNumber)
                    NowEndPoint = PointNo(FinishedPointsNumber + 1)
                    i = NowStartPoint
                    j = NowEndPoint
                    NowLength = gintMap(i, j)
                    If i < j Then
                        NowLength = gintMap(j, i)
                    End If
                    NowLocation = 0
                Else
                    blFinished = True
                    NowLocation = NowLength
                End If
            End If
            NowFinishedRate = NowLocation / NowLength
            If NowFinishedRate > 0 Then
                NowLocationDescription = ""
                strTemp = "目前车辆" + No.ToString + "位于" + gstrPointName(NowStartPoint) + "至" + gstrPointName(NowEndPoint) + "的道路上"
                NowLocationDescription += strTemp + "，"
                strTemp = "距离" + gstrPointName(NowEndPoint) + " " + Int(NowLength - NowLocation).ToString + "公里"
                NowLocationDescription += strTemp + "，"
                strTemp = "当前车速" + Int(NowV).ToString + "公里每小时"
                NowLocationDescription += strTemp + "。"
            End If
            Thread.CurrentThread.Sleep(5000)
        Loop Until blFinished
    End Sub
End Class
