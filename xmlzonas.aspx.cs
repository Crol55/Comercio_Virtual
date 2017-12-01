using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Windows.Forms;
public partial class xmlzonas : System.Web.UI.Page
{
    //Regex expresionregular;
    //Match match;
    bool archivoactivo = false;
    string archivonombre = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (FileUpload1.HasFile == true)
        {
            string extension = System.IO.Path.GetExtension(FileUpload1.FileName);

            if (extension.ToLower() == ".xml")
            {
                archivoactivo = true;


                archivonombre = FileUpload1.FileName;
                Label2.Text = "Archivo correcto";
                Label2.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label2.Text = "Solo se permite enviar archivos ' xml '";
                Label2.ForeColor = System.Drawing.Color.Red;
                archivoactivo = false;
            }
        }
        else
        {
            Label2.Text = "No ha seleccionado ningun archivo";
            Label2.ForeColor = System.Drawing.Color.White;
            archivoactivo = false;
        }


        if (archivoactivo == true)
        {
            
            conexionprincipal c = new conexionprincipal();
            XDocument documento = XDocument.Load("C:\\SAC\\CATALOGOPRODUCTOS\\"+archivonombre+"");
            var zonaas = from zona in documento.Descendants("ZONAS") select zona;

            foreach (XElement user in zonaas.Elements("ZONA"))
            {

                int zon = Convert.ToInt32(user.Element("no_zona").Value);
                string zonaa = user.Element("nombre_zona").Value;
                int zonaaa = Convert.ToInt32(user.Element("zona_superior").Value);
                c.insertarzonas(zon, zonaa, zonaaa);

            }// finaliza foreach  
            foreach (XElement user in zonaas.Elements("ZONAVECINA"))
            {
                MessageBox.Show("si ingreso aqui");
                int zo = Convert.ToInt32(user.Element("ZONA_no_zona").Value);
                //string zonaa = user.Element("nombre_zona").Value;
                int zon = Convert.ToInt32(user.Element("ZONA_zona_vecina").Value);
                c.insertarZonaVecina(zo,zon);

            }// finaliza foreach 
            MessageBox.Show("Datos Registrados");
        } archivoactivo = false; 
    }
}