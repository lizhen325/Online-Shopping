using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookType
    {
        //TypeId        int     primary key
        //TypeTitle     varchar(50),
        //TypeParentId    int

        private int _typeId;

        public int TypeId
        {
            get { return _typeId; }
            set { _typeId = value; }
        }
        private string _typeTitle;

        public string TypeTitle
        {
            get { return _typeTitle; }
            set { _typeTitle = value; }
        }
        private int _typeParentId;

        public int TypeParentId
        {
            get { return _typeParentId; }
            set { _typeParentId = value; }
        }
    }
}
