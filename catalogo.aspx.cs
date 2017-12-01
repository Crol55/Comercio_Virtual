using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


public partial class catalogo : System.Web.UI.Page
{
    string variabledebusqueda = "";
 

    conexionprincipal c = new conexionprincipal();
        
    void cargar(string busqueda) {
        conexionprincipal conexion = new conexionprincipal();
        DataList1.DataSource = conexion.mostrarproductos(busqueda);
        DataList1.DataBind();
    }
           
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            variabledebusqueda = "0";
            cargar(variabledebusqueda);
           
        }
     
      //  lblmensaje.Text = ContadorCarrito;
       // Global.importante = "FCB";
   
    }
    

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        Response.Redirect("carrito.aspx");
   
        
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
  
     
    }
   

    protected void btncarrito_Click1(object sender, EventArgs e)
    {
        conexionprincipal cc = new conexionprincipal();
        if(Global.importante.Equals("")){

            cc.mostarmensaje("Debe iniciar Sesion para poder agregar al carrito");
            Response.Redirect("paginainicio.aspx");
        }
        else { 
       
      
        Button bt = (Button)sender;
        DataListItem fila = (DataListItem)bt.Parent;
        var nombrep = (Label)fila.Controls[1];
        Image imagen = (Image)fila.Controls[3];
        var descripcion=(Label)fila.Controls[5];
        var precio=(Label)fila.Controls[7];
        var cantidad = (TextBox)fila.Controls[9];
        var id_prod = (Label)fila.Controls[13];
        var existencia = (Label)fila.Controls[15];
       
        
        string i = id_prod.Text.ToString();
        string n = nombrep.Text.ToString();
        string d = descripcion.Text.ToString();
        string p =precio.Text.ToString();
        string s = existencia.Text.ToString();
        string c=cantidad.Text.ToString();
        string im = imagen.ImageUrl.ToString();


        int valor = cc.buscarexistenciaentablaauxiliar(i);// verificamos si el producto que se quiere agregar al carrito ya fue agregado anteriormente
        if (valor >= 1)
        {
            cc.mensaje();
        }
        else
        {
            cc.insertartablaauxiliar(i, n, d, p, s, im, c);
        }

        }// cierre de if global.importante
       
        //Label existencia = (Label)fila.Controls[11];
        //string x = id_prod.Text;
        //lblmensaje.Text =x;
        //lblmensaje.Text = imagen.ImageUrl;
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        variabledebusqueda = DropDownList1.SelectedValue;
        if (IsPostBack)
        {
           
            cargar(variabledebusqueda);
        }

    }
}