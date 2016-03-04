using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using BookShopBLL;
using System.Text;

namespace UI.BookShop
{
    public partial class OrderList : System.Web.UI.Page
    {
        protected string OrderCode { get; set; }
        protected DataTable DtCartInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!Common.SessionValidate.IsLogin())
            //{

            //}
            int CId = Convert.ToInt32(Session["id"]);
            if (!IsPostBack)
            {
                OrderCode = DateTime.Now.ToString("yyyyMMddHHmmss") + Session["id"];
                CartInfoBLL bll = new CartInfoBLL();
                DtCartInfo = bll.GetAllCartInfo(CId);
            }
            else
            {
                OrderMainBLL bll = new OrderMainBLL();
                string orderId = Request["orderId"];
                int customerId = Convert.ToInt32(Session["id"]);
                if (bll.ExecProc(orderId, customerId))
                {
                    //AliPay API

                    //partner: business id
                    //return_url: 
                    //subject: product name
                    //body: product description
                    //out_trade_no: orderId
                    //total_fee: total price
                    //seller_email: email address
                    //sign: (total price, business id, order id, product name, business password,) use get method
                    StringBuilder sb = new StringBuilder("http://localhost:4912/AliPay/PayGate.ashx?"); //Test AliPay API
                    //partner：business ID
                    sb.Append("partner=lizhen325");
                    //return_url：return url
                    sb.Append("&return_url=http://localhost:61877/Index.aspx");
                    //subject：product name
                    sb.Append("&subject=book");
                    //body：product Description
                    sb.Append("&body=book123");
                    //out_trade_no：orderId
                    sb.Append("&out_trade_no=" + orderId);
                    //total_fee：total price
                    string total_fee = Request["TotalMoney"];
                    sb.Append("&total_fee=" + total_fee);
                    //seller_email：seller eamil
                    sb.Append("&seller_email=zhenli336@gmail.com");
                    //sign: total price, bisiness ID, orderId, product name, bisiness password,
                    //using MD5(utf-8, "x2", toLower)
                    string sign = total_fee + "lizhen325" + orderId + "book" + "123";
                    sign = Common.MD5Encrypt.EncryptAli(sign);
                    sb.Append("&sign=" + sign);

                    Response.Redirect(sb.ToString());
                }
                else
                {
                    Response.Redirect("Error.html");
                }
            }
        }
    }
}