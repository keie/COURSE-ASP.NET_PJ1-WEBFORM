<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeRegister.aspx.cs" Inherits="ProyectoHospital.Employess.EmployeeRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br /><br />
            <div class="row">
                <div class="col-12">
                    <h2>REGISTRO DE EMPLEADO</h2>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-4">
                    <label for="txtLastName">APELLIDO</label>
                    <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label for="txtName">NOMBRE</label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label for="ddlType">TIPO DE EMPLEADO</label>
                    <asp:DropDownList ID="ddlType" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-4">
                    <label for="txtAccount">CUENTA</label>
                    <asp:TextBox ID="txtAccount" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label for="txtPass">CONTRASEÑA</label>
                    <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label for="ddlTurn">TURNO</label>
                    <asp:DropDownList ID="ddlTurn" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="row">               
                <div class="col-12" style="text-align:right;">
                    <asp:Label ID="lblData" runat="server" Text="Label" Visible="False"></asp:Label>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Employess/Employess.aspx" CssClass="btn btn-secondary">Return</asp:HyperLink>
                    <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Registrar" CssClass="btn btn-primary" />

                </div>
            </div>
        </div>
        <div>
        </div>
    </form>
</body>
</html>
