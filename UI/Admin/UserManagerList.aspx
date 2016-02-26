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

    <script type="text/javascript">
        $(function () {
            $('#addUser').click(function () {
                AddUser();
            })
        });
        function AddUser() {
            $('#addDiv').css('display', 'block');
            $('#addDiv').dialog({
                title: 'Add User Info',
                width: 300,
                height: 230,
                buttons: [{
                    text: 'Add',
                    iconCls: 'icon-ok',
                    handler: function () {
                        //Add User Info
                        addUserEvent();
                    }
                }, {
                    text: 'Cancel',
                    handler: function () {
                        $('#addDiv').dialog('close');
                    }
                }]
            });
        }
        function addUserEvent() {
            var serverData = $('#addForm').serializeArray();
            $.post("UserManagerAdd.aspx", serverData, function (data) {
                if (data == 'ok') {
                    alert("Fail to Add!!!");
                } else {
                    alert('Sucess!');
                    $('#addDiv').dialog('close');
                }
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <a href="javascript:void(0)" id="addUser">Add User</a>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-bordered" style="text-align: center;">
                        <tbody>
                            <tr>
                                <th>&nbsp;</th>
                                <th style="text-align:center;">UserInfo Table</th>
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
                                <td>&nbsp;</td>
                                <td><%=PageBar %> </td>
                                <td>&nbsp;</td>
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
            </table>
        </form>
    </div>
</body>
</html>
