<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Movie.aspx.cs" Inherits="Movie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 44%;
            height: 593px;
        }
        .auto-style3 {
            width: 200px;
            height: 23px;
        }
        .auto-style4 {
            width: 302px;
        }
        .auto-style5 {
            width: 200px;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
            width: 302px;
        }
        .auto-style7 {
            width: 200px;
            height: 300px;
        }
        .auto-style9 {
            width: 200px;
            height: 19px;
        }
        .auto-style10 {
            width: 200px;
            height: 38px;
        }
        .auto-style12 {
            width: 200px;
            height: 24px;
        }
        .auto-style13 {
            margin-left: 20px;
            margin-top: 0px;
            margin-bottom: 0px;
        }
        .auto-style14 {
            margin-left: 100px;
        }
        .auto-style15 {
            margin-left: 0px;
        }
        .auto-style16 {
            margin-left: 20px;
        }
        .auto-style17 {
            margin-left: 40px;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style6">
                <asp:Label ID="lblTitle" runat="server" CssClass="auto-style16" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                    <asp:Image ID="imgMovie" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
            <td class="auto-style4" rowspan="10">
                <asp:Label ID="lblStoryline" runat="server" CssClass="auto-style13" Font-Size="Large" Height="500px" Width="340px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblRating" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="X-Large" Height="40px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Director"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="lblDirector" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Stars"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="lblStars" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Runtime"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Label ID="lblRuntime" runat="server"></asp:Label>
            </td>
            <td class="auto-style4" rowspan="2">
                <asp:Button ID="btnBack" runat="server" CssClass="auto-style15" Height="30px" Text="Back" Width="100px" />
                <asp:Button ID="btnBuy" runat="server" CssClass="auto-style14" Height="30px" Text="Buy Ticket" Width="100px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style12">
                &nbsp;</td>
        </tr>
    </table>
        <asp:Button ID="btnTest" runat="server" OnClick="btnTest_Click" Text="Test" />
    </form>
</body>
</html>
