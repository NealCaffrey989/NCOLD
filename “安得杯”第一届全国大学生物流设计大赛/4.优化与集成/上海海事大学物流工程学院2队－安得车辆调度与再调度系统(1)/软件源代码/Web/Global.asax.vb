Imports System.Web
Imports System.Web.SessionState

Public Class Global
    Inherits System.Web.HttpApplication

#Region " �����������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ�������������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '���������������
    Private components As System.ComponentModel.IContainer

    'ע��: ���¹��������������������
    '����ʹ�����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' ��Ӧ�ó�������ʱ����
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' �ڻỰ����ʱ����
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' ��ÿ������ʼʱ����
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' ���Զ�ʹ�ý��������֤ʱ����
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' �ڷ�������ʱ����
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' �ڻỰ����ʱ����
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' ��Ӧ�ó������ʱ����
    End Sub

End Class
