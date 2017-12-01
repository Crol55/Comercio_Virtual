using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class inventariopropio : System.Web.UI.Page
{
    conexionprincipal cone = new conexionprincipal();

    protected void Page_Load(object sender, EventArgs e)
    {
        Global.nit = "5265-e";
      DataList1.DataSource=cone.InventarioPropio(Global.nit);
      DataList1.DataBind();
    }
}