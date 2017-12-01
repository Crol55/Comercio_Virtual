using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
public partial class comercios : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string nombre = "";
        string nit = "";
        string zona = "";
        string sigla = "";
        string direccion = "";
        string email = "";
        int fax = 0; ;
        int telefono = 0 ;
        string responsable = "";
        string propio = "";
        string comun = "";
        string dadobaja="no";
        string aceptado = "no";
//-------------------------------------------------------------------------------
        nombre = txtnombre.Text;
        sigla = txtsiglas.Text;
        direccion = txtdireccion.Text;
        email = txtemail.Text;
        nit = txtnit.Text;
        responsable = txtresponsable.Text;
        propio = txtpropio.Text;
        comun = txtcomun.Text;
        dadobaja = "no";
        zona=DropDownList1.SelectedValue;
        if (nombre == "" || sigla == "" || direccion == "" || email == "" || txtfax.Text == "" || txttelefono.Text == "" || responsable == ""
            || propio == "" || comun == "" || zona=="" || nit=="" )
        {
           
            MessageBox.Show("Debe rellenar todos los campos");
        }
        else {
            fax = Convert.ToInt32(txtfax.Text);
            telefono = Convert.ToInt32(txttelefono.Text);
            conexionprincipal conex = new conexionprincipal();
            int verificador =conex.BuscarComercio(nit);
            if(verificador==0){
                conex.insertarcomercios(nombre, sigla, direccion, email, fax, telefono, responsable, propio, comun, dadobaja, aceptado, nit, Convert.ToInt32(zona));
            
            }else{
               conex.mostarmensaje("Ya existe un comercio registrado con ese # de nit");
               txtnit.Text = "";
            }
          
        }
     }
}