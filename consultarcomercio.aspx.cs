using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
public partial class consultarcomercio : System.Web.UI.Page
{
    conexionprincipal conexio = new conexionprincipal();
    byte[] ascii;
   

    bool verdadero;
    protected void Page_Load(object sender, EventArgs e)
    {
      if(!IsPostBack){
          lblm1.Visible = false;
          lblm2.Visible = false;
      }  
      
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
  
        if (IsPostBack)
        {
            cargarcomercios();// referencia a el metodo de abajo
        }
      
    }
    public void cargarcomercios() {
        DataList1.DataSource = conexio.comercios_noaceptados();
        DataList1.DataBind();
    }
    
    public void esconder() {
        lblmm.Visible = false;
        lblm1.Visible = false;
        lblm2.Visible = false;
        txt1.Visible = false;
        txt2.Visible = false;
        btnaceptar.Visible = false;
        btncancelar.Visible = false;
    }
    public void mostrar() {
        lblmm.Visible = true;
        lblm1.Visible = true;
        lblm2.Visible = true;
        txt1.Visible = true;
        txt2.Visible = true;
        btnaceptar.Visible = true;
        btncancelar.Visible = true;
    }
    public void limpiar() {
     
        txt1.Text = "";
        txt2.Text = "";
    
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {

        Button bt = (Button)sender;
        DataListItem fila = (DataListItem)bt.Parent;
        var nit = (Label)fila.Controls[47];
        var nombre = (Label)fila.Controls[37];
        var zona = (Label)fila.Controls[49];
        Global.nit = nit.Text.ToString();
        Global.nombre = nombre.Text.ToString();
        Global.zona = zona.Text.ToString();
        mostrar();
        limpiar();
        lblm.Text = Global.nit;
        lblmmm.Text = Global.nombre;
        

        //conexio.modificarcomercio(nombre.Text.ToString());
        //cargarcomercios();

    }

   
    protected void Button3_Click(object sender, EventArgs e){

        if ((txt1.Text.Equals("")) && (txt2.Text.Equals("")))// verificar si los texbox poseen texto
        {
            conexio.mostarmensaje("debe llenar todas las casillas para dar de alta el comercio");

        }
        else { // si el campo id y contraseña estan llenos
               string id= txt1.Text;
               string contrasena= txt2.Text;
              ascii = Encoding.ASCII.GetBytes(id);
            for (int x = 0; x < ascii.Length; x++)
               {
                   if ((ascii[x] >= 48 && ascii[x] <= 57))
                   {
                       verdadero = true;// nos indica que efectivamente el id esta lleno de digitos
                     

                   } else {// si existe algo diferente a un digito en el id, da error 
                       verdadero = false;
                       conexio.mostarmensaje("El id del Responsable debe tener unicamente caracteres");
                       txt1.Text = "";
                       break;
                   }
            }
                if(verdadero==true){// si el id tiene puros digitos 
                   
                    if (conexio.buscarResponsable(Convert.ToInt32(id)) == 0)// verificamos si el id del responsable ya existe en la base de datos
                    {// si es =0 significa que el id no existe entoncs se puede almacenar

                        conexio.modificarcomercio(Global.nit);// aceptamos el comercio en base de datos
                        conexio.llenarResponsable(Convert.ToInt32(id), contrasena, Global.nombre, Global.nit);// y asignamos el responsable
                        conexio.llenarComercio_zona(Global.nit,Convert.ToInt32(Global.zona));
                        esconder();
                        cargarcomercios();

                        conexio.mostarmensaje("Datos Registrados, comercio aceptado");
                        Global.nit = "";
                        Global.nombre = "";
                        Global.zona = "";

                    } else {
                        conexio.mostarmensaje("El id ya existe en la base de datos, ingrese otro id porfavor");
                        txt1.Text = "";
                    }
                  
                }
        
        }// termina else


    }
    protected void btncancelar_Click(object sender, EventArgs e)
    {
        limpiar();
        esconder();
        Global.nit= "";
        Global.nombre = "";
        verdadero = false;
    }
}