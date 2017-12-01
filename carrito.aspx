<%@ Page Language="C#" AutoEventWireup="true" CodeFile="carrito.aspx.cs" Inherits="carrito" %>

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
                height: 26px;
            }
            .auto-style3 {
                width: 377px;
            }
            .auto-style4 {
                height: 26px;
                width: 377px;
            }
            .auto-style5 {
                width: 115px;
            }
            .auto-style6 {
                height: 26px;
                width: 115px;
            }
            .auto-style7 {
                width: 157px;
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
        <li class="active"><a href="#">Carrito</a></li>
        <li><a href="inicial.aspx">Agregar mas productos</a>
           

        </li>
        <li><a href="iniciarsesion.aspx">Cerrar sesion</a></li>

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
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Carrito de Compras "></asp:Label>
                <asp:Label ID="lblm" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pagar Carrito" />
                <asp:Label ID="lblpre" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:DataList ID="DataList1" runat="server" Width="263px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
                    <ItemTemplate>
                      
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("descripcion") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("precio") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("existencia") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="lblcantidad"></asp:Label>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("cantidad") %>' ></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("multimedia") %>' />
                                </td>
                                <td>
                                    <asp:Button ID="btnactualizar" runat="server" Text="Actualizar cantidad" OnClick="btnactualizar_Click" />
                                </td>
                                <td>
                                    <asp:Button ID="btneliminar" runat="server" Text="Eliminar producto" OnClick="btneliminar_Click" />
                                </td>
                                <td>

                                    <asp:Label ID="lblid" runat="server" Text='<%# Eval("id") %>'></asp:Label>

                                </td>
                            </tr>
                        </table>
                      
                    </ItemTemplate>
                </asp:DataList>
               
            </td>
            <td class="auto-style6">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style7">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Label7" runat="server" Text="Nombre :" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtnombre" runat="server" Visible="False" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Label8" runat="server" Text="Apellido :" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtapellido" runat="server" Visible="False" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Label9" runat="server" Text="Correo :" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtcorreo" runat="server" Visible="False" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Label10" runat="server" Text="Telefono:" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txttelefono" runat="server" Visible="False" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Label11" runat="server" Text="Direccion:" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtdireccion" runat="server" Visible="False" Width="67px"></asp:TextBox>
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem>13</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Label12" runat="server" Text="# de tarjeta" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtcredito" runat="server" Visible="False" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Aceptar" Visible="False" />
                        </td>
                        <td>
                            <asp:Button ID="Button3" runat="server" Text="Cancelar" Visible="False" OnClick="Button3_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style2">
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Label ID="Label13" runat="server" Font-Size="Medium" ForeColor="Black" Text="Desea convertirse en Socio" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Aceptar" Visible="False" />
                            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Rechazar" Visible="False" />
                        </td>
                    </tr>
                </table>
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
