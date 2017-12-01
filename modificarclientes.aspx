<%@ Page Language="C#" AutoEventWireup="true" CodeFile="modificarclientes.aspx.cs" Inherits="modificarclientes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Comercio Virtual</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link rel="stylesheet" href="layout/styles/layout.css" type="text/css" />
<script type="text/javascript" src="layout/scripts/jquery.min.js"></script>
<script type="text/javascript" src="layout/scripts/jquery.jcarousel.pack.js"></script>
<script type="text/javascript" src="layout/scripts/jquery.jcarousel.setup.js"></script>
 
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #cccccc;
        }
        .auto-style2 {
            width: 113px;
        }
        .auto-style3 {
            width: 128px;
        }
    </style>
 
    </head>
<body id="top">
    <form id="form1" runat="server">
<!-- #######################
    
   
    ################################################################################ -->
<div class="wrapper col1">
  <div id="header">
    <div id="logo">
      <h1><a href="inicio.aspx">Comercio Virtual</a></h1>
     <!-- <p>Compra de Productos</p>-->
    </div>
    <div id="topnav">
      <ul>
        <li class="active"><a href="comercios.aspx">Sesion iniciada</a></li>
        <li><a href="sesionclientes.aspx">Volver</a>
            <ul>
            <li><a href="paginainicio.aspx">modificar Datos personales</a></li>
      
          </ul>

        </li>
        <li><a href="carrito.aspx">Compras</a></li>
         <li><a href="catalogo.aspx">Catalogo</a></li>
        <li><a href="inicial.aspx">Cerrar Sesion</a>
          
        </li>
            <%--  <li class="last"><a href="#">Cerrar</a></li>--%>
      </ul>
    </div>
    <br class="clear" />
  </div>
</div>
<!-- ####################################################################################################### -->

<div class="wrapper col11">
 
    <table class="auto-style1">
        <tr>
            <td colspan="3">
                <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Modificar Usuario"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="White" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtnombre" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label3" runat="server" Font-Size="Medium" ForeColor="White" Text="Apellido"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtapellido" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label6" runat="server" Font-Size="Medium" ForeColor="White" Text="Telefono"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txttelefono" runat="server" Width="199px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="btnaceptar" runat="server" Text="Aceptar" OnClick="btnaceptar_Click" />
                <br /> <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                 <br />
                <asp:Label ID="Label7" runat="server"></asp:Label>
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
 
</div>
        
<!-- ####################################################################################################### -->
<div class="wrapper col5">
  <div id="copyright">
    <p class="fl_left">Copyright &copy; 2016  - <a href="#">Comercio Virtual</a></p>
    <p class="fl_right">WEB por <a target="_blank" title="Free Website Templates">C. Orantes</a></p>
    <br class="clear" />
  </div>
</div>
    </form>
</body>
</html>

