<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoHospital.Login" %>

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
            height: 23px;
            text-align: center;
        }
        .auto-style3 {
            width: 439px;
        }
        .auto-style5 {
            width: 439px;
            text-align: right;
        }
        .auto-style6 {
            width: 439px;
            height: 22px;
        }
        .auto-style7 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>SISTEMA DE CLINICA</strong></td>
                </tr>
                <tr>
                    <td class="auto-style5">Usuario</td>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Contrasena</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnEnter" runat="server" OnClick="btnEnter_Click" Text="Ingresar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">
                        <asp:Label ID="lblReq" runat="server" BorderColor="Red" ForeColor="#FF3300" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
