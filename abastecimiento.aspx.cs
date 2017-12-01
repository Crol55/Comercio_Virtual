using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class abastecimiento : System.Web.UI.Page
{
    conexionprincipal c = new conexionprincipal();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack){
            DataList1.DataSource = c.ConsultarTodasLasSolicitudes();
            DataList1.DataBind();
        }
       
    }
}