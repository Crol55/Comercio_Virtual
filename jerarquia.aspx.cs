using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class jerarquia : System.Web.UI.Page
{
    conexionprincipal c = new conexionprincipal();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataList1.DataSource = c.ConsultarZonas();
        DataList1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string d = DropDownList1.SelectedValue;
        if(d.Equals("0")){
            DataList2.DataSource = c.ConsultarZonas();// sobrecarga de metodo
            DataList2.DataBind();
        }
        else
        {
 DataList2.DataSource = c.ConsultarZonas(Convert.ToInt32(d));// sobrecarga de metodo
        DataList2.DataBind();

        }
       
    }
}