Imports System.Net
Imports System.Threading
Module mCVehiclesComm '车辆通讯类
    Public Class CVehicleComm
        Public intClstIndex As Int16 '车辆在CheckList空间中的位置
        Public intVehicleNO As Int16 '车辆编号
        Public blNowMonitor As Boolean = False '车辆是否现在正在程序中被监视
        Public Local, Remote As IPEndPoint '本地和远程终端地址及端口
        Public strSend As String '发送字符串
        Public strLastSend As String '上一次发送的数据
        Public blConnect As Boolean = False '是否在线标志
        Private bytQueue(1023) As Byte '接收数据处理队列
        Private intQueueLength As Int16 '队列长度
        Private Udp As Sockets.UdpClient 'UDP对象
        Private thConnect As Thread '测试在线线程
        Private thRecv As Thread '监听线程
        Private thResend As Thread '重发数据检测
        Private blWaitSend As Boolean = False '是否等待发送
        Public Sub StartComm()
            '启动UDP对象及线程
            Udp = New Sockets.UdpClient(Local)
            Udp.Connect(Remote)
            thConnect = New Thread(AddressOf sthConnect)
            thConnect.Start()
            thRecv = New Thread(AddressOf sthRecv)
            thRecv.Start()
            thResend = New Thread(AddressOf sthResend)
            thResend.Start()
        End Sub
        Public Sub StopComm()
            thConnect.Abort()
            thRecv.Abort()
            thResend.Abort()
            Udp.Close()
        End Sub
        Public Sub sSend(ByVal strSend As String, ByVal bytLength As Byte) '发送数据
            Dim i As Int16
            Dim bytSend(63) As Byte
            Dim intCheck As Int16
            If strSend <> "OK" Then
                strLastSend = strSend
                blWaitSend = True
            End If
            For i = strSend.Length To bytLength
                strSend += " "
            Next
            intCheck = 0
            '计算校验码
            For i = 1 To bytLength
                bytSend(i) = Asc(Mid(strSend, i, 1))
                intCheck += bytSend(i)
            Next
            bytSend(0) = Asc("#")
            bytSend(bytLength + 1) = intCheck \ 256
            bytSend(bytLength + 2) = intCheck Mod 256
            bytSend(bytLength + 3) = Asc("$")
            Udp.Send(bytSend, bytLength + 4)
        End Sub
        Private Sub sthConnect() '连接测试线程
            Do
                If blConnect Then
                    frmVehiclesControl.ClstVehicles.SetItemChecked(intClstIndex, True)
                Else
                    frmVehiclesControl.ClstVehicles.SetItemChecked(intClstIndex, False)
                End If
                blConnect = False
                '发送连接测试数据
                sSend("OK", 32)
                Thread.CurrentThread.Sleep(8000)
            Loop
        End Sub
        Private Sub sthRecv()
            Dim bytRecv(64) As Byte
            Dim i As Byte
            Do
                '开始接收
                bytRecv = Udp.Receive(Remote)
                '将接收到的数据压入队列
                For i = 0 To bytRecv.Length - 1
                    bytQueue(intQueueLength) = bytRecv(i)
                    intQueueLength += 1
                Next
                If intQueueLength >= 7 Then
                    sHandleQueue()
                End If
                Thread.CurrentThread.Sleep(10)
            Loop
        End Sub
        Private Sub sResend()
            sSend(strLastSend, 34)
        End Sub
        Private Sub sthResend() '重发数据检测
            Do
                If blWaitSend And blConnect Then
                    sResend()
                End If
                Thread.CurrentThread.Sleep(3000)
            Loop
        End Sub
        Private Sub sHandleQueue()
            Dim i, intBegin, intEnd As Int16
            Dim bytOnepackage(63) As Byte '一个有用的数据包
            Dim bytOnePackageLength As Byte   '及它的长度
            Dim intCheckCode As Int16 '效验码
            Dim bytCmd(3) As Byte '命令字符的ASCII码
            Dim strCmd As String '命令
            Dim blContinue As Boolean '是否已经处理完队列
            Do
                intBegin = -1
                intEnd = -1
                blContinue = True
                '取有用部分
                For i = 0 To intQueueLength - 1
                    If bytQueue(i) = 35 Then intBegin = i
                    If bytQueue(i) = 36 Then intEnd = i
                    If intBegin <> -1 And intEnd <> -1 Then Exit For
                Next
                '有有效的数据包?
                If intBegin <> -1 And intEnd <> -1 Then
                    '有有效的数据包
                    '取数据包
                    bytOnePackageLength = 0
                    For i = intBegin + 1 To intEnd - 1
                        bytOnepackage(bytOnePackageLength) = bytQueue(i)
                        bytOnePackageLength = bytOnePackageLength + 1
                    Next
                    '从队列中删除
                    For i = intEnd + 1 To intQueueLength - 1
                        bytQueue(i - intEnd - 1) = bytQueue(i)
                    Next
                    intQueueLength = intQueueLength - intEnd - 1
                    If bytOnePackageLength < 6 Then Exit Sub
                    '计算效验码
                    intCheckCode = 0
                    For i = 0 To bytOnePackageLength - 3
                        intCheckCode = intCheckCode + bytOnepackage(i)
                    Next
                    '效验码正确吗?
                    If intCheckCode = 256 * bytOnepackage(bytOnePackageLength - 2) + bytOnepackage(bytOnePackageLength - 1) Then
                        '效验码正确
                        bytCmd(0) = bytOnepackage(0)
                        bytCmd(1) = bytOnepackage(1)
                        bytCmd(2) = bytOnepackage(2)
                        bytCmd(3) = bytOnepackage(3)
                        strCmd = System.Text.Encoding.Default.GetString(bytCmd)
                        If blNowMonitor Then
                            frmVehiclesControl.txtRecv.Text = strCmd
                        End If
                        Select Case strCmd
                            Case "00OK"
                                If Not blConnect Then
                                    blConnect = True
                                End If
                            Case "M0OK"
                                blWaitSend = False
                            Case "00M1"
                                sResend()
                        End Select
                    Else
                        '效验码不正确

                    End If
                Else
                    '没有有效的数据包
                    blContinue = True
                End If
            Loop Until blContinue
        End Sub
    End Class
End Module
