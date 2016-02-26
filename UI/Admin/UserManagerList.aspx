<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagerList.aspx.cs" Inherits="UI.Admin.UserManagerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
            <HeaderTemplate>
                    <table class="table table-bordered" style="text-align:center;">
                            <tr>
                                <th colspan="3" style="text-align: center;">UserInfo Table</th>
                            </tr>
                            <tr>
                                <td>Id</td>
                                <td>UserName</td>
                                <td>Crud</td>
                            </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("UserId") %></td>
                    <td><%#Eval("UserName") %></td>
                    <td>aaa</td>
                </tr>
                
            </ItemTemplate>
             
        </asp:Repeater>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllUser" TypeName="BookShopBLL.UserManagerBLL"></asp:ObjectDataSource>
       </table>
            </div>
    </form>
</body>
</html>
