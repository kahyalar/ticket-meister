<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Theatre.aspx.cs" Inherits="Theatre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 24%;
        }
        .auto-style2 {
            margin-left: 40px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Date"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlDate" runat="server">
                        <asp:ListItem>Choose a Day</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Theatre Location"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server">
                        <asp:ListItem>Choose a City</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem>Choose a Theatre</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnBack" runat="server" Text="Back" Width="120px" />
                    <asp:Button ID="btnContinue" runat="server" CssClass="auto-style2" Text="Continue" Width="120px" />
                </td>
            </tr>
        </table>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Session.aspx">TEST: Next Page</asp:HyperLink>
        </p>
    </form>
</body>
</html>
