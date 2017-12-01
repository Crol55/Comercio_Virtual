using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class iniciarsesion : System.Web.UI.Page
{
    string correo = "";
    string contrasena = "";
    string nombre = "";
    string tipofinal = "";

    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        correo = txtcorreo.Text;
        contrasena=txtcontrasena.Text;
        nombre = txtnombre.Text;

   if(correo==""){
            MessageBox.Show("no se ingreso correo");
      }else if(contrasena==""){
            MessageBox.Show("No se ingreso contraseña");
         }
           else if (nombre == ""){

            MessageBox.Show("No se selecciono tipo de usuario");
              }else { // si todos los campos estan llenos, ingresa a verificar a la base de datos

                  conexionprincipal conex = new conexionprincipal();
        //conex.existenciausuarios(nombre,correo,contrasena);
        foreach (DataRow row in conex.existenciausuarios(nombre,correo,contrasena).Rows)// traemos todos los datos de la tabla aux
        {
            string tipo = row["tipo"].ToString();// recuperamos el tipo del usuario q se intenta loggear
            tipofinal = tipo;

        }
      
               if(tipofinal.Equals("Gerente")){
                   //MessageBox.Show("efectivamente fue gerente lo retornado");
                   Response.Redirect("sesiongerente.aspx");

               }else if(tipofinal.Equals("Comercio")){
                       
                   Response.Redirect("sesiondecomercio.aspx");


               }else if(tipofinal.Equals("Administrador")){
                   Response.Redirect("registraradministrador.aspx");
                   //MessageBox.Show("efectivamente fue administrador lo retornado");

               }
               else if (tipofinal.Equals("Usuario"))
               {
                   Global.importante = txtnombre.Text;
                   Response.Redirect("sesionclientes.aspx");
                   //MessageBox.Show("efectivamente fue usuario lo retornado");
              
                
            }else if(tipofinal.Equals("Socio")){
                Global.importante = txtnombre.Text;
                Response.Redirect("sesionclientes.aspx");
                //MessageBox.Show("efectivamente fue socio lo retornado");
              
            }else if(tipofinal.Equals("Abastecimiento")){
                Response.Redirect("abastecimiento.aspx");
            }
               
       }

       
      
    }
    protected void txtcorreo_TextChanged(object sender, EventArgs e)
    {

    }
}