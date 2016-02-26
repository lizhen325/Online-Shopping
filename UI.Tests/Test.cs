using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;
using Model;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BookShopDAL.Tests
{
    [TestClass()]
    public class Test
    {
        
        [TestMethod()]
        public void InsertUserInfoTest()
        {
            UserInfo ui = new UserInfo();
            UserInfoDAL dal = new UserInfoDAL();
            ui.UserName = "Lizhen";
            ui.UserPwd = "flwls3250";
            ui.Email = "zhenli336@gmail.com";
            ui.Address = "Albany";
            ui.MobilePhone = "0211017759";
            ui.RegisterTime = System.DateTime.Now;
            int i = dal.InsertUserInfo(ui);
            Assert.IsTrue(i > 0);
        }

        //private int InsertUserInfo(UserInfo ui)
        //{
        //    string sql = "insert into UserInfo (UserName,UserPwd,Email,Address,MobilePhone,RegisterTime) values(@UserName,@UserPwd,@Email,@Address,@MobilePhone,@RegisterTime)";
        //    SqlParameter[] ps = {
        //                             new SqlParameter("@UserName",ui.UserName),
        //                             new SqlParameter("@UserPwd",ui.UserPwd),
        //                             new SqlParameter("@Email",ui.Email),
        //                             new SqlParameter("@Address",ui.Address),
        //                             new SqlParameter("@MobilePhone",ui.MobilePhone),
        //                             new SqlParameter("@RegisterTime",ui.RegisterTime)
        //                         };
        //    return SqlHelper.ExcuteNonQuery(sql, ps);
        //}

        //private static int ExcuteNonQuery(string sql, params SqlParameter[] ps)
        //{
        //    string conStr = "Data Source=.; Initial Catalog=shop; Integrated Security=True;";
        //    using (SqlConnection con = new SqlConnection(conStr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(sql, con))
        //        {
        //            if (ps != null)
        //            {
        //                cmd.Parameters.AddRange(ps);
        //            }
        //            con.Open();
        //            return cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}
