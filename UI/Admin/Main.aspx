<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="UI.Admin.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        BODY {
            FONT-SIZE: 12px;
            COLOR: #000000;
            FONT-FAMILY: 宋体;
            BACKGROUND-COLOR: #d6dff7;
        }

        A {
            FONT: 12px 宋体;
            COLOR: #000000;
            TEXT-DECORATION: none;
        }

            A:hover {
                COLOR: #428eff;
            }

        TD {
            FONT-SIZE: 12px;
            LINE-HEIGHT: 15px;
            FONT-FAMILY: 宋体;
        }

        TH {
            FONT-WEIGHT: bold;
            FONT-SIZE: 12px;
            BACKGROUND-IMAGE: url(images/admin_bg_1.gif);
            COLOR: white;
            BACKGROUND-COLOR: #4455aa;
        }

        TD.txlHeaderBackgroundAlternate {
            COLOR: #ffffff;
            BACKGROUND-COLOR: #799ae1;
        }

        #TableTitleLink A:link {
            COLOR: #ffffff;
            TEXT-DECORATION: none;
        }

        #TableTitleLink A:visited {
            COLOR: #ffffff;
            TEXT-DECORATION: none;
        }

        #TableTitleLink A:active {
            COLOR: #ffffff;
            TEXT-DECORATION: none;
        }

        #TableTitleLink A:hover {
            COLOR: #ffffff;
            TEXT-DECORATION: underline;
        }

        TD.txlRow {
            BACKGROUND-COLOR: #dee5fa;
        }

        TD.txlRowHighlight {
            BACKGROUND-COLOR: #d4def9;
        }

        .tableBorder {
            BORDER-RIGHT: #6595d6 1px solid;
            BORDER-TOP: #6595d6 1px solid;
            BORDER-LEFT: #6595d6 1px solid;
            BORDER-BOTTOM: #6595d6 1px solid;
            BACKGROUND-COLOR: #ffffff;
        }

        INPUT {
            FONT-SIZE: 12px;
            LINE-HEIGHT: 15px;
            FONT-FAMILY: Tahoma,Verdana,宋体;
        }

        SELECT {
            FONT-SIZE: 12px;
            LINE-HEIGHT: 15px;
            FONT-FAMILY: Tahoma,Verdana,宋体;
        }

        TEXTAREA {
            FONT-SIZE: 12px;
            LINE-HEIGHT: 15px;
            FONT-FAMILY: Tahoma,Verdana,宋体;
        }
    </style>
</head>
<body bottommargin="0" bgcolor="#ddeeff" leftmargin="0" topmargin="0" rightmargin="0"
    marginwidth="0" marginheight="0" style="text-align: center;">
    <table cellspacing="1" cellpadding="3" width="95%" align="center" border="0">
        <tbody>
            <tr>
                <td valign="top" width="100%">
                    <p>
                        <br>
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
    <table class="tableBorder" cellspacing="1" cellpadding="2" width="95%" align="center"
        border="0">
        <tbody>
            <tr>
                <th width="100%" height="25" class="tableHeaderText">&nbsp;</th>
        </tbody>
    </table>
    <h1>欢迎使用后台管理系统</h1>
    <table class="tableBorder" cellspacing="1" cellpadding="2" width="95%" align="center"
        border="0">
        <tbody>
            <tr>
                <th width="100%"
                    height="25" class="tableHeaderText">&nbsp;</th>
            </tr>
        </tbody>
    </table>
</body>
</html>
