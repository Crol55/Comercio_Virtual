using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
/// <summary>
/// Descripción breve de Global
/// </summary>
public class Global
{
   public static string usuarioconectado="";
   public static string NIT;
   public static string NOMBRE;
   public static string ID;
   public static string Zona;
   public static string CARRITO;
   public static int cantidad;
   public static string importante
   {
       set
       {
           //MessageBox.Show("asignacion");
           usuarioconectado = value;
           //MessageBox.Show("se asigno " + usuarioconectado);
       }
       get
       {
           //MessageBox.Show("retorno");

           return usuarioconectado;
       }
     
   }

   public static string nit
   {
       set { NIT = value; }
       get { return NIT; }
   
   
   }

   public static string nombre {
       set { NOMBRE = value; }
       get { return NOMBRE; }
   }
   public static string id { 
    set { ID = value; }
       get { return ID; }
   
   
   }
   public static string zona {
       set { Zona = value; }
       get { return Zona; }
   }

   public static string carrito
   {
       set { CARRITO = value; }
       get { return CARRITO; }
   }
   public static int valor
   {
       set { cantidad = value; }
       get { return cantidad; }
   }
}