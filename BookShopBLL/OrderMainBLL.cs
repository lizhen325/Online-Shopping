using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;

namespace BookShopBLL
{
    public class OrderMainBLL
    {
        OrderMainDAL dal = new OrderMainDAL();
        /// <summary>
        /// execute procedure
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public bool ExecProc(string orderId, int customerId)
        {
            return dal.ExecProc(orderId, customerId) > 0;
        }
    }
}
