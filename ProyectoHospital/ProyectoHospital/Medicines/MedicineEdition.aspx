<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicineEdition.aspx.cs" Inherits="ProyectoHospital.Medicines.MedicineEdition" %>

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
            width: 530px;
        }
        .auto-style4 {
            width: 530px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>EDICION DE MEDICINA</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">Codigo Del Medicamento:<asp:Label ID="lblCode" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Nombre Del Medicamento</strong></td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Laboratorio</strong></td>
                    <td>
                        <asp:TextBox ID="txtLab" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Precio</strong></td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Stock</strong></td>
                    <td>
                        <asp:DropDownList ID="ddlStock" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Medicines/Medicines.aspx">Return</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Label ID="lblData" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
