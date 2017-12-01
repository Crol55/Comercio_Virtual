<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inventariopropio.aspx.cs" Inherits="inventariopropio" %>


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
        <li class="active"><a href="#">Inventario Propio</a></li>
              <li><a href="sesiondecomercio.aspx">Volver</a>
                

              </li>
        
            <li><a href="#">Cargas</a>
                <ul>
        
            <li><a href="cargarxml.aspx">Cargar productos(xml)</a></li>
            
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

<div class="wrapper col16">
 
     

    
    
 
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Black" Text="Inventario Propio"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black">
                    <AlternatingItemStyle BackColor="PaleGoldenrod" />
                    <FooterStyle BackColor="Tan" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text="ID"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text="NOMBRE"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="TIPO"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="OFERTADO"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="MULTIMEDIA"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="PRECIO"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="STOCK"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="CATEGORIA"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label11" runat="server" Text='<%# Eval("id_producto") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label17" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label16" runat="server" Text='<%# Eval("tipo") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label15" runat="server" Text='<%# Eval("ofertado") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label14" runat="server" Text='<%# Eval("multimedia") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label13" runat="server" Text='<%# Eval("precio") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label12" runat="server" Text='<%# Eval("existencia") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("nombre_C") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                </asp:DataList>
            </td>
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