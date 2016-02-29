<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookInfo.aspx.cs" Inherits="UI.Admin.BookInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        function RemoveConfirm(id) {
            if (confirm("Are you sure??")) {
                $.post('BookInfoDelete.ashx', { id: id }, function (data) {
                    if (data == 1) {
                        //reload current page
                        location.href = location.href;
                    } else {
                        alert('Fail to Delete');
                    }
                });
            };
        }
    </script>
    <style type="text/css">
         tr:nth-child(even){
            background-color:#f2f2f2;
        }
        th{
            background-color:#4CAF50;
        }
    </style>
</head>
<body>
    <div class="container-fluid">
         <div class="container-fluid">
                <span> Operator: <i class="glyphicon glyphicon-user"> <span style="color:blue;">Administor</span> </i></span>                
            </div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <div class="table-responsive">
                <table class="table table-bordered" style="text-align: center;">
                    <tbody>
                         <tr>
                                <td colspan="10" style="text-align:left;"><b>UserInfo Table:</b>  <a href="BookInfoAdd.aspx" class="btn btn-info">+Add</a></td>                                                        
                           </tr>
                        <tr>
                            <th style="text-align: center; width: 10%;">Id</th>
                            <th style="text-align: center; width: 10%;">Title</th>
                            <th style="text-align: center; width: 10%;">Price</th>
                            <th style="text-align: center; width: 10%;">DiscountPrice</th>
                            <th style="text-align: center; width: 10%;">Author</th>
                            <th style="text-align: center; width: 10%;">Publisher</th>
                            <th style="text-align: center; width: 10%;">PublishDate</th>
                            <th style="text-align: center; width: 10%;">SaleDate</th>
                            <th style="text-align: center; width: 10%;">Update</th>
                            <th style="text-align: center; width: 10%;">Remove</th>
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
                        <a href='UserInfoUpdate.aspx?id=<%#Eval("Id")%>' class="btn btn-info">Update</a>
                        
                    </td>
                    <td>
                        <a href='javascript:RemoveConfirm(<%#Eval("Id") %>)' class="btn btn-info">Remove</a>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                <tr>
                    <td colspan="10" style="text-align: center;"><%=PageBar %> </td>
                </tr>

                </tbody>
        </table>
            </FooterTemplate>
           
        </asp:Repeater>
    </div>
</body>
</html>
