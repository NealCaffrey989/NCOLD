<%@ Page Language="vb" AutoEventWireup="false" Codebehind="TranOrderFormOK.aspx.vb" Inherits="Web.TranOrderFormOK"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>客户订单网上录入确认</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="background.jpg">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 113; LEFT: 24px; POSITION: absolute; TOP: 96px" runat="server"
				Height="24px" Width="96px">订单目的地：</asp:Label>
			<asp:Label id="Label8" style="Z-INDEX: 118; LEFT: 40px; POSITION: absolute; TOP: 408px" runat="server"
				Height="24px" Width="80px">安排车次：</asp:Label>
			<asp:TextBox id="txtVehicleTurn" style="Z-INDEX: 109; LEFT: 128px; POSITION: absolute; TOP: 408px"
				runat="server" Height="24px" Width="248px" ReadOnly="True"></asp:TextBox>
			<asp:Button id="btnCancel" style="Z-INDEX: 117; LEFT: 224px; POSITION: absolute; TOP: 464px"
				runat="server" Height="32px" Width="144px" Text="放弃"></asp:Button>
			<asp:Label id="Label7" style="Z-INDEX: 116; LEFT: 24px; POSITION: absolute; TOP: 56px" runat="server"
				Height="24px" Width="97px">订单始发地：</asp:Label>
			<asp:TextBox id="txtInitialPlace" style="Z-INDEX: 105; LEFT: 128px; POSITION: absolute; TOP: 56px"
				runat="server" Height="24px" Width="248px" ReadOnly="True"></asp:TextBox>
			<asp:Label id="Label6" style="Z-INDEX: 115; LEFT: 40px; POSITION: absolute; TOP: 16px" runat="server"
				Height="24px" Width="80px">订单编号：</asp:Label>
			<asp:TextBox id="txtTranOrderFormNO" style="Z-INDEX: 106; LEFT: 128px; POSITION: absolute; TOP: 16px"
				runat="server" Height="24px" Width="248px" ReadOnly="True"></asp:TextBox>
			<asp:Label id="Label2" style="Z-INDEX: 114; LEFT: 8px; POSITION: absolute; TOP: 176px" runat="server"
				Height="24px" Width="112px">要求完成时间：</asp:Label>
			<asp:TextBox id="txtExtraService" style="Z-INDEX: 111; LEFT: 128px; POSITION: absolute; TOP: 256px"
				runat="server" Height="136px" Width="248px" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
			<asp:TextBox id="txtRFIDBarCodeNO" style="Z-INDEX: 110; LEFT: 128px; POSITION: absolute; TOP: 216px"
				runat="server" Height="24px" Width="248px" ReadOnly="True"></asp:TextBox>
			<asp:TextBox id="txtCmpltTime" style="Z-INDEX: 108; LEFT: 128px; POSITION: absolute; TOP: 176px"
				runat="server" Height="24px" Width="248px" ReadOnly="True"></asp:TextBox>
			<asp:TextBox id="txtTotalQuantity" style="Z-INDEX: 107; LEFT: 128px; POSITION: absolute; TOP: 136px"
				runat="server" Height="24px" Width="248px" ReadOnly="True"></asp:TextBox>
			<asp:Label id="Label5" style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 216px" runat="server"
				Height="24px" Width="88px">RFID条码：</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 101; LEFT: 40px; POSITION: absolute; TOP: 256px" runat="server"
				Height="24px" Width="80px">额外服务：</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 100; LEFT: 40px; POSITION: absolute; TOP: 136px" runat="server"
				Height="24px" Width="80px">运输总量：</asp:Label>
			<asp:TextBox id="txtDestination" style="Z-INDEX: 104; LEFT: 128px; POSITION: absolute; TOP: 96px"
				runat="server" Height="24px" Width="248px" ReadOnly="True"></asp:TextBox>
			<asp:Button id="btnOK" style="Z-INDEX: 112; LEFT: 40px; POSITION: absolute; TOP: 464px" runat="server"
				Height="32px" Width="144px" Text="确认"></asp:Button>
		</form>
	</body>
</HTML>
