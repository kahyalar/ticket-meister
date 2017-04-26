<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyTickets.aspx.cs" Inherits="MyTickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
        .auto-style21 {
            margin-left: 480px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstTickets" runat="server" AutoPostBack="True" Height="206px" OnSelectedIndexChanged="lstTickets_SelectedIndexChanged" Width="720px"></asp:ListBox>
        <br />
        <asp:Button ID="btnShowTicket" runat="server" CssClass="auto-style1" Enabled="False" OnClick="btnShowTicket_Click" Text="Show Ticket" Width="120px" />
                    <asp:Button ID="btnReturnHome" runat="server" CssClass="auto-style21" Text="Home Page" Width="120px" OnClick="btnReturnHome_Click" />
    </form>
</body>
</html>
