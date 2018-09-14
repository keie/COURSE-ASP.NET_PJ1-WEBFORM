<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BedEdition.aspx.cs" Inherits="ProyectoHospital.Beds.BedEdition" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 517px;
        }
        .auto-style4 {
            width: 517px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>EDICION DE CAMAS</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">Numero De Cama:<asp:Label ID="lblCode" runat="server" Text="lblCode"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Precio Diario</strong></td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Categoria</strong></td>
                    <td>
                        <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Estado</strong></td>
                    <td>
                        <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Modificar" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Beds/Beds.aspx">Return</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Label ID="lblData" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
