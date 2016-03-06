using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;


namespace BookShopDAL
{
    public class OrderMainDAL
    {
        /// <summary>
        /// execute procedure
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public int ExecProc(string orderId, int customerId)
        {
            SqlParameter[] ps = {
                                    new SqlParameter("@OrderId",orderId),
                                    new SqlParameter("@CustomerId",customerId)
                                };
            int rowAffected;
            SqlHelper.RunProcedure("InsertOrderss", ps, out rowAffected);
            return rowAffected;
        }

        //alter proc InsertOrders
        //@OrderId varchar(50),
        //@CustomerId int
        //as
        //begin
        //    begin tran

        //    begin try
        //        declare @total decimal(6,2)
        //        select @total = sum(BookCount*BookUnitPrice)from CartInfo where CustomerId=@CustomerId
        //        insert into OrderMain (OrderId,CustomerId,OrderDate,Price)values(@OrderId,@CustomerId,GETDATE(),@total)
        //        insert into OrderDep (OrderId,BookId,BookCount)
        //        select @OrderId,BookId,BookCount from CartInfo where CustomerId=@CustomerId
        //        commit tran
        //    end try
        //    begin catch
        //        rollback tran
        //    end catch
        //end

        //exec InsertOrders '2016030422181735',35

    }
}
