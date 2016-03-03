<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="UI.BookShop.BookDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        $(function () {
            $.getJSON('CommentInfoList.ashx', { 'id': id }, function (data) {
                alert(1);
                var list1 = $('#CoomentList');
                $.each(data, function (index, item) {
                    list1.append('<li>' + item.CTime + ':' + item.CMsg + '</li>');
                });
            });
        });
    </script>
    <div class="container" style="margin:70px 0 0 0;">   
    <table class="table">
        <tr>
            <td rowspan="11"><img src="<%=biModel.ImgTitle %>" /></td>           
            </tr>
        <tr>
            <td><b>Description Info</b> </td>
        </tr>
        <tr>
            <td colspan="2"><p><%=biModel.Details %></p></td>
        </tr>
        <tr>
            <td><b>BookTitle: </b> <%=biModel.BookTitle %></td>
        </tr>
        <tr>
            <td><b>SubTitle: </b> <%=biModel.SubTitle %></td>
            </tr>
        <tr>
            <td><b>Author: </b> <%=biModel.Author %></td>
            </tr>
        <tr>
            <td><b>Price: </b> <s style="color:red;"> <%=biModel.PriceNew %></s></td>
            </tr>
        <tr>
            <td style="color:red;"><b> Now Price: &#36;<%=biModel.PriceOld %></b></td>            
        </tr>
        <tr>
            <td><b>ISBN: </b> <%=biModel.Isbn %></td>            
        </tr>
        <tr>
            <td><b>Publisher: </b><%=biModel.Publisher %></td>            
        </tr>
        <tr>
            <td><b>Publish Date: </b> <%=biModel.PublishDate.ToString("yyyy-MM-dd") %></td>            
        </tr>
        <tr>
            <td>
                <ul id="CommentList">

                </ul>
            </td>
        </tr>
    </table>
        </div>
</asp:Content>
