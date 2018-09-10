<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="ProyectoHospital.Employess.Employees" %>

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
            height: 24px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 529px;
        }
        .auto-style5 {
            height: 23px;
            width: 529px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2"><strong>EMPLEADOS</strong></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="codigo_empleado" DataSourceID="Data" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="558px" Height="130px">
                        <AlternatingRowStyle BackColor="Gainsboro" />
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="codigo_empleado" HeaderText="codigo_empleado" InsertVisible="False" ReadOnly="True" SortExpression="codigo_empleado" />
                            <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
                            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                            <asp:BoundField DataField="tipo_empleado" HeaderText="tipo_empleado" SortExpression="tipo_empleado" />
                            <asp:BoundField DataField="cuenta" HeaderText="cuenta" SortExpression="cuenta" />
                            <asp:BoundField DataField="turno" HeaderText="turno" SortExpression="turno" />
                             
                        </Columns>
                       
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="Data" runat="server" ConnectionString="<%$ ConnectionStrings:auroraConnectionString %>" SelectCommand="SELECT [codigo_empleado], [apellido], [nombre], [tipo_empleado], [cuenta], [turno] FROM [EMPLEADO]"></asp:SqlDataSource>
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button3" runat="server" Text="Button" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <asp:Button ID="Button2" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
