<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio154.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Suma</title>
</head>
<body>
    <h1>Suma de dos números </h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Numero 1:"></asp:Label>&nbsp;<asp:TextBox ID="txbNumero1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Numero 2:"></asp:Label>&nbsp;<asp:TextBox ID="txbNumero2" runat="server"></asp:TextBox>
            <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
        </div>
        <div>

            <asp:Label ID="lblResultado" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
