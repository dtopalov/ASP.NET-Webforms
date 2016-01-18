namespace WebFormsSummator
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.Drawing.Text;
    using System.Web;

    public class TextToImageHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/png";
            var text = context.Request.Params["text"] ?? context.Request.Path.Substring(1, (context.Request.Path.Length - 5));
            var image = this.CreateBitmapImage(text);

            image.Save(context.Response.OutputStream, ImageFormat.Png);
        }

        private Bitmap CreateBitmapImage(string sImageText)
        {
            Bitmap objBmpImage = new Bitmap(1, 1);

            // Create the Font object for the image text drawing.
            Font objFont = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel);

            // Create a graphics object to measure the text's width and height.
            Graphics objGraphics = Graphics.FromImage(objBmpImage);

            // This is where the bitmap size is determined.
            var intWidth = (int)objGraphics.MeasureString(sImageText, objFont).Width;
            var intHeight = (int)objGraphics.MeasureString(sImageText, objFont).Height;

            // Create the bmpImage again with the correct size for the text and font.
            objBmpImage = new Bitmap(objBmpImage, new Size(intWidth, intHeight));

            // Add the colors to the new bitmap.
            objGraphics = Graphics.FromImage(objBmpImage);

            // Set Background color
            objGraphics.Clear(Color.White);
            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            objGraphics.DrawString(sImageText, objFont, new SolidBrush(Color.FromArgb(102, 102, 102)), 0, 0);
            objGraphics.Flush();
            return (objBmpImage);
        }

        public bool IsReusable => false;
    }
}