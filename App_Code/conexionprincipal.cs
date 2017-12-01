using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Globalization;
/// <summary>
/// Descripción breve de conexionprincipal
/// </summary>
public class conexionprincipal
{
    public static string estado = "";
    SqlConnection conexion;
    SqlCommand comando;
    SqlDataReader Datos;
    DataTable dt;
    SqlDataAdapter da;
    string tip = "";
    int v = 0;
	public conexionprincipal(){// constructor que se inicia al principio
        try {
            conexion = new SqlConnection("Data Source=.;Initial Catalog=comercio_virtual;Integrated Security=True");
            conexion.Open();
            //MessageBox.Show("Se realizo conexion");
        }catch(Exception e){
          MessageBox.Show("Existe un error en la base de datos"+e.ToString());
        }
	}
//****************************************************************************************************************************
    public int buscarexistenciaentablaauxiliar(string id) { 
     int contador2 = 0;

     try
     {
         // comando = new SqlCommand("SELECT nombre from usuarios; ", conexion);
         comando = new SqlCommand("SELECT *from auxiliar where id='" + id + "'", conexion);
         Datos = comando.ExecuteReader();
         while (Datos.Read())
         {

             contador2++;
         } Datos.Close();
     }catch(Exception e){
         MessageBox.Show("Error en tabla auxiliar "+e.ToString());
     }
     return contador2;
    }
 //***********************************************************************************************************************
    public void mensaje() {
       
    
        MessageBox.Show("ya fue seleccionada 1 vez");
      //  return mensaje;
    }

//**************************************************************************************************************************
    public void msg(string va) {
        MessageBox.Show("el usuario conectado es  "+va);
    }
    public void eliminaraux(string id) { 
    
      try
          {
              comando = new SqlCommand("DELETE FROM auxiliar where id='" + id + "'", conexion);
              comando.ExecuteNonQuery();
             
          }
          catch (Exception ex){
              MessageBox.Show("Error en eliminar registro de tabla aux "+ex.ToString());
          }
          
    }
    //****************************************************************************************************************************

    public DataTable mostrarproductos(string buscacategoria) {
       if(buscacategoria.Equals("0")){// trae todos los productos de la base de datos
           da = new SqlDataAdapter("Select id_producto,nombre,descripcion,precio,multimedia,existencia from productos", conexion);
       
       }else{// trae los productos segun la categoria seleccionada por el usuario
           da = new SqlDataAdapter("Select id_producto,nombre,descripcion,precio,multimedia,existencia from productos where producto_categoria='" + buscacategoria + "'", conexion);
       
       }
       dt = new DataTable();
        da.Fill(dt);
       
        return dt;
    }
    //**********************************************************************************************************************

    public DataTable mostrarAuxiliar() {
        da = new SqlDataAdapter("Select id,nombre,descripcion,precio,existencia,multimedia,cantidad from auxiliar", conexion);
        dt = new DataTable();
        da.Fill(dt);
        
        return dt;
    
    }
    //****************************************************************************************************************************

    public void insertartablaauxiliar(string id,string nombre, string descripcion, string precio,string stock,string imagen,string cantidad){
     //   MessageBox.Show("fue "+id+" "+nombre+" "+descripcion+" "+precio+" "+stock+" "+imagen);
        if (cantidad.Equals("")) { cantidad = "1"; }
        try
        {

            comando = new SqlCommand("insert into auxiliar (id,nombre,descripcion,precio,existencia,multimedia,cantidad) values('" + id + "','" + nombre + "','" + descripcion + "','" + precio + "','" + stock + "','" + imagen + "','" + cantidad + "')", conexion);
            comando.ExecuteNonQuery();
           // MessageBox.Show("Datos Registrados");

        }
        catch (Exception e)
        {
            MessageBox.Show("existio un error en tabla auxiliar" + e.ToString());
        }
    }

    //****************************************************************************************************************************

