<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="UI.BookShop.OrderList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container" style="margin:70px 0 0 0;">
    <h1>My Order</h1>
    <table class="table table-condensed">
        <tr>
            <td>Order Date: </td>
            <td colspan="4">Order Id: </td>
        </tr>
        <tr>
            <th>Book ID</th>
            <th>Book Title</th>
            <th>Count</th>
            <th>Unit Price</th>
            <th>Price</th>
        </tr>
        <tr>
            <td>111</td>
            <td>2222</td>
            <td>1</td>
            <td>1000</td>
            <td>10000</td>
        </tr>
        <tr>
            <td colspan="5">Total Price: </td>
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
</div>
</asp:Content>
