using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace XML
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void cmdCreateXml_Click(object sender, System.EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            FileStream fs = new FileStream(@"c:\SuperProProductList.xml", FileMode.Create);
            XmlTextWriter w = new XmlTextWriter(fs, null);

            //Escribe el primer producto
            w.WriteStartElement("Product");
            w.WriteAttributeString("ID", "", "1");
            w.WriteAttributeString("Name", "", "Chair");

            w.WriteStartElement("Price");
            w.WriteString("49.33");
            w.WriteEndElement();

            w.WriteEndElement();

            //Escribe el segundo producto
            w.WriteStartElement("Product");
            w.WriteAttributeString("ID", "", "2");
            w.WriteAttributeString("Name", "", "Car");

            w.WriteStartElement("Price");
            w.WriteString("43399.55");
            w.WriteEndElement();

            w.WriteEndElement();

            //Escribe el tercer producto 
            w.WriteStartElement("Product");
            w.WriteAttributeString("ID", "", "3");
            w.WriteAttributeString("Name", "", "Fresh Fruit Basket");

            w.WriteStartElement("Price");
            w.WriteString("49.99");
            w.WriteEndElement();

            w.WriteEndElement();

            //Cerrar el elemento raiz 
            w.WriteEndElement();
            w.WriteEndDocument();
            w.Close();

            lblXml.Text = @"File c:\SuperProProductLsit.xml written successfully.";
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            //abrir una secuencia en el archivo
            FileStream fs = new FileStream(@"c:\SuperProProductList.xml", FileMode.Open);
            XmlTextReader r = new XmlTextReader(fs);

            //crear una colección genérica de productos
            List<Product> products = new List<Product>();

            //Lopp a través de los productos
            while (r.Read())
            {
                if (r.NodeType == XmlNodeType.Element && r.Name == "Product")
                {
                    Product newProduct = new Product();
                    newProduct.ID = Int32.Parse(r.GetAttribute(0));
                    newProduct.Name = r.GetAttribute(1);

                    //Obtenga el resto de subetiquetas para este producto
                    while (r.NodeType != XmlNodeType.EndElement)
                    {
                        r.Read();

                        //
                        if (r.Name == "Price")
                        {
                            while (r.NodeType != XmlNodeType.EndElement)
                            {
                                r.Read();
                                if (r.NodeType == XmlNodeType.Text)
                                {
                                    newProduct.Price = decimal.Parse(r.Value);
                                }
                            }
                        }
                        //podría comprobar otros nodos de productos
                        //(como Disponible, estado, etc.) aquí.
                    }
                    //agregar el producto a la lista
                    products.Add(newProduct);
                }
            }
            r.Close();
            // mostrar el documento recuperado
            gridResults.DataSource = products;
            gridResults.DataBind();
        }

        protected void Page_Load(object sender, System.EventArgs e)
        {

        }

        protected void cmdReadXml_Click(object sender, System.EventArgs e)
        {
            FileStream fs = new FileStream(@"c:\SuperProProductList.xml", FileMode.Open);
            XmlTextReader r = new XmlTextReader(fs);

            //almacenar todo el archivo en un StringWriter (mucho más rápido que usar)
            //operaciones de cadena
            StringWriter writer = new StringWriter();

            // analizar el archivo y volver a leer cada nota
            while (r.Read())
            {
                writer.Write("<b>Type:</b>");
                writer.Write(r.NodeType.ToString());
                writer.Write("<br>");

                if (r.Name != "")
                {
                    writer.Write("<b>Name:</b>");
                    writer.Write(r.Name);
                    writer.Write("<br>");
                }
                
                if (r.Value !="")
                {
                    writer.Write("<b>Value:</b>");
                    writer.Write(r.Value);
                    writer.Write("<br>");
                }

                if (r.AttributeCount > 0)
                {
                    writer.Write("<b>Attributes:</b>");
                    for (int i = 0; i < r.AttributeCount; i++)
                    {
                        writer.Write("  ");
                        writer.Write(r.GetAttribute(i));
                        writer.Write("  ");
                    }
                    writer.Write("<br>");
                }
                writer.Write("<br>");
            }
            r.Close();

            // copiar el contenido de la cadena en una etiqueta para mostrarlo
            lblXml.Text = writer.ToString();
        }
    }

}