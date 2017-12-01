using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
public partial class paginainicio : System.Web.UI.Page
{

    SqlCommand comando;
  
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string usuario = "";
        string nombre = "";
        string apellido = "";
        string correo = "";
        string contraseña = "";
        string telefono = "";
        string tipo = "";
        string zon = "";
        string baja = "no";
        int mayuscula = 0;
        int minuscula = 0;
        int digito = 0;
        byte[] ascii;
       conexionprincipal cn = new conexionprincipal();// creamos la instancia de la clase conexionprincipal.cs
       usuario = txtuser.Text;
        nombre = txtnombre.Text;
        apellido = txtapellido.Text;
        correo = txtcorreo.Text;
        contraseña = txtcontrasena.Text;
        telefono = txttelefono.Text;
        tipo = RadioButtonList1.SelectedValue;
        zon = DropDownList1.SelectedValue;
       if (nombre == "" || apellido == "" || correo == "" || contraseña == "" || telefono == "" || tipo=="" || usuario=="")
       {
           MessageBox.Show("Rellene todas las casillas");
      
           
       }
       else {

           if (contraseña.Length >= 8){// verificamos si la contraseña tiene 8 caracteres como minimo

               ascii = Encoding.ASCII.GetBytes(contraseña);
               for (int x = 0; x < ascii.Length; x++)
               {
                  // MessageBox.Show("ascii sapbe" + ascii[x]);
                   if ((ascii[x] >= 48 && ascii[x] <= 57))
                   {
                       digito = 1;
                   }
                   else if ((ascii[x] >= 65 && ascii[x] <= 90))
                   {
                       mayuscula = 1;


                   }
                   else if ((ascii[x] >= 97 && ascii[x] <= 122))
                   {
                       minuscula = 1;
                   }
                   
               }
               if(digito==1 && mayuscula==1 && minuscula==1){// si la contraseña cumple con los requisitos
               
       //if (tipo.Equals("operario"))
       //{
       //   // MessageBox.Show("Si ingresa a operario");
       //    cn.operario(nombre,apellido,correo,contraseña,tipo,telefono);
       //}
       //else
       //{}
                   if (telefono.Length <= 8)
                   {
                       int resultado = cn.BuscarUsuario(usuario);
                       if (resultado == 0)
                       {
                           cn.insertarUsuarios(nombre, apellido, correo, contraseña, telefono, tipo, baja,usuario,Convert.ToInt32(zon));// llenaremos la base de datos con los datos de los campos
                           txtnombre.Text = "";
                           txtapellido.Text = "";
                           txtcorreo.Text = "";
                           txtcontrasena.Text = "";
                           txttelefono.Text = "";
                           txtuser.Text = "";
                       }
                       else {
                           cn.mostarmensaje("el usuario ya existe en la base de datos elija otro");
                           txtuser.Text="";
                       }
                     
                    

                   }
                   else {
                       MessageBox.Show("El telefono debe tener 8 caracteres");
                       txttelefono.Text = "";
                          
                   }
          
        
               
               }// end if
           }
           else
           {
               MessageBox.Show("Contraseña invalida, debe poseer 8 caracteres como minimo");
           
           }

          
     
     }
       
       }// else de if y los or



    


}