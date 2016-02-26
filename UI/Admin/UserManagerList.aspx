<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagerList.aspx.cs" Inherits="UI.Admin.UserManagerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="stylesheet" href="inc/css.css" type="text/css" />
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
                <HeaderTemplate>
                    <table width="100%" border="0" align="center" cellpadding="2" cellspacing="1" bordercolor="#799AE1" class="tableBorder">
                        <tbody>
                            <tr>
                                <th align="center" colspan="16" style="height: 23px">管理员列表</th>
                            </tr>
                            <tr bgcolor="#DEE5FA">
                                <td colspan="16" align="center" class="txlrow">&nbsp;</td>
                            </tr>
                            <tr align="center" bgcolor="#799AE1">
                                <td width="30%" align="center" class="txlHeaderBackgroundAlternate">编号</td>
                                <td width="40%" align="center" class="txlHeaderBackgroundAlternate">用户名</td>
                                <td width="30%" align="center" class="txlHeaderBackgroundAlternate">操作</td>
                            </tr>
                </HeaderTemplate>
                <FooterTemplate>
                    <tr>
                        <td align="center" class="txlrow" colspan="3">
                        </td>
                    </tr>
                    </tbody></table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr bgcolor="#DEE5FA">
                        <td align="center" class="txlrow"><%#Eval("UserId") %></td>
                        <td align="center" class="txlrow"><%#Eval("UserName") %></td>
                        <td align="center" class="txlrow"></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllUser" TypeName="BookShopBLL.UserManagerBLL"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
