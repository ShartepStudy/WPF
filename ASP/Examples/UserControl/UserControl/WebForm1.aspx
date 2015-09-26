<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UserControl.WebForm1" %>
<%@ Register TagPrefix="apress" TagName="TimeDisplay" Src="TimeDisplay.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      <apress:TimeDisplay id="TimeDisplay1" Format="dddd, dd MMMM yyyy HH:mm:ss tt (GMT z)" runat="server" />
      <br /><br /><hr /><br />
      <apress:TimeDisplay id="TimeDisplay2" runat="server" />

    </div>
    </form>
</body>
</html>
