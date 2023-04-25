<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3a.aspx.cs" Inherits="TrabajoPractico4.Ejercicio3a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 3a - Seleccion Tema</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            Seleccionar Tema:
            <asp:DropDownList ID="ddlTemas" runat="server">
                <asp:ListItem Value="1">Tema 1</asp:ListItem>
                <asp:ListItem Value="2">Tema 2</asp:ListItem>
                <asp:ListItem Value="3">Tema 3</asp:ListItem>
            </asp:DropDownList>
        </p>
        <div>
            <asp:LinkButton ID="lbtnVerLibros" runat="server" OnClick="lbtnVerLibros_Click">Ver libros</asp:LinkButton>
        </div>
    </form>
</body>
</html>
