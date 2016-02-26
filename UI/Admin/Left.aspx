<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Left.aspx.cs" Inherits="UI.Admin.Left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<<style type="text/css">
        BODY {
            BACKGROUND: #799ae1;
            MARGIN: 0px;
            FONT: 9pt 宋体;
        }

        TABLE {
            BORDER-RIGHT: 0px;
            BORDER-TOP: 0px;
            BORDER-LEFT: 0px;
            BORDER-BOTTOM: 0px;
        }

        TD {
            FONT: 12px 宋体;
        }

        IMG {
            BORDER-RIGHT: 0px;
            BORDER-TOP: 0px;
            VERTICAL-ALIGN: bottom;
            BORDER-LEFT: 0px;
            BORDER-BOTTOM: 0px;
        }

        A {
            FONT: 12px 宋体;
            COLOR: #000000;
            TEXT-DECORATION: none;
        }

            A:hover {
                COLOR: #428eff;
                TEXT-DECORATION: underline;
            }

        .sec_menu {
            BORDER-RIGHT: white 1px solid;
            BACKGROUND: #d6dff7;
            OVERFLOW: hidden;
            BORDER-LEFT: white 1px solid;
            BORDER-BOTTOM: white 1px solid;
        }

        .menu_title {
        }

            .menu_title SPAN {
                FONT-WEIGHT: bold;
                LEFT: 7px;
                COLOR: #215dc6;
                POSITION: relative;
                TOP: 2px;
            }

        .menu_title2 {
        }

            .menu_title2 SPAN {
                FONT-WEIGHT: bold;
                LEFT: 8px;
                COLOR: #428eff;
                POSITION: relative;
                TOP: 2px;
            }
    </style>
</head>
<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <table cellspacing="0" cellpadding="0" width="100%" align="left" border="0">
        <tbody>
            <tr>
                <td valign="top" bgcolor="#799ae1">
                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <tr>
                                <td valign="bottom" height="42">
                                    <img height="38"
                                        src="left.files/title.gif" width="158">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <tr>
                                <td class="menu_title" onmouseover="this.className='menu_title2';"
                                    onmouseout="this.className='menu_title';" background=""
                                    height="25"><span>| <a
                                        href="exit.asp"
                                        target="_parent"><b>退出</b></a></span></td>
                            </tr>
                            <tr>
                                <td class="menu_title" onmouseover="this.className='menu_title2';"
                                    onmouseout="this.className='menu_title';" background=""
                                    height="25">&nbsp;</td>
                            </tr>
                        </tbody>
                    </table>
                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <tr>
                                <td class="menu_title" id="menuTitle1"
                                    onmouseover="this.className='menu_title2';" onclick="showsubmenu(0)"
                                    onmouseout="this.className='menu_title';"
                                    background="left.files/admin_left_1.gif"
                                    height="25"><span><b>管理员管理</b></span></td>
                            </tr>
                            <tr>
                                <td id="submenu0">
                                    <div class="sec_menu" style="WIDTH: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td height="20"><a
                                                        href="UserManagerAdd.aspx"
                                                        target="mainFrame">添加</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a
                                                        href="UserManagerList.aspx"
                                                        target="mainFrame">列表</a></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div style="WIDTH: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td height="20"></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>



                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <tr>
                                <td class="menu_title" id="TD1"
                                    onmouseover="this.className='menu_title2';" onclick="showsubmenu(2)"
                                    onmouseout="this.className='menu_title';"
                                    background="left.files/admin_left_2.gif" height="25"><span>商品管理</span> </td>
                            </tr>
                            <tr>
                                <td id="submenu2">
                                    <div class="sec_menu" style="WIDTH: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td height="20"><a href="Produce.asp" target="mainFrame">商品管理帮助</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a href="ProduceShow.asp" target="mainFrame">商品浏览|修改</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a href="ProduceAdd.asp" target="mainFrame">商品添加</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a href="ProduceSearch.asp" target="mainFrame">商品搜索</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a href="addCategory.asp" target="mainFrame">商品类别|添加</a></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div style="WIDTH: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td
                                                        height="20"></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>


                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <tr>
                                <td class="menu_title" id="TD2"
                                    onmouseover="this.className='menu_title2';" onclick="showsubmenu(1)"
                                    onmouseout="this.className='menu_title';"
                                    background="left.files/admin_left_2.gif" height="25"><span>员工管理</span>
                                </td>
                            </tr>
                            <tr>
                                <td id="submenu1">
                                    <div class="sec_menu" style="WIDTH: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td height="20"><a href="User.asp" target="mainFrame">员工管理帮助</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a href="UserShow.asp" target="mainFrame">员工显示|修改</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a href="UserAdd.asp" target="mainFrame">员工添加</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a href="userSearch.asp" target="mainFrame">员工搜索</a></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div style="WIDTH: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td
                                                        height="20"></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>

                   


                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <tr>
                                <td class="menu_title" id="TD4"
                                    onmouseover="this.className='menu_title2';"
                                    onmouseout="this.className='menu_title';"
                                    background="left.files/admin_left_9.gif"
                                    height="25"><span>超市管理版权信息</span></td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="sec_menu" style="WIDTH: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td height="20" bgcolor="#D6DFF7" style="LINE-HEIGHT: 150%">版权:传智播客
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
            </tr>
        </tbody>
    </table>
    </body>
</html>
