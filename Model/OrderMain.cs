using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderMain
    {
        //OrderId       varchar
        //CustomerId    int
        //OrderDate     date
        //Price         decimal
        //Status        int //1 for delivered, 0 for undelivered
        private string _orderId;

        public string OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }
        private int _customerId;

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        private DateTime _orderDate;

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }
        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _status;

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        
    }
}
