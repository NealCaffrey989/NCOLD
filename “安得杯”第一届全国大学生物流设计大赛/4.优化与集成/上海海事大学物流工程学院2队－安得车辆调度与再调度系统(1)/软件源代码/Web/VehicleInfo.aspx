<%@ Page Language="vb" AutoEventWireup="false" Codebehind="VehicleInfo.aspx.vb" Inherits="Web.VehicleInfo"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>车辆调度中心网上跟踪</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="background.jpg">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 40px; POSITION: absolute; TOP: 40px" runat="server"
					Width="112px" Height="24px">请输入订单号：</asp:Label>
				<asp:Button id="btnSearch" style="Z-INDEX: 102; LEFT: 240px; POSITION: absolute; TOP: 40px"
					runat="server" Width="88px" Height="24px" Text="查找"></asp:Button>
				<asp:TextBox id="txtInfo" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 72px" runat="server"
					Width="320px" Height="104px" TextMode="MultiLine"></asp:TextBox>
				<asp:TextBox id="txtNo" style="Z-INDEX: 104; LEFT: 152px; POSITION: absolute; TOP: 40px" runat="server"
					Width="64px" Height="26px"></asp:TextBox></FONT>
		</form>
	</body>
</HTML>
