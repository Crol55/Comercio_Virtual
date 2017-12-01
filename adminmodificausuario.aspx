<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminmodificausuario.aspx.cs" Inherits="adminmodificausuario" %>

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
        }
        .auto-style3 {
            width: 164px;
        }
        .auto-style4 {
            width: 201px;
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
        <li class="active"><a href="sesiongerente.aspx">volver a administrador</a></li>
        <li><a href="#">Modificaciones</a>
            <ul>
            <li><a href="gerentemodificausuario.aspx">usuarios</a></li>
        
          
          </ul>

        </li>

        <li><a href="#">Cerrar Sesion</a>
          
        </li>
            <%--  <li class="last"><a href="#">Cerrar</a></li>--%>
      </ul>
    </div>
    <br class="clear" />
  </div>
</div>
<!-- ####################################################################################################### -->

<div class="wrapper col13">
 
  
    
    <table class="auto-style1">
        <tr>
            <td colspan="3">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Modificacion de Usuario"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label10" runat="server" Font-Size="Medium" ForeColor="White" Text="Ingrese el nombre del usuario para poder modificarlo"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Nombre" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtnombre" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:TextBox ID="txtnombreamodificar" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Apellido" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtapellido" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Aceptar" />
            </td>
            <td class="auto-style3">
                <asp:Label ID="Label4" runat="server" ForeColor="White" Text="Correo" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcorreo" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" ForeColor="White" Text="Tipo" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txttipo" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label6" runat="server" ForeColor="White" Text="Contraseña" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcontrasena" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label7" runat="server" ForeColor="White" Text="Telefono" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txttelefono" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label8" runat="server" ForeColor="White" Text="Dar de baja" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdarbaja" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="btnaceptar" runat="server" Text="Enviar" OnClick="btnaceptar_Click" Visible="False" />
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label9" runat="server" Font-Size="Medium" ForeColor="White" Text="Consultar Clientes"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
 
 
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Visible="False">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
            <asp:BoundField DataField="correo" HeaderText="correo" SortExpression="correo" />
            <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
            <asp:BoundField DataField="contraseña" HeaderText="contraseña" SortExpression="contraseña" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
            <asp:BoundField DataField="dadodebaja" HeaderText="dadodebaja" SortExpression="dadodebaja" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
 
  
    
 
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:comercio_virtualConnectionString %>" SelectCommand="SELECT * FROM [usuarios]"></asp:SqlDataSource>
 
  
    
 
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