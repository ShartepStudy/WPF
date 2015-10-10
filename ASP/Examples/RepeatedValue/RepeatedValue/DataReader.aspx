<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataReader.aspx.cs" Inherits="RepeatedValue.DataReader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox 
            ID="ListBox1" 
            runat="server" 
            SelectionMode="Multiple" 
	        DataTextField="FullName"
            DataValueField="EmployeeID" 
            Height="180px" 
            AutoPostBack="true" 
            OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" />
        <br />
        <asp:Label ID="Result" EnableViewState="false" runat="server" Text="<b>Выбранные элементы</b><br>"></asp:Label>
    </div>
    </form>
</body>
</html>
