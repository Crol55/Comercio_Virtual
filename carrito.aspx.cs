using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;
using System.Globalization;
public partial class carrito : System.Web.UI.Page
{
   
    string identificador;
    conexionprincipal conex = new conexionprincipal();
    ArrayList listazona = new ArrayList();
    ArrayList listanit = new ArrayList();
    int[] vectorzona;
    string zo;
    public void cargar() {// traemos los registros de auxiliar y los agregamos al DataLista1
        DataList1.DataSource = conex.mostrarAuxiliar();
        DataList1.DataBind();
        

    }
    public void trasladar(int id) {// para traer todos los registros que estan en la tabla auxiliar
        foreach (DataRow row in conex.mostrarAuxiliar().Rows)// traemos todos los datos de la tabla aux
        {
            string id_producto = row["id"].ToString();// recuperamos el id de todos los registros del datatable (conex.mostrarcarrito)
            string cantidad = row["cantidad"].ToString();
            conex.Insertar_carrito_producto(Convert.ToInt32(id),Convert.ToInt32(id_producto),Convert.ToInt32(cantidad));// y los reinsertamos en carrito
           
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
           
            if (Global.importante.Equals(""))
            {
               
                //DateTime now = DateTime.Now;


                //lblm.Text = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                conex.mostarmensaje("Debes iniciar sesion para poder utilizar el carrito");
                Response.Redirect("paginainicio.aspx");
            }
            else {
                cargar();
            
            }
            
        }
      
    }
    protected void btneliminar_Click(object sender, EventArgs e)// eliminar registros del carrito
    {

        Button boton = (Button)sender;
        DataListItem fila = (DataListItem)boton.Parent;
        var id = (Label)fila.Controls[19];
        lblm.Text = id.Text;

        conex.eliminaraux(id.Text.ToString());// eliminamos los productos seleccionados por el usuario 
      if(IsPostBack){// si ya fue al servidor varias veces 

          cargar();// traemos denuevo la informacion de la tabla auxiliar y la actualiza


      }
      
    }
    protected void Button1_Click(object sender,EventArgs e)
    {
      int verificador = conex.BuscarTipoDeUsuario(Global.importante);
        if (verificador == 0)// si es 0 es porque el usuarios es tipo USUARIO
        {

            Label7.Visible = true; txtnombre.Visible = true;
            Label8.Visible = true; txtapellido.Visible = true;
            Label9.Visible = true; txtcorreo.Visible = true;
            Label10.Visible = true; txttelefono.Visible = true;
            Label11.Visible = true; txtdireccion.Visible = true;
            Label12.Visible = true; txtcredito.Visible = true;
            Button2.Visible = true; Button3.Visible = true;
            DropDownList1.Visible = true;
        
        }
        else {// ENTONCS el usuarios es tipo SOCIO 
            //conex.mostarmensaje("es un socio");
            conex.insertar_carrito(Global.importante, "23/10/2016");// creamos el registro en la tabla "carrito"
            foreach (DataRow row in conex.retornar_idcarrito().Rows)
            {
                identificador = row["id_carrito"].ToString();
            }// recuperamos el ultimo registro de carrito hecho o escrito en la base de datos para poder asignarle al comprador los productos
            int idcarr = Convert.ToInt32(identificador);

            trasladar(idcarr);//llenamos carrito_productos
            conex.eliminar_registros_auxiliar();// eliminamos todo de la tabla auxiliar
            foreach (DataRow row in conex.RecuperarZonaDeSocio(Global.importante).Rows)
            {
                 zo = row["zona"].ToString();
            } 
               
            conex.GenerarPedido(idcarr, Convert.ToInt32(zo));
            listazona.Add(zo);// añadimos la zona principal
            cargar();
            recuperarNIT(Convert.ToInt32(zo),idcarr);
            ocultarbotones();
            DateTime now = DateTime.Now;


            //lblm.Text = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            conex.InsertarPago(Global.valor, now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            conex.mostarmensaje("Pedido Almacenado");
        }

 }
    




