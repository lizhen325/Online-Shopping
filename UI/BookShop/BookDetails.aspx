<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="UI.BookShop.BookDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin:70px 0 0 0;">

    
    <table class="table">
        <tr>
            <td rowspan="11"><img src="<%=biModel.ImgTitle %>" /></td>           
            </tr>
        <tr>
            <td>Description: </td>
        </tr>
        <tr>
            <td colspan="2"><p><%=biModel.Details %></p></td>
        </tr>
        <tr>
            <td>BookTitle: <%=biModel.BookTitle %></td>
        </tr>
        <tr>
            <td>SubTitle: <%=biModel.SubTitle %></td>
            </tr>
        <tr>
            <td>Author: <%=biModel.Author %></td>
            </tr>
        <tr>
            <td>Price: <s> <%=biModel.PriceNew %></s></td>
            </tr>
        <tr>
            <td style="color:red;"> Now Price: &#36;<%=biModel.PriceOld %></td>            
        </tr>
        <tr>
            <td>ISBN: <%=biModel.Isbn %></td>            
        </tr>
        <tr>
            <td>Publisher: <%=biModel.Publisher %></td>            
        </tr>
        <tr>
            <td>Publish Date: <%=biModel.PublishDate.ToString("yyyy-MM-dd") %></td>            
        </tr>
        
    </table>
        </div>
</asp:Content>
