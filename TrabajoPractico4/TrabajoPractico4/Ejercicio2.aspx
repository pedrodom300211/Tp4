﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TrabajoPractico4.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 2</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 208px;
        }
        .auto-style3 {
            width: 122px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Id Producto:&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddlIdProducto" runat="server">
                <asp:ListItem Value="=">Igual a: </asp:ListItem>
                <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
            </asp:DropDownList>
                    </td>
                    <td colspan="2">
            <asp:TextBox ID="txtIdProducto" runat="server" Width="400px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Id Categoria:&nbsp;&nbsp; <asp:DropDownList ID="ddlIdCategoria" runat="server">
                <asp:ListItem Value="=">Igual a: </asp:ListItem>
                <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
            </asp:DropDownList>
                    </td>
                    <td colspan="2">
            <asp:TextBox ID="txtIdCategoria" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnQuitarFiltro" runat="server" Text="Quitar Filtro" OnClick="btnQuitarFiltro_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="grdProductos" runat="server" style="margin-top: 40px">
        </asp:GridView>
    </form>
</body>
</html>
