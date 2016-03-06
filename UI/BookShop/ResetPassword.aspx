<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="UI.BookShop.ResetPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript">
    $(function () {
        
        
        $('#btnResetPassword').click(function () {
            var resetPassword = $('#ResetPassword').val();
            var confirmResetPassword = $('#ConfirmResetPassword').val();
            if (resetPassword == "" || confirmResetPassword == "") {
                $('#errorR').css('display', 'block');
                $('#Rerror').text('Error: Please enter your password');
                return false;
            } else if (resetPassword != confirmResetPassword) {
                $('#Rerror').text('Error: Password Does not match');
                return false;
            } else {
                $.post('ResetPassword.ashx', { 'password': confirmResetPassword, 'id': GetNameFormUrl('id') }, function (data) {
                    if (data == 'ok') {
                        location.href = 'SuccessActivation.aspx';
                    } else if (data == 'no') {
                        alert('fail to change password');
                    }
                });
            }
        })
    });

    function GetNameFormUrl(name) {
        var reg = new RegExp("(^|\\?|&)"+ name +"=([^&]*)(\\s|&|$)", "i");

        if (reg.test(location.href))

            return unescape(RegExp.$2.replace(/\+/g, " "));

        return "";
    }
</script>
<div class="container" style="margin:100px 0 0 0;">
    <h1>Reset Password</h1>
    <br />
    <br />
    
     <div class="alert alert-danger" style="display:none;" id="errorR">
          <p id="Rerror"> Error: </p>
    </div> 
    <br />
    <br />
    <div class="row">
        <div class="col-sm-2">
            <label>Reset Password</label>
        </div>
        <div class="col-sm-4">
            <input type="password" id="ResetPassword"/>
        </div>
    </div>
    <br />
    <br />
    <div class="row">
        <div class="col-sm-2">
            <label>Confirm Password</label>
        </div>
        <div class="col-sm-4">
            <input type="password" name="password" id="ConfirmResetPassword"/>
        </div>
    </div>
    <br />
    <br />
    <div class="row">
        <div class="col-sm-4 col-sm-offset-2">
            <button type="button" id="btnResetPassword" class="btn btn-info" /> submit
        </div>
    </div>
</div>
    <br />
    <br />
</asp:Content>
