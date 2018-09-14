<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceEdition.aspx.cs" Inherits="ProyectoHospital.Services.ServiceEdition" %>

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
            width: 190px;
        }
        .auto-style3 {
            width: 367px;
        }
        .auto-style4 {
            width: 190px;
        }
        .auto-style5 {
            width: 367px;
            text-align: right;
        }
        .auto-style6 {
            width: 367px;
            height: 23px;
            text-align: right;
        }
        .auto-style7 {
            width: 190px;
            height: 23px;
        }
        .auto-style8 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2"><strong>EDICION DE SERVICIO</strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">Numero De Servicio:<asp:Label ID="lblCode" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>Descripcion</strong></td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6"><strong>Tipo</strong></td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>Precio</strong></td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Modificar" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Services/Services.aspx">Return</asp:HyperLink>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Label ID="lblData" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
