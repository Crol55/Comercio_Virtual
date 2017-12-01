<%@ Page Language="C#" AutoEventWireup="true" CodeFile="consultarcomercio.aspx.cs" Inherits="consultarcomercio" %>

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
            width: 158px;
        }
        .auto-style4 {
            width: 119px;
        }
        .auto-style5 {
            width: 165px;
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
        <li class="active"><a href="#">Sesion iniciada</a></li>
        <li><a href="sesiongerente.aspx">Volver</a>
          
        </li>
      
<%--         <li><a href="iniciarsesion.aspx">Catalogo</a></li>--%>
        <li><a href="inicial.aspx">Cerrar Sesion</a>
          
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
            <td class="auto-style2" colspan="2">
                <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="White" Text="Consultar Comercios pendientes a procesar"></asp:Label>
                <asp:Label ID="lblm" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="lblmmm" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" />
            </td>
            <td class="auto-style3">
                <asp:Label ID="lblmm" runat="server" Font-Size="Medium" ForeColor="White" Text="Ingrese id y contraseña para brindarle al comercio." Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style3">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lblm1" runat="server" Text="id Responsable:" ForeColor="White"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt1" runat="server" MaxLength="5" Visible="False" Width="101px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lblm2" runat="server" Text="contraseña:" ForeColor="White"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt2" runat="server" MaxLength="50" Visible="False" Width="99px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Button ID="btnaceptar" runat="server" OnClick="Button3_Click" Text="Aceptar" Visible="False" />
                        </td>
                        <td>
                            <asp:Button ID="btncancelar" runat="server" OnClick="btncancelar_Click" Text="Cancelar" Visible="False" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                <asp:DataList ID="DataList1" runat="server" ForeColor="White" RepeatLayout="Table">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="siglas"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Direccion"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Fax"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="Telefono"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="Responsable"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text="P,Propio"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text="P.Comun"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label11" runat="server" Text="Dado de Baja"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label12" runat="server" Text="Aceptado"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label13" runat="server" Text="NIT"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label14" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label15" runat="server" Text='<%# Eval("siglas") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label16" runat="server" Text='<%# Eval("direccion") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label17" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label18" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label19" runat="server" Text='<%# Eval("telefono") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label20" runat="server" Text='<%# Eval("responsable") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label21" runat="server" Text='<%# Eval("productopropio") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label22" runat="server" Text='<%# Eval("productocomun") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label23" runat="server" Text='<%# Eval("dadodebaja") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label24" runat="server" Text='<%# Eval("aceptado") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label25" runat="server" Text='<%# Eval("nit_empresa") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label26" runat="server" Text='<%# Eval("id_zona") %>' Visible="False"></asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Dar de alta" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
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
