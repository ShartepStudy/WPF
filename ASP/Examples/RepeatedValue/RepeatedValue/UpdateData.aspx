<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateData.aspx.cs" Inherits="RepeatedValue.UpdateData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient" 
	        ConnectionString="<%$ ConnectionStrings:AspNetDB %>"
            SelectCommand="SELECT EmployeeID, FirstName, LastName, City FROM Employees"
            UpdateCommand="UPDATE Employees SET FirstName=@FirstName, LastName=@LastName, City=@City FROM Employees WHERE EmployeeID=@EmployeeID" 
            DeleteCommand="DELETE FROM Employees where EmployeeID = @EmployeeID"
            InsertCommand="INSERT INTO Employees (FirstName, LastName, City) VALUES (@FirstName, @LastName, @City)"
            />
        
        <asp:GridView ID="grid" runat="server"  DataKeyNames="EmployeeID" DataSourceID="SqlDataSource1" AutoGenerateEditButton="true">
            <Columns>
                <asp:CommandField ShowDeleteButton="true" />
            </Columns>
        </asp:GridView>
        
        <br /><br />
        <asp:DetailsView ID="DetailsView1" runat="server" DataSourceID="SqlDataSource1" 
            AutoGenerateInsertButton="true" AllowPaging="true" >
        </asp:DetailsView>

    </div>
    </form>
</body>
</html>
