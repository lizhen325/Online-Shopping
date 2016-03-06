<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="UI.BookShop.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript">
    $(function () {
        $('#forgotpassword').click(function () {
            var id = $('#id').val();
            var email = $('#email').val();
            if (id == "" || email == "") {
                $('#errorp').css('display', 'block');
                $('#perror').text('Error: Please enter your ID and your email address');
                return false;
            } else {
                $.get('CheckUserNameAndPassword.ashx', { 'id': id, 'email': email }, function (data) {
                    if (data == 'ok') {
                        location.href = 'ChangePassword.aspx?id='+id+'&email='+email;
                    } else if (data =='no') {
                        $('#errorp').css('display', 'block');
                        $('#perror').text('Error: ID or email is incorrect');
                    }
                });
            }
        });
    });
</script>
<div class="container" style="margin:100px 0 0 0;">
    <h3>online password lookup</h3> <span> Please enter your ID and your email address</span>
    <br />
    <br />
    <div class="alert alert-danger" style="display:none;" id="errorp">
          <p id="perror"> Error: </p>
    </div>       
    <div class="row">
        <div class="col-sm-1">
            <label> ID:</label> 
        </div>
          <div class="col-sm-6">
              <input type="text" class="form-control" placeholder="Enter ID" name="id" id="id"/>
          </div>            
        </div> 
     <br />
    <br />
    <div class="row">
        <div class="col-sm-1">
          <label> Email:</label> 
        </div>
        <div class="col-sm-6">
            <input type="email" class="form-control" placeholder="Enter email" name="email" id="email"/>
        </div>
    </div>
    <br />
    <br />
         <div class="row">        
      <div class="col-sm-1 col-sm-offset-1">
        <button type="submit" class="btn btn-default" id="forgotpassword">Send Request</button>
      </div>
    </div>
  
</div>
</asp:Content>
