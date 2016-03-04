using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;
using System.Data;
using Model;

namespace BookShopBLL
{
    public class CartInfoBLL
    {
        CartInfoDAL dal = new CartInfoDAL();
        /// <summary>
        /// get all cart table
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllCartInfo()
        {
            return dal.GetAllCartInfo();
        }

        /// <summary>
        /// get all cartinfo by bookid
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public DataTable GetAllCartInfo(int customerId)
        {
            return dal.GetAllCartInfo(customerId);
        }

        /// <summary>
        /// insert cart info
        /// </summary>
        /// <param name="ci"></param>
        /// <returns></returns>
        public bool InsertCartInfo(CartInfo ci)
        {
            return dal.InsertCartInfo(ci) > 0;
        }
    }
}
