<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 121px;
            margin-right: 6px;
            margin-bottom: 7px;
        }
        .auto-style2 {
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style7 {
            height: 29px;
        }
        .auto-style12 {
            height: 44px;
        }
        .auto-style13 {
            height: 26px;
            width: 70px;
        }
        .auto-style14 {
            height: 29px;
            width: 70px;
        }
        .auto-style15 {
            margin-left: 125px;
        }
    </style>
</head>
<body style="width: 267px; height: 132px">
    <form id="form1" runat="server">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style13">
                    <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtUsername" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12" colspan="2">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" Width="120px" OnClick="btnLogin_Click" CssClass="auto-style15" />
                </td>
            </tr>
        </table>
    
    </form>
</body>
</html>
