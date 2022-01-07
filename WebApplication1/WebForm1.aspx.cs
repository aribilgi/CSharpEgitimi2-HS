using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    //Burası code behind
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Label1.Text = "btnKaydet e tıklandı";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label1.Text = "LinkButton a tıklandı";
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            Literal1.Text = "<h2>" + txtGiris.Text + "</h2>"; // textbox tan girilen değeri literale yazdır
        }
    }
}