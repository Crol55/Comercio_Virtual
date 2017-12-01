using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class estadocomercio : System.Web.UI.Page
{
    conexionprincipal c = new conexionprincipal();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void cargarcomercio() {
        DataList1.DataSource = c.estado_comercios();
        DataList1.DataBind();
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cargarcomercio();
    }
}