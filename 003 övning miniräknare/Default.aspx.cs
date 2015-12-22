using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_övning_miniräknare
{
    public partial class Default : System.Web.UI.Page
    {
        public static float a, c, d;
        public static char b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))
            {
                t.Text = "";
                t.Text = t.Text + b2.Text;
            }
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void b4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void b5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void b7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void b0_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void div_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void eql_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void clr_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}