<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registraradministrador.aspx.cs" Inherits="registraradministrador" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Comercio Virtual</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link rel="stylesheet" href="layout/styles/layout.css" type="text/css" />
<script type="text/javascript" src="layout/scripts/jquery.min.js"></script>
<script type="text/javascript" src="layout/scripts/jquery.jcarousel.pack.js"></script>
<script type="text/javascript" src="layout/scripts/jquery.jcarousel.setup.js"></script>
 
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
            
             <li><a href="xmlzonas.aspx">Cargar Zonas de Distribucion</a></li>
            <li><a href="inventario.aspx">Inventario</a></li>
          </ul>

        </li>
        <li><a href="iniciarsesion.aspx">Consultas</a>
             <ul>
            <li><a href="paginainicio.aspx">Generar Catalogo</a></li>
             <li><a href="jerarquia.aspx">Zonas de Distribucion</a></li>
            <li><a href="#">Generar inventario</a></li>
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

<div class="wrapper col12">
 
 <div id="fondo">
   <br> <br><br><br><br><br><br><br>
        <h1 id="EtiquetaCentral">Sesion de Administrador del Sistema</h1>
        <h2 id="etiquetabaja">Puede realizar cualquier cambio y consultas</h2>
        

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

