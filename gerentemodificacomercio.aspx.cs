using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class gerentemodificacomercio : System.Web.UI.Page
{
    ArrayList lista= new ArrayList();
    ArrayList listanombres = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string comercioamodificar="";
        string nombre="";
        string siglas = "";
        string email = "";
        string fax = "";
        string telefono = "";
        string responsable = "";
        string productopropio = "";
        string comun = "";
        string direccion = "";
        string dardebaja = "";
        nombre = txtnombre.Text;
        siglas = txtsigla.Text;
        direccion = txtdir.Text;
        email = txtcorreo.Text;
        fax = txtfax.Text;
        telefono = txttelefono.Text;
        responsable = txtresponsable.Text;
        productopropio = txtpropio.Text;
        comun = txtcomun.Text;
        dardebaja = rb1.SelectedValue;
        comercioamodificar = txtnombreprincipal.Text;
        
        // agregando a la lista todos los datos
        if (nombre != "") { listanombres.Add("nombre");     lista.Add(nombre); }

        if (siglas != "") { listanombres.Add("siglas");    lista.Add(siglas); }

        if (direccion != "") { listanombres.Add("direccion"); lista.Add(direccion); }

        if (email != "") { listanombres.Add("email");     lista.Add(email); }

        if (fax != "") { listanombres.Add("fax");    lista.Add(fax); }

        if (telefono != "") { listanombres.Add("telefono"); lista.Add(telefono); }

        if (responsable != "") { listanombres.Add("responsable"); lista.Add(responsable); }

        if (productopropio != "") { listanombres.Add("productopropio"); lista.Add(productopropio); }

        if (comun != "") { listanombres.Add("productocomun"); lista.Add(comun); }

        if (dardebaja != "") { listanombres.Add("dadodebaja");      lista.Add(dardebaja); }

      
      
        //--------------cierre de lista

        conexionprincipal conexion = new conexionprincipal();
        string[] vector=(String[]) lista.ToArray( typeof( string ) );
        string[] vectornombres = (String[])listanombres.ToArray(typeof(string));
       

        conexion.gerentecomercio(vectornombres,vector,comercioamodificar);
        //conexion.mier(vector);
       // conexion.gerentecomercio(nombre,siglas,email,fax,telefono,responsable,productopropio,comun);

        lista.Clear();
        listanombres.Clear();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label2.Visible = true;
        Label3.Visible = true;
        Label4.Visible = true;
        Label5.Visible = true;
        Label6.Visible = true;
        Label7.Visible = true;
        Label8.Visible = true;
        Label9.Visible = true;
        Label10.Visible = true;
        Label11.Visible = true;

        txtnombre.Visible = true;
        txtsigla.Visible = true;
        txtdir.Visible = true;
        txtcorreo.Visible = true;
        txtfax.Visible = true;
        txttelefono.Visible = true;
        txtresponsable.Visible = true;
        txtpropio.Visible = true;
        txtcomun.Visible = true;
        rb1.Visible = true;
        Button1.Visible = true; 
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        datosl.Visible = true;
      
    }
}