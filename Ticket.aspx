<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ticket.aspx.cs" Inherits="Ticket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 33%;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 151px;
        }
        .auto-style5 {
            height: 30px;
        }
        .auto-style7 {
            height: 148px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblTitle" runat="server" Font-Bold="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblDate" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblCity" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblTheatre" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Adult:" Width="50px" CssClass="auto-style2"></asp:Label>
                    <asp:Label ID="lblAdultAmount" runat="server" Text="##" Width="60px"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text="Student:" Width="70px"></asp:Label>
                    <asp:Label ID="lblStudentAmount" runat="server" Text="##" Width="60px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblSession" runat="server"></asp:Label>
                    </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Seats:" Width="50px"></asp:Label>
                    <asp:Label ID="lblSeats" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblTotalPrice" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblPNR" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="2">
                    <asp:Label ID="lblBarcode" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" colspan="2">
                    <asp:Label ID="Label4" runat="server" Text="Your e-Ticket is ready. Please do not forget it to bring.  Enjoy!"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
