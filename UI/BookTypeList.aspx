<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeList.aspx.cs" Inherits="UI.BookTypeList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/themes/icon.css" rel="stylesheet" />
    <link href="Content/zTreeStyle/zTreeStyle.css" rel="stylesheet" />
    <link href="../css/themes/default/easyui.css" rel="stylesheet" />
    <link href="../css/themes/default/dialog.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.1.js"></script>
    <script src="../js/jquery.easyui.min.js"></script>
    <script src="js/jquery.ztree.core-3.5.min.js"></script>
    <script src="../js/admin.js"></script>
    <script>
        $(function(){
            var setting = {
                data: {
                    simpleData: {
                        enable: true
                    }
                },
                callback: {
                    beforeClick: function(treeId, treeNode) {
                        Prompt(treeNode.id,treeNode.isParent);
                    }
                }
            };

            var zNodes =<%=ZTree%>;

            $.fn.zTree.init($("#treeDemo"), setting, zNodes);
        })
        </script>
</head>
<body>
    <a href="../Admin/BookTypeAdd.aspx?pid=0">Add Classcification</a>
    <ul id="treeDemo" class="ztree"></ul>
</body>
</html>
