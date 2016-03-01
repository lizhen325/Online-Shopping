﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UI.Index" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/custom.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <a href="Index.aspx" class="navbar-brand logo"><img src="https://d3nbni5ovlf4g9.cloudfront.net/frontend/images/browse/categories/heading-books~f3910b34.png" style="height:30px;" /></a>
                <img src="https://d3nbni5ovlf4g9.cloudfront.net/frontend/images/browse/categories/monkey-books~9d4d6837.png" style="height:40px;"/>
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse" id="navbar-collapse">
                <ul class="nav navbar-nav">
                    <li><a href="index.html" class="active"><span class="glyphicon glyphicon-home"></span> Home</a></li>
                    <li><a href="information.html"><span class="glyphicon glyphicon-list"></span> Information</a></li>
                    <%--<li><a href="case.html"><span class="glyphicon glyphicon-fire"></span> Case</a></li>--%>
                    <li><a href="about.html"><span class="glyphicon glyphicon-question-sign"></span> About</a></li>
                    <li style="margin:11px 0 0 0;"><input type="text" name="search" placeholder="search" /></li>
                    <li style="margin:11px 0 0 0;"><select style="height:26px;">
                        <option selected="selected">All Categories</option>
                        <option>Programming</option>
                        </select>
                    </li>
                    <li><a href="#"><span class="btn btn-primary" style="margin:-6px 0 0 0; height:30px;">Search</span></a></li>
                    <li><a href="about.html"><span class="glyphicon glyphicon-shopping-cart"></span>Shopping Cart</a></li>
                    <li><a href="BookShop/Register.aspx"><span class="glyphicon glyphicon-user"></span> Sign Up / Log In</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <div id="myCarousel" class="carousel slide">
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" style="background:#223240">
            <div class="item active">
                <img src="../UploadedImage/s3.jpeg" style="width:800px; margin:0 auto;"/>
            </div>
            <div class="item" style="background:#000000">
                <img src="../UploadedImage/s5.jpg" style="margin:0 auto; height:450px;"/>
            </div>
            <div class="item" style="background:#000000">
                <img src="../UploadedImage/s6.jpg" style="margin:0 auto; height:450px;" />
            </div>
        </div>
        <a href="#myCarousel" data-slide="prev" class="carousel-control left">
            <span class="glyphicon glyphicon-chevron-left"></span>
        </a>
        <a href="#myCarousel" data-slide="next" class="carousel-control right">
            <span class="glyphicon glyphicon-chevron-right"></span>
        </a>
    </div>
        <footer id="footer">
        <div class="container">
            <p><a href="#" style="color:#eee;">Corporate Tranning</a> | <a href="#" style="color:#eee;">Cooperation</a> | <a href="#" style="color:#eee;">About Me</a></p>
            <p>Copyright &copy; 2016-02 Zhen Li. Powered by ASP.NET</p>
        </div>
    </footer>
    </form>    
</body>
</html>