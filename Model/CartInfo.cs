using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CartInfo
    {
        //Id    int
        //CustomerId    int
        //BookId        int
        //BookCount     int
        //BookUnitPrice decimal

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _customerId;

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
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
        private decimal _bookUnitPrice;

        public decimal BookUnitPrice
        {
            get { return _bookUnitPrice; }
            set { _bookUnitPrice = value; }
        }
    }
}
