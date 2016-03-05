<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="UI.BookShop.Register" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $(function () {
            //get cookie
            var cookiearr = document.cookie.split(';');
            for (var i = 0; i < cookiearr.length; i++) {
                var name = cookiearr[i].split('=')[0];
                var value = cookiearr[i].split('=')[1];
                if (name == 'rm') {
                    $('#login-username').val(value);
                }
            }
            $('#username').blur(function () {
                var username = $('#username').val();
                if (username != "") {                    
                    $.post('CheckUserName.ashx', { 'userName': username }, function (data) {
                        if (data == 'ok') {
                            $('#userhidden').val('no');
                            $('#usercheck').css('display', 'block');
                            $('#userspan').css('display', 'none');
                        } else if (data == 'no') {
                            $('#userhidden').val('ok');
                            $('#userspan').css('display', 'block');
                            $('#usercheck').css('display', 'none');
                            $('#userspan').text('* try another');
                        }
                    })
                } else {
                    $('$userspan').text('* Required');
                }
            });
            document.getElementById('pwd').onkeyup = function () {
                $('#checkpassword').css('display', 'block');
                if (this.value.length > 6) {
                    $('#passwordhidden').val('ok');
                    $('#passwordspan').text('');
                } else {
                    $('#passwordhidden').val('no');
                }
                var tds = document.getElementById('tb').getElementsByTagName('td');
                for (var i = 0; i < tds.length; i++) {
                    tds[i].style.backgroundColor = '';
                }
                var level = checkPwd(this.value);
                if (this.value.length > 0) {
                    if (level == 4) {
                        tds[0].style.backgroundColor = 'blue';
                        tds[1].style.backgroundColor = 'blue';
                        tds[2].style.backgroundColor = 'blue';
                    } if (level >= 2 && level < 4) {
                        tds[0].style.backgroundColor = 'yellow';
                        tds[1].style.backgroundColor = 'yellow';
                    } if (level <= 1) {
                        tds[0].style.backgroundColor = 'red';
                    }
                }
            };
            document.getElementById('pwd').onblur = function () {
                $('#checkpassword').css('display', 'none');
            }
            $('#cofirmpassword').keyup(function () {
                var pwd = $('#pwd').val();
                var cpwd = $(this).val();
                if (pwd == cpwd) {
                    $('#confirmpasswordhidden').val('ok');
                    $('#cpwdi').css('display', 'block');
                    $('#cpwds').css('display', 'none');
                } else {
                    $('#confirmpasswordhidden').val('no');
                    $('#cpwds').text('* no match');
                    $('#cpwdi').css('display', 'none');
                    $('#cpwds').css('display', 'block');
                }
            });
            $('#email').keyup(function () {
                var e = $(this).val();
                if (e.match(/^(([^<>()\[\]\.,;:\s@\"]+(\.[^<>()\[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i)) {                    
                    $('#emaili').css('display', 'block');
                    $('#emails').css('display', 'none');
                    $.post("CheckUserEmail.ashx", { 'email': e }, function (data) {
                        if(data == 'ok')
                        {
                            $('#emailhidden').val('ok');
                            $('#emaili').css('display', 'block');
                            $('#emailhidden').val('ok');
                        } else if (data == 'no') {
                            $('#emailhidden').val('no');
                            $('#emaili').css('display', 'none');
                            $('#emails').css('display', 'block');
                            $('#emails').text('* Try another');
                        }
                    })
                } else {
                    $('#emailhidden').val('no');
                    $('#emaili').css('display', 'none');
                    $('#emails').css('display', 'block');
                    $('#emails').text('* Invalid Email');
                }
            });
            $('#phone').keyup(function () {
                $('#checkphone').css('display', 'block');
                var phone = $(this).val();
                if (phone.match(/^(\()?\d{2,3}(\))?(-|\s)?\d{3,4}(-|\s)\d{4,7}$/)) {
                    $('#phonhidden').val('ok');
                    $('#phonei').css('display', 'block');
                    $('#phones').css('display', 'none');
                } else {
                    $('#phonhidden').val('no');
                    $('#phonei').css('display', 'none');
                    $('#phones').css('display', 'block');
                    $('#phones').text('* Invalid Phone');
                }
            });
            $('#phone').blur(function () {
                $('#checkphone').css('display', 'none');
            });
            $('#signupform').submit(function () {
                if ($('#userhidden').val() == 'ok') {
                    return true;
                }else if ($('#passwordhidden').val() == 'ok') {
                    return true;
                } else if ($('#confirmpasswordhidden').val() == 'ok') {
                    return true;
                } else if ($('#emailhidden').val() == 'ok') {
                    return true;
                } else if ($('#phonhidden').val() == 'ok') {
                    return true;
                }
                return false;
            });

            //validate login
            $('#btn-login').click(function () {
                var username = $('#login-username').val();
                var password = $('#login-password').val();
                if (username == '' || password == '') {
                    $('#errorspan').text('username or password can not be empty');
                    return;
                }
                $.post('CheckUserPassword.ashx', { 'username': username, 'password': password }, function (data) {
                    if (data == 'ok') {
                        //set cookie
                        <%%>
                        if (document.getElementById('login-remember').checked == true) {
                            var now = new Date();
                            var expireTime = now.getTime() + 1000 * 3600 * 24;
                            document.cookie = 'rm=' + username + '; expires=' + expireTime + ';';
                        } else {
                            //delete cookie
                            var now = new Date();
                            var expiredate = now.getTime() - 1000 * 3600;
                            document.cookie = 'rm=' + username + '; expires=' + expiredate + ';';
                        }
                        location.href = '../Index.aspx';
                    } else if (data == 'no') {
                        $('#signupalert').css('display', 'block');
                        $('#errorspan').text('Invalid username and password');
                    }
                });
            });
        });
        
        function checkPwd(msg) {
            var lvl = 0;
            if (msg.match(/[0-9]/)) {
                lvl++;
            } if (msg.match(/[a-zA-Z]/)) {
                lvl++;
            } if (msg.match(/[^a-zA-Z0-9]/)) {
                lvl++;
            } if (msg.match(/[-!$%^&*()_+|~=`{}\[\]:";'<>?,.\/]/)) {
                lvl++;
            } if (msg.length < 6) {
                lvl--;
            }
            return lvl;
        }

    </script>
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
                    <%-- Error --%>
                        <div id="signupalert" class="alert alert-danger login-alert">
                            <p id="errorspan"> Error: </p>
                        </div>
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
                        <%-- User ID --%>
                        <div class="form-group">
                            <label for="userid" class="col-md-3 control-label">User ID</label>
                            <div class="col-md-6">
                                <input type="text" class="form-control" name="userid" placeholder="User ID" id="username" />
                            </div>
                            <div class="col-md-3">
                                <i class="glyphicon glyphicon-ok" style="color:#00ff21; display:none;" id="usercheck"></i>
                                <span style="color:red;" id="userspan">*</span>
                                <input type="hidden" id="userhidden" />
                            </div>
                        </div>
                        <%-- Password --%>
                        <div class="form-group">
                            <label for="password" class="col-md-3 control-label">Password</label>
                            <div class="col-md-6">
                                <input type="password" class="form-control" name="password" placeholder="Password" id="pwd" />
                            </div>
                            <div class="col-md-3">
                                <span style="color:red;" id="passwordspan">*</span>
                                <input type="hidden" id="passwordhidden" />
                            </div>
                        </div>
                        <div class="form-group" id="checkpassword" style="display:none;">
                            <table style="width:300px; height:30px; text-align:center; margin:0 0 0 140px;" id="tb">
                                <tr>
                                    <td>L</td>
                                    <td>M</td>
                                    <td>S</td>
                                </tr>
                            </table>
                            <ul style="color:#666; margin:0 0 0 100px;">
                                <li>use at least 6 characters</li>
                                <li>Besides a include at least a number or symbol(!@#$%^&*_+) </li>
                                <li>password is a case sensitive</li>
                                <li>avoid to user the same password for multiple sites</li>
                            </ul>
                        </div>
                        <%-- Confirm Password --%>
                        <div class="form-group">
                            <label for="confirmpassword" class="col-md-3 control-label">Confirm Password</label>
                            <div class="col-md-6">
                                <input type="password" class="form-control" name="confirmpassword" placeholder="Confirm Password" id="cofirmpassword"/>
                            </div>
                            <div class="col-md-3">
                                <i class="glyphicon glyphicon-ok" style="color:#00ff21; display:none;" id="cpwdi"></i>
                                <span style="color:red;" id="cpwds">*</span>
                                <input type="hidden" id="confirmpasswordhidden" />
                            </div>
                        </div>
                        <%-- Email --%>
                        <div class="form-group">
                            <label for="email" class="col-md-3 control-label">Email</label>
                            <div class="col-md-6">
                                <input type="text" class="form-control" name="email" placeholder="Email Address" id="email"/>
                            </div>
                            <div class="col-md-3">
                                <i class="glyphicon glyphicon-ok" style="color:#00ff21; display:none;" id="emaili"></i>
                                <span style="color:red;" id="emails">*</span>
                                <input type="hidden" id="emailhidden" />
                            </div>
                        </div>
                        <%-- Address --%>
                        <div class="form-group">
                            <label for="address" class="col-md-3 control-label">Address</label>
                            <div class="col-md-6">
                                <input type="text" class="form-control" name="address" placeholder="Address" />
                            </div>
                        </div>
                        <%-- Phone --%>
                        <div class="form-group">
                            <label for="mobilephone" class="col-md-3 control-label">Phone</label>
                            <div class="col-md-6">
                                <input type="text" class="form-control" name="mobilephone" placeholder="Mobile Phone" id="phone"/>
                            </div>
                            <div class="col-md-3">
                                <i class="glyphicon glyphicon-ok" style="color:#00ff21; display:none;" id="phonei"></i>
                                <span style="color:red;" id="phones">*</span>
                                <input type="hidden" id="phonehidden" />
                            </div>
                        </div>
                        <div class="form-group" id="checkphone" style="display:none;">
                            <ul style="color:#666; margin:0 0 0 100px;">
                                <li>phone should be following format</li>
                                <li>XXX-XXXX-XXXX</li>
                                <li>XXX-XXX-XXXXX</li>
                                <li>XX-XXX-XXXX</li>
                            </ul>
                        </div>
                        <!-- Sign -->
                        <div class="form-group">
                            <div class="col-md-offset-3 col-md-9">
                                <input type="submit" value="Sign Up" id="btn-signup" class="btn btn-info" /> <i class="icon-hand-right"></i>
                                <strong>or</strong>
                                <a href="FacebookLogIn.aspx" class="btn btn-primary"> <i class="icon-facebook"></i> Sign Up with Facebook </a>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

