<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio203.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Productos</title>
    <link href="Styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="contenedor">
        <h1>Productos</h1>
        <form id="frmProductos" runat="server">
            <div class="row">
                <div class="botones">
                    <asp:ImageButton ID="tsbNuevo" runat="server" ImageUrl="Images/nuevo.png" Height="25px" Width="25px" OnClick="tsbNuevo_Click" />
                    <asp:ImageButton ID="tsbGuardar" runat="server" ImageUrl="Images/guardar.png" Height="25px" Width="25px" OnClick="tsbGuardar_Click" />
                    <asp:ImageButton ID="tsbCancelar" runat="server" ImageUrl="Images/cancelar.png" Height="25px" Width="25px" OnClick="tsbCancelar_Click" />
                    <asp:ImageButton ID="tsbEliminar" runat="server" ImageUrl="Images/eliminar.png" Height="25px" Width="25px" OnClick="tsbEliminar_Click" />
                </div>
                <div class="busqueda-id">
                    <asp:Label ID="Label1" runat="server" Text="Buscar por id:"></asp:Label>
                    <asp:TextBox ID="tstId" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="tsbBuscar" runat="server" ImageUrl="Images/buscar.png" Height="25px" Width="25px" OnClick="tsbBuscar_Click" />
                </div>
            </div>
            <div class=" row">
                <div class="col">
                    <div>
                        <asp:Label ID="lblId" runat="server" Text="Id:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <div>
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <asp:Label ID="lblPrecio" runat="server" Text="Precio:"></asp:Label>
                    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <asp:Label ID="lblStock" runat="server" Text="Stock:"></asp:Label>
                    <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">

                <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />

            </div>
        </form>
    </div>
</body>
</html>
