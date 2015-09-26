<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PlaceHolder.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Имя: "></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Фамилия: "></asp:Label><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br /><br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true" />Отображать ввод отчества

    </div>
    </form>
</body>
</html>
