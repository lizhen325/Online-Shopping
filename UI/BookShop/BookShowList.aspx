<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="BookShowList.aspx.cs" Inherits="UI.BookShop.BookShowList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin: 100px 0 0 0; text-align: center;">
        <h2>Image Gallery</h2>
        <p>BookList</p>
        <%foreach (var item in BookList)
          {%>
        <div class="row">
            <div class="col-lg-4">
                <a href="BookDetails.aspx?id=<%=item.Id %>" class="thumbnail">
                    <p><%=item.BookTitle %></p>
                    <p><%=item.SubTitle %></p>
                    <img src="../UploadedImage/index.jpg" alt="Cinque Terre" style="width: 150px; height: 150px" />
                    <p style="text-align: right;">&#36;<%=item.PriceNew %></p>
                </a>
            </div>

            <%} %>
        </div>
        <p><%=PageBar %></p>
    </div>
</asp:Content>
