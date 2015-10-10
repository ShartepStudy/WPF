<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlDataSource.aspx.cs" Inherits="RepeatedValue.SqlDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient" 
	        ConnectionString="<%$ ConnectionStrings:AspNetDB %>" OnSelected="SqlDataSource1_Selected"
            SelectCommand="SELECT EmployeeID, FirstName, LastName, City FROM Employees"/>

        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" 
            DataTextField="EmployeeID" />
        <br />

        <asp:GridView ID="grid" runat="server" DataSourceID="SqlDataSource1" />

        <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>

        <p>=============================================================================</p>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server"
	        ConnectionString="<%$ ConnectionStrings:AspNetDB %>"
	        SelectCommand="SELECT DISTINCT City FROM Employees" />

        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="City"
	        DataSourceID="SqlDataSource2"  AutoPostBack="true" />

        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ProviderName="System.Data.SqlClient"
	        ConnectionString="<%$ ConnectionStrings:AspNetDB %>" 
	        SelectCommand="SELECT EmployeeID, FirstName, LastName, City FROM Employees 
		        WHERE City=@City">
		        <SelectParameters>
			        <asp:ControlParameter ControlID="DropDownList1" Name="City" PropertyName="SelectedValue" />
		        </SelectParameters>
        </asp:SqlDataSource>

        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource3" />

    </div>
    </form>
</body>
</html>