    protected void Button2_Click(object sender, EventArgs e)
    {// este boton es el ultimo que actualiza la compra y bases de datos, carrito, carrito_productos 
                  string nombre=txtnombre.Text;
       
                 string apellido=txtapellido.Text;
                 string correo=txtcorreo.Text;
                 string telefono = txttelefono.Text; ;
                 string direccion=txtdireccion.Text;
                 string zona= DropDownList1.SelectedValue;
                 string tarjeta=txtcredito.Text;

        if(nombre=="" || apellido=="" || correo=="" || telefono=="" || direccion=="" || zona=="" || tarjeta==""){
            // verificar si los campos estan llenos
            conex.mostarmensaje("Debe rellenar todos los campos para comprar los productos");


        }else{
            conex.insertar_carrito(Global.importante, "2/11/2016");// creamos el registro en la tabla "carrito"
            foreach (DataRow row in conex.retornar_idcarrito().Rows)
            {
                identificador = row["id_carrito"].ToString();
            }// recuperamos el ultimo registro de carrito hecho o escrito en la base de datos para poder asignarle al comprador los productos
            int idcarr = Convert.ToInt32(identificador);

            trasladar(idcarr);//llenamos carrito_productos
            conex.eliminar_registros_auxiliar();// eliminamos todo de la tabla auxiliar
            conex.GenerarPedido(idcarr,Convert.ToInt32(zona));
            listazona.Add(zona);// añadimos la zona principal
            recuperarNIT(Convert.ToInt32(zona),idcarr);
            cargar();

            ocultarbotones();
            DateTime now = DateTime.Now;


            //lblm.Text = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            conex.InsertarPago(Global.valor, now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));

            Label13.Visible = true;
            Button4.Visible = true;
            Button5.Visible = true;
        }


       
    }
    public void recuperarNIT(int zona,int id_carrito)
    { // nos sirve para saber a que comercios asignarles el pedido(depende de la zona que eligio el usuario)
       
        foreach (DataRow row in conex.RecuperarZona_vecina(zona).Rows)// recuperamos todas las zonas vecinas de la zona principal
        {
            string zonavecina = row["zona_vecina"].ToString();
            listazona.Add(zonavecina);
        }
        string[] vector = (String[])listazona.ToArray(typeof(string));// trasladamos las zonas a un vector 

        for (int x = 0; x < vector.Length; x++)
        {

            foreach (DataRow row in conex.recuperarNit_Utilizando_ZonaVecina(Convert.ToInt32(vector[x])).Rows)// recuperamos el nit de la empresa con todas las posibles zonas asociadas
            {

                string NitComercio = row["nit_comercio"].ToString();
                listanit.Add(NitComercio);
                //conex.mostarmensaje(NitComercio);

            }//cierre foreach

        }// cierre recuperarnit
        string[] vectorNit = (String[])listanit.ToArray(typeof(string));
        for (int y = 0; y < vectorNit.Length; y++)
        {

            //conex.mostarmensaje(vectorNit[y]);
            conex.crearxmlsolicitudes(vectorNit[y],y+1);// generamos los xml de solicitudes
            conex.llenarsolicitudes(id_carrito,vectorNit[y]);// llenamos la base de datos tabla solicitudes
            prioridades(y,vectorNit[y],id_carrito);
        }


    }
    public void prioridades(int dato,string nit,int carrito) {

        if (dato == 0)
        {// asignarle prioridad alta
            string p = "Alta";
            conex.prioridad(p,nit,carrito);
        }
        else {//prioridad baja 
            string pb = "Baja";
            conex.prioridad(pb, nit,carrito);
        }
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnactualizar_Click(object sender, EventArgs e)// actualizar cantidad
    {
        Button boton = (Button)sender;
        DataListItem fila = (DataListItem)boton.Parent;
        var precio = (Label)fila.Controls[5];
        var cantidad = (TextBox)fila.Controls[11];
        var id = (Label)fila.Controls[19];
        lblm.Text =cantidad.Text;
        int cant = Convert.ToInt32(cantidad.Text);
        conex.actualizar_cantidad(cantidad.Text.ToString(),id.Text.ToString());// actualizamos la cantidad de un producto
    
        ///--------------------crearemos el metodo de pago
        int pre = Convert.ToInt32(precio.Text.ToString());
        int canti = Convert.ToInt32(cantidad.Text.ToString());

        Global.valor =Global.valor+(pre * canti);
        lblpre.Text = Global.valor.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {// cancelar pedido
        ocultarbotones();
        
    }

    public void ocultarbotones() {

        Label7.Visible = false; txtnombre.Visible = false;
        Label8.Visible = false; txtapellido.Visible = false;
        Label9.Visible = false; txtcorreo.Visible = false;
        Label10.Visible = false; txttelefono.Visible = false;
        Label11.Visible = false; txtdireccion.Visible = false;
        Label12.Visible = false; txtcredito.Visible = false;
        Button2.Visible = false; Button3.Visible = false;
        DropDownList1.Visible = false;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        conex.VolverUsuarioSocio(Global.importante);
        Label13.Visible = false;
        Button4.Visible = false;
        Button5.Visible = false;
        conex.mostarmensaje("Se ha registrado como socio");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Label13.Visible = false;
        Button4.Visible = false;
        Button5.Visible = false;
    }
}