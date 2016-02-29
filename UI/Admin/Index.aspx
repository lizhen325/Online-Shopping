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
    
        <div class="row">
            <iframe src="Head.aspx" style="height: 100px;" frameborder="0" scrolling="no" name="Head" class="col-md-12 col-sm-12 col-xs-12"></iframe>
        </div>      
    
    
        <iframe src="Left.aspx" class="col-md-2 col-sm-2 col-xs-2" style="height: 800px;" frameborder="1" scorlling="No" name="Left"></iframe>
        <iframe src="Main.aspx" class="col-md-10 col-sm-10 col-xs-10" style="height: 800px;" frameborder="0" scorlling="No" name="Main"></iframe>          

        <div class="row">
            <iframe src="Foot.aspx" class="col-md-12 col-sm-12 col-xs-12" style="height:200px;" frameborder="0" name="Foot"></iframe>  
        </div>  
</body>
</html>
