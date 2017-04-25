<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Purchase.aspx.cs" Inherits="Purchase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 36%;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 190px;
        }
        .auto-style4 {
            margin-left: 10px;
        }
        .auto-style5 {
            margin-left: 100px;
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
                <td class="auto-style3">
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                    <asp:Label ID="lblSurname" runat="server" CssClass="auto-style4"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblCreditCardNumber" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblExpirationDate" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblCVV" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label4" runat="server" Text="TOTAL PRICE:" Width="120px"></asp:Label>
                    <asp:Label ID="lblTotalPrice" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnPurchase" runat="server" CssClass="auto-style5" Text="Purchase" Width="198px" OnClick="btnPurchase_Click" />
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
