<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Routes.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Страница 1</h2>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="/Page2" runat="server">На страницу 2</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" NavigateUrl="/Book/fantasy" runat="server">На страницу 3</asp:HyperLink>
    </div>
    </form>
</body>
</html>
