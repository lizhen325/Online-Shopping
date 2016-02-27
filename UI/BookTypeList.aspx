﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeList.aspx.cs" Inherits="UI.BookTypeList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/zTreeStyle/zTreeStyle.css" rel="stylesheet" />
    <script src="js/jquery-1.7.1.js"></script>
    <script src="js/jquery.ztree.core-3.5.min.js"></script>
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

        function Prompt(){
            alert(1);
        }
        
        </script>
</head>
<body>
    <ul id="treeDemo" class="ztree"></ul>
        
</body>
</html>
