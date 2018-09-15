<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoHospital.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type"
    content="text/html; charset=utf-8"/>
    <title></title>

     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <style type="text/css">
        
        .login{
            margin:auto;
            margin-top:auto;
            width:500px;
            height:500px;
        }

        .local{
            max-width:350px;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">

       <div class="login" >
           <br /><br /><br />
             <div class="" >
            <div class="">
                <div class="">
                    <h2>SISTEMA DE CLINICA</h2>
                </div>
            </div> 
            <div class="">
                <div class="">
                    <div class="local">
                        <div class="form-group">
                            <label for="txtUser">Usuario</label>
                            <asp:TextBox ID="txtUser" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtPassword">Contraseña</label>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" ></asp:TextBox>
                        </div>
                        <div class="" style="text-align:right;">
				                <asp:Button ID="btnEnter" runat="server" OnClick="btnEnter_Click" Text="Ingresar" CssClass="btn btn-primary" />
                                <asp:Label ID="lblReq" runat="server" BorderColor="Red" ForeColor="#FF3300" Text="Label" Visible="False"></asp:Label>
                        </div>
                        <div style="text-align:center;">
                            <label>&copy;Todos los Derechos Reservados</label>
                        </div>
                    </div>
                </div>                
            </div>           
        </div>
       </div>
    </form>
</body>
</html>
