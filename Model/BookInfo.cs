using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //Id            int         primary key,
    //Title         varchar(50),
    //SubTitle      varchar(100),
    //PriceOld      decimal(6,2),
    //PriceNew      decimal(6,2),
    //Author        varchar(50),
    //Publisher     varchar(50),
    //PublishDate   date,
    //SaleDate date,
    //ISBN          varchar(50),
    //Details       varchar(MAX),
    //imgTitle      varchar(50)
    public class BookInfo
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _bookTitle;

        public string BookTitle
        {
            get { return _bookTitle; }
            set { _bookTitle = value; }
        }
        private string _subTitle;

        public string SubTitle
        {
            get { return _subTitle; }
            set { _subTitle = value; }
        }
        private decimal _priceOld;

        public decimal PriceOld
        {
            get { return _priceOld; }
            set { _priceOld = value; }
        }
        private decimal _priceNew;

        public decimal PriceNew
        {
            get { return _priceNew; }
            set { _priceNew = value; }
        }
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        private string _publisher;

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        private DateTime _publishDate;

        public DateTime PublishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }
        private DateTime _saleDate;

        public DateTime SaleDate
        {
            get { return _saleDate; }
            set { _saleDate = value; }
        }
        private string _isbn;

        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        private string _details;

        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }
        private string _imgTitle;

        public string ImgTitle
        {
            get { return _imgTitle; }
            set { _imgTitle = value; }
        }
        private string _typeId;

        public string TypeId
        {
            get { return _typeId; }
            set { _typeId = value; }
        }
    }
}
