<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceRegister.aspx.cs" Inherits="ProyectoHospital.Services.ServiceRegister" %>

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
            width: 540px;
        }
        .auto-style4 {
            width: 540px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>REGISTRO DE SERVICIO</strong></td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Descripcion</strong></td>
                    <td>
                        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Tipo</strong></td>
                    <td>
                        <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Precio</strong></td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Registrar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Label ID="lblData" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
