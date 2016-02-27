<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagerList.aspx.cs" Inherits="UI.Admin.UserManagerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/themes/icon.css" rel="stylesheet" />
    <link href="../css/themes/default/easyui.css" rel="stylesheet" />
    <link href="../css/themes/default/dialog.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.1.js"></script>
    <script src="../js/jquery.easyui.min.js"></script>
    <script src="../js/admin.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <a href="javascript:void(0)" id="addUser" class="btn btn-success">Add User</a>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-bordered" style="text-align: center;">
                        <tbody>
                            <tr>
                               
                                <th colspan="10" style="text-align:center;">UserInfo Table</th>
                               
                            </tr>
                            <tr>
                                <td style="text-align: center;">Id</td>
                                <td style="text-align: center;">UserName</td>
                                <td style="text-align: center;">Password</td>
                                <td style="text-align: center;">Email</td>
                                <td style="text-align: center;">Address</td>
                                <td style="text-align: center;">MobilePhone</td>
                                <td style="text-align: center;">RegisterTime</td>
                                <td style="text-align: center;">LoginTime</td>
                                <td style="text-align: center;">Up/Re</td>
                            </tr>
                </HeaderTemplate>
                <ItemTemplate>
                            <tr>
                                <td><%#Eval("UserId") %></td>
                                <td><%#Eval("UserName") %></td>
                                <td><%#Eval("UserPwd") %></td>
                                <td><%#Eval("Email") %></td>
                                <td><%#Eval("Address") %></td>
                                <td><%#Eval("MobilePhone") %></td>
                                <td><%#Eval("RegisterTime") %></td>
                                <td><%#Eval("LoginTime") %></td>
                                <td>
                                    <a href='UserInfoUpdate.aspx?id=<%#Eval("UserId")%>' class="btn btn-success">Update</a>
                                    <a href='javascript:RemoveConfirm(<%#Eval("UserId") %>)'>Remove</a>
                                </td>
                                

                            </tr>
                </ItemTemplate>
                <FooterTemplate>
                            <tr>
                                <td colspan="10" style="text-align:center;"><%=PageBar %> </td>
                            </tr>
                        </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
    <div id="addDiv" style="display:none; background-color:#0094ff;">
        <form id="addForm">
            <table class="table">
                <tr>
                    <td>UserName</td><td><input type="text" name="txtName" /></td>
                </tr>
                <tr>
                    <td>Password</td><td><input type="text" name="txtPwd" /></td>
                </tr>
                <tr>
                    <td>Email</td><td><input type="text" name="txtEmail" /></td>
                </tr>
                <tr>
                    <td>Address</td><td><input type="text" name="txtAddress" /></td>
                </tr>
                <tr>
                    <td>MobilePhone</td><td><input type="text" name="txtMobilePhone" /></td>
                </tr>
            </table>
        </form>
    </div>
</body>
</html>
