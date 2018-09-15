<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicineEdition.aspx.cs" Inherits="ProyectoHospital.Medicines.MedicineEdition" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <div class="row">
                <div class="col-12">
                    <h3>EDICION DE MEDICINA</h3>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-4">
                    <label>Codigo Del Medicamento</label>
                    <asp:Label ID="lblCode" runat="server" Text="Label" CssClass="form-control"></asp:Label></div>
                <div class="col-4">
                    <label>Nombre Del Medicamento</label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox></div>
                <div class="col-4">
                    <label>Laboratorio</label>
                    <asp:TextBox ID="txtLab" runat="server" CssClass="form-control"></asp:TextBox></div>
            </div>
            <br />
            <div class="row">
                <div class="col-4">
                    <label>Precio</label>
                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox></div>
                <div class="col-4">
                    <label>Stock</label>
                    <asp:DropDownList ID="ddlStock" runat="server" CssClass="form-control">
                    </asp:DropDownList>
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
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Medicines/Medicines.aspx" CssClass="btn btn-secondary">Return</asp:HyperLink>
                    <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Guardar" CssClass="btn btn-primary" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>
