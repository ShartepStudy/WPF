<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObjectDataSource.aspx.cs" Inherits="RepeatedValue.ObjectDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            TypeName="RepeatedValue.EmployeeDB" SelectMethod="GetEmployees"/>

        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" 
            AutoGenerateColumns="False" DataKeyNames="EmployeeID">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="Имя" />
                <asp:BoundField DataField="LastName" HeaderText="Фамилия" />
                <asp:BoundField DataField="City" HeaderText="Город" />
            </Columns>
        </asp:GridView>

    </div>
    </form>
</body>
</html>
