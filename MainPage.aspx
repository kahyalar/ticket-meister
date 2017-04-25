<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 99%;
        }
        .auto-style7 {
            width: 825px;
            height: 115px;
        }
        .auto-style12 {
            height: 23px;
            width: 190px;
        }
        .auto-style13 {
            height: 23px;
            width: 191px;
        }
        .auto-style15 {
            height: 33px;
        }
        .auto-style17 {
            width: 150px;
            height: 34px;
        }
        .auto-style18 {
            width: 341px;
            height: 34px;
        }
        .auto-style19 {
            width: 184px;
            height: 34px;
        }
        .auto-style20 {
            height: 33px;
            width: 150px;
        }
    </style>
</head>
<body style="width: 827px; height: 2510px">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="lblWelcome" runat="server" Text="Welcome "></asp:Label>
                    <asp:Label ID="lblFullName" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:HyperLink ID="hlAdmin" runat="server" NavigateUrl="~/ManageMovies.aspx" Visible="False">Add Movie</asp:HyperLink>
                </td>
                <td class="auto-style17">
                    <asp:Button ID="btnMyTickets" runat="server" OnClick="btnMyTickets_Click" Text="My Tickets" />
                </td>
            </tr>
            <tr>
                <td class="auto-style15" colspan="2">Movies in Theatre</td>
                <td class="auto-style20">
                    &nbsp;</td>
            </tr>
            </table>
        <table class="auto-style7">
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton4" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton6" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton7" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton8" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton9" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton10" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton11" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton12" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton13" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton14" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton15" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton16" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton17" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton18" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton19" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton20" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton21" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton22" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton23" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton24" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton25" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton26" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton27" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton28" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton29" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton30" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton31" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton32" runat="server" Height="300px" ImageAlign="Middle" Width="200px" Visible="False" OnClick="ImageButton_Click" />
                </td>
            </tr>
            </table>
    </form>
</body>
</html>
