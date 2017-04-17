<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageMovies.aspx.cs" Inherits="ManageMovies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style14 {
            width: 135px;
        }
        .auto-style15 {
            width: 220px;
        }
        .auto-style16 {
            width: 218px;
        }
        .auto-style17 {
            margin-left: 60px;
        }
        .auto-style18 {
            margin-left: 0px;
        }
        .auto-style19 {
            height: 147px;
        }
        .auto-style20 {
            width: 100%;
            height: 300px;
        }
    </style>
</head>
<body style="width: 1069px; height: 580px">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style16" rowspan="2">
                    <asp:ListBox ID="lbMovies" runat="server" AutoPostBack="True" Height="215px" OnSelectedIndexChanged="lbMovies_SelectedIndexChanged" Width="200px"></asp:ListBox>
                </td>
                <td class="auto-style19">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnClear" runat="server" CssClass="auto-style18" Text="Clear" Width="120px" />
                    <asp:Button ID="btnSave" runat="server" CssClass="auto-style17" Text="Save" Width="120px" />
                </td>
            </tr>
        </table>
        <table class="auto-style20">
            <tr>
                <td class="auto-style15" rowspan="7">
                    <asp:Image ID="imgMovie" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style14">
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Large" Text="Poster Location"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPosterURL" runat="server" Width="650px">~/movies/</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" Text="Title"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" Width="650px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" Text="IMDB Link"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIMDB" runat="server" Width="650px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Director"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDirector" runat="server" Width="650px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Stars"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtStars" runat="server" Width="650px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Runtime"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRuntime" runat="server" Width="650px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" Text="Storyline"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtStoryline" runat="server" Width="650px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
