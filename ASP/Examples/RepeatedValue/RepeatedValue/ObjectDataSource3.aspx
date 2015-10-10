<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObjectDataSource3.aspx.cs" Inherits="RepeatedValue.ObjectDataSource3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            TypeName="RepeatedValue.EmployeeDB" SelectMethod="GetEmployees"
            UpdateMethod="UpdateEmployee" OnUpdating="ObjectDataSource1_Updating" />

        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" 
            AutoGenerateEditButton="true">
        </asp:GridView>

    </div>
    </form>
</body>
</html>
