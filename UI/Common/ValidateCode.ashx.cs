using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web.SessionState;

namespace UI.Common
{
    /// <summary>
    /// Summary description for ValidateCode
    /// </summary>
    public class ValidateCode : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/jgeg";
            int codeLength = 4;
            string sourcestring = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0213456789";
            string temp = "";
            Random r = new Random();
            for(int i=0; i<codeLength; i++)
            {
                temp += sourcestring[r.Next(0, sourcestring.Length)];
            }
            context.Session["ValidateCode"] = temp;

            Bitmap bitmap = new Bitmap(50, 20);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.DrawRectangle(new Pen(Color.Black), 0, 0, bitmap.Width - 1, bitmap.Height - 1);
            g.DrawString(temp, new Font("Consolas", 14), new SolidBrush(Color.Blue), 0, 0);

            bitmap.Save(context.Response.OutputStream, ImageFormat.Jpeg);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}