<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <title></title>
 <style type="text/css">
     .auto-style1 {
        width: 429px;
     }
     .auto-style2 {
        font-size: xx-large;
     }
     .auto-style3 {
        font-size: xx-large;
        color: #009900;
     }
 </style>
</head>
 
<body style="margin-bottom: 384px; height: 484px; background-color:#a9f2f2">
    <h1 class="auto-style3">Приложение</h1>
    <h2>Серверная страница</h2>
    <p style="height: 25px" class="auto-style2"> <strong>Форма ввода клиентских данных</strong></p>
    <form id="form1" runat="server">
        <table style="width: 40%; height: 162px;">
            <tr>
                <td class="auto-style2"><strong>Имя</strong></td>
                <td class="auto-style1">
                <asp:TextBox ID="TextBox1" runat="server" Width="202px"
                 Font-Bold="True" Font-Size="X-Large" ForeColor="Red"
                  Height="24px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Фамилия</strong></td>
                <td class="auto-style1">
                <asp:TextBox ID="TextBox2" runat="server" Width="252px" Font-Bold="True"
                 Font-Size="X-Large" ForeColor="Red"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" ><strong>Страна</strong></td>
                <td class="auto-style1">
                <asp:TextBox ID="TextBox3" runat="server" Font-Bold="True" Font-Size="X-Large" 
                ForeColor="Red"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Font-Bold="True" Font-Size="X-Large" 
        Height="49px" Text="Отправить на сервер" Width="599px" />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" 
        style="font-size: x-large" Text="Сервер получил:"></asp:Label>
    </form>
</body>

</html>
