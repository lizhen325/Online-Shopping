using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace BookShopBLL
{
    public class BookTypeBLL
    {
        BookTypeDAL dal = new BookTypeDAL();
        /// <summary>
        /// Get All BookType
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllBookType()
        {
            return dal.GetAllBookType();
        }

        /// <summary>
        /// Insert book type
        /// </summary>
        /// <param name="bt"></param>
        /// <returns></returns>
        public bool InsertBookType(BookType bt)
        {
            return dal.InsertBookType(bt) > 0;
        }

        /// <summary>
        /// Delete book type by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteBookType(int id)
        {
            return dal.DeleteBookType(id) > 0;
        }

        /// <summary>
        /// Get book type by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BookType GetBookTypeById(int id)
        {
            return dal.GetBookTypeById(id);
        }

        /// <summary>
        /// updqte Book type by id
        /// </summary>
        /// <param name="bk"></param>
        /// <returns></returns>
        public bool UpdateBookType(BookType bk)
        {
            return dal.UpdateBookType(bk) > 0;
        }

        /// <summary>
        /// Get all list with where condition
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
    }
}
