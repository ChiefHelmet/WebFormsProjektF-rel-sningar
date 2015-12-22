using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_MeasureConverter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConvertToMeter.Click += ConvertToMeter_Click;
            //ConvertToFeet.Click += ConvertToFeet_Click;
        }



        private void ConvertToMeter_Click(object sender, EventArgs e)
        {
            string value = string.Empty;
            value = TextBoxOne.Text;

            double doubleValue;
            //double.TryParse(TextBoxOne.Text, out doubleValue);
            double.TryParse(value, out doubleValue);
            //ConvertClass.MetersToFeet(doubleValue);
            doubleValue = doubleValue*0.3048;
            //doubleValue.ToString();

            TextBoxOne.Text = doubleValue.ToString();

            //double.TryParse(TextBoxOne, out)
            //TextBoxOne = value;
        }
        //private void ConvertToFeet_Click(object sender, EventArgs e)
        //{
        //    string value = string.Empty;
        //    value = ConvertToFeet.Text;


        //    //TextBoxOne = value;
        //    //kod: double.tryparse(textBoxOne, out/*<- viktig!*/ value
        //}
    }
}