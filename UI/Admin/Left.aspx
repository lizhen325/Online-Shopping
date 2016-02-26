<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Left.aspx.cs" Inherits="UI.Admin.Left" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .content{
            padding:0;
            margin:0;
            text-align:center;
        }
    </style>
</head>
<body >
    <div class="container-fluid content">
        <div class="list-group">
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
        </div>
    </div>
</body>
</html>
