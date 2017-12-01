using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pago : System.Web.UI.Page
{
    conexionprincipal c = new conexionprincipal();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack){
            DataList1.DataSource = c.pago();
            DataList1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string dato = DropDownList1.SelectedValue;
        DataList1.DataSource = c.pago(dato);
        DataList1.DataBind();

    }
}