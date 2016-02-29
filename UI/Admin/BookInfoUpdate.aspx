<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookInfoUpdate.aspx.cs" ValidateRequest="false" Inherits="UI.Admin.BookInfoUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/UMEditorThemes/default/css/umeditor.min.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.1.js"></script>
    <script src="../js/ajaxfileupload.js"></script>
    <script src="../js/UMEditor/umeditor.config.js"></script>
    <script src="../js/UMEditor/umeditor.min.js"></script>
    <script src="../js/UMEditor/lang/en/en.js"></script>
    <script type="text/javascript">
        var id1 = '<%=biModel.TypeId%>';
        var temp = id1.split(',');
        $(function () {
            //load type
            LoadTypeList(1, 0);

            $('#type1').change(function () {
                LoadTypeList(2, $('#type1').val());
            })
            $('#type2').change(function () {
                LoadTypeList(3, $('#type2').val());
            })

            //file upload
            $('#btnUpload').click(function () {
                if ($('#UpImg1').val() == "") {
                    alert("Please select a file");
                    return;
                }
                $.ajaxFileUpload({
                    url: 'FileUploadAjax.ashx',
                    fileElementId: 'UpImg1',
                    success: function (data) {
                        alert("Upload SuccessFul!!");
                        $('#imgTitle').val($(data).text());
                    }
                });
            });
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
                    if (data.length <= 0) {
                        typeList.append('<option value="0">No Option</option>')
                    } else {
                        $.each(data, function (index, item) {
                            typeList.append('<option value="' + item.TypeId + '">' + item.TypeTitle + '</option>');
                        });
                        typeList.val(temp[type - 1]);
                        if (type < 3) {
                            LoadTypeList(type + 1, typeList.val());
                        }
                    }
                }
            );
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid">
        <div class="container-fluid">
                <span> Operator: <i class="glyphicon glyphicon-user"> <span style="color:blue;">Administor</span> </i></span>                
            </div>
        <div class="col-sm-10">
            <table class="table table-bordered">
                <tr>
                    <td>Id: </td>
                    <td><input type="text" name="bid" value="<%=biModel.Id %>" readonly="readonly"/></td>
                </tr>
                <tr>
                    <td>Title</td>
                    <td>
                        <input type="text" name="title" value="<%=biModel.BookTitle %>" />

                    </td>
                </tr>
                <tr>
                    <td>SbuTitle</td>
                    <td>
                        <input type="text" name="subtitle" value="<%=biModel.SubTitle %>"/></td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td>
                        <input type="text" name="price" value="<%=biModel.PriceOld %>"/></td>
                </tr>
                <tr>
                    <td>Discount Price</td>
                    <td>
                        <input type="text" name="discountprice" value="<%=biModel.PriceNew %>"/></td>
                </tr>
                <tr>
                    <td>Author</td>
                    <td>
                        <input type="text" name="author" value="<%=biModel.Author %>"/></td>
                </tr>
                <tr>
                    <td>Publisher</td>
                    <td>
                        <input type="text" name="publisher" value="<%=biModel.Publisher %>" /></td>
                </tr>
                <tr>
                    <td>Publish Date</td>
                    <td>
                        <input type="text" name="publishdate" value="<%=biModel.PublishDate %>" /></td>
                </tr>
                <tr>
                    <td>ISBN</td>
                    <td>
                        <input type="text" name="isbn" value="<%=biModel.Isbn %>" /></td>
                </tr>
                <tr>
                    <td>Type</td>
                    <td>
                        <select id="type1" name="type1"></select>
                        <select id="type2" name="type2"></select>
                        <select id="type3" name="type3"></select>
                    </td>
                </tr>
                <tr>
                    <td>Details</td>
                    <td>
                        <script type="text/plain" id="myEditor" style="width: 500px; height: 300px;"><%=biModel.Details %></script>
                    <script type="text/javascript">
                        var um = UM.getEditor('myEditor');
                    </script>
                        </td>
                </tr>
                <tr>
                    <td>Image</td>
                    <td>
                        <input type="text" readonly="readonly" name="imgTitle" id="imgTitle" value="<%=biModel.ImgTitle %>" />
                        <br />
                        <input style="margin: 10px 0 0 0;" type="file" id="UpImg1" name="UpImg1" />
                        <input style="margin: 10px 0 0 128px;" type="button" id="btnUpload" value="Upload" class="btn btn-info" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <input type="submit" value="Update" class="btn btn-info" /></td>
                </tr>
            </table>
        </div>
            </div>
    </form>
</body>
</html>
