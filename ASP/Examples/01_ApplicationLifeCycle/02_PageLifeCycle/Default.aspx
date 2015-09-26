<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02_PageLifeCycle.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Жизненный цикл страницы</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Button ID="TestButton" Text="Test Button" runat="server" OnClick="Button_Click" />
    </div>
    </form>
</body>
</html>
