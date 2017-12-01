using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class modificardatoscomercio : System.Web.UI.Page
{
    ArrayList listaDatos = new ArrayList();
    ArrayList listaValor = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
    public void limpiar() {
        txtcorreo.Text = "";
        txtdireccion.Text = "";
        txttelefono.Text = "";
        listaDatos.Clear();
        listaValor.Clear();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string correo = "";
        string direccion = "";
        string telefono = "";

        correo = txtcorreo.Text;
        direccion = txtdireccion.Text;
        telefono = txttelefono.Text;


        if (correo != "") { listaDatos.Add("correo"); listaValor.Add(correo); }
        if (direccion != "") { listaDatos.Add("direccion"); listaValor.Add(direccion); }
        if (telefono != "") { listaDatos.Add("telefono"); listaValor.Add(telefono); }

        string[] vector1 = (String[])listaDatos.ToArray(typeof(string));
        string[] vector2 = (String[])listaValor.ToArray(typeof(string));
        conexionprincipal c = new conexionprincipal();
        //c.mostarmensaje(Global.nit);
        c.ComercioModificaDatos(Global.nit,vector1,vector2);
        limpiar();
    }
    
}