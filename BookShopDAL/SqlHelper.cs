﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BookShopDAL
{
    public  static class SqlHelper
    {
        //Avoid to user Connectionstrings, when you are tesing.
        //private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private static string conStr = "Data Source=.; Initial Catalog=shop; Integrated Security=True;";
        
        
        //private string a = "Data Source=.; Initial Catalog=shop; Integrated Security=True;";
        /// <summary>
        /// Get all table
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static DataTable GetAllList(string sql, params SqlParameter[] ps)
        {
            DataTable dt = new DataTable();
            using(SqlDataAdapter da = new SqlDataAdapter(sql,conStr))
            {
                if(ps!=null)
                {
                    da.SelectCommand.Parameters.AddRange(ps);
                }
                da.Fill(dt);
                return dt;
            }
        }

        /// <summary>
        /// Fetch rows => insert,update,delete
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static int ExcuteNonQuery(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection con = new SqlConnection(SqlHelper.conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Take one row
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static object ExcuteScalar(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection con = new SqlConnection(SqlHelper.conStr))
            {

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// multile rows
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="ps">sql语句参数</param>
        /// <returns>多行多列</returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(SqlHelper.conStr);
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                if (ps != null)
                {
                    cmd.Parameters.AddRange(ps);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch (Exception e)
                {
                    con.Close();
                    con.Dispose();
                    throw e;
                }
            }
        }

        /// <summary>
        /// Get all talbe information
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet Query(string sql)
        {
            using (SqlConnection con = new SqlConnection(SqlHelper.conStr))
            {
                DataSet ds = new DataSet();
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }
    }
}
