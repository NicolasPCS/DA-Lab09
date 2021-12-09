using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqSQL
{
    public partial class Movie1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Movie1 dc = new Movie1(); 
            var query = from m in dc.Movie select m;
            this.GridView1.DataSource = query; this.GridView1.DataBind();
        }

       
    }
}