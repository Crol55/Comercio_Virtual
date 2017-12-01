<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jerarquia.aspx.cs" Inherits="jerarquia" %>



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
            width: 330px;
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
        <li class="active"><a href="comercios.aspx">Sesion iniciada</a></li>
        <li><a href="xmlzonas.aspx">Zonas de Distribucion</a>
            <ul>
            <li><a href="paginainicio.aspx">modificar Datos</a></li>
            <li><a href="comercios.aspx">darse de baja</a></li>
            <li><a href="#">Inventario</a></li>
          </ul>

        </li>
       
        <li><a href="inicial.aspx">Cerrar Sesion</a>
          
        </li>
            <%--  <li class="last"><a href="#">Cerrar</a></li>--%>
      </ul>
    </div>
    <br class="clear" />
  </div>
</div>
<!-- ####################################################################################################### -->

<div class="wrapper col3">
 
  
    

  
    
 
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="White" Text="CONSULTAR TODAS LAS ZONAS DE DISTRIBUCION"></asp:Label>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar Z." />
            </td>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="White" Text="CONSULTAR JERARQUIA"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="0">todo</asp:ListItem>
                    <asp:ListItem Value="1">Zona 1</asp:ListItem>
                    <asp:ListItem Value="2">Zona 2</asp:ListItem>
                    <asp:ListItem Value="3">Zona 3</asp:ListItem>
                    <asp:ListItem Value="4">Zona 4</asp:ListItem>
                    <asp:ListItem Value="5">Zona 5</asp:ListItem>
                    <asp:ListItem Value="6">Zona 6</asp:ListItem>
                    <asp:ListItem Value="7">Zona 7</asp:ListItem>
                    <asp:ListItem Value="8">Zona 8</asp:ListItem>
                    <asp:ListItem Value="9">Zona 9</asp:ListItem>
                    <asp:ListItem Value="10">Zona 10</asp:ListItem>
                    <asp:ListItem Value="11">Zona 11</asp:ListItem>
                    <asp:ListItem Value="12">Zona 12</asp:ListItem>
                    <asp:ListItem Value="13">Zona 13</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Font-Size="Medium" ForeColor="White" Text="CONSULTAR ZONA VECINA"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="2" ForeColor="White">
                    <HeaderTemplate>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    </HeaderTemplate>
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="ZONA"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text="REGION"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("no_zona") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("nombre_zona") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
              
            </td>
            <td class="auto-style2">

                  <asp:DataList ID="DataList2" runat="server" ForeColor="White">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text="ZONA"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label11" runat="server" Text="REGION"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label12" runat="server" Text="ZONA SUPERIOR"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label13" runat="server" Text='<%# Eval("no_zona") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label14" runat="server" Text='<%# Eval("nombre_zona") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label15" runat="server" Text='<%# Eval("zona_superior") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>

                &nbsp;</td>
            <td class="auto-style2">
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
