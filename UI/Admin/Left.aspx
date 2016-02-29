<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Left.aspx.cs" Inherits="UI.Admin.Left" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
</head>
<body style="background-image:url(/Content/img/bkg-blu.jpg)">
<div class="container">    
  <h4 style="color:#0094ff;">Admin Manage</h4>
    <%-- Home --%>
   <div class="panel-group">
       <div class="panel panel-default">
        <div class="panel-heading">
            <h4 class="panel-title">
                <a href="Main.aspx" target="Main"><i class="glyphicon glyphicon-home"></i><span style="font-size:12px;"> &nbsp;Home</span></a>
            </h4>
        </div> 
       </div>
   </div>
    <%-- User Info Manage --%>
  <div class="panel-group">
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title"">
          <a data-toggle="collapse" href="#collapse1"><i class="glyphicon glyphicon-th-list"></i><span style="font-size:12px;"> &nbsp;User</span></a>
        </h4>
      </div>
      <div id="collapse1" class="panel-collapse collapse">
        <ul class="list-group">
          <li class="list-group-item"><a href="UserManagerList.aspx" class="list-group-item" target="Main"><span style="font-size:13px;">Details</span></a></li>
        </ul>
      </div>
    </div>
  </div>
    <%-- Prouct Manage --%>
    <div class="panel-group">
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" href="#collapse2"><i class="glyphicon glyphicon-th-list"></i><span style="font-size:12px;"> &nbsp;Product</span></a>
        </h4>
      </div>
      <div id="collapse2" class="panel-collapse collapse">
        <ul class="list-group">
          <li class="list-group-item"><a href="BookInfo.aspx" class="list-group-item" target="Main"><span style="font-size:13px;">Details</span></a></li>
        </ul>
      </div>
    </div>
  </div>
</div>
</body>
</html>
