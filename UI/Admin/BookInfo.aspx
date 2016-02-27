<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookInfo.aspx.cs" Inherits="UI.Admin.BookInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <table class="table table-bordered" style="text-align: center;">
                <tbody>
                    <tr>
                        <th colspan="10" style="text-align: center;">ProductInfo Table</th>
                    </tr>
                    <tr>
                        <td style="text-align: center; width: 10%;">Id</td>
                        <td style="text-align: center; width: 10%;">Title</td>
                        <td style="text-align: center; width: 10%;">Price</td>
                        <td style="text-align: center; width: 10%;">DiscountPrice</td>
                        <td style="text-align: center; width: 10%;">Author</td>
                        <td style="text-align: center; width: 10%;">Publisher</td>
                        <td style="text-align: center; width: 10%;">PublishDate</td>
                        <td style="text-align: center; width: 10%;">SaleDate</td>
                        <td style="text-align: center; width: 10%;">Up/Re</td>
                    </tr>
        </HeaderTemplate>
        <ItemTemplate>
                <tr>
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("Title") %></td>
                    <td><%#Eval("PriceOld") %></td>
                    <td><%#Eval("PriceNew") %></td>
                    <td><%#Eval("Author") %></td>
                    <td><%#Eval("Publisher") %></td>
                    <td><%#Convert.ToDateTime(Eval("PublishDate")).ToString("yyyy-MM-dd") %></td>
                    <td><%#Convert.ToDateTime(Eval("SaleDate")).ToString("yyyy-MM-dd") %></td>
                    <td>
                        <a href='UserInfoUpdate.aspx?id=<%#Eval("Id")%>' class="btn btn-success">Update</a>
                        <a href='javascript:RemoveConfirm(<%#Eval("Id") %>)'>Remove</a>
                    </td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
                <tr>
                </tr>
            </tbody>
        </table>
        </FooterTemplate>
    </asp:Repeater>
</body>
</html>
