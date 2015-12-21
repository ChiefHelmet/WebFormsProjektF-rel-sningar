using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _002_måndag_15_12_21_övning
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ButtonOne.Click += ButtonOne_Click;
            
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            string value = string.Empty;
            value = TextBoxOne.Text;
            TextBoxOne.Text = string.Empty;
            LabelOne.Text = value;
        }
    }
}