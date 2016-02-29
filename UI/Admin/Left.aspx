<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Left.aspx.cs" Inherits="UI.Admin.Left" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
</head>
<body >
<div class="container">
  <h4 style="color:#0094ff;">Admin Manage</h4>
    <%-- User Info Manage --%>
  <div class="panel-group">
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" href="#collapse1"><span style="font-size:11px;">User Mange</span></a>
        </h4>
      </div>
      <div id="collapse1" class="panel-collapse collapse">
        <ul class="list-group">
          <li class="list-group-item"><a href="UserManagerList.aspx" class="list-group-item" target="Main"><span style="font-size:11px;">User Details</span></a></li>
        </ul>
      </div>
    </div>
  </div>
    <%-- Prouct Manage --%>
    <div class="panel-group">
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" href="#collapse2"><span style="font-size:11px;">Product Mange</span></a>
        </h4>
      </div>
      <div id="collapse2" class="panel-collapse collapse">
        <ul class="list-group">
          <li class="list-group-item"><a href="BookInfo.aspx" class="list-group-item" target="Main"><span style="font-size:11px;">Product Details</span></a></li>
        </ul>
      </div>
    </div>
  </div>
</div>
        <%--<div class="list-group">
            <p class="list-group-item list-group-item-info">User Management</p>
            <a href="UserManagerList.aspx" class="list-group-item" target="Main">User Details</a>
            <a href="#" class="list-group-item">Add User</a>
        </div>
         <div class="list-group">
            <p class="list-group-item list-group-item-info">Product Management</p>
            <a href="UserManagerList.aspx" class="list-group-item">Product Details</a>
            <a href="#" class="list-group-item">Add Product</a>
        </div>
         <div class="list-group">
            <p class="list-group-item list-group-item-info">Product Type</p>
            <a href="UserManagerList.aspx" class="list-group-item">Product Type Detials</a>
            <a href="#" class="list-group-item">Add Product Type</a>
        </div>--%>
</body>
</html>
