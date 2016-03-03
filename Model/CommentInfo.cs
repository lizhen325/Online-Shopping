using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CommentInfo
    {
        //CommentId     int
        //CommentMsg    varchar(max)
        //CommentTime   date
        //BookId        int

        private int _commentId;

        public int CommentId
        {
            get { return _commentId; }
            set { _commentId = value; }
        }
        private string _coomentMsg;

        public string CoomentMsg
        {
            get { return _coomentMsg; }
            set { _coomentMsg = value; }
        }
        private DateTime _commentTime;

        public DateTime CommentTime
        {
            get { return _commentTime; }
            set { _commentTime = value; }
        }
        private int _bookId;

        public int BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }
    }
}
