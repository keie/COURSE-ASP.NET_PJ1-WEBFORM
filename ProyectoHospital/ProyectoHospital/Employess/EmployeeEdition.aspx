<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeEdition.aspx.cs" Inherits="ProyectoHospital.Employess.EmployeeEdition" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <div class="row">
                <div class="col-12">
                    <h3>EDICION DE EMPLEADO</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-4">
                    <label>Codigo De Empleado</label>
                    <asp:Label ID="lblCode" runat="server" Text="Label" CssClass="form-control"></asp:Label>
                </div>
                <div class="col-4">
                    <label>Apellidos</label>
                    <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox></div>
                <div class="col-4">
                    <label>Nombre</label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox></div>
            </div>
            <br />
            <div class="row">
                <div class="col-4">
                    <label>Tipo De Empleado</label>
                    <asp:TextBox ID="txtType" runat="server" CssClass="form-control"></asp:TextBox></div>
                <div class="col-4">
                    <label>Cuenta</label>
                    <asp:TextBox ID="txtAccount" runat="server" CssClass="form-control"></asp:TextBox></div>
                <div class="col-4">
                    <label>Contraseña</label>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox></div>
            </div>
            <br />
            <div class="row">
                <div class="col-4">
                    <label>Turno</label>
                    <asp:TextBox ID="txtTurn" runat="server" CssClass="form-control"></asp:TextBox></div>
                <div class="col-4">
                    <label></label>
                </div>
                <div class="col-4">
                    <label></label>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-12">
                    <asp:Label ID="lblData" runat="server" Text="Label" Visible="False"></asp:Label>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-12" style="text-align:right;">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Employess/Employess.aspx" CssClass="btn btn-secondary">Return</asp:HyperLink>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Modificar" CssClass="btn btn-primary"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
