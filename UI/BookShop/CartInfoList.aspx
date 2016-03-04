﻿<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="CartInfoList.aspx.cs" Inherits="UI.BookShop.CartInfoList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
 
            function RemoveCartInfo(id) {
                if (confirm("Are you sure?")) {
                    $.post('CartInfoDelete.ashx', { cid: id }, function (msg) {
                        if (msg == 1) {
                            location.href = 'CartInfoList.aspx';
                        } else {
                            alert('Fail to Delete');
                        }
                    });
                }
            }
   

</script>
    <div class="container" style="margin:90px 0 0 0;">
        <table class="table">
            <tr>
                <td><span class="glyphicon glyphicon-shopping-cart"></span>Shopping Cart</td>
                <td><span class="glyphicon glyphicon-search">MyOrder</span></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <th>Photo</th>
                <th>Book Name</th>
                <th>Price</th>
                <th>Count</th>
                <th>Delete</th>
            </tr>
            <%foreach(System.Data.DataRow dr in dt.Rows)
              { %>           
            <tr>
                <td><img src='<%=dr["ImgTitle"].ToString() %>'style="height:100px;" class="thumbnail" /></td>
                <td style="padding:50px 0 0 10px;"><%=dr["Title"].ToString() %></td>
                <td style="padding:50px 0 0 10px;"><strong style="color:red; ">&#36;<%=Convert.ToDecimal(dr["BookUnitPrice"]) %></strong></td>
                <td style="padding:50px 0 0 10px;"><input style="width:50px;" readonly="readonly" type="text" value="<%=dr["BookCount"].ToString() %>" /></td>
                <td style="padding:50px 0 0 10px;"><a href="javascript:RemoveCartInfo(<%=dr["CId"].ToString() %>);">Delete</a></td>
            </tr>
            <%} %>
            <tr>
                <td colspan="5"></td>
            </tr>
            <tr>
                <td></td>
                <td>Total Price: 0</td>
                <td>
                    <a href="BookShowList.aspx" class="btn btn-primary"><i class="glyphicon glyphicon-backward"></i> Buy More</a>
                    <button class="btn btn-primary">Payment <span class="glyphicon glyphicon-forward"></span></button>
                </td>
                <td></td>
            </tr>
        </table>
    </div>
</asp:Content>
