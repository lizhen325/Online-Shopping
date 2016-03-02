<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="UI.BookShop.BookDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
        <tr>
            <td><img src="../UploadedImage/index.jpg" /></td>
            <td>BookTitle: <%=biModel.BookTitle %></td>
            </tr>
        <tr>
            <td>SubTitle: <%=biModel.SubTitle %></td>
            </tr>
        <tr>
            <td>Author: <%=biModel.Author %></td>
            </tr>
        <tr>
            <td>Price: <%=biModel.PriceNew %></td>
            </tr>
        <tr>
            <td>Now Price: <%=biModel.PriceOld %></td>
            
        </tr>
        <tr>
            <td colspan="2"><%=biModel.Details %></td>
        </tr>
    </table>
</asp:Content>
