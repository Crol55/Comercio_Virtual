
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
public partial class sesionclientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Global.importante.Equals(""))
        {
            MessageBox.Show("DEBE INICIAR SESION PARA INGRESAR");
            Response.Redirect("inicial.aspx");
        }
    }
}