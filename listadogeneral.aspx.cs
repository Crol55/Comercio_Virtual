using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class listadogeneral : System.Web.UI.Page
{
    conexionprincipal cn = new conexionprincipal();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack){
            DataList1.DataSource = cn.listadoGeneralParaResponsable(0);
            DataList1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int dato=DropDownList1.SelectedIndex;
        DataList1.DataSource = cn.listadoGeneralParaResponsable(dato);
        DataList1.DataBind();
    }
}