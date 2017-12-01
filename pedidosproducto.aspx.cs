using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pedidosproducto : System.Web.UI.Page
{
    conexionprincipal c = new conexionprincipal();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataList1.DataSource = c.RecuperarProductosDelCarrito(Convert.ToInt32(Global.carrito));
            DataList1.DataBind();

        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {// nos sirve para consultar en stock
        Button bt = (Button)sender;
        DataListItem fila = (DataListItem)bt.Parent;
        var cantidad = (Label)fila.Controls[15];
        var stock = (Label)fila.Controls[23];

        int can = Convert.ToInt32(cantidad.Text.ToString());
        int stoc = Convert.ToInt32(stock.Text.ToString());
        //c.mostarmensaje("cantidad " + can + " stock " + stoc);
        if (stoc >= can)
        {
            c.mostarmensaje("EL PRODUCTO SE PUEDE SURTIR CON EL STOCK ACTUAL");
        }
        else {
            c.mostarmensaje("EL PEDIDO NO PUEDE SER SURTIDO CON EL STOCK ACTUAL");
        }
        

    }
}