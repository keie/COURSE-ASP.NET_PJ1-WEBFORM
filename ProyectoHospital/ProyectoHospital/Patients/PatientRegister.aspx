<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientRegister.aspx.cs" Inherits="ProyectoHospital.Pacientes.CreatePatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
    
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br /><br />
            <div class="row">
                <div class="col-12">
                    <h3>CREATE PATIENT</h3>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-4">
                    <label>Apellido</label>
                    <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label>Nombre</label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label>Telefono</label>
                     <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
             <div class="row">
                <div class="col-4">
                    <label>DNI</label>
                    <asp:TextBox ID="txtDni" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4"><label></label></div>
                <div class="col-4"><label></label></div>
            </div>
            <div class="row">                
                <div class="col-12">
                    <asp:Label ID="lblData" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
            <div class="row" style="text-align:right;">
                <div class="col-12">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Patients/Patients.aspx" CssClass="btn btn-secondary">Return</asp:HyperLink>
                     <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" CssClass="btn btn-primary" />
                </div>
            </div>           
        </div>
    </form>
</body>
</html>
