<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Routes.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Страница 3 с параметрами</h2>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" NavigateUrl="/" runat="server">На страницу 1</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" NavigateUrl="/Page2" runat="server">На страницу 2</asp:HyperLink>
    </div>
    </form>
</body>
</html>
