using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class modificarclientes : System.Web.UI.Page
{
    string n = "";
    string a = "";
    string co = "";
    string c = "";
    string t = "";
    ArrayList lista = new ArrayList();
    ArrayList listan = new ArrayList();
    conexionprincipal con = new conexionprincipal();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnaceptar_Click(object sender, EventArgs e)
    {
        n = txtnombre.Text;
        a =txtapellido.Text;
        //co = txtcorreo.Text;
        //c = txtcontrasena.Text;
        t = txttelefono.Text;

        if (n != "") { listan.Add("nombre"); lista.Add(n); }
        if (a != "") { listan.Add("apellido"); lista.Add(a); }
        if (t != "") { listan.Add("telefono"); lista.Add(t); }
     
        string[] vectorn = (String[])listan.ToArray(typeof(string));
        string[] vector = (String[])lista.ToArray(typeof(string));
        con.modifica_usuario(Global.importante,vectorn,vector);
        txtnombre.Text = "";
        txtapellido.Text = "";
        txttelefono.Text = "";
    }
}