namespace WebFormsSummator
{
    using System;
    using System.Web;
    using System.Web.UI;

    public partial class Converter : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var text = this.Request.Params["text"] ?? "Default";
            this.MyTextImage.ImageUrl = "CreateImageText.ashx?text=" + text;
        }

        protected void RenderImageButtonClicked(object sender, EventArgs e)
        {
            string text = string.IsNullOrEmpty(this.MyTextBox.Text) ? "Empty" : this.MyTextBox.Text;
            this.MyTextImage.ImageUrl = "CreateImageText.ashx?text=" + HttpContext.Current.Server.UrlEncode(text);
        }
    }
}