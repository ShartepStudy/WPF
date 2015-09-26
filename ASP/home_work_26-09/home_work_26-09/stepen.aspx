<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stepen.aspx.cs" Inherits="home_work_26_09.stepen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="число"></asp:Label>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="степень"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="привести" />
        </p>
        <asp:Label ID="Label3" EnableViewState="false" runat="server" Text="результат: "></asp:Label>
    </form>
</body>
</html>
