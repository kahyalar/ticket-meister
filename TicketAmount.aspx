<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TicketAmount.aspx.cs" Inherits="TicketAmount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 30%;
        }
        .auto-style2 {
            margin-left: 40px;
        }
        .auto-style3 {
            margin-left: 15px;
            margin-right: 0px;
        }
        .auto-style4 {
            margin-left: 20px;
        }
        .auto-style7 {
            margin-left: 0px;
        }
        .auto-style9 {
            height: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblTitle" runat="server" Font-Bold="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDate" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCity" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTheatre" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSession" runat="server"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Ticket Amount &amp; Types"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label7" runat="server" Text="Adult" Width="100px"></asp:Label>
                    <asp:Label ID="Label8" runat="server" Text="$12" Width="50px"></asp:Label>
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" Height="25px" Text="-" Width="25px" />
                    <asp:Label ID="lblAdultAmount" runat="server" CssClass="auto-style3" Text="0" Width="30px"></asp:Label>
                    <asp:Button ID="Button6" runat="server" Font-Bold="False" Font-Size="Large" Height="25px" Text="+" Width="25px" />
                    <asp:Label ID="lblAdultTotalPrice" runat="server" CssClass="auto-style4" Text="$0" Width="50px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label11" runat="server" Text="Student" Width="100px"></asp:Label>
                    <asp:Label ID="Label12" runat="server" Text="$8" Width="50px"></asp:Label>
                    <asp:Button ID="Button5" runat="server" Font-Bold="True" Font-Size="Large" Height="25px" Text="-" Width="25px" />
                    <asp:Label ID="lblStudentAmount" runat="server" CssClass="auto-style3" Text="0" Width="30px"></asp:Label>
                    <asp:Button ID="Button7" runat="server" Font-Bold="False" Font-Size="Large" Height="25px" Text="+" Width="25px" />
                    <asp:Label ID="lblStudentTotalPrice" runat="server" CssClass="auto-style4" Text="$0" Width="50px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label15" runat="server" Text="TOTAL" Width="281px"></asp:Label>
                    <asp:Label ID="Label16" runat="server" CssClass="auto-style7" Text="$0" Width="50px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <asp:Button ID="btnBack" runat="server" Text="Back" Width="120px" />
                    <asp:Button ID="btnContinue" runat="server" CssClass="auto-style2" Text="Continue" Width="120px" />
                </td>
            </tr>
        </table>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Seat.aspx">TEST: Next Page</asp:HyperLink>
        </p>
    </form>
</body>
</html>
