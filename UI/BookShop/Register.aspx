<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="UI.BookShop.Register" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin:100px 0 0 0;">
        <%-- Log in --%>
        <div id="loginbox" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 loginbox">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title"> Sign In </div>
                    <div class="forgot-password"> <a href="#">Forgot password?</a> </div>
                </div>
                <div class="panel-body panel-pad">
                    <div id="login-alert" class="alert alert-danger col-sm-12 login-alert"></div>
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
                                <a id="btn-login" href="#" class="btn btn-block btn-success">Login </a>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-12 control">
                                <div class="no-acc">
                                    Don't have an account!
                                    <a href="#" onclick="$('#loginbox').hide(); $('#signupbox').show()"> Sign Up Here </a>
                                    <div class="forgot-password"> <a href="../Admin/AdminLoginPage.aspx">The Admin Login</a> </div>
                                </div>
                            </div>
                        </div>
                </div>
            </div>
        </div>
        <%-- Sign Up --%>
        <div id="signupbox" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 signup-box">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title"> Sign Up </div>
                    <div class="signin">
                        <a id="signinlink" href="#" onclick="$('#signupbox').hide(); $('#loginbox').show()">Sign In</a>
                    </div>
                </div>
                <div class="panel-body">
                    <form id="signupform" class="form-horizontal" role="form" runat="server">
                        <%-- Error --%>
                        <div id="signupalert" class="alert alert-danger login-alert">
                            <p> Error: </p>
                            <span></span>
                        </div>
                        <%-- User ID --%>
                        <div class="form-group">
                            <label for="userid" class="col-md-3 control-label">User ID</label>
                            <div class="col-md-9">
                                <input type="text" class="form-control" name="userid" placeholder="User ID" />
                            </div>
                        </div>
                        <%-- Password --%>
                        <div class="form-group">
                            <label for="password" class="col-md-3 control-label">Password</label>
                            <div class="col-md-9">
                                <input type="password" class="form-control" name="password" placeholder="Password" />
                            </div>
                        </div>
                        <%-- Confirm Password --%>
                        <div class="form-group">
                            <label for="confirmpassword" class="col-md-3 control-label">Confirm Password</label>
                            <div class="col-md-9">
                                <input type="password" class="form-control" name="confirmpassword" placeholder="Confirm Password" />
                            </div>
                        </div>
                        <%-- Email --%>
                        <div class="form-group">
                            <label for="email" class="col-md-3 control-label">Email</label>
                            <div class="col-md-9">
                                <input type="text" class="form-control" name="email" placeholder="Email Address" />
                            </div>
                        </div>
                        <%-- Address --%>
                        <div class="form-group">
                            <label for="address" class="col-md-3 control-label">Address</label>
                            <div class="col-md-9">
                                <input type="text" class="form-control" name="address" placeholder="Address" />
                            </div>
                        </div>
                        <%-- Phone --%>
                        <div class="form-group">
                            <label for="mobilephone" class="col-md-3 control-label">Phone</label>
                            <div class="col-md-9">
                                <input type="text" class="form-control" name="mobilephone" placeholder="Mobile Phone" />
                            </div>
                        </div>
                        <!-- Sign -->
                        <div class="form-group">
                            <div class="col-md-offset-3 col-md-9">
                                <input type="submit" value="Sign Up" id="btn-signup" type="button" class="btn btn-info" /> <i class="icon-hand-right"></i>
                                <strong>or</strong>
                                <button id="btn-fbsignup" type="button" class="btn btn-facebook"> <i class="icon-facebook"></i> Sign Up with Facebook </button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

