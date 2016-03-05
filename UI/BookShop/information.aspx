<%@ Page Title="" Language="C#" MasterPageFile="~/BookShop/Shop.Master" AutoEventWireup="true" CodeBehind="information.aspx.cs" Inherits="UI.BookShop.information" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin: 100px 0 0 0;">
        <div class="jumbotron">
            <h1>Online Shopping</h1>
            <p>Online book shopping project is a web application which is implemented in C# ASP.NET + ADO.NET.</p>
            <p>Front End: HTML, CSS, Bootstrap, Javascript, JQeury</p>
        </div>
        <h3>Database shop</h3>
        <h2>Tables</h2>
        <ul>
            <li>UserInfo</li>
            <ul>
                <li>UserId, UserName, UserPwd, Email, Address, MobilePhone, RegisterTime, LoginTime, State</li>
            </ul>
            <li>UserManager</li>
            <ul>
                <li>Id, UserName, UserPwd</li>
            </ul>
            <li>BookInfo</li>
            <ul>
                <li>Id, Title, SubTitle, PriceOld, PriceNew, Author, Publisher, PublishDate, SaleDate, ISBN, TypeId, Details, ImgTitle</li>
            </ul>
            <li>BookType</li>
            <ul>
                <li>TypeId, TypeTitle, TypeParentId</li>
            </ul>
            <li>CartInfo</li>
            <ul>
                <li>CId, CustomerId, BookId, BookCount, BookUnitPrice</li>
            </ul>
            <li>Comment</li>
            <ul>
                <li>CommentId, CommentMsg, CommentTime, BookId</li>
            </ul>
            <li>OrderMain</li>
            <ul>
                <li>OrderId, CustomerId, OrderDate, Price</li>
            </ul>
            <li>OrderDep</li>
            <ul>
                <li>OrdeId, DepId, BookId, BookCount</li>
            </ul>
        </ul>
        <div class="container">
            <h3>1. Register Page</h3>
            <ul>
                <li>Data format and form validation </li>
                <li>Using AJAX to confirm whether ID and Email already exist or not</li>
                <li>Activation By user's Email: if the user activated in their own email, State, in UserInfo table, will be changed to 1 </li>
                <li>Forget Password: At first, if the email is matching with user's ID, the user will reiceve the email to change their password</li>
                <li>User can also register using facebook: retrieve user's information from Graph API to save in database</li>
            </ul>
        </div>
        <div class="container">
            <h3>2. Login Page</h3>
            <ul>
                <li>admin login page and customer login page: using AJAX</li>
                <li>Check remeber me checkbox, set the cookie with 14 expire dates</li>
            </ul>
        </div>
        <div class="container">
            <h3>3. Admin Page</h3>
            <p>There are four main regions for managing the site which are User, Product, Product type and Order information</p>
            <ul>
                <li>User Details</li>
                <ul>
                    <li>Add: insert user using JQuery dialog with AJAX</li>
                    <li>Delete: delete user with AJAX</li>
                    <li>Update: get data with a id and update </li>
                </ul>
                <li>Product Details</li>
                <ul>
                    <li>Add, Delete, Update are similar to User Details</li>
                    <li>Showing Type: one of the difficult part in this project. </li>
                    <li>Product Description: using Jquery API UMEditor</li>
                    <li>Image: HttpPostedFlie to Get the file name, save the image in UploadedImage file</li>
                </ul>
                <li>Generate Static Page:</li>
                <ul>
                    <li></li>
                </ul>
                <li>Product Type</li>
                <ul>
                    <li></li>
                </ul>
                <li>Order Info</li>
                <ul>
                    <li>Check the Order: </li>
                    <li>If the order have been delived, the state will be change to 1.</li>
                </ul>
            </ul>
        </div>
        <div class="container">
            <h3>4. Main Page</h3>

        </div>
    </div>
</asp:Content>
