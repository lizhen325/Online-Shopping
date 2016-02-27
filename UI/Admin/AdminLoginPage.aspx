<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLoginPage.aspx.cs" Inherits="UI.Admin.AdminLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/custom.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" />
    <script src="../js/jquery-ui-1.8.20.min.js"></script>
</head>
<body>
    
    <div class="container">
        <div id="loginbox" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 loginbox">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title"> Sign In </div>
                    <div class="forgot-password"> <a href="#">Forgot password?</a> </div>
                </div>
                <div class="panel-body panel-pad">
                    <div id="login-alert" class="alert alert-danger col-sm-12 login-alert"></div>
                        <form id="form1" class="form-horizontal" role="form" runat="server">
                            <div class="input-group margT25">
                                <span class="input-group-addon">
                                    <i class="glyphicon glyphicon-user"></i>
                                </span>
                                <input id="login-username" type="text" class="form-control" name="username" value="" placeholder="username or email" />
                            </div>
                            <div class="input-group margT25">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                                <input id="login-password" type="password" class="form-control" name="password" placeholder="password" />
                            </div>
                            <%--<div class="input-group margT25">
                                <span class="input-group-addon">Authentication</span>
                                <img src="../Common/ValidateCode.ashx" />
                            </div>--%>
                            <div class="input-group">
                                <div class="checkbox">
                                    <label>
                                        <input id="login-remember" type="checkbox" name="remember" value="1" /> Remember me
                                    </label>
                                </div>
                            </div>
                            <div class="form-group margT10">
                            <!-- Button -->
                                <div class="col-sm-12 controls">
                                    <input type="submit" value="Login"id="btn-login" class="btn btn-block btn-success" />
                                </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
