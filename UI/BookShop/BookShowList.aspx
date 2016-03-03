<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="BookShowList.aspx.cs" Inherits="UI.BookShop.BookShowList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin: 70px 0 0 0; text-align: center;">
        <h2>Programming Book List</h2>
        <%foreach (var item in BookList)
          {%>
        <div class="row" style="margin:0  auto;">
            <div class="col-md-4 col-lg-4">
                <a href="BookDetails.aspx?id=<%=item.Id %>" class="thumbnail">
                    <p><%=item.BookTitle %></p>
                    <p><%=item.SubTitle %></p>
                    <img src="<%=item.ImgTitle %>" style="width: 100px; height: 130px" />
                    <p style="text-align: right;">&#36;<%=item.PriceNew %></p>
                </a>
            </div>

            <%} %>
        </div>
        <p ><%=PageBar %></p>
    </div>
</asp:Content>
