using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class catalogopropio : System.Web.UI.Page
{
    conexionprincipal con = new conexionprincipal();

    protected void Page_Load(object sender, EventArgs e)
    {
        Global.nit = "5265-e";
        if(!IsPostBack){
            DataList1.DataSource = con.CatalogoPropio(Global.nit);
            DataList1.DataBind();
        }
    }
}