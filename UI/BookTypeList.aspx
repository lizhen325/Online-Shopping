<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeList.aspx.cs" Inherits="UI.BookTypeList" %>

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

        function Prompt(id){
            var temp = prompt("Plaese 1:Add, 2:Update, 3:Delete");
            switch(temp){
                case '1':
                    location.href = "../Admin/BookTypeAdd.aspx?pid="+id;
                    break;
                case '2':
                    break;
                case '3':
                    break;
                default:
                    alert('please');
                    break;
            }
        }
        </script>
</head>
<body>
    <a href="../Admin/BookTypeAdd.aspx?pid=0">Add Classcification</a>
    <ul id="treeDemo" class="ztree"></ul>
        
</body>
</html>
