using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class adminmodificausuario : System.Web.UI.Page
{
    ArrayList listanombres = new ArrayList();
    ArrayList listacambio = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnaceptar_Click(object sender, EventArgs e)
    {
        string nombreamodificar = "";
        string nombre = "";
        string apellido = "";
        string correo = "";
        string tipo = "";
        string contrasena = "";
        string telefono = "";
        string darbaja = "";

        nombre = txtnombre.Text;
        apellido = txtapellido.Text;
        correo = txtcorreo.Text;
        tipo = txttipo.Text;
        contrasena = txtcontrasena.Text;
        telefono = txttelefono.Text;
        darbaja = txtdarbaja.Text;
        nombreamodificar = txtnombreamodificar.Text;
        if (nombre != "") { listanombres.Add("nombre"); listacambio.Add(nombre); }

        if (apellido != "") { listanombres.Add("apellido"); listacambio.Add(apellido); }

        if (correo != "") { listanombres.Add("correo"); listacambio.Add(correo); }

        if (tipo != "") { listanombres.Add("tipo"); listacambio.Add(tipo); }

        if (contrasena != "") { listanombres.Add("contrasena"); listacambio.Add(contrasena); }

        if (telefono != "") { listanombres.Add("telefono"); listacambio.Add(telefono); }

        if (darbaja != "") { listanombres.Add("dardebaja"); listacambio.Add(darbaja); }




        conexionprincipal conex = new conexionprincipal();
        string[] vector1 = (String[])listacambio.ToArray(typeof(string));
        string[] vector2 = (String[])listanombres.ToArray(typeof(string));
        //listacambio.Clear();
        //listanombres.Clear();

        conex.gerentemodificausuario(nombreamodificar, vector1, vector2);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label3.Visible = true; btnaceptar.Visible = true;
        Label4.Visible = true; txtnombre.Visible = true;
        Label5.Visible = true; txtapellido.Visible = true;
        Label6.Visible = true; txtcorreo.Visible = true;
        Label7.Visible = true; txttipo.Visible = true;
        Label8.Visible = true; txtcontrasena.Visible = true;
        Label2.Visible = true; txttelefono.Visible = true;
        txtdarbaja.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
    }
}