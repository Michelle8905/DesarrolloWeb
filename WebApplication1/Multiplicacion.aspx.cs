using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.operaciones;

namespace WebApplication1
{
    public partial class Multiplicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(TextBox2.Text);
            multiplicacion multi1 = new multiplicacion(a, b);
            Label3.Text = a + "*" + b + "=" + (multi1.getMultiplicacion());
        }
    }
}