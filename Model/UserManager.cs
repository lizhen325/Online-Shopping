using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserManager
    {
        //UserId    int     PK
        //UserName  varchar(50)
        //UserPwd   varchar(50)
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _userPwd;

        public string UserPwd
        {
            get { return _userPwd; }
            set { _userPwd = value; }
        }
    }
}
