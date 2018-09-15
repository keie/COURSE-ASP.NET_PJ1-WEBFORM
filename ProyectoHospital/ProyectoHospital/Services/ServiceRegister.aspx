<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceRegister.aspx.cs" Inherits="ProyectoHospital.Services.ServiceRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
   
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-12"><h3>REGISTRO DE SERVICIO</h3></div>
            </div>
            <div class="row">
                <div class="col-4">
                   <label>Descripcion</label>
                    <asp:TextBox ID="txtDesc" runat="server" CssClass="form-control"></asp:TextBox>
                </div> 
                <div class="col-4">
                   <label>Tipo</label> 
                    <asp:TextBox ID="txtType" runat="server" CssClass="form-control"></asp:TextBox>
                </div> 
                <div class="col-4">
                   <label>Precio</label>
                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
                </div> 
                </div>
            <div class="row">
                <div class="col-12">
                     <asp:Label ID="lblData" runat="server" Text="Label"></asp:Label>
                </div>
            </div> 
            <div class="row">
                <div class="col-12">
                     <button type="button" onclick="history.back();return 0;" class="btn btn-secondary" >Return</button>
                    <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Registrar" />
                </div>
            </div> 

        </div>
    </form>
</body>
</html>
