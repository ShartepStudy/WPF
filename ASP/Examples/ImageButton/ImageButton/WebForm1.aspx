<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ImageButton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton id="ImageButton1" style="Z-INDEX: 101; LEFT: 18px; POSITION: absolute; TOP: 21px"
			        runat="server" ImageUrl="button.png" OnClick="ImageButton1_Click" ></asp:ImageButton>
	        <asp:Label id="lblResult" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 163px"
		        runat="server" Height="60px" Width="393px"></asp:Label>
            <asp:Literal ID="Literal1" runat="server">Hellow world</asp:Literal>
        </div>
    </form>
</body>
</html>
