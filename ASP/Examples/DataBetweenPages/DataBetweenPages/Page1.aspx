<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="DataBetweenPages.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Page2.aspx?data=data_from_querystring" runat="server">
            Отправить данные на Page2 с помощью QueryString
        </asp:HyperLink>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Отправить данные на Page2 с помощью Session" OnClick="Button1_Click" />
        <br /><br />
        <asp:Button ID="Button2" runat="server" Text="Отправить данные на Page2 с помощью Cookies" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
