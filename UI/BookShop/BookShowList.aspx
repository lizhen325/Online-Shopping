<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="BookShowList.aspx.cs" Inherits="UI.BookShop.BookShowList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin: 70px 0 0 0;">
        <div id="myCarousel" class="carousel slide">
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" style="background:#000000">
            <div class="item active">
                <img src="../UploadedImage/4.png" style="width:800px; height:400px; margin:0 auto" />
            </div>
            <div class="item" style="background:#000000">
                <img src="../UploadedImage/2.png" style="width:800px; margin:0 auto; height:400px;"/>
            </div>
            <div class="item" style="background:#000000">
                <img src="../UploadedImage/3.jpg" style=" width:800px; margin:0 auto; height:400px;" />
            </div>
        </div>
        <a href="#myCarousel" data-slide="prev" class="carousel-control left">
            <span class="glyphicon glyphicon-chevron-left"></span>
        </a>
        <a href="#myCarousel" data-slide="next" class="carousel-control right">
            <span class="glyphicon glyphicon-chevron-right"></span>
        </a>
    </div>
    </div>
    <div class="container" style=" text-align: center;">
        <h2>Programming Book List</h2>
        <%foreach (var item in BookList)
          {%>
        <div class="row" style="margin:0  auto;">
            <div class="col-md-4 col-lg-4">
                <a href="BookDetails_<%=item.Id %>.aspx" class="thumbnail">
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
