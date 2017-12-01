<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pedidosproducto.aspx.cs" Inherits="pedidosproducto" %>


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
        <li class="active"><a href="comercios.aspx">Sesion De Comercio iniciada</a></li>
             
        
          
          </ul>

            </li>
        <li><a href="pedidos.aspx">Pedidos</a></li>
        <li><a href="inicial.aspx">Salir</a>
          
        </li>
            <%--  <li class="last"><a href="#">Cerrar</a></li>--%>
      </ul>
    </div>
    <br class="clear" />
  </div>
</div>
<!-- ####################################################################################################### -->

<div class="wrapper col10">
 
  
    
 
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="id_carrito"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="cantidad adquirida"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="nombre"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="descripcion"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="precio"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="existencia"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label14" runat="server" Text='<%# Eval("id_carrito") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label12" runat="server" Text='<%# Eval("cantidad") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label11" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text='<%# Eval("descripcion") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text='<%# Eval("precio") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("existencia") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar Stock" />
                                </td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" Text="Surtir" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
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