<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Routes.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Страница 2</h2>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="/" runat="server">На страницу 1</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" NavigateUrl="/Book/fantasy" runat="server">На страницу 3</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
