<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePatient.aspx.cs" Inherits="ProyectoHospital.Pacientes.CreatePatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            height: 23px;
        }
        .auto-style3 {
            width: 376px;
        }
        .auto-style4 {
            width: 376px;
            height: 23px;
            text-align: right;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 376px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>CREATE PATIENT</strong></td>
                </tr>
                <tr>
                    <td class="auto-style6">Apellido</td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Nombre</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Telefono</td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">DNI</td>
                    <td>
                        <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" Text="Register" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:HyperLink ID="HyperLink1" runat="server">Return</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
