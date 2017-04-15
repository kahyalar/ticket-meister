<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 438px;
            height: 34px;
        }
        .auto-style4 {
            height: 34px;
        }
        .auto-style5 {
            width: 438px;
            height: 346px;
        }
        .auto-style6 {
            height: 346px;
        }
        .auto-style7 {
            width: 1147px;
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
        .auto-style14 {
            height: 34px;
            width: 171px;
        }
        .auto-style15 {
            height: 346px;
            width: 171px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblWelcome" runat="server" Text="Welcome "></asp:Label>
                    <asp:Label ID="lblFullName" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:HyperLink ID="HyperLink1" runat="server">My Tickets</asp:HyperLink>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style5">Movies in Theatre</td>
                <td class="auto-style15">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="130px" />
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtLinks" runat="server" Height="223px" TextMode="MultiLine" Width="561px"></asp:TextBox>
                </td>
            </tr>
            </table>
        <table class="auto-style7">
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/236019314.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/ask_n-krall_g_-united-kingdom.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/baraka-the-shack.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton4" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/ghost-intheshell.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/guzelcrk.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton6" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/H_zl__ve_Ofkeli_8_-_TR_Afis.jpg" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton7" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/Life_Hayat_Poster_y_.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton8" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/logan.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton9" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/nocturama_xlg.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton10" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/otoban.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton11" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/Otopsi_-_The_Autopsy_of_Jane_Doe.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton12" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/Power_Rangers_Afis_Final.jpg" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton13" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/Sirinler_Kayip_Koy_Afis_y.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton14" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/umut-bahcesi-zookeepers-wife.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton15" runat="server" Height="300px" ImageAlign="Middle" Width="200px" ImageUrl="~/movies/Yasamak_Guzel_Sey_AF_S_final2.jpg" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton16" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton17" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton18" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton19" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton20" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton21" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton22" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton23" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton24" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:ImageButton ID="ImageButton25" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton26" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton27" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton28" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton29" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
                <td class="auto-style13">
                    <asp:ImageButton ID="ImageButton30" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
