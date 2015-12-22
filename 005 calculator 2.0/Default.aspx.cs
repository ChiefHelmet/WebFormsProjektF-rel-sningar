using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _005_calculator_2._0
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            string inputValueOne = string.Empty;
            string inputValueTwo = string.Empty;
            inputValueOne = InputBoxOne.Text;
            inputValueTwo = InputBoxTwo.Text;
            double doubleInputValueOne;
            double doubleInputValueTwo;
            double.TryParse(inputValueOne, out doubleInputValueOne);
            double.TryParse(inputValueTwo, out doubleInputValueTwo);
            double OutputValue = doubleInputValueOne + doubleInputValueTwo;
            OutputBox.Text = OutputValue.ToString();
        }
    }
}