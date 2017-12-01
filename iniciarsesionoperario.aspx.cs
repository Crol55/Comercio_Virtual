using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class iniciarsesionoperario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string nombre = "";
        string contrasena = "";
        int cumple = 0;
        nombre = txtnombre.Text;
        contrasena = txtcontrasena.Text;

        conexionprincipal conexion = new conexionprincipal();
        cumple = conexion.BuscarResponsable(Convert.ToInt32(nombre),contrasena);
        if(cumple==1){// si el id y la contraseña existen en la base de datos responsables procedemos a traer el nit de la empresa, para reconocer que comercio esta conectado
            foreach (DataRow row in conexion.RecuperarNit(Convert.ToInt32(nombre)).Rows)// traemos todos los datos de la tabla aux
            {
                string tipo = row["nit_comercio"].ToString();// recuperamos el tipo del usuario q se intenta loggear
                Global.nit = tipo;
                conexion.mostarmensaje(Global.nit);

            }
            
        Response.Redirect("sesiondecomercio.aspx");
        }
        
    }
}