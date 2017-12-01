using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Windows.Forms;
public partial class cargarxml : System.Web.UI.Page
{
    Regex expresionregular;
    Match match;
    bool archivoactivo = false;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void MoverArchivo(string ruta, string nombrearchivo) {// metodo para mover archivo a ERRORES
        string source = @"C:\\SAC\\CATALOGOPRODUCTOS\\" + nombrearchivo + "";
        string destino = System.IO.Path.Combine(ruta,nombrearchivo);
        System.IO.File.Move(source,destino);
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Text = "";
        Label2.ForeColor = System.Drawing.Color.White;
        string archivonombre = "";

        if (FileUpload1.HasFile == true)
        {
            string extension = System.IO.Path.GetExtension(FileUpload1.FileName);

            if (extension.ToLower() == ".xml")
            {
                //  Label2.Text = "ese archivo era txt";


                archivonombre = FileUpload1.FileName;
                string patron = "[a-zA-z]+[_](([0-2][1-9])|10|20|30|31)[-](0[0-9]|1[0-2])[-]2016.xml";
                expresionregular = new Regex(patron);
                match = expresionregular.Match(archivonombre);
                if (match.Success == true)
                {
                    Label2.Text = "El archivo coincidio";
                    FileUpload1.SaveAs(Server.MapPath("~/archivos_xml/ " + FileUpload1.FileName));
                    archivoactivo = true;
                    Label2.ForeColor = System.Drawing.Color.Green;
                }else {
                    archivoactivo = false;
                    Label2.Text = "La mascara del archivo es incorrecta debe ser 'Siglas_fecha.xml'";
                    Label2.ForeColor = System.Drawing.Color.Red;
                    MoverArchivo(@"C:\SAC\ERRORES", archivonombre);
                }
                
            }
            else
            {
                archivonombre = FileUpload1.FileName;
                Label2.Text = "Solo se permite enviar archivos ' xml '";
                Label2.ForeColor = System.Drawing.Color.Red;
                MoverArchivo(@"C:\SAC\ERRORES", archivonombre);
            }
        } else{

            Label2.Text = "No ha seleccionado ningun archivo";
            Label2.ForeColor = System.Drawing.Color.White;
        }




        if (archivoactivo == true)// si el archivo es .txt y la mascara es correcta entoncs 
        {
            //XDocument documento = XDocument.Load(@"C:\SAC\CATALOGOPRODUCTOS\DEA_19-11-2016.txt");
            // Label2.Text = documento.ToString();
            conexionprincipal c = new conexionprincipal();
            XDocument documento = XDocument.Load("C:\\SAC\\CATALOGOPRODUCTOS\\"+archivonombre+"");
            var producto = from prod in documento.Descendants("PRODUCTOS") select prod;
            foreach (XElement user in producto.Elements("PRODUCTO"))
            {
                int id = Convert.ToInt32(user.Element("id_producto").Value);
                string nombre = user.Element("nombre_producto").Value;
                string tipo = user.Element("tipo_producto").Value;
                string descripcion = user.Element("descripcion").Value;
                string oferta = user.Element("ofertado").Value;
                string multimedia = user.Element("multimedia").Value;
                string precio = user.Element("precio").Value;
                int existencia = Convert.ToInt32(user.Element("existencia").Value);
                string categoriaproducto = user.Element("CATEGORIA_PRODUCTO_no_categoria").Value;

                c.insertarproductos(id, nombre, tipo, descripcion, oferta, multimedia, precio, existencia, categoriaproducto,Global.nit);

            }// finaliza foreach    

        }// finaliza if (archivo) 
             archivoactivo = false; 
        }
    }