<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoUpdate.aspx.cs" Inherits="UI.Admin.UserInfoUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        div{
            padding:10px;
        }
    </style>
</head>
<body>
    <div id="signupbox" class="mainbox col-md-7 col-md-offset-3 col-sm-8 col-sm-offset-2 signup-box">
        <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title" style="text-align:center;"> Update User Info </div>
                </div>
            <div class="panel-body">
                
                <form id="form1" runat="server">
                    <input type="text" name="uid" value="<%=ui.UserId %>"/>
                    <div id="signupalert" class="alert alert-danger login-alert" style="display:none;">
                        <p>Error: </p>
                        <span></span>
                    </div>
                    <%-- UserName --%>
                    <div class="form-group" style="margin:20px 0 0 0">
                        <label for="username" class="col-md-3 control-label">UserName</label>
                        <div class="col-md-9">
                            <input type="text" class="form-control" name="username" value="<%=ui.UserName %>"/>
                        </div>
                    </div>
                    <%-- Email --%>
                    <div class="form-group" style="margin:20px 0 0 0">
                        <label for="email" class="col-md-3 control-label">Email</label>
                        <div class="col-md-9">
                            <input type="text" class="form-control" name="email" value="<%=ui.Email %>"/>
                        </div>
                    </div>
                    <%-- Address --%>
                    <div class="form-group" style="margin:20px 0 0 0">
                        <label for="address" class="col-md-3 control-label">Address</label>
                        <div class="col-md-9">
                            <input type="text" class="form-control" name="address" value="<%=ui.Address %>"/>
                        </div>
                    </div>
                    <%-- mobile phone --%>
                    <div class="form-group">
                        <label for="mobilephone" class="col-md-3 control-label"  style="margin:20px 0 0 0">Mobile Phone</label>
                        <div class="col-md-9">
                            <input type="text" class="form-control" name="mobilephone" value="<%=ui.MobilePhone %>"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <!-- Button -->
                        <div class="col-md-offset-3 col-md-9">
                            <input type="submit" value="update" class="btn btn-info" />
                        </div>
                    </div>
                </form>
            </div>
            </div>
        </div>
</body>
</html>
