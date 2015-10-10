<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListElements.aspx.cs" Inherits="RepeatedValue.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%">
                <tr>
                    <td>
                        <select runat="server" id="Select1" size="3" datatextfield="Value" datavaluefield="Key"
                            name="Select1" />
                    </td>
                    <td>
                        <select runat="server" id="Select2" datatextfield="Value" datavaluefield="Key" name="Select2" />
                    </td>
                    <td>
                        <asp:ListBox runat="server" ID="Listbox1" Size="3" DataTextField="Value" DataValueField="Key" />
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="DropdownList1" DataTextField="Value" DataValueField="Key" />
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="OptionList1" DataTextField="Value" DataValueField="Key" />
                    </td>
                    <td>
                        <asp:CheckBoxList runat="server" ID="CheckList1" DataTextField="Value" DataValueField="Key" />
                    </td>
                </tr>
            </table>
            <asp:Button runat="server" Text="Получить выбранные элементы" ID="cmdGetSelection" OnClick="cmdGetSelection_Click" />

            <br />
            <br />
            <asp:Literal runat="server" ID="Result" EnableViewState="False" />

    </div>
    </form>
</body>
</html>
