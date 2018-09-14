<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicineRegister.aspx.cs" Inherits="ProyectoHospital.Medicines.MedicineRegister" %>

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
            text-align: right;
            width: 479px;
            height: 23px;
        }
        .auto-style4 {
            width: 479px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 479px;
            text-align: right;
        }
        .auto-style7 {
            width: 479px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <strong>REGISTRO DE MEDICINAS</strong></div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"><strong>Nombre Del Medicamento</strong></td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Laboratorio</strong></td>
                <td>
                    <asp:TextBox ID="txtLab" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Precio</strong></td>
                <td>
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Stock</strong></td>
                <td>
                    <asp:DropDownList ID="ddlStock" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style5">
                    <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Registrar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Label ID="lblData" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
