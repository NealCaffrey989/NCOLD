<%@ Page Language="vb" AutoEventWireup="false" Codebehind="TranOrderForm.aspx.vb" Inherits="Web.TranOrderForm"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>客户订单网上录入</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="background.jpg">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 24px" runat="server"
					Width="96px" Height="24px">订单目的地：</asp:Label>
				<asp:TextBox id="txtExtraService" style="Z-INDEX: 110; LEFT: 128px; POSITION: absolute; TOP: 184px"
					runat="server" Width="248px" Height="136px" TextMode="MultiLine"></asp:TextBox>
				<asp:TextBox id="txtRFIDBarCodeNO" style="Z-INDEX: 109; LEFT: 128px; POSITION: absolute; TOP: 144px"
					runat="server" Width="248px" Height="24px"></asp:TextBox>
				<asp:TextBox id="txtCmpltTime" style="Z-INDEX: 108; LEFT: 128px; POSITION: absolute; TOP: 104px"
					runat="server" Width="248px" Height="24px"></asp:TextBox>
				<asp:TextBox id="txtTotalQuantity" style="Z-INDEX: 107; LEFT: 128px; POSITION: absolute; TOP: 64px"
					runat="server" Width="248px" Height="24px"></asp:TextBox>
				<asp:Label id="Label5" style="Z-INDEX: 105; LEFT: 40px; POSITION: absolute; TOP: 144px" runat="server"
					Width="80px" Height="24px">RFID条码：</asp:Label>
				<asp:Label id="Label4" style="Z-INDEX: 104; LEFT: 40px; POSITION: absolute; TOP: 184px" runat="server"
					Width="80px" Height="24px">额外服务：</asp:Label>
				<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 40px; POSITION: absolute; TOP: 64px" runat="server"
					Width="80px" Height="24px">运输总量：</asp:Label>
				<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 104px" runat="server"
					Width="112px" Height="24px">要求完成时间：</asp:Label>
				<asp:TextBox id="txtDestination" style="Z-INDEX: 106; LEFT: 128px; POSITION: absolute; TOP: 24px"
					runat="server" Width="248px" Height="24px"></asp:TextBox>
				<asp:Button id="btnSubmit" style="Z-INDEX: 111; LEFT: 40px; POSITION: absolute; TOP: 352px"
					runat="server" Width="345px" Height="32px" Text="提交"></asp:Button></FONT>
		</form>
	</body>
</HTML>
