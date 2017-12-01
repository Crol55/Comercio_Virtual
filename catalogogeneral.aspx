<%@ Page Language="C#" AutoEventWireup="true" CodeFile="catalogogeneral.aspx.cs" Inherits="catalogogeneral" %>


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
        .auto-style3 {
            width: 277px;
        }
        .auto-style4 {
            width: 16px;
        }
        .auto-style5 {
            width: 229px;
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
        <li class="active"><a href="#">Sesion Iniciada</a></li>
        
  
        <li><a href="#">Consulta Catalogo</a>
          
       
        <li><a href="inicial.aspx">Cerrar sesion</a>
          
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
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="White" Text="Catalogo General de Productos"></asp:Label>
&nbsp;</td>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="White" Text="Catalogo De productos por comercio"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox1" runat="server" Width="108px" ></asp:TextBox>
                <asp:Button ID="Button1" runat="server" ForeColor="Black" Text="Generar Pdf" OnClick="Button1_Click" />
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" runat="server" Width="107px"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Generar Xml" />
            </td>
            <td class="auto-style4">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nit_empresa">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:comercio_virtualConnectionString %>" SelectCommand="SELECT [nombre], [nit_empresa] FROM [comercios]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Generar Pdf" OnClick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" Text="Generar Xml" OnClick="Button4_Click" />
                <br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
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