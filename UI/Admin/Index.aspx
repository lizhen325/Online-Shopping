<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UI.Admin.Index" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        footer {
            background-color: #555;
            color: white;
            padding: 15px;
        }
    </style>
</head>
<body>
    <div class="container-fluid">
        <div class="row">
         <iframe src="Head.aspx" style="height:200px;" scrolling="No" name="Head" class="col-md-12 col-sm-12 col-lg-12">
        
        </iframe>
        </div>
        
    </div>

    <div class="container-fluid">
        <iframe src="Left.aspx" class="col-sm-2" style="height:600px; border:1px solid #eee; background-color:#eee;" name="Left">

        </iframe>
        <iframe src="Main.aspx" class="col-sm-10" style="height:600px; border:1px solid #eee;" scorlling="No" name="Main">

        </iframe>
    </div>

    <footer class="container-fluid text-center">
        <p>&copy <strong>Zhen Li</strong></p>
    </footer>
</body>
</html>
