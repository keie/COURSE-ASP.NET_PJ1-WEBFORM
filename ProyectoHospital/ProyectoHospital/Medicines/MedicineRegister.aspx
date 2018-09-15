<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicineRegister.aspx.cs" Inherits="ProyectoHospital.Medicines.MedicineRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
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
    <form id="form1" runat="server" class="container">
        <br />
        <div class="row">
            <div class="col-12">
                 <h2>Registro De Medicinas</h2>
            </div>
            
        </div>
        <div class="row">
            <div class="col-3">
                <div class="form-group">
                    <label for="txtName">Nombre Del Medicamento</label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div> 
            <div class="col-3"><div class="form-group">
                <label for="txtLab">Laboratorio</label>
                <asp:TextBox ID="txtLab" runat="server" CssClass="form-control"></asp:TextBox>
                </div></div> 
            <div class="col-3"><div class="form-group">
                <label for="txtPrice">Precio</label>
                <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
                </div></div>
        </div>
       <div class="row">
            <div class="col-3">
                <div class="form-group">
                    <label for="ddlStock">Stock</label>
                    <asp:DropDownList ID="ddlStock" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
            </div> 
            <div class="col-3"><div class="form-group">
                
                </div></div> 
            <div class="col-3"><div class="form-group">
                
                </div></div>
        </div>
        <div class="row">
            <div class="col-12">
                <div class="" style="text-align:right">
                    <button type="button" onclick="history.back();return 0;" class="btn btn-secondary" >Return</button>
                 <asp:Label ID="lblData" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Registrar" CssClass="btn btn-primary"/>
            </div>
            </div>
            
        </div>
               
    </form>
</body>
</html>
