<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Head.aspx.cs" Inherits="UI.Admin.Head" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        span{
            font-size:20px; 
            color:#eee;
        }
    </style>
</head>
<body >
    <div class="container" style="background-color:#666;">
             <div class="navbar-header">
                 <img src="https://d3nbni5ovlf4g9.cloudfront.net/frontend/images/browse/categories/heading-books~f3910b34.png" style="padding:22px;" />    
                 <img src="https://d3nbni5ovlf4g9.cloudfront.net/frontend/images/browse/categories/monkey-books~9d4d6837.png" style="padding:5px;"/> 
                 <span style="font-size:30px;"><i>OpenWonderLand</i></span>
             </div>
        <ul class="nav navbar-nav navbar-right" style="margin: 50px 20px 0 0;">
            <li><span>Sever Admin</span></li>
            <li style="padding:0 0 0 5px;"><span style="color:chocolate"><%=DateTime.Now.ToString("dd/MM/yyyy") %></span></li>
        </ul>
    </div>
</body>
</html>
