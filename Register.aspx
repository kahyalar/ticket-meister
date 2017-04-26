<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 99%;
        }
        .auto-style2 {
            width: 147px;
        }
        .auto-style3 {
            width: 253px;
        }
        .auto-style5 {
            height: 41px;
        }
        .auto-style6 {
            width: 147px;
            height: 23px;
        }
        .auto-style7 {
            width: 253px;
            height: 23px;
        }
        .auto-style8 {
            height: 23px;
        }
        .auto-style10 {
            margin-left: 0px;
        }
        .auto-style11 {
            margin-right: 0px;
        }
        .auto-style12 {
            margin-left: 3px;
        }
    </style>
</head>
<body style="width: 782px">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Name:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Surname:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSurname" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Username:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUsername" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">City:</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlCity" runat="server">
                        <asp:ListItem>Select a city..</asp:ListItem>
                        <asp:ListItem>Istanbul</asp:ListItem>
                        <asp:ListItem>Eskisehir</asp:ListItem>
                        <asp:ListItem>Izmir</asp:ListItem>
                        <asp:ListItem>Ankara</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Email:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Credit Card Number:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtCreditCard" runat="server" Width="200px" placeholder="Please write 16-digit card number"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtCreditCard" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[0-9]{16}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Expiration Date:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtExpDateMonth" runat="server" Width="20px" placeholder="MM" CssClass="auto-style11"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style12" Font-Size="Large" Text="/" Width="10px"></asp:Label>
                    <asp:TextBox ID="txtExpDateYear" runat="server" Width="20px" placeholder="YY" CssClass="auto-style10"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtExpDateMonth" ErrorMessage="RegularExpressionValidator" ValidationExpression="^([0]{1}[1-9]{1}|[1]{1}[0-2]{1})$"></asp:RegularExpressionValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtExpDateYear" ErrorMessage="RegularExpressionValidator" ValidationExpression="^([1]{1}[7-9]{1}|[2]{1}[0-9]{1})$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">CVV:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtCVV" runat="server" Width="35px" placeholder="XXX"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtCVV" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[0-9]{3}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" colspan="3">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Width="120px" CssClass="auto-style10" />
                </td>
            </tr>
        </table>
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
