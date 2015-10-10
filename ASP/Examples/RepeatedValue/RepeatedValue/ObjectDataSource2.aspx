<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObjectDataSource2.aspx.cs" Inherits="RepeatedValue.ObjectDataSource2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="sourceEmployeesList" runat="server" SelectMethod="GetEmployees"
            TypeName="RepeatedValue.EmployeeDB" />

        <asp:ListBox ID="lstEmployees" runat="server" DataSourceID="sourceEmployeesList" DataTextField="EmployeeID"
            Width="131px" AutoPostBack="True" Height="171px" />

        <asp:ObjectDataSource ID="sourceEmployee" runat="server" SelectMethod="GetEmployee"
		    TypeName="RepeatedValue.EmployeeDB" OnSelecting="sourceEmployee_Selecting">
	        <SelectParameters>
		        <asp:ControlParameter ControlID="lstEmployees" Name="employeeID" PropertyName="SelectedValue" />
	        </SelectParameters>
        </asp:ObjectDataSource>

        <asp:DetailsView ID="DetailsView2" runat="server"
	        DataSourceID="sourceEmployee" Height="50px" Width="125px" />


    </div>
    </form>
</body>
</html>
