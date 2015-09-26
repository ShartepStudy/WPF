<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu2.aspx.cs" Inherits="Views.Menu2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:SiteMapDataSource id="nav1" runat="server" />

    <form runat="server">
        <asp:Menu runat="server" DataSourceId="nav1" Target="_blank" />
    </form>
</body>
</html>
