<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3b.aspx.cs" Inherits="TrabajoPractico4.Ejercicio3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 3b - Listar Libros</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Listado de libros:<br />
            <br />
            <asp:GridView ID="grvListadoDeLibros" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
