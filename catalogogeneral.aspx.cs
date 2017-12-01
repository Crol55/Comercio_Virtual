using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.IO;
public partial class catalogogeneral : System.Web.UI.Page
{
    conexionprincipal c = new conexionprincipal();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {// buton de catalogo general----------> xml
        if(TextBox2.Text.Equals("")){
            c.mostarmensaje("Ingrese el nombre para el archivo");
        
        
        }else{

            c.XmlCatalogoGeneral(TextBox2.Text.ToString());// generamos el archivo xml
            TextBox2.Text = "";
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {// catalogo general-----------> pdf
        if(TextBox1.Text.Equals("")){
            c.mostarmensaje("Ingrese el nombre que tendra el archivo");
        
        }else{

            string nam = TextBox1.Text.ToString();
            GridView GridView1 = new GridView();

            GridView1.DataSource = c.CatalogoGeneral();
            GridView1.DataBind();

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=" + nam + ".pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            GridView1.AllowPaging = false;
            GridView1.HeaderRow
                 .Style.Add("width", "15%");
            GridView1.HeaderRow.Style.Add("font-size", "10px");
            GridView1.Style.Add("text-decoration", "none");
            GridView1.Style.Add("font-family", "Arial, Helvetica, sans-serif;");
            GridView1.Style.Add("font-size", "8px");
            GridView1.RenderControl(hw);


            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();

        }
        TextBox1.Text = "";
    }


    protected void Button3_Click(object sender, EventArgs e)
    {// pdf por comercio
        if (TextBox3.Text.Equals(""))
        {
            c.mostarmensaje("Ingrese el nombre para el archivo");
        }
        else
        {


              string nitt = DropDownList1.SelectedValue;
              string nam = TextBox3.Text.ToString();
            GridView GridView2 = new GridView();
          
            GridView2.DataSource = c.CatalogoPorComercio(nitt); 
            GridView2.DataBind();


            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition","attachment;filename="+nam+".pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            GridView2.AllowPaging = false;
            GridView2.HeaderRow
                 .Style.Add("width", "15%");
            GridView2.HeaderRow.Style.Add("font-size", "10px");
            GridView2.Style.Add("text-decoration", "none");
            GridView2.Style.Add("font-family", "Arial, Helvetica, sans-serif;");
            GridView2.Style.Add("font-size", "8px");
            GridView2.RenderControl(hw);


            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();

            TextBox3.Text = "";
        
        }
       

          

        }


    protected void Button4_Click(object sender, EventArgs e)
    {
        if (TextBox3.Text.Equals(""))
        {
            c.mostarmensaje("Ingrese el nombre para el archivo");
        }
        else
        {
            string nit = DropDownList1.SelectedValue;

            c.XmlCatalogoPorComercio(TextBox3.Text.ToString(), nit.ToString());

            c.mostarmensaje("Archivo Generado");

        }
        TextBox3.Text = "";
    }
}



   
