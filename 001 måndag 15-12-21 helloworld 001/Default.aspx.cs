using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _001_måndag_15_12_21_helloworld_001
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Jello, World!";
        }
    }
}