using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderDep
    {
        //DepId     int
        //OrderId   varchar
        //BookId    int
        //BookCount int

        private int _dep;

        public int Dep
        {
            get { return _dep; }
            set { _dep = value; }
        }
        private string _orderId;

        public string OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }
        private int _bookId;

        public int BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }
        private int _bookCount;

        public int BookCount
        {
            get { return _bookCount; }
            set { _bookCount = value; }
        }
    }
}
