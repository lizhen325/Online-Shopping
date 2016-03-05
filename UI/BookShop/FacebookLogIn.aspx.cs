using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facebook;
using System.Web.Script.Serialization;
using BookShopBLL;
using Model;

namespace UI.BookShop
{
    public partial class FacebookLogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckAuthorization();
        }

        private void CheckAuthorization()
        {
            string app_id = "1541705872826416";
            string app_secret = "1503e2ad32a958a4f637bedbd3f1f7f4";
            string scope = "email";
            if(Request["code"] == null)
            {
                Response.Redirect(string.Format("https://graph.facebook.com/oauth/authorize?client_id={0}&redirect_uri={1}&scope={2}", app_id, Request.Url.AbsoluteUri, scope));

            }
            else
            {
                Dictionary<string, string> tokens = new Dictionary<string, string>();
                string url = string.Format("https://graph.facebook.com/oauth/access_token?client_id={0}&redirect_uri={1}&scope={2}&code={3}&client_secret={4}", app_id, Request.Url.AbsoluteUri, scope, Request["code"].ToString(), app_secret);
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                using(HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string vals = reader.ReadToEnd();
                    foreach(string token in vals.Split('&'))
                    {
                        tokens.Add(token.Substring(0, token.IndexOf("=")), token.Substring(token.IndexOf("=") + 1, token.Length - token.IndexOf("=")-1));

                    }
                }
                string access_token = tokens["access_token"];
                var client = new FacebookClient(access_token);
                //get Json
                var user = client.Get("me?fields=email,id,name,gender,location");
                //Serializer javascript
                var jss = new JavaScriptSerializer();
                //deserialize
                var table = jss.Deserialize<dynamic>(user.ToString());

                //insert into database
                UserInfo ui = new UserInfo();
                ui.UserName = table["name"];
                ui.Email = table["email"];
                ui.RegisterTime = System.DateTime.Now;
                ui.UserPwd = Common.MD5Encrypt.MD5Check(table["name"]);
                ui.State = 1;

                UserInfoBLL bll = new UserInfoBLL();
                if(bll.InsertUserInfoByFaceBook(ui))
                {
                    Session["user"] = ui.UserName;
                    Response.Redirect("../Index.aspx");
                }
                else
                {
                    Response.Redirect("Error.html");
                }

            }
        }
    }
}