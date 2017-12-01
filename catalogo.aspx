<%@ Page Language="C#" AutoEventWireup="true" CodeFile="catalogo.aspx.cs" Inherits="catalogo" %>

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
                width: 418px;
            }
            .auto-style3 {
                width: 418px;
                height: 44px;
            }
            .auto-style4 {
                height: 44px;
                width: 80px;
            }
            .auto-style5 {
                width: 80px;
            }
        </style>
    </head>
<body id="top">
    <form id="form1" runat="server">
        <br />
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
        <li class="active"><a href="#">catalogo</a></li>
        <li><a href="sesionclientes.aspx">Volver a usuario</a>
           

        </li>
        <li><a href="carrito.aspx">Ir al carrito</a></li>
        <li><a href="inicial.aspx">cerrar sesion</a>
          
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
                   <td class="auto-style2">
                       <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Black" Text="Productos a la venta en el centro comercial"></asp:Label>
                   </td>
                   <td class="auto-style5">
                       <asp:ImageButton ID="ImageButton1" runat="server" Height="64px" ImageUrl="~/imagenes/carrito.jpg" OnClick="ImageButton1_Click" Width="63px" />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   </td>
                   <td class="auto-style5">
                       <asp:Label ID="lbl1" runat="server"></asp:Label>
                       <br />
                       <br />
                       <asp:Label ID="lblmensaje" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="0" Visible="False"></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style3">
                       <table style="width:100%;">
                           <tr>
                               <td>
                                   <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="CATALOGO DE PRODUCTOS"></asp:Label>
                                   <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="nombre_C" DataValueField="id_categoria" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                   </asp:DropDownList>
                                   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:comercio_virtualConnectionString %>" SelectCommand="SELECT [id_categoria], [nombre_C] FROM [categorias]"></asp:SqlDataSource>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                 
                                   <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" RepeatColumns="4">
                                       <AlternatingItemStyle BackColor="White" />
                                       <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                       <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                       <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                      
                                       <ItemTemplate>
                                           <table class="auto-style1">
                                               <tr>
                                                   <td>nombre:<asp:Label ID="lblnombre" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td>
                                                       &nbsp;<asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("multimedia","~/productos/{0}")%>' />
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td>
                                                       Descripcion :<asp:Label ID="lbldescripcion" runat="server" Text='<%# Eval("descripcion") %>'></asp:Label>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td>
                                                       Precio:
                                                       <asp:Label ID="lblprecio" runat="server" Text='<%# Eval("precio") %>'></asp:Label>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td>Cantidad:<asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td>
                                                       <asp:Button ID="btncarrito" runat="server" OnClick="btncarrito_Click1" Text="Agregar al Carrito" />
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td>
                                                       <asp:Label ID="lblID" runat="server" Text='<%# Eval("id_producto") %>' Visible="False"></asp:Label>
                                                       <asp:Label ID="lblstock" runat="server" Text='<%# Eval("existencia") %>' Visible="False"></asp:Label>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td>
                                                       &nbsp;</td>
                                               </tr>
                                           </table>
                                       </ItemTemplate>
                                       <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                   </asp:DataList>
                               </td>
                           </tr>
                       </table>
                       <br />
                       <br />
                       <br />
                       <br />
                   </td>
                   <td class="auto-style4">
                       &nbsp;</td>
                   <td class="auto-style4">
                       &nbsp;</td>
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
