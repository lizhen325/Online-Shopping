<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="UI.BookShop.OrderList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin:70px 0 0 0;">
    <h1>My Order</h1>
    <form runat="server"> 
    <table class="table table-condensed">
        <tr>
            <td>Order Date: <span style="color:red;"> <%=DateTime.Now.ToString("yyyy-MM-dd") %> </span></td>
            <td colspan="4">Order Id: <span style="color:red;"><%=OrderCode %></span> <input type="hidden" name="orderId" value="<%=OrderCode %>" /></td>            
        </tr>
        <tr>
            <th>Book ID</th>
            <th>Book Title</th>
            <th>Count</th>
            <th>Unit Price</th>
            <th>Price</th>
        </tr>
        <%
            decimal total = 0;
            foreach(System.Data.DataRow dr in DtCartInfo.Rows){ %>        
        <tr>
            <td><%=dr["BookId"].ToString() %></td>
            <td><%=dr["Title"].ToString() %></td>
            <td><span style="color:red;"><%=dr["BookCount"].ToString() %></span></td>
            <td><span style="color:red;"><%=dr["BookUnitPrice"].ToString() %></span></td>
            <td><span style="color:red;"><%
              decimal total1 = Convert.ToDecimal(dr["BookUnitPrice"]) * Convert.ToInt32(dr["BookCount"]);
              total += total1;
              Response.Write(total1);
                                         %></span></td>
        </tr>
        <%} %>
        <tr>
            <td colspan="5">Total Price: <span style="color:red;"><%=total %></span> <input type="hidden" name="TotalMoney" value="<%=total %>" /> </td>
        </tr>
        <tr>
            <td><input type="radio" name="pay" /><img src="../UploadedImage/paypal1.png" /> </td>
            <td><input type="radio" name="pay" /><img src="../UploadedImage/alipay.png" style="width:187px; height:130px;" /></td>
        </tr>
        <tr>
            <td colspan="1"></td>
            <td style="text-align:center;"><input type="submit" value="Buy Now" class="btn btn-primary" /></td>
        </tr>
    </table>
        </form>
</div>
</asp:Content>
