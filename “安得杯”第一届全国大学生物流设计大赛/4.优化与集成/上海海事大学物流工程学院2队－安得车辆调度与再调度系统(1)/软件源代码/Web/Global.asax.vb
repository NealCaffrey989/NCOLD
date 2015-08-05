Imports System.Web
Imports System.Web.SessionState

Public Class Global
    Inherits System.Web.HttpApplication

#Region " 组件设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是组件设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '组件设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是组件设计器所必需的
    '可以使用组件设计器修改此过程。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' 在应用程序启动时激发
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' 在会话启动时激发
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' 在每个请求开始时激发
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' 尝试对使用进行身份验证时激发
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' 在发生错误时激发
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' 在会话结束时激发
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' 在应用程序结束时激发
    End Sub

End Class
