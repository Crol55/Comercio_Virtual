<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gerentemodificacomercio.aspx.cs" Inherits="gerentemodificacomercio" %>

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
            width: 239px;
        }
        .auto-style3 {
            width: 239px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 135px;
        }
        .auto-style6 {
            height: 26px;
            width: 135px;
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
        <li><a href="#">Modificaciones</a>
            <ul>
            <li><a href="#">modificar Datos</a></li>
            <li><a href="#">darse de baja</a></li>
            <li><a href="#">Inventario</a></li>
          </ul>

        </li>
        <li><a href="iniciarsesion.aspx">Pedidos</a></li>
        <li><a href="#">Cerrar Sesion</a>
          
        </li>
            <%--  <li class="last"><a href="#">Cerrar</a></li>--%>
      </ul>
    </div>
    <br class="clear" />
  </div>
</div>
<!-- ####################################################################################################### -->

<div class="wrapper col12">
 
  
    
 
    <table class="auto-style1">
        <tr>
            <td colspan="3">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Modificacion de Comercio"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label12" runat="server" Font-Size="Medium" ForeColor="White" Text="Para Modificar ingrese nombre de usuario"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Nombre" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtnombre" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:TextBox ID="txtnombreprincipal" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Siglas" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtsigla" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Aceptar" />
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label4" runat="server" ForeColor="White" Text="Direccion" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdir" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label13" runat="server" Font-Size="Medium" ForeColor="White" Text="Puede consultar los comercios "></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label5" runat="server" ForeColor="White" Text="Correo" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcorreo" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Button3" runat="server" Text="Consultar" OnClick="Button3_Click" />
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label6" runat="server" ForeColor="White" Text="fax" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtfax" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label7" runat="server" ForeColor="White" Text="Telefono" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txttelefono" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label8" runat="server" ForeColor="White" Text="Responsale" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtresponsable" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label9" runat="server" ForeColor="White" Text="Producto Propio" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtpropio" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style6">
                <asp:Label ID="Label10" runat="server" ForeColor="White" Text="Producto Comun" Visible="False"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtcomun" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label11" runat="server" ForeColor="White" Text="Dar de Baja" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="rb1" runat="server" Visible="False">
                    <asp:ListItem>Si</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" Visible="False" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
 
  
    
 
    <asp:GridView ID="datosl" runat="server" AutoGenerateColumns="False" DataKeyNames="nombre" DataSourceID="SqlDataSource1" ForeColor="White" Visible="False">
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="nombre" ReadOnly="True" SortExpression="nombre" />
            <asp:BoundField DataField="siglas" HeaderText="siglas" SortExpression="siglas" />
            <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            <asp:BoundField DataField="fax" HeaderText="fax" SortExpression="fax" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
            <asp:BoundField DataField="productopropio" HeaderText="productopropio" SortExpression="productopropio" />
            <asp:BoundField DataField="responsable" HeaderText="responsable" SortExpression="responsable" />
            <asp:BoundField DataField="productocomun" HeaderText="productocomun" SortExpression="productocomun" />
            <asp:BoundField DataField="dadodebaja" HeaderText="dadodebaja" SortExpression="dadodebaja" />
            <asp:BoundField DataField="aceptado" HeaderText="aceptado" SortExpression="aceptado" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:comercio_virtualConnectionString %>" SelectCommand="SELECT [nombre], [siglas], [direccion], [email], [fax], [telefono], [productopropio], [responsable], [productocomun], [dadodebaja], [aceptado] FROM [comercios]"></asp:SqlDataSource>
 
  
    
 
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