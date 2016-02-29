<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagerList.aspx.cs" Inherits="UI.Admin.UserManagerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <link href="../css/themes/icon.css" rel="stylesheet" />
    <link href="../css/themes/default/easyui.css" rel="stylesheet" />
    <link href="../css/themes/default/dialog.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.1.js"></script>
    <script src="../js/jquery.easyui.min.js"></script>
    <script src="../js/admin.js"></script>
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
    <form id="form1" runat="server">
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
                                <td colspan="9" style="text-align:left;"><b>UserInfo Table:</b>  <a href="javascript:void(0)" id="addUser" class="btn btn-info">+Add</a></td>                                                        
                            </tr>
                            <tr>
                                <th style="text-align: center;">Id</th>
                                <th style="text-align: center;">UserName</th>                                
                                <th style="text-align: center;">Email</th>
                                <th style="text-align: center;">Address</th>
                                <th style="text-align: center;">MobilePhone</th>
                                <th style="text-align: center;">RegisterTime</th>
                                <th style="text-align: center;">LoginTime</th>
                                <th style="text-align: center;">UpDate</th>
                                <th style="text-align: center;">Remove</th>
                            </tr>
                </HeaderTemplate>
                <ItemTemplate>
                            <tr>
                                <td><%#Eval("UserId") %></td>
                                <td><%#Eval("UserName") %></td>
                                <%--<td><%#Eval("UserPwd") %></td>--%>
                                <td><%#Eval("Email") %></td>
                                <td><%#Eval("Address") %></td>
                                <td><%#Eval("MobilePhone") %></td>
                                <td><%#Eval("RegisterTime") %></td>
                                <td><%#Eval("LoginTime") %></td>
                                <td>
                                    <a href='UserInfoUpdate.aspx?id=<%#Eval("UserId")%>' class="btn btn-info">Update</a>
                                   
                                </td>
                                <td>
                                     <a href='javascript:RemoveConfirm(<%#Eval("UserId") %>)'  class="btn btn-info">Remove</a>
                                </td>
                                

                            </tr>
                </ItemTemplate>
                <FooterTemplate>
                            <tr>
                                <td colspan="10" style="text-align:center;"><%=PageBar %> </td>
                            </tr>
                        </tbody>
                    </table>
                    </div>
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
