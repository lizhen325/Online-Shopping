using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserInfo
    {
        //UserId        int         PK
        //UserName      varchar(50)
        //UserPwd       varchar(50)
        //Email         varchar(50)
        //Address       varchar(50)
        //MobilePhone   varchar(50)
        //RegisterTime  Date
        //LoginTime     Date
        //State         int         for acivation register
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
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _mobilePhone;

        public string MobilePhone
        {
            get { return _mobilePhone; }
            set { _mobilePhone = value; }
        }
        private DateTime _registerTime;

        public DateTime RegisterTime
        {
            get { return _registerTime; }
            set { _registerTime = value; }
        }
        private DateTime _loginTime;

        public DateTime LoginTime
        {
            get { return _loginTime; }
            set { _loginTime = value; }
        }

        private int _state;

        public int State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
