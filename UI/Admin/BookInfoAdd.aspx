<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookInfoAdd.aspx.cs" Inherits="UI.Admin.BookInfoAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            LoadTypeList(1, 0);
        });

        function LoadTypeList(type, pid) {
            //type:1，2，3
            $.getJSON(
                'BookTypeList.ashx',
                {
                    type: type,
                    pid: pid
                },
                function (data) {
                    var typeList = $('#type' + type);
                    typeList.empty();
                    $.each(data, function (index, item) {
                        typeList.append('<option value="' + item.TypeId + '">' + item.TypeTitle + '</option>');
                    });
                    if (type < 3) {
                        LoadTypeList(type + 1, typeList.val());
                    }
                }
            );
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-sm-2">
        </div>
        <div class="col-sm-10">
            <table class="table table-bordered">
                <tr>
                    <td>Title</td>
                    <td>
                        <input type="text" name="title" /></td>
                </tr>
                <tr>
                    <td>SbuTitle</td>
                    <td>
                        <input type="text" name="subtitle" /></td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td>
                        <input type="text" name="price" /></td>
                </tr>
                <tr>
                    <td>Discount Price</td>
                    <td>
                        <input type="text" name="discountprice" /></td>
                </tr>
                <tr>
                    <td>Author</td>
                    <td>
                        <input type="text" name="author" /></td>
                </tr>
                <tr>
                    <td>Publisher</td>
                    <td>
                        <input type="text" name="publisher" /></td>
                </tr>
                <tr>
                    <td>Publish Date</td>
                    <td>
                        <input type="text" name="publishdate" /></td>
                </tr>
                <tr>
                    <td>Sale Date</td>
                    <td>
                        <input type="text" name="saledate" /></td>
                </tr>
                <tr>
                    <td>ISBN</td>
                    <td>
                        <input type="text" name="isbn" /></td>
                </tr>
                <tr>
                    <td>Type</td>
                    <td>
                        <select id="type1"></select>
                        <select id="type2"></select>
                        <select id="type3"></select>
                    </td>
                </tr>
                <tr>
                    <td>Details</td>
                    <td>
                        <input type="text" name="details" /></td>
                </tr>
                <tr>
                    <td>Image</td>
                    <td>
                        <input type="text" name="image" id="imgTitle" readonly="readonly" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <input type="submit" value="Add" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
