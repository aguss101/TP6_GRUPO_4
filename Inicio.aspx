<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_GRUPO_4.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 6px;
            height: 54px;
        }
        .auto-style4 {
            height: 54px;
        }
        .auto-style5 {
            width: 6px;
            height: 99px;
        }
        .auto-style6 {
            height: 99px;
        }
        .auto-style7 {
            width: 6px;
            height: 103px;
        }
        .auto-style8 {
            height: 103px;
        }
        .auto-style9 {
            width: 6px;
            height: 126px;
        }
        .auto-style10 {
            height: 126px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6">
                    <asp:Label ID="group" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="GRUPO N°4"></asp:Label>
                </td>
                <td class="auto-style6"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:HyperLink ID="hpEj1" runat="server" Font-Size="Large" Font-Underline="True" ForeColor="Blue">Ejercicio 1</asp:HyperLink>
                </td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style10">
                    <asp:HyperLink ID="hpEj2" runat="server" Font-Size="Large" Font-Underline="True" ForeColor="Blue">Ejercicio 2</asp:HyperLink>
                </td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
        </table>
    </form>
</body>
</html>
