<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="SuccessActivation.aspx.cs" Inherits="UI.BookShop.SuccessActivation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        $(function () {
            DownTime();
        });
        function DownTime() {
            var sec = $('#bbb').text();
            sec--;
            if (sec > -1) {
                $('#bbb').text(sec);
                setTimeout(function () { DownTime() }, 1000);
            } else {
                location.href = "../Index.aspx";
            }
        }
        
    </script>
    <div class="container" style="margin:100px 0 0 0;">
         
         <span>Thank you for verifying your email address</span>
        <br />
        <span>go main page in <span id="bbb" style="color:red;">5</span> Seconds</span>
    </div>
</asp:Content>
