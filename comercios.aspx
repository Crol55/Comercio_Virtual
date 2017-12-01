<%@ Page Language="C#" AutoEventWireup="true" CodeFile="comercios.aspx.cs" Inherits="comercios" %>

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
            width: 372px;
        }
        .auto-style5 {
            height: 26px;
        }
            .auto-style7 {
                width: 241px;
            }
            .auto-style8 {
                width: 224px;
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
        <li class="active"><a href="#">Comercio</a></li>
        <li><a href="inicial.aspx">Volver al inicio</a>
           

        </li>
        <li><a href="iniciarsesion.aspx">Iniciar Sesion</a></li>
        <li><a href="#">Catalogo</a>
          
        </li>
            <%--  <li class="last"><a href="#">Cerrar</a></li>--%>
      </ul>
    </div>
    <br class="clear" />
  </div>
</div>
<!-- ####################################################################################################### -->

<div class="wrapper col9">
 
       <div id="menucomercio">

           
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Label ID="Label1" runat="server" ForeColor="White" Text="FORMULARIO PARA COMERCIOS" BackColor="Black" Font-Bold="False" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style7">
                    <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Nombre" Font-Bold="False" Font-Size="Medium"></asp:Label>
                    <br />
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtnombre" runat="server" Width="193px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Siglas" Font-Size="Medium"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="txtsiglas" runat="server" Width="193px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label4" runat="server" ForeColor="White" Text="Direccion" Font-Size="Medium"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="txtdireccion" runat="server" Width="137px"></asp:TextBox>
                    <asp:DropDownList ID="DropDownList1" runat="server">
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
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label5" runat="server" ForeColor="White" Text="Email" Font-Size="Large"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server" Width="195px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label6" runat="server" ForeColor="White" Text="Fax" Font-Size="Large"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="txtfax" runat="server" Width="195px" MaxLength="8"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label7" runat="server" ForeColor="White" Text="Telefono" Font-Size="Large"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="txttelefono" runat="server" Width="196px" MaxLength="8"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label8" runat="server" ForeColor="White" Text="Responsable Del Comercio" Font-Bold="True" Font-Size="Medium"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="txtresponsable" runat="server" Width="196px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label9" runat="server" ForeColor="White" Text="Productor propio" Font-Size="Large"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpropio" runat="server" Width="198px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label10" runat="server" ForeColor="White" Text="Producto Comun" Font-Size="Large"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="txtcomun" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="NIT"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtnit" runat="server" MaxLength="20" Width="203px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:Button ID="btnaceptar" runat="server" Text="Aceptar" OnClick="Button1_Click" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label15" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    


        


    </div>



    
 
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
