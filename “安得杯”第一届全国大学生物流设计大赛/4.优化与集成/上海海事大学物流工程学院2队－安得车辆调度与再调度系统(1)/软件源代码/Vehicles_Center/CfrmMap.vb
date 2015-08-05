Imports Microsoft
Public Class CfrmMap
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPointsNumberOK As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnEditRoadOK As System.Windows.Forms.Button
    Friend WithEvents txtRoad As System.Windows.Forms.TextBox
    Friend WithEvents txtRoadLength As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCreateRoadOK As System.Windows.Forms.Button
    Friend WithEvents btnNowEditRoadOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveMap As System.Windows.Forms.Button
    Friend WithEvents btnLoadMap As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnLoadMapBackground As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CfrmMap))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnNowEditRoadOK = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.txtRoadLength = New System.Windows.Forms.TextBox
        Me.txtRoad = New System.Windows.Forms.TextBox
        Me.btnEditRoadOK = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCreateRoadOK = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnPointsNumberOK = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnLoadMap = New System.Windows.Forms.Button
        Me.btnSaveMap = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnQuit = New System.Windows.Forms.Button
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.btnLoadMapBackground = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLoadMapBackground)
        Me.GroupBox1.Controls.Add(Me.btnNowEditRoadOK)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox1.Controls.Add(Me.txtRoadLength)
        Me.GroupBox1.Controls.Add(Me.txtRoad)
        Me.GroupBox1.Controls.Add(Me.btnEditRoadOK)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnCreateRoadOK)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnPointsNumberOK)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(584, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 376)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "��ͼ������"
        '
        'btnNowEditRoadOK
        '
        Me.btnNowEditRoadOK.Enabled = False
        Me.btnNowEditRoadOK.Location = New System.Drawing.Point(16, 296)
        Me.btnNowEditRoadOK.Name = "btnNowEditRoadOK"
        Me.btnNowEditRoadOK.Size = New System.Drawing.Size(176, 24)
        Me.btnNowEditRoadOK.TabIndex = 18
        Me.btnNowEditRoadOK.Text = "���浱ǰ��·�޸�"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "���䵥�ۣ�"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "��·���ȣ�"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(104, 264)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.ReadOnly = True
        Me.txtUnitPrice.Size = New System.Drawing.Size(88, 21)
        Me.txtUnitPrice.TabIndex = 13
        Me.txtUnitPrice.Text = ""
        '
        'txtRoadLength
        '
        Me.txtRoadLength.Location = New System.Drawing.Point(104, 240)
        Me.txtRoadLength.Name = "txtRoadLength"
        Me.txtRoadLength.ReadOnly = True
        Me.txtRoadLength.Size = New System.Drawing.Size(88, 21)
        Me.txtRoadLength.TabIndex = 12
        Me.txtRoadLength.Text = ""
        '
        'txtRoad
        '
        Me.txtRoad.Location = New System.Drawing.Point(16, 216)
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.ReadOnly = True
        Me.txtRoad.Size = New System.Drawing.Size(176, 21)
        Me.txtRoad.TabIndex = 11
        Me.txtRoad.Text = ""
        '
        'btnEditRoadOK
        '
        Me.btnEditRoadOK.Enabled = False
        Me.btnEditRoadOK.Location = New System.Drawing.Point(16, 344)
        Me.btnEditRoadOK.Name = "btnEditRoadOK"
        Me.btnEditRoadOK.Size = New System.Drawing.Size(176, 24)
        Me.btnEditRoadOK.TabIndex = 10
        Me.btnEditRoadOK.Text = "��ɱ༭�������ͼ"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "���������޸ĵ�·��Ϣ"
        '
        'btnCreateRoadOK
        '
        Me.btnCreateRoadOK.Enabled = False
        Me.btnCreateRoadOK.Location = New System.Drawing.Point(16, 152)
        Me.btnCreateRoadOK.Name = "btnCreateRoadOK"
        Me.btnCreateRoadOK.Size = New System.Drawing.Size(176, 24)
        Me.btnCreateRoadOK.TabIndex = 8
        Me.btnCreateRoadOK.Text = "ȷ��"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "�ڶ��������ӵ�·"
        '
        'btnPointsNumberOK
        '
        Me.btnPointsNumberOK.Location = New System.Drawing.Point(16, 88)
        Me.btnPointsNumberOK.Name = "btnPointsNumberOK"
        Me.btnPointsNumberOK.Size = New System.Drawing.Size(176, 24)
        Me.btnPointsNumberOK.TabIndex = 3
        Me.btnPointsNumberOK.Text = "ȷ��"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "��һ���������ͼ�ڵ���"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnLoadMap)
        Me.GroupBox3.Controls.Add(Me.btnSaveMap)
        Me.GroupBox3.Location = New System.Drawing.Point(584, 376)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 112)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "�������ȡ"
        '
        'btnLoadMap
        '
        Me.btnLoadMap.Location = New System.Drawing.Point(8, 72)
        Me.btnLoadMap.Name = "btnLoadMap"
        Me.btnLoadMap.Size = New System.Drawing.Size(184, 24)
        Me.btnLoadMap.TabIndex = 1
        Me.btnLoadMap.Text = "��ȡ���е�ͼ"
        '
        'btnSaveMap
        '
        Me.btnSaveMap.Location = New System.Drawing.Point(8, 32)
        Me.btnSaveMap.Name = "btnSaveMap"
        Me.btnSaveMap.Size = New System.Drawing.Size(184, 24)
        Me.btnSaveMap.TabIndex = 0
        Me.btnSaveMap.Text = "���浱ǰ��ͼ"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnQuit)
        Me.GroupBox4.Location = New System.Drawing.Point(584, 488)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 72)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "�˳�"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(8, 32)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(184, 24)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "�˳�������ͼ"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "��ͼ�ļ�(*.Map)|*.Map"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "��ͼ�ļ�(*.Map)|*.Map"
        '
        'btnLoadMapBackground
        '
        Me.btnLoadMapBackground.Location = New System.Drawing.Point(16, 32)
        Me.btnLoadMapBackground.Name = "btnLoadMapBackground"
        Me.btnLoadMapBackground.Size = New System.Drawing.Size(176, 24)
        Me.btnLoadMapBackground.TabIndex = 19
        Me.btnLoadMapBackground.Text = "���ص�ͼ����"
        '
        'CfrmMap
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CfrmMap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "������ͼ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private WithEvents Btns As New CMappoints(Me) '��ť�ؼ��飬������ʾ�ڵ�
    Private WithEvents Labels As New CMapRoads(Me) '��ǩ�ؼ��飬������ʾ��·��Ϣ
    Private intMap(8, 8), intInfo(8, 8) As Int16 '��ͼ���󣬵�ͼ��Ϣ����
    Private intPointsNumber, intRoadsNumber As Int16 '��ͼ�ڵ�������ͼ��·��
    Private intNowLabelNumber As Int16 '��ǰѡ�еı�ǩ�ڿؼ����еı��
    Private blDraw As Boolean '�Ƿ����ڻ��Ƶ�·��־
    Private intDrawPointNumber1, intDrawPointNumber2 As Int16 '��·���˵İ�ť�ؼ����
    Private strPointName(7) As String '��ͼ�ڵ�����
    Private strFileName As String '��ͼ�����ļ�·�����ļ���
    Private strMapBackgroundFileName As String '��ͼ�����ļ�·�����ļ���
    Protected Overrides Sub onPaint(ByVal e As System.Windows.Forms.PaintEventArgs) '����OnPaint���������ڻ��Ƶ�·
        Dim Pen As New Pen(Color.Red)
        Dim i, j As Int16
        Pen.Width = 3 '���û��ʿ��
        '���ݵ�ͼ������Ƶ�ͼ��·
        For i = 0 To 7
            For j = i To 7
                If intMap(i, j) <> 0 Then
                    e.Graphics.DrawLine(Pen, Btns.Item(i).Left + 20, Btns.Item(i).Top + 20, Btns.Item(j).Left + 20, Btns.Item(j).Top + 20)
                End If
            Next
        Next
    End Sub

    Private Sub RefreshTheMapAndInfo() '��ʾ��ͼ�������ͼ��Ϣ����
        Dim i, j As Int16
        Dim strMap, strInfo, strTemp As String
        strMap = ""
        strInfo = ""
        '��ȡ������ʾ
        For i = 0 To intPointsNumber - 1
            For j = 0 To intPointsNumber - 1
                If i = j Then
                    strMap += "*" + i.ToString + "*  "
                    strInfo += "*" + i.ToString + "*  "
                Else
                    strTemp = VisualBasic.Right("00" + intMap(i, j).ToString, 3) + "  "
                    strMap += strTemp
                    strTemp = VisualBasic.Right("00" + intInfo(i, j).ToString, 3) + "  "
                    strInfo += strTemp
                End If
            Next
            strMap = strMap + Chr(13) + Chr(10)
            strMap = strMap + Chr(13) + Chr(10)
            strInfo = strInfo + Chr(13) + Chr(10)
            strInfo = strInfo + Chr(13) + Chr(10)
        Next
    End Sub

    Private Sub btnPointsNumberOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPointsNumberOK.Click '��ɽڵ㲼��
        btnCreateRoadOK.Enabled = True
        btnPointsNumberOK.Enabled = False
    End Sub

    Private Sub CfrmCreateMap_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        frmMain.Enabled = True
    End Sub

    Private Sub CfrmCreateMap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click '���ýڵ�
        If intPointsNumber < 8 And btnPointsNumberOK.Enabled Then
            Btns.AddItem(Me.MousePosition.X - Me.Location.X, Me.MousePosition.Y - Me.Location.Y - 20)
            intPointsNumber += 1
            RefreshTheMapAndInfo()
        End If
    End Sub

    Private Sub CfrmCreateMap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '�����������Զ����ص�ͼ
        If GstrFileName <> "" Then
            sLoadMap(GstrFileName)
        End If
    End Sub

    Private Sub Btns_Click(ByVal ItemNumber As Int16) Handles Btns.Click
        Dim strTemp As String '��ʱ�ַ���
        Dim intTemp As Int16 '��ʱ����
        '���Ƶ�·
        If btnCreateRoadOK.Enabled Then
            If Not blDraw Then
                '��ѡ�е�һ���ڵ�
                intDrawPointNumber1 = ItemNumber
                blDraw = True
            Else
                '��ѡ�еڶ����ڵ�
                intDrawPointNumber2 = ItemNumber
                If intDrawPointNumber1 <> intDrawPointNumber2 And intMap(intDrawPointNumber1, intDrawPointNumber2) = 0 Then
                    If intDrawPointNumber1 > intDrawPointNumber2 Then
                        intTemp = intDrawPointNumber2
                        intDrawPointNumber2 = intDrawPointNumber1
                        intDrawPointNumber1 = intTemp
                    End If
                    '���Ƶ�·
                    intMap(intDrawPointNumber1, intDrawPointNumber2) = 1
                    intMap(intDrawPointNumber2, intDrawPointNumber1) = 1
                    intInfo(intDrawPointNumber1, intDrawPointNumber2) = 1
                    intInfo(intDrawPointNumber2, intDrawPointNumber1) = 0
                    strTemp = "R" + intDrawPointNumber1.ToString + intDrawPointNumber2.ToString + ":" + intMap(intDrawPointNumber2, intDrawPointNumber1).ToString + "," + intInfo(intDrawPointNumber1, intDrawPointNumber2).ToString
                    Labels.AddItem((Btns.Item(intDrawPointNumber1).Left + Btns.Item(intDrawPointNumber2).Left) / 2, (Btns.Item(intDrawPointNumber1).Top + Btns.Item(intDrawPointNumber2).Top) / 2, strTemp)
                    intRoadsNumber += 1
                    Me.Refresh()
                    blDraw = False
                End If
            End If
            RefreshTheMapAndInfo()
        Else
            '������ڻ��Ƶ�·״̬�����������
            strTemp = InputBox("�������µ���", "�������", Btns.Item(ItemNumber).Text)
            Btns.Item(ItemNumber).Text = IIf(strTemp = "", Btns.Item(ItemNumber).Text, strTemp)
            strPointName(ItemNumber) = Btns.Item(ItemNumber).Text
        End If
    End Sub
    Private Sub Labels_Click(ByVal ItemNumber As Int16) Handles Labels.Click
        Dim intPoint1, intpoint2 As Int16 '��·���˽ڵ���
        '��ʾ��·��Ϣ
        If btnEditRoadOK.Enabled Then
            txtRoad.Text = VisualBasic.Left(Labels.Item(ItemNumber).Text, 3)
            intPoint1 = VisualBasic.Mid(txtRoad.Text, 2, 1)
            intpoint2 = VisualBasic.Right(txtRoad.Text, 1)
            txtRoadLength.Text = intMap(intpoint2, intPoint1).ToString
            txtUnitPrice.Text = intInfo(intPoint1, intpoint2).ToString
            intNowLabelNumber = ItemNumber
        End If
    End Sub


    Private Sub btnCreateRoadOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateRoadOK.Click
        txtRoadLength.ReadOnly = False
        txtUnitPrice.ReadOnly = False
        btnEditRoadOK.Enabled = True
        btnNowEditRoadOK.Enabled = True
        btnCreateRoadOK.Enabled = False
    End Sub

    Private Sub btnNowEditRoadOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNowEditRoadOK.Click '���浱ǰ�޸ĵĵ�·��Ϣ
        Dim PointNumber1, PointNumber2 As Int16
        Dim strTemp As String
        If Not txtRoad.Text = "" Then
            PointNumber1 = VisualBasic.Mid(txtRoad.Text, 2, 1)
            PointNumber2 = VisualBasic.Mid(txtRoad.Text, 3, 1)
            intMap(PointNumber2, PointNumber1) = Int16.Parse(txtRoadLength.Text)
            intInfo(PointNumber1, PointNumber2) = Int16.Parse(txtUnitPrice.Text)
            strTemp = "R" + PointNumber1.ToString + PointNumber2.ToString + ":" + intMap(PointNumber2, PointNumber1).ToString + "," + intInfo(PointNumber1, PointNumber2).ToString
            Labels.Item(intNowLabelNumber).Text = strTemp
            RefreshTheMapAndInfo()
        End If
    End Sub

    Private Sub btnSaveMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMap.Click '�����ͼ
        Dim i, j As Int16
        Dim strTemp As String
        SaveFileDialog.Filter = "��ͼ�ļ�(*.Map)|*.Map"
        SaveFileDialog.FileName = ""
        SaveFileDialog.ShowDialog()
        If Not SaveFileDialog.FileName = "" Then
            'д��ڵ������·��
            FileOpen(1, SaveFileDialog.FileName, OpenMode.Output, OpenAccess.Write, OpenShare.Shared, -1)
            Write(1, intPointsNumber)
            Write(1, intRoadsNumber)
            'д�����
            For i = 0 To intPointsNumber - 1
                For j = 0 To intPointsNumber - 1
                    Write(1, intMap(i, j))
                Next
            Next
            For i = 0 To intPointsNumber - 1
                For j = 0 To intPointsNumber - 1
                    Write(1, intInfo(i, j))
                Next
            Next
            'д��ؼ���Ϣ������·��ڵ���Ϣ��
            For i = 0 To intPointsNumber - 1
                Write(1, Btns.Item(i).Text)
                Write(1, Btns.Item(i).Left)
                Write(1, Btns.Item(i).Top)
            Next
            For i = 0 To intRoadsNumber - 1
                Write(1, Labels.Item(i).Text)
                Write(1, Labels.Item(i).Left)
                Write(1, Labels.Item(i).Top)
            Next
            strTemp = SaveFileDialog.FileName
            strTemp = VisualBasic.Left(strTemp, strTemp.Length - 3) + "jpg"
            If Not strMapBackgroundFileName = strTemp Then
                FileCopy(strMapBackgroundFileName, strTemp)
            End If
            strMapBackgroundFileName = strTemp
            FileClose(1)
            strFileName = SaveFileDialog.FileName
            MsgBox("�����ͼ�ɹ�", , "�����ͼ")
        End If
    End Sub
    Private Sub sLoadMap(ByVal FileName As String) '��ȡ��ͼ����
        Dim i, j As Int16
        Dim strBackground As String
        Btns.ClearAll()
        Labels.ClearAll()
        FileOpen(1, FileName, OpenMode.Input, OpenAccess.Read, OpenShare.Shared, -1)
        '��ȡ�ڵ������·��
        Input(1, intPointsNumber)
        Input(1, intRoadsNumber)
        '��ȡ����
        For i = 0 To intPointsNumber - 1
            For j = 0 To intPointsNumber - 1
                Input(1, intMap(i, j))
            Next
        Next
        For i = 0 To intPointsNumber - 1
            For j = 0 To intPointsNumber - 1
                Input(1, intInfo(i, j))
            Next
        Next
        RefreshTheMapAndInfo()
        '��ȡ�ؼ���Ϣ������·��ڵ���Ϣ��
        For i = 0 To intPointsNumber - 1
            Btns.AddItem(100, 100)
            Input(1, Btns.Item(i).Text)
            strPointName(i) = Btns.Item(i).Text
            Input(1, Btns.Item(i).Left)
            Input(1, Btns.Item(i).Top)
        Next
        For i = 0 To intRoadsNumber - 1
            Labels.AddItem(100, 100, "")
            Input(1, Labels.Item(i).Text)
            Input(1, Labels.Item(i).Left)
            Input(1, Labels.Item(i).Top)
        Next
        strBackground = FileName
        strBackground = VisualBasic.Left(strBackground, strBackground.Length - 3) + "jpg"
        Me.BackgroundImage = System.Drawing.Image.FromFile(strBackground)
        strMapBackgroundFileName = strBackground
        FileClose(1)
        btnPointsNumberOK.Enabled = False
        btnCreateRoadOK.Enabled = False
        btnEditRoadOK.Enabled = True
        btnNowEditRoadOK.Enabled = True
        Me.Refresh()
        MsgBox("��ȡ��ͼ�ɹ�", , "��ȡ��ͼ")
        strFileName = FileName
    End Sub


    Private Sub btnLoadMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadMap.Click '��ȡ��ͼ
        OpenFileDialog.Filter = "��ͼ�ļ�(*.Map)|*.Map"
        OpenFileDialog.FileName = ""
        OpenFileDialog.ShowDialog()
        If Not OpenFileDialog.FileName = "" Then
            sLoadMap(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnEditRoadOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRoadOK.Click 'ϵͳ�����ͼ�ļ�
        Dim i, j As Int16
        If strFileName = "" Then
            MsgBox("��ͼ�ļ�δ���棬���ȱ����ͼ�ļ�", , "ȷ�ϵ�ͼ")
        Else
            btnEditRoadOK.Enabled = False
            btnNowEditRoadOK.Enabled = False
            btnSaveMap.Enabled = False
            btnLoadMap.Enabled = False
            txtRoadLength.ReadOnly = True
            txtUnitPrice.ReadOnly = True
            GintPointsNumber = intPointsNumber
            GintRoadsNumber = intRoadsNumber
            For i = 0 To GintPointsNumber - 1
                For j = 0 To GintPointsNumber - 1
                    GintMap(i, j) = intMap(i, j)
                    GintInfo(i, j) = intInfo(i, j)
                Next
                GstrPointName(i) = strPointName(i)
            Next
            MsgBox("�õ�ͼ�Ѿ��ɹ��������ȡ", , "ȷ�ϵ�ͼ")
            frmMain.MenuGPSVehiclesMonitor.Enabled = True
            frmMain.MenuTranPlan.Enabled = True
            frmMain.MenuVehiclesControl.Enabled = True
            GstrFileName = strFileName
        End If
    End Sub

    Private Sub btnLoadMapBackground_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadMapBackground.Click
        OpenFileDialog.Filter = "��ͼ����ͼƬ�ļ�(*.jpg)|*.jpg"
        OpenFileDialog.FileName = ""
        OpenFileDialog.ShowDialog()
        If Not OpenFileDialog.FileName = "" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog.FileName)
            strMapBackgroundFileName = OpenFileDialog.FileName
        End If
    End Sub
End Class
