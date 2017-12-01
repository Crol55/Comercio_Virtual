using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class pedidos : System.Web.UI.Page
{
    conexionprincipal c = new conexionprincipal();
    ArrayList listazona = new ArrayList();
    ArrayList listanit = new ArrayList();
    string zon = "";
    string ID_CARRITO = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if(!IsPostBack){
            cargarsolicitudes();

        }
        
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Button bt = (Button)sender;
        DataListItem fila = (DataListItem)bt.Parent;
        var solicitud = (Label)fila.Controls[7];
        string s = solicitud.Text.ToString();
        c.ActualizarSolicitud(Global.nit,Convert.ToInt32(s));
    }
    protected void Button2_Click(object sender, EventArgs e)
    {// boton para rechazar solicitudes
        Button bt = (Button)sender;
        DataListItem fila = (DataListItem)bt.Parent;
        var solicitud = (Label)fila.Controls[7];
        var id_carrito=(Label)fila.Controls[9];
        string s = solicitud.Text.ToString();
          ID_CARRITO=id_carrito.Text.ToString();
        c.RechazarSolicitud(Global.nit,Convert.ToInt32(s));
        cargarsolicitudes();
        foreach (DataRow row in c.RecuperarZona(Global.nit).Rows)// recuperamos todas las zonas vecinas de la zona principal
        {// recuperamos la zona de la empresa que esta rechazando el pedido
            string zona = row["id_zona"].ToString();
            zon = zona.ToString();
        }
        foreach (DataRow row in c.RecuperarZona_vecina(Convert.ToInt32(zon)).Rows)// recuperamos todas las zonas vecinas de la zona principal
        {
            string zonavecina = row["zona_vecina"].ToString();
            listazona.Add(zonavecina);// tenemos las zonas vecinas de la ZONA PRINCIPAL QUE rechazo el pedido
        }
        string[] vectorzonavecina = (String[])listazona.ToArray(typeof(string));
        for (int x = 0; x < vectorzonavecina.Length; x++)
        {
            foreach (DataRow row in c.recuperarNit_Utilizando_ZonaVecina(Convert.ToInt32(vectorzonavecina[x])).Rows)// recuperamos el nit de la empresa con todas las posibles zonas asociadas
            {

                string NitComercio = row["nit_comercio"].ToString();
                listanit.Add(NitComercio);
                //conex.mostarmensaje(NitComercio);

            }//cierre foreach
        }//cierre for
        string[] vectorNit = (String[])listanit.ToArray(typeof(string));

        for (int y = 0; y < vectorNit.Length; y++)
        {
            c.ActualizarEstadoSolicitudes(vectorNit[y],Convert.ToInt32(ID_CARRITO));
          
        }
    }

    public void cargarsolicitudes() {
        DataList1.DataSource = c.consultarSolicitudes(Global.nit);
        DataList1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {// botn consultar debe redirigir a todos los productos adquiridos con ese id de carrito
        Button bt = (Button)sender;
        DataListItem fila = (DataListItem)bt.Parent;
        var solicitud = (Label)fila.Controls[9];
        Global.carrito = solicitud.Text.ToString();
        Response.Redirect("pedidosproducto.aspx");

    }
}