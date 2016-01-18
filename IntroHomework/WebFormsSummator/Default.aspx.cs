using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsSummator
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Sum(object sender, EventArgs e)
        {
            var sum = double.Parse(this.FirstNumber.Value) + double.Parse(this.SecondNumber.Value);
            this.OutputLabel.Visible = true;
            this.OutputLabel.Text = $"{this.FirstNumber.Value} + {this.SecondNumber.Value} = {sum}";
        }
    }
}