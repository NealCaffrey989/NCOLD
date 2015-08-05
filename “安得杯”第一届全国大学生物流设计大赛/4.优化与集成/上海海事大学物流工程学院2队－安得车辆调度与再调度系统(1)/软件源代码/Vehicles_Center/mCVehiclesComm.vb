Imports System.Net
Imports System.Threading
Module mCVehiclesComm '����ͨѶ��
    Public Class CVehicleComm
        Public intClstIndex As Int16 '������CheckList�ռ��е�λ��
        Public intVehicleNO As Int16 '�������
        Public blNowMonitor As Boolean = False '�����Ƿ��������ڳ����б�����
        Public Local, Remote As IPEndPoint '���غ�Զ���ն˵�ַ���˿�
        Public strSend As String '�����ַ���
        Public strLastSend As String '��һ�η��͵�����
        Public blConnect As Boolean = False '�Ƿ����߱�־
        Private bytQueue(1023) As Byte '�������ݴ������
        Private intQueueLength As Int16 '���г���
        Private Udp As Sockets.UdpClient 'UDP����
        Private thConnect As Thread '���������߳�
        Private thRecv As Thread '�����߳�
        Private thResend As Thread '�ط����ݼ��
        Private blWaitSend As Boolean = False '�Ƿ�ȴ�����
        Public Sub StartComm()
            '����UDP�����߳�
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
        Public Sub sSend(ByVal strSend As String, ByVal bytLength As Byte) '��������
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
            '����У����
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
        Private Sub sthConnect() '���Ӳ����߳�
            Do
                If blConnect Then
                    frmVehiclesControl.ClstVehicles.SetItemChecked(intClstIndex, True)
                Else
                    frmVehiclesControl.ClstVehicles.SetItemChecked(intClstIndex, False)
                End If
                blConnect = False
                '�������Ӳ�������
                sSend("OK", 32)
                Thread.CurrentThread.Sleep(8000)
            Loop
        End Sub
        Private Sub sthRecv()
            Dim bytRecv(64) As Byte
            Dim i As Byte
            Do
                '��ʼ����
                bytRecv = Udp.Receive(Remote)
                '�����յ�������ѹ�����
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
        Private Sub sthResend() '�ط����ݼ��
            Do
                If blWaitSend And blConnect Then
                    sResend()
                End If
                Thread.CurrentThread.Sleep(3000)
            Loop
        End Sub
        Private Sub sHandleQueue()
            Dim i, intBegin, intEnd As Int16
            Dim bytOnepackage(63) As Byte 'һ�����õ����ݰ�
            Dim bytOnePackageLength As Byte   '�����ĳ���
            Dim intCheckCode As Int16 'Ч����
            Dim bytCmd(3) As Byte '�����ַ���ASCII��
            Dim strCmd As String '����
            Dim blContinue As Boolean '�Ƿ��Ѿ����������
            Do
                intBegin = -1
                intEnd = -1
                blContinue = True
                'ȡ���ò���
                For i = 0 To intQueueLength - 1
                    If bytQueue(i) = 35 Then intBegin = i
                    If bytQueue(i) = 36 Then intEnd = i
                    If intBegin <> -1 And intEnd <> -1 Then Exit For
                Next
                '����Ч�����ݰ�?
                If intBegin <> -1 And intEnd <> -1 Then
                    '����Ч�����ݰ�
                    'ȡ���ݰ�
                    bytOnePackageLength = 0
                    For i = intBegin + 1 To intEnd - 1
                        bytOnepackage(bytOnePackageLength) = bytQueue(i)
                        bytOnePackageLength = bytOnePackageLength + 1
                    Next
                    '�Ӷ�����ɾ��
                    For i = intEnd + 1 To intQueueLength - 1
                        bytQueue(i - intEnd - 1) = bytQueue(i)
                    Next
                    intQueueLength = intQueueLength - intEnd - 1
                    If bytOnePackageLength < 6 Then Exit Sub
                    '����Ч����
                    intCheckCode = 0
                    For i = 0 To bytOnePackageLength - 3
                        intCheckCode = intCheckCode + bytOnepackage(i)
                    Next
                    'Ч������ȷ��?
                    If intCheckCode = 256 * bytOnepackage(bytOnePackageLength - 2) + bytOnepackage(bytOnePackageLength - 1) Then
                        'Ч������ȷ
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
                        'Ч���벻��ȷ

                    End If
                Else
                    'û����Ч�����ݰ�
                    blContinue = True
                End If
            Loop Until blContinue
        End Sub
    End Class
End Module
