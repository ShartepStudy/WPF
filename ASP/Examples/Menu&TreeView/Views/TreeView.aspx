<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TreeView.aspx.cs" Inherits="Views.TreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:SiteMapDataSource id="nav1" runat="server" SiteMapProvider="SiteMap1" />

    <form runat="server">
        <asp:TreeView runat="server" DataSourceId="nav1" BackColor="Black" >
            <NodeStyle ForeColor="White" />
        </asp:TreeView>
    </form>
</body>
</html>
