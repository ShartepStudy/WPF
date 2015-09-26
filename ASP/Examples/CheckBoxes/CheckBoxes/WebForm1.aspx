<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CheckBoxes.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Отправить" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

    </div>
    </form>
</body>
</html>
