<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pago.aspx.cs" Inherits="pago" %>


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
            width: 335px;
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
              <li><a href="#">Consultas</a>
                   <ul>
            <li><a href="abastecimiento2.aspx">Consultar Solicitudes por prioridad</a></li>
     
           <li><a href="listadogeneral.aspx">Listado General de productos</a></li>
          </ul>

              </li>
        
           
     
        <li><a href="inicial.aspx">Salir</a>
          
        </li>
            <%--  <li class="last"><a href="#">Cerrar</a></li>--%>
      </ul>
    </div>
    <br class="clear" />
  </div>
</div>
<!-- ####################################################################################################### -->

<div class="wrapper col1">
 
    

    
 
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="White" Text="Ver Monto de Ventas"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="fecha" DataValueField="fecha" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:comercio_virtualConnectionString %>" SelectCommand="SELECT [fecha] FROM [pagos]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Monto Q"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("cantidad") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
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