using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;


namespace UI.Common
{
    public class MD5Encrypt
    {
        public static string MD5Check(string str)
        {
            byte[] bs = Encoding.Unicode.GetBytes(str);
            MD5 md5 = MD5.Create();
            byte[] bs2 = md5.ComputeHash(bs);
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<bs2.Length; i++)
            {
                sb.Append(bs2[i].ToString("x"));
            }
            return sb.ToString();
        }

        public static string EncryptAli(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            MD5 md5 = MD5.Create();
            byte [] bytes2 = md5.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<bytes2.Length; i++)
            {
                sb.Append(bytes2[i].ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}