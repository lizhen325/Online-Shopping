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
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-bordered" style="text-align: center;">
                        <tbody>
                            <tr>
                                <th>&nbsp;</th>
                                <th style="text-align: center;">UserInfo Table</th>
                                <th>&nbsp;</th>
                            </tr>
                            <tr>
                                <td style="text-align: center;">Id</td>
                                <td style="text-align: center;">UserName</td>
                                <td style="text-align: center;">Crud</td>
                            </tr>
                </HeaderTemplate>
                <ItemTemplate>
                            <tr>
                                <td><%#Eval("UserId") %></td>
                                <td><%#Eval("UserName") %></td>
                            </tr>
                </ItemTemplate>
                <FooterTemplate>
                            <tr>
                                <td colspan="3"><%=PageBar %> </td>
                            </tr>
                        </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
