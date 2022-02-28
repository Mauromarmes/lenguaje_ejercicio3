using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercio3
{
    public partial class ejerc3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double presion, volumen, temperatura,masa;
            presion = Convert.ToDouble(txtpre.Text);
            volumen = Convert.ToDouble(txtvol.Text);
            temperatura = Convert.ToDouble(txttem.Text);
            masa = (presion * volumen) / (0.37 * (temperatura + 460));
            lblmasa.Text = System.Convert.ToString(masa);
        }
    }
}