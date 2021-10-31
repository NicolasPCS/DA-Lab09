using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace LinqEntity
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EJERCICIO_PROPUESTOEntities bdfarmacia = new EJERCICIO_PROPUESTOEntities();
            var query2 = from m in bdfarmacia.VENTA select m;
            GriedView2.DataSource = query2.ToList();
            GriedView2.DataBind();
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            EJERCICIO_PROPUESTOEntities bdfarmacia = new EJERCICIO_PROPUESTOEntities();
            GriedView1.Visible = false;
            if (codigoProducto.Text != "")
            {
                GriedView1.Visible = true;
                var query = from m in bdfarmacia.PRODUCTO where m.idproducto.ToString() == codigoProducto.Text select m;
                GriedView1.DataSource = query.ToList();
                GriedView1.DataBind();
            }
            else
            {
                labelProducto.Text = "El id ingresado no existe";
                GriedView2.Visible = false;
            }
        }

    }
}