      public void insertarUsuarios(string nombre,string apellido,string correo,string contraseña,string telefono,string tipo,string dadodebaja,string usuario,int zona) {
        
        try {
            if (tipo.Equals("Socio"))
            {
                comando = new SqlCommand("insert into usuarios (nombre,apellido,correo,tipo,contraseña,telefono,dadodebaja,id_usuario,zona) values('" + nombre + "','" + apellido + "','" + correo + "','" + tipo + "','" + contraseña + "','" + telefono + "','" + dadodebaja + "','" + usuario + "','6')", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos Registrados");
                comando = new SqlCommand("update usuarios set zona='"+zona+"' where id_usuario='"+usuario+"'", conexion);
                comando.ExecuteNonQuery();
        
            }
            else
            {
                comando = new SqlCommand("insert into usuarios (nombre,apellido,correo,tipo,contraseña,telefono,dadodebaja,id_usuario) values('" + nombre + "','" + apellido + "','" + correo + "','" + tipo + "','" + contraseña + "','" + telefono + "','" + dadodebaja + "','" + usuario + "')", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos Registrados");
            }
        }catch(Exception e){
            MessageBox.Show("existio un error al insertar datos"+e.ToString());
        }
    }
      //****************************************************************************************************************************




 
   
    
    public void insertarcomercios(string nombre,string siglas,string dir,string email,int fax,int telefono,string responsable,string propio,string comun,string dadobaja,string aceptado,string nit,int ZONA) {
          

              try
              {

                  comando = new SqlCommand("insert into comercios (nombre,siglas,direccion,email,fax,telefono,responsable,productopropio,productocomun,dadodebaja,aceptado,nit_empresa,id_zona) values('" + nombre + "','" + siglas + "','" + dir + "','" + email + "','" + fax + "','" + telefono + "','" + responsable + "','" + propio + "','" + comun + "','" + dadobaja + "','" + aceptado + "','"+nit+"','"+ZONA+"')", conexion);
                  comando.ExecuteNonQuery();
                  MessageBox.Show("Datos Registrados");

              }
              catch (Exception e)
              {
                  MessageBox.Show("existio un error al insertar datos" + e.ToString());
              }



      }
    //****************************************************************************************************************************











   
      public DataTable existenciausuarios(string usuario, string correo,string contrasena) {// retorna el tipo de usuario que se anda buscando(admin,socio,gerente, etc)
          da = new SqlDataAdapter("select tipo from usuarios where id_usuario='"+usuario+"' and correo='"+correo+"' and contraseña='"+contrasena+"'", conexion);
          dt = new DataTable();
          da.Fill(dt);

          return dt;
      }

  //****************************************************************************************************************************









      public void modificarcomercio(string nit) {

       
              try
              {

                  comando = new SqlCommand("update comercios set aceptado='si' where nit_empresa='"+nit+"'", conexion);
                  comando.ExecuteNonQuery();
              }
              catch (Exception e)
              {
                  MessageBox.Show("error " + e.ToString());
              }

          
      
      }// termina modificarcomercio()

      //****************************************************************************************************************************





    //------------------------------------Gerente modifica cualquier tupla del comercio------------------

      public void gerentecomercio(string []nombres,string [] datos,string nombredato) {
          for (int i = 0; i < datos.Length;i++ )
          {
              try
              {
                  switch(nombres[i]){
                  
                      case "nombre":{
                          comando = new SqlCommand("update comercios set nombre='" + datos[i]+ "' where nombre='"+nombredato+"'", conexion);
                          if (nombredato !=datos[i]) { nombredato = datos[i]; }
                          comando.ExecuteNonQuery();

                      }break;
                      case "siglas": {
                          comando = new SqlCommand("update comercios set siglas='" + datos[i] + "' where nombre='" + nombredato + "'", conexion);
                          comando.ExecuteNonQuery();
                       
                      }break;
                      case "direccion": {
                          MessageBox.Show("si se activo direccion ");
                          comando = new SqlCommand("update comercios set direccion='" + datos[i] + "' where nombre='" + nombredato + "'", conexion);
                          comando.ExecuteNonQuery();
                      } break;
                      case "email": {
                          comando = new SqlCommand("update comercios set email='" + datos[i] + "' where nombre='" + nombredato + "'", conexion);
                          comando.ExecuteNonQuery();
                      } break;
                      case "fax": {
                          comando = new SqlCommand("update comercios set fax='" + datos[i] + "' where nombre='" + nombredato + "'", conexion);
                          comando.ExecuteNonQuery();
                      } break;
                      case "telefono": {
                          comando = new SqlCommand("update comercios set telefono='" + datos[i] + "' where nombre='" + nombredato + "'", conexion);
                          comando.ExecuteNonQuery();
                      } break;
                      case "responsable": {
                          comando = new SqlCommand("update comercios set responsable='" + datos[i] + "' where nombre='" + nombredato + "'", conexion);
                          comando.ExecuteNonQuery();
                      } break;
                      case "productopropio": {
                          comando = new SqlCommand("update comercios set productopropio='" + datos[i] + "' where nombre='" + nombredato + "'", conexion);
                          comando.ExecuteNonQuery();
                      } break;
                      case "productocomun": {
                          comando = new SqlCommand("update comercios set productocomun='" + datos[i] + "' where nombre='" + nombredato + "'", conexion);
                          comando.ExecuteNonQuery();
                      } break;
                      case "dadodebaja": {
                          comando = new SqlCommand("update comercios set dadodebaja='" + datos[i] + "' where nombre='" + nombredato + "'", conexion);
                          comando.ExecuteNonQuery();
                      } break;
                  
                  }
                 
                //  MessageBox.Show("Se ha actualizado la base de datos con exito" + comando);


              }
              catch (Exception e)
              {
                  MessageBox.Show("error " + e.ToString());
              }
            //  MessageBox.Show("Base "+nombres[i]+"datos ingresado "+datos[i]);



          }// cierre de for

         
      }

      //****************************************************************************************************************************



    //--------------------------------------Gerente modifica cualquier tupla de un usuario---------




      public void gerentemodificausuario(string nombren, string[] vector1, string[] vector2)
      {

          for (int i = 0; i < vector1.Length; i++)
          {
              try
              {
                  switch (vector2[i])
                  {

                      case "nombre":
                          {
                              comando = new SqlCommand("update usuarios set nombre='" + vector1[i] + "' where nombre='" + nombren + "'", conexion);
                              if (nombren != vector1[i]) { nombren = vector1[i]; }
                              comando.ExecuteNonQuery();
                          } break;
                      case "apellido":
                          {
                              comando = new SqlCommand("update usuarios set apellido='" + vector1[i] + "' where nombre='" + nombren + "'", conexion);
                              comando.ExecuteNonQuery();

                          } break;
                      case "correo":
                          {
                              comando = new SqlCommand("update usuarios set correo='" + vector1[i] + "' where nombre='" + nombren + "'", conexion);
                              comando.ExecuteNonQuery();
                          } break;
                      case "tipo":
                          {
                              comando = new SqlCommand("update usuarios set tipo='" + vector1[i] + "' where nombre='" + nombren + "'", conexion);
                              comando.ExecuteNonQuery();
                          } break;
                      case "contraseña":
                          {
                              comando = new SqlCommand("update usuarios set contraseña='" + vector1[i] + "' where nombre='" + nombren + "'", conexion);
                              comando.ExecuteNonQuery();
                          } break;
                      case "telefono":
                          {
                              comando = new SqlCommand("update usuarios set telefono='" + vector1[i] + "' where nombre='" + nombren + "'", conexion);
                              comando.ExecuteNonQuery();
                          } break;
                      case "dadodebaja":
                          {
                              comando = new SqlCommand("update usuarios set dadodebaja='" + vector1[i] + "' where nombre='" + nombren + "'", conexion);
                              comando.ExecuteNonQuery();
                          } break;

                  }

                  //  MessageBox.Show("Se ha actualizado la base de datos con exito" + comando);


              }//cierre de switch
              catch (Exception e)
              {
                  MessageBox.Show("error " + e.ToString());
              }




          }// cierre de for




      }


      //****************************************************************************************************************************



      public void operario(string nombre,string apellido, string correo,string contra,string tipo,string telefono) {

          try
          {

              comando = new SqlCommand("insert into operarios (nombre,apellido,correo,contraseña,tipo,telefono) values('" + nombre + "','" + apellido + "','" + correo + "','" + contra + "','" + tipo+ "','" + telefono + "')", conexion);
              comando.ExecuteNonQuery();
              comando = new SqlCommand("update comercios set operario='"+nombre+"' where responsable='"+nombre+"'", conexion);
              comando.ExecuteNonQuery();
              MessageBox.Show("Datos Registrados");

          }
          catch (Exception e)
          {
              MessageBox.Show("existio un error al insertar datos" + e.ToString());
          }

      
      }

      public int buscaroperario(string nombre, string contrasena) {// perteneces a la clase iniciarsesionoperario.aspx 

          int contador = 0;
          int contador2=0;
          int cumplio = 0;

          try
          {
              // comando = new SqlCommand("SELECT nombre from usuarios; ", conexion);
              comando = new SqlCommand("SELECT *from operarios where nombre='" + nombre + "' AND contraseña='" + contrasena + "'", conexion);
              Datos = comando.ExecuteReader();
              while (Datos.Read())
              {

                  contador++;
              }
              Datos.Close();
             
          }
          catch (Exception e)
          {
              MessageBox.Show("Error en la base de datos "+e.ToString());
          }

          try {
            comando = new SqlCommand("SELECT *from comercios where operario='" + nombre + "' AND aceptado='si'", conexion);
              Datos = comando.ExecuteReader();
              while (Datos.Read())
              {

                  contador2++;
              }
              Datos.Close();
          
          }catch(Exception e){
              MessageBox.Show("error "+e.ToString());
          }

          if (contador == 1 && contador2 == 1)
          {

              MessageBox.Show("Bienvenido");
              cumplio = 1;

          }
          else { 
              MessageBox.Show("El Comercio aun no ha sido aceptado por el Gerente"); 
          }
          return cumplio;
      }

      public void crearxml(string ruta,string nitcomercio) {
          XmlDocument documento = new XmlDocument();// creamos el documento xml que almacenara todos los tags
          XmlElement trabajoimpresion = documento.CreateElement("INVENTARIOGENERAL");// referencia al trabajo de impresion
          documento.AppendChild(trabajoimpresion);
          foreach (DataRow row in llenarXmlInventarioComercio(nitcomercio).Rows)
          {
              string id_p = row["id_producto"].ToString();
              string nom = row["nombre"].ToString();
              string ti = row["tipo"].ToString();
              string descripcion = row["descripcion"].ToString();
              string ofertado = row["ofertado"].ToString();
              string multimedia = row["multimedia"].ToString();
              string precio = row["precio"].ToString();
              string existencia = row["existencia"].ToString();
              string id_c = row["producto_categoria"].ToString();
              string nit_Comercio = row["nit_comercio"].ToString();
              string nombre_comercio = row["siglas"].ToString();

              XmlElement datos = documento.CreateElement("PRODUCTOS");
              trabajoimpresion.AppendChild(datos);

              XmlElement fechaCreacion = documento.CreateElement("id_producto");
              fechaCreacion.AppendChild(documento.CreateTextNode(id_p));
              datos.AppendChild(fechaCreacion);

              XmlElement identificador = documento.CreateElement("nombre");
              identificador.AppendChild(documento.CreateTextNode(nom));
              datos.AppendChild(identificador);

              XmlElement nombre = documento.CreateElement("tipo");
              nombre.AppendChild(documento.CreateTextNode(ti));
              datos.AppendChild(nombre);


              XmlElement departamento = documento.CreateElement("descripcion");
              departamento.AppendChild(documento.CreateTextNode(descripcion));
              datos.AppendChild(departamento);

              XmlElement tipo = documento.CreateElement("ofertado");
              tipo.AppendChild(documento.CreateTextNode(ofertado));
              datos.AppendChild(tipo);


              XmlElement totaldehojas = documento.CreateElement("multimedia");
              totaldehojas.AppendChild(documento.CreateTextNode(multimedia));
              datos.AppendChild(totaldehojas);

              XmlElement cantidadDocumentos = documento.CreateElement("precio");
              cantidadDocumentos.AppendChild(documento.CreateTextNode(precio));
              datos.AppendChild(cantidadDocumentos);

              XmlElement paginasimpresas = documento.CreateElement("existencia");
              paginasimpresas.AppendChild(documento.CreateTextNode(existencia));
              datos.AppendChild(paginasimpresas);

              XmlElement paginasblancas = documento.CreateElement("id_categoria");
              paginasblancas.AppendChild(documento.CreateTextNode(id_c));
              datos.AppendChild(paginasblancas);


              XmlElement tamanoimpre = documento.CreateElement("nit_comercio");
              tamanoimpre.AppendChild(documento.CreateTextNode(nit_Comercio));
              datos.AppendChild(tamanoimpre);

              XmlElement formatoimpre = documento.CreateElement("siglas_comercio");
              formatoimpre.AppendChild(documento.CreateTextNode(nombre_comercio));
              datos.AppendChild(formatoimpre);


              documento.Save(@"C:\SAC\CATALOGOPRODUCTOS\" + ruta + ".xml");
          
          
          }

      }

      public void crearxml(string NombreEntrante)
      {
         
          XmlDocument documento = new XmlDocument();// creamos el documento xml que almacenara todos los tags
          XmlElement trabajoimpresion = documento.CreateElement("INVENTARIOGENERAL");// referencia al trabajo de impresion
          documento.AppendChild(trabajoimpresion);
          //-------------------------------------------------------------------------------------------------------------------
          foreach (DataRow row in llenarXmlInventario().Rows)// traemos datos de comercios y productos con (join)
          {
              //string tipo = row["tipo"].ToString();
              string id_p = row["id_producto"].ToString();
              string nom = row["nombre"].ToString();
              string ti = row["tipo"].ToString();
              string descripcion= row["descripcion"].ToString();
              string ofertado = row["ofertado"].ToString();
              string multimedia = row["multimedia"].ToString();
              string precio = row["precio"].ToString();
              string existencia = row["existencia"].ToString();
              string id_c = row["producto_categoria"].ToString();
              string nit_Comercio = row["nit_comercio"].ToString();
              string nombre_comercio = row["siglas"].ToString();

              XmlElement datos = documento.CreateElement("PRODUCTOS");
              trabajoimpresion.AppendChild(datos);

              XmlElement fechaCreacion = documento.CreateElement("id_producto");
              fechaCreacion.AppendChild(documento.CreateTextNode(id_p));
              datos.AppendChild(fechaCreacion);

              XmlElement identificador = documento.CreateElement("nombre");
              identificador.AppendChild(documento.CreateTextNode(nom));
              datos.AppendChild(identificador);

              XmlElement nombre = documento.CreateElement("tipo");
              nombre.AppendChild(documento.CreateTextNode(ti));
              datos.AppendChild(nombre);


              XmlElement departamento = documento.CreateElement("descripcion");
              departamento.AppendChild(documento.CreateTextNode(descripcion));
              datos.AppendChild(departamento);

              XmlElement tipo = documento.CreateElement("ofertado");
              tipo.AppendChild(documento.CreateTextNode(ofertado));
              datos.AppendChild(tipo);


              XmlElement totaldehojas = documento.CreateElement("multimedia");
              totaldehojas.AppendChild(documento.CreateTextNode(multimedia));
              datos.AppendChild(totaldehojas);

              XmlElement cantidadDocumentos = documento.CreateElement("precio");
              cantidadDocumentos.AppendChild(documento.CreateTextNode(precio));
              datos.AppendChild(cantidadDocumentos);

              XmlElement paginasimpresas = documento.CreateElement("existencia");
               paginasimpresas.AppendChild(documento.CreateTextNode(existencia));
              datos.AppendChild(paginasimpresas);

              XmlElement paginasblancas = documento.CreateElement("id_categoria");
              paginasblancas.AppendChild(documento.CreateTextNode(id_c));
              datos.AppendChild(paginasblancas);


              XmlElement tamanoimpre = documento.CreateElement("nit_comercio");
              tamanoimpre.AppendChild(documento.CreateTextNode(nit_Comercio));
              datos.AppendChild(tamanoimpre);

              XmlElement formatoimpre = documento.CreateElement("siglas_comercio");
              formatoimpre.AppendChild(documento.CreateTextNode(nombre_comercio));
              datos.AppendChild(formatoimpre);



          }// cierre de foreach
      
          documento.Save(@"C:\SAC\CATALOGOPRODUCTOS\"+NombreEntrante+".xml");

      }
//--------------------------------------------------------Insertar productos por xml------------------------------
      public void insertarproductos(int id,string nombre,string tipo,string descripcion,string ofertado,
          string multimedia,string precio, int existencia,string  producto_categoria,string NitDelComercio)
      {


          try
          {

              comando = new SqlCommand("insert into productos (id_producto,nombre,tipo,descripcion,ofertado,multimedia,precio,existencia,producto_categoria,nit_comercio) values('" + id + "','" + nombre + "','" + tipo + "','" + descripcion + "','" + ofertado + "','" + multimedia + "','" + precio + "','" + existencia + "','" + producto_categoria + "','"+NitDelComercio+"')", conexion);
              comando.ExecuteNonQuery();
              MessageBox.Show("Datos Registrados");

          }
          catch (Exception e)
          {
              MessageBox.Show("existio un error al insertar datos" + e.ToString());
          }
      }

      //****************************************************************************************************************************




    //--------------------------------------------Insertar zonas por xml------------------------------------
      public void insertarzonas(int zona1,string zona2,int zona3) {
          try {
              comando = new SqlCommand("insert into zonas (no_zona,nombre_zona,zona_superior) values('"+zona1+"','"+zona2+"','"+zona3+"')",conexion);
              comando.ExecuteNonQuery();
          }catch(Exception e){
              MessageBox.Show("Error "+e.ToString());
          }
      
      
      }

    //****************************************************************************************************************************
      public void Insertar_carrito_producto(int id_carrito,int id_producto,int cantidad_adquirida) {
          try { 
            comando = new SqlCommand("insert into carrito_productos(id_carrito,id_producto,cantidad) values('"+id_carrito+"','"+id_producto+"','"+cantidad_adquirida+"')",conexion);
            comando.ExecuteNonQuery();
          }catch(Exception e){
              MessageBox.Show("Error en Carrito_productos"+e.ToString());
          }
        
      
      }
   //*************************************************************************************************************************
      public void insertar_carrito(string usuarioactual,string fecha) {
          MessageBox.Show("el nombre entrante es  "+usuarioactual);
          try
          {
              comando = new SqlCommand("insert into carrito(fecha,id_usuario) values('" + fecha+ "','" +usuarioactual + "')", conexion);
              comando.ExecuteNonQuery();
          }
          catch (Exception e)
          {
              MessageBox.Show("Error en Carrito " + e.ToString());
          }
      }

      public DataTable retornar_idcarrito() {

          da = new SqlDataAdapter("Select id_carrito from carrito", conexion);
          dt = new DataTable();
          da.Fill(dt);

          return dt;
      }

      public void modifica_usuario(string correo,string []vector,string []vector2) {
         if(correo.Equals("")){
             MessageBox.Show("Efectivamente el usuario si esta vacio");
         }
          try {
              for (int x = 0; x < vector.Length;x++ )
              {
                
                   switch(vector[x]){
                         case "nombre":{
                          comando = new SqlCommand("update usuarios set nombre='" + vector2[x]+ "' where correo='"+correo+"'", conexion);
                          comando.ExecuteNonQuery();

                      }break;
                         case "apellido":
                             {
                                 comando = new SqlCommand("update usuarios set apellido='" + vector2[x] + "' where correo='" + correo + "'", conexion);
                                 comando.ExecuteNonQuery();

                             } break;
                         case "telefono":
                             {
                                 comando = new SqlCommand("update usuarios set telefono='" + vector2[x] + "' where correo='" + correo + "'", conexion);
                                 comando.ExecuteNonQuery();


                             } break;



                          }// cierre switch
          

              }// cierre for
              MessageBox.Show("Datos actualizados");
          }catch(Exception e){
              MessageBox.Show("Error en Modifica_usuario   "+e.ToString());
          }


      }

      public void mostarmensaje(string mensaje) {
          MessageBox.Show(mensaje);
      }

    public void eliminar_registros_auxiliar(){

        try {
            comando = new SqlCommand("delete from auxiliar", conexion);
            comando.ExecuteNonQuery();
        
        }catch(Exception e){
            MessageBox.Show("Error en Eliminar_registros_deauxiliar  "+e.ToString());
        }
    
    }

    public void actualizar_cantidad(string cantidad,string id_producto) {
        try
        {
            comando = new SqlCommand("update auxiliar set cantidad='"+cantidad+"' where id='"+id_producto+"'", conexion);
            comando.ExecuteNonQuery();

        }
        catch (Exception e)
        {
            MessageBox.Show("Error en actualizar_cantidad  " + e.ToString());
        }
    
    }

    public DataTable comercios_noaceptados() {
        da = new SqlDataAdapter("Select * from comercios where aceptado ='no'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    }

    public DataTable estado_comercios() {
        da = new SqlDataAdapter("Select nit_empresa,nombre,direccion,telefono,responsable,dadodebaja from comercios", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    
    }
    public void llenarResponsable(int id,string contrasena,string nombre,string nit) {
        try
        {
            comando = new SqlCommand("insert into responsables(id_responsable,contraseña,nombre,dadodebaja,nit_comercio) values('"+id+"','"+contrasena+"','"+nombre+"','no','"+nit+"')", conexion);
            comando.ExecuteNonQuery();

        }
        catch (Exception e)
        {
            MessageBox.Show("Error en Tabla Responsable  " + e.ToString());
        }
    }
    public int buscarResponsable(int id) {

        int cont = 0;

        try
        {
            // comando = new SqlCommand("SELECT nombre from usuarios; ", conexion);
            comando = new SqlCommand("SELECT *from responsables where id_responsable='" + id + "'", conexion);
            Datos = comando.ExecuteReader();
            while (Datos.Read())
            {

                cont++;
            } Datos.Close();
        }
        catch (Exception e)
        {
            MessageBox.Show("Error en tabla responsables " + e.ToString());
        }
        return cont;

    }//----------------------------------------------------------------------------------------------------------------------------------------

    public int BuscarResponsable(int id, string contrasena) {
        int contador = 0;
        try
        {
            // comando = new SqlCommand("SELECT nombre from usuarios; ", conexion);
            comando = new SqlCommand("SELECT *from responsables where id_responsable='" + id + "' AND contraseña='" + contrasena + "'", conexion);
            Datos = comando.ExecuteReader();
            while (Datos.Read())
            {

                contador++;
            }
            Datos.Close();

        }
        catch (Exception e)
        {
            MessageBox.Show("Error en la base de datos " + e.ToString());
        }
        return contador;
    }
    public DataTable RecuperarNit(int id)
    {
        da = new SqlDataAdapter("Select nit_comercio from responsables where id_responsable='" + id + "'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    }

    public void ComercioModificaDatos(string nit,string []vector1,string []vector2) {

        for (int x = 0; x < vector1.Length;x++){
            switch(vector1[x]){
                case "correo":
                    {
                        comando = new SqlCommand("update comercios set email='"+vector2[x]+"' where nit_empresa ='"+nit+"'", conexion);
                        comando.ExecuteNonQuery();

                    } break;
                case "direccion":
                    {
                        comando = new SqlCommand("update comercios set direccion='" + vector2[x] +"' where nit_empresa ='" + nit + "'", conexion);
                        comando.ExecuteNonQuery();

                    } break;
                case "telefono":
                    {
                        comando = new SqlCommand("update comercios set telefono='" + vector2[x] + "' where nit_empresa ='" + nit + "'", conexion);
                        comando.ExecuteNonQuery();

                    } break;
            }// cierre switch
        }//cierre for
        MessageBox.Show("Datos Actualizados");
    }

    public DataTable llenarXmlInventario() {
        da = new SqlDataAdapter("select id_producto,productos.nombre,tipo,descripcion,ofertado,multimedia,precio,existencia,producto_categoria,nit_comercio,siglas from comercios join productos on comercios.nit_empresa=productos.nit_comercio;", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    }

    public DataTable llenarXmlInventarioComercio(string nitdeComercio) {
        da = new SqlDataAdapter("select id_producto,productos.nombre,tipo,descripcion,ofertado,multimedia,precio,existencia,producto_categoria,nit_comercio,siglas from comercios join productos on comercios.nit_empresa=productos.nit_comercio where nit_comercio='"+nitdeComercio+"'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    }

    public DataTable CatalogoGeneral()
    {

        da = new SqlDataAdapter("select id_producto,nombre,tipo,descripcion,multimedia,precio from productos", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;

    }

    public void XmlCatalogoGeneral(string nombrearchivo) {


        XmlDocument documento = new XmlDocument();// creamos el documento xml que almacenara todos los tags
        XmlElement trabajoimpresion = documento.CreateElement("CATALOGOGENERAL");// referencia al trabajo de impresion
        documento.AppendChild(trabajoimpresion);
        //-------------------------------------------------------------------------------------------------------------------
        foreach (DataRow row in CatalogoGeneral().Rows)// traemos datos de comercios y productos con (join)
        {
            //string tipo = row["tipo"].ToString();
            string id_p = row["id_producto"].ToString();
            string nom = row["nombre"].ToString();
            string ti = row["tipo"].ToString();
            string descripcion = row["descripcion"].ToString();
            string multimedia = row["multimedia"].ToString();
            string precio = row["precio"].ToString();
           
           

            XmlElement datos = documento.CreateElement("PRODUCTOS");
            trabajoimpresion.AppendChild(datos);

            XmlElement fechaCreacion = documento.CreateElement("id_producto");
            fechaCreacion.AppendChild(documento.CreateTextNode(id_p));
            datos.AppendChild(fechaCreacion);

            XmlElement identificador = documento.CreateElement("nombre");
            identificador.AppendChild(documento.CreateTextNode(nom));
            datos.AppendChild(identificador);

            XmlElement nombre = documento.CreateElement("tipo");
            nombre.AppendChild(documento.CreateTextNode(ti));
            datos.AppendChild(nombre);


            XmlElement departamento = documento.CreateElement("descripcion");
            departamento.AppendChild(documento.CreateTextNode(descripcion));
            datos.AppendChild(departamento);


            XmlElement totaldehojas = documento.CreateElement("multimedia");
            totaldehojas.AppendChild(documento.CreateTextNode(multimedia));
            datos.AppendChild(totaldehojas);

            XmlElement cantidadDocumentos = documento.CreateElement("precio");
            cantidadDocumentos.AppendChild(documento.CreateTextNode(precio));
            datos.AppendChild(cantidadDocumentos);


        }// cierre de foreach

        documento.Save(@"C:\SAC\CATALOGOPRODUCTOS\" + nombrearchivo + ".xml");

    
    
    }

    public DataTable CatalogoPorComercio(string nitbusqueda) {

        da = new SqlDataAdapter("select id_producto,nombre,tipo,descripcion,multimedia,precio from productos where nit_comercio='"+nitbusqueda+"'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    }

    public void XmlCatalogoPorComercio(string NombreArchivo,string nit) {// se busca segun el nit del comercio
    
        
        XmlDocument documento = new XmlDocument();// creamos el documento xml que almacenara todos los tags
        XmlElement trabajoimpresion = documento.CreateElement("CATALOGOCOMERCIO");// referencia al trabajo de impresion
        documento.AppendChild(trabajoimpresion);
        //-------------------------------------------------------------------------------------------------------------------
        foreach (DataRow row in CatalogoPorComercio(nit).Rows)// traemos datos de comercios y productos con (join)
        {
            //string tipo = row["tipo"].ToString();
            string id_p = row["id_producto"].ToString();
            string nom = row["nombre"].ToString();
            string ti = row["tipo"].ToString();
            string descripcion = row["descripcion"].ToString();
            string multimedia = row["multimedia"].ToString();
            string precio = row["precio"].ToString();
           
           

            XmlElement datos = documento.CreateElement("PRODUCTOS");
            trabajoimpresion.AppendChild(datos);

            XmlElement fechaCreacion = documento.CreateElement("id_producto");
            fechaCreacion.AppendChild(documento.CreateTextNode(id_p));
            datos.AppendChild(fechaCreacion);

            XmlElement identificador = documento.CreateElement("nombre");
            identificador.AppendChild(documento.CreateTextNode(nom));
            datos.AppendChild(identificador);

            XmlElement nombre = documento.CreateElement("tipo");
            nombre.AppendChild(documento.CreateTextNode(ti));
            datos.AppendChild(nombre);


            XmlElement departamento = documento.CreateElement("descripcion");
            departamento.AppendChild(documento.CreateTextNode(descripcion));
            datos.AppendChild(departamento);


            XmlElement totaldehojas = documento.CreateElement("multimedia");
            totaldehojas.AppendChild(documento.CreateTextNode(multimedia));
            datos.AppendChild(totaldehojas);

            XmlElement cantidadDocumentos = documento.CreateElement("precio");
            cantidadDocumentos.AppendChild(documento.CreateTextNode(precio));
            datos.AppendChild(cantidadDocumentos);


        }// cierre de foreach

        documento.Save(@"C:\SAC\CATALOGOPRODUCTOS\" + NombreArchivo+ ".xml");

    
    
    }

    public DataTable listadoGeneralParaResponsable(int digito) {
         switch(digito){
          case 0: {
              da = new SqlDataAdapter("select id_producto,nombre,tipo,descripcion,multimedia from productos", conexion);
    
          } break;
          case 1: {
              da = new SqlDataAdapter("select id_producto,nombre,tipo,descripcion,multimedia,precio from productos where tipo='COMUN'", conexion);
    
          } break;
          case 2:
              {
                  da = new SqlDataAdapter("select id_producto,nombre,tipo,descripcion,multimedia,precio from productos where tipo='PROPIO'", conexion);
              } break;
      }
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    
    }


    public DataTable CatalogoPropio(string nitComercio) {
        da = new SqlDataAdapter("select id_producto,nombre,tipo,descripcion,multimedia,precio from productos where nit_comercio='"+nitComercio+"'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    
    }

    public DataTable InventarioPropio(string nitcomercio) {
        da = new SqlDataAdapter("select id_producto,productos.nombre,tipo,ofertado,multimedia,precio,existencia,nombre_C from productos join categorias on productos.producto_categoria=categorias.id_categoria where nit_comercio='"+nitcomercio+"'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    }

    public void insertarZonaVecina(int no_zona, int zonaVecina) {
        MessageBox.Show("recibiendo "+no_zona+" y tambien "+zonaVecina);
        try {
            comando = new SqlCommand("insert into zona_vecina (no_zona,zona_vecina) values('"+no_zona+"','"+zonaVecina+"')",conexion);
            comando.ExecuteNonQuery();
        }catch(Exception e){
            MessageBox.Show("error en insertar zonavecina "+e.ToString());
        }
    
    }

    public DataTable ConsultarZonas() {

        da = new SqlDataAdapter("select * from zonas", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    
    }
    public DataTable ConsultarZonas(int no_zona)
    {

        da = new SqlDataAdapter("select * from zonas where no_zona='"+no_zona+"'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;

    }

    public int BuscarComercio(string nit) {
        int conta = 0;
        try
        {
          
            comando = new SqlCommand("SELECT * from comercios where nit_empresa='"+nit+"'", conexion);
            Datos = comando.ExecuteReader();
            while (Datos.Read())
            {

                conta++;
            }
            Datos.Close();

        }
        catch (Exception e)
        {
            MessageBox.Show("Error en la base de datos " + e.ToString());
        }
        return conta;
    }

    public int BuscarUsuario(string usuario) {
        int conta = 0;
        try
        {

            comando = new SqlCommand("SELECT * from usuarios where id_usuario='" + usuario + "'", conexion);
            Datos = comando.ExecuteReader();
            while (Datos.Read())
            {

                conta++;
            }
            Datos.Close();

        }
        catch (Exception e)
        {
            MessageBox.Show("Error en la base de datos " + e.ToString());
        }
        return conta;
    
    
    }

    public void GenerarPedido(int id_carrito, int zona) {

        try {
        comando= new SqlCommand("insert into pedidos(id_carrito,zona) values('"+id_carrito+"','"+zona+"')",conexion);
        comando.ExecuteNonQuery();
        }catch(Exception e ){
            MessageBox.Show("Error en tabla pedido "+e.ToString());
        }
    
    }

    public int BuscarTipoDeUsuario(string id) {// busca si el usuario ingresado es socio
        int conta = 0;
        try
        {

            comando = new SqlCommand("SELECT * from usuarios where id_usuario='" +id+ "' and tipo='Socio'", conexion);
            Datos = comando.ExecuteReader();
            while (Datos.Read())
            {

                conta++;
            }
            Datos.Close();

        }
        catch (Exception e)
        {
            MessageBox.Show("Error en la base de datos " + e.ToString());
        }
        return conta;
    
    }

    public void llenarComercio_zona(string nit, int zona) {
        try { 
        comando= new SqlCommand("insert into comercio_zona(nit_comercio,id_zona) values('"+nit+"','"+zona+"')",conexion);
        comando.ExecuteNonQuery();
        }catch(Exception e){
            MessageBox.Show("Error en comercio_zona");
        }
    
    }


    public DataTable RecuperarZona(string nit) {

        da = new SqlDataAdapter("select id_zona from comercios where nit_empresa='"+nit+"'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;

    
    }

    public DataTable RecuperarZona_vecina(int zona)
    {

        da = new SqlDataAdapter("select zona_vecina from zona_vecina where no_zona='" + zona + "'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;


    }

    public DataTable recuperarNit_Utilizando_ZonaVecina(int zona_vecina)
    {
        da = new SqlDataAdapter("select nit_comercio from comercio_zona where id_zona='" + zona_vecina + "';", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;


    }

    public DataTable llenarSolicitudes()
    {
        da = new SqlDataAdapter("select id_pedido,id_producto,cantidad from pedidos join carrito on pedidos.id_carrito=carrito.id_carrito join carrito_productos on carrito.id_carrito=carrito_productos.id_carrito", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;


    }
    public void crearxmlsolicitudes(string nit, int no_solicitud)
    {

        XmlDocument documento = new XmlDocument();// creamos el documento xml que almacenara todos los tags
        XmlElement trabajoimpresion = documento.CreateElement("SOLICITUDES");// referencia al trabajo de impresion
        documento.AppendChild(trabajoimpresion);
        foreach (DataRow row in llenarSolicitudes().Rows)
        {
            string id_pedido = row["id_pedido"].ToString();
            string id_producto = row["id_producto"].ToString();
            string cantidad = row["cantidad"].ToString();


            XmlElement datos = documento.CreateElement("DETALLE_SOLICITUD");
            trabajoimpresion.AppendChild(datos);

            XmlElement fechaCreacion = documento.CreateElement("id_producto");
            fechaCreacion.AppendChild(documento.CreateTextNode(id_producto));
            datos.AppendChild(fechaCreacion);

            XmlElement identificador = documento.CreateElement("cantidad");
            identificador.AppendChild(documento.CreateTextNode(cantidad));
            datos.AppendChild(identificador);

            XmlElement nombre = documento.CreateElement("no_pedido");
            nombre.AppendChild(documento.CreateTextNode(id_pedido));
            datos.AppendChild(nombre);

            DateTime now = DateTime.Now;
            now.ToString("dddd, dd MMMM yyyy HH:mm:ss");


            documento.Save(@"C:\SAC\PEDIDOS\SOLICITUDES\pedido" + id_pedido + ",solicitud" + no_solicitud + ",comercio asociado " + nit +".xml");


        }

    }
    public DataTable RecuperarZonaDeSocio(string usuario) {
        da = new SqlDataAdapter("select zona from usuarios where id_usuario='"+usuario+"'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;

    
    }

    public void VolverUsuarioSocio(string use) {

        try
        {

            comando = new SqlCommand("update usuarios set tipo='Socio' where id_usuario='"+use+"'", conexion);
            comando.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show("error " + e.ToString());
        }

    
    }

    public void llenarsolicitudes(int carrito,string nitcomercio) {

        try
        {

            comando = new SqlCommand("insert into solicitudes(id_carrito,id_comercio) values('"+carrito+"','"+nitcomercio+"')", conexion);
            comando.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show("error " + e.ToString());
        }

    }

    public void prioridad(string tipoprioridad,string id,int carrito) {
        try
        {

            comando = new SqlCommand("update solicitudes set prioridad='"+tipoprioridad+"' where id_comercio='"+id+"' and id_carrito='"+carrito+"'", conexion);
            comando.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show("error " + e.ToString());
        }
    }
    public void insertarsocios(string nombre,string apellido,string correo,string tipo,string contraseña,string telefono,string id,int zona) {
        try
        {

            comando = new SqlCommand("insert into usuarios (nombre,apellido,correo,tipo,contraseña,telefono,dadodebaja,id_usuario,zona) values('" + nombre + "','" + apellido + "','" + correo + "','" + tipo + "','" + contraseña + "','" + telefono + "','no','" +id+ "','"+zona+"')", conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos Registrados");

        }
        catch (Exception e)
        {
            MessageBox.Show("existio un error al insertar datos" + e.ToString());
        }
    }

    public DataTable consultarSolicitudes(string id_comercio) {
        da = new SqlDataAdapter("select * from solicitudes where id_comercio='"+id_comercio+"' and estado='Pendiente'", conexion);
        dt = new DataTable();
        da.Fill(dt);
        
        return dt;
    
    
    
    }
    public DataTable ConsultarTodasLasSolicitudes() {
        da = new SqlDataAdapter("select * from solicitudes", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    
    }

    public void ActualizarSolicitud(string id,int solicitud) {
        try
        {

            comando = new SqlCommand("update solicitudes set estado='Pendiente' where id_comercio='"+id+"' and ID_solicitud='"+solicitud+"'", conexion);
            comando.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show("error " + e.ToString());
        }
    
    }

    public void RechazarSolicitud(string id,int solicitud) { 
    
          try
        {

            comando = new SqlCommand("update solicitudes set estado='Rechazado' where id_comercio='"+id+"' and ID_solicitud='"+solicitud+"'", conexion);
            comando.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show("error " + e.ToString());
        }
    
    
    }

    public void ActualizarEstadoSolicitudes(string id,int carrito) {
        try
        {

            comando = new SqlCommand("update solicitudes set prioridad='Alta' where id_comercio='" + id + "' and Id_carrito='" + carrito+ "'", conexion);
            comando.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show("error " + e.ToString());
        }
    
    }

    public DataTable RecuperarProductosDelCarrito(int id_carrito) {
        da = new SqlDataAdapter("select id_carrito,cantidad,nombre,descripcion,precio,existencia from carrito_productos join productos on carrito_productos.id_producto=productos.id_producto where id_carrito='"+id_carrito+"';", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    
    }


    public DataTable RecuperarSolicitudesPorDropdownlist(string dato) {

        da = new SqlDataAdapter("select * from solicitudes where prioridad='"+dato+"'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    
    
    }

    public DataTable RecuperarSolicitudesPorGerente(string nit) {

        da = new SqlDataAdapter("select ID_solicitud,estado from solicitudes where id_comercio='"+nit+"'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    
    }

    public void InsertarPago(int cantidad,string fecha) {

        try
        {

            comando = new SqlCommand("insert into pagos (cantidad,fecha) values('"+cantidad+"','"+fecha+"')", conexion);
            comando.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show("error " + e.ToString());
        }
    
    }
    public DataTable pago(string fecha) {

        da = new SqlDataAdapter("select cantidad from pagos where fecha='"+fecha+"'", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;
    
    }
    public DataTable pago()
    {

        da = new SqlDataAdapter("select cantidad from pagos", conexion);
        dt = new DataTable();
        da.Fill(dt);

        return dt;

    }
}