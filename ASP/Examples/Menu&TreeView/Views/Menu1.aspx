<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu1.aspx.cs" Inherits="Views.DataGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .level1
        {
            color: White;
            background-color: Black;
            font-variant: small-caps;
            font-size: large;
            font-weight: bold;
        }

        .level2
        {
            color: Blue;
            font-family: Gill Sans MT !important;
            font-size: medium;
            background-color: Gray;
        }

        .level3
        {
            color: black;
            background-color: Silver;
            font-family: Gill Sans MT !important;
            font-size: small;
        }

        .hoverstyle
        {
            font-weight: bold;
        }

        .level4
        {
            background-color: Gray !important;
            color: White !important;
            font-size: small;
        }   
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Menu id="NavigationMenu1" CssClass="menu1"
            staticdisplaylevels="3"
            staticsubmenuindent="0" 
            orientation="Vertical"
            target="_blank"
            Font-names="Arial, Gill Sans"
            Width="100px"
            runat="server">

            <LevelMenuItemStyles>
                <asp:MenuItemStyle CssClass="level1" />
                <asp:MenuItemStyle CssClass="level2" />
                <asp:MenuItemStyle CssClass="level3" />
                <asp:MenuItemStyle CssClass="level4" />
            </LevelMenuItemStyles>
  
            <StaticHoverStyle CssClass="hoverstyle"/>
  
            <Items>
                <asp:menuitem text="Home" tooltip="Home">
                    <asp:menuitem text="Section 1" tooltip="Section 1">
                        <asp:menuitem text="Item 1" tooltip="Item 1"/>
                        <asp:menuitem text="Item 2" tooltip="Item 2"/>
                        <asp:menuitem text="Item 3" tooltip="Item 3"/>
                    </asp:menuitem>
                    <asp:menuitem text="Section 2" tooltip="Section 2">
                        <asp:menuitem text="Item 1" tooltip="Item 1"/>
                        <asp:menuitem text="Item 2" tooltip="Item 2">
                        <asp:menuitem text="Subitem 1"/>
                        <asp:menuitem text="Subitem 2" />
                        </asp:menuitem>
                        <asp:menuitem text="Item 3" tooltip="Item 3"/>
                    </asp:menuitem>
                </asp:menuitem>
            </Items>
        </asp:Menu>
    
    </div>
    </form>
</body>
</html>
