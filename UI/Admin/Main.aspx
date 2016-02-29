<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="UI.Admin.Main" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <style type="text/css">
        .bg-grey {
            background-color: #f6f6f6;
        }
    </style>
</head>
<body>
    <div class="container-fluid text-center bg-grey">
        <h1>Welcome to Admin Page</h1>
        <div id="myCarousel" class="carousel slide text-center" data-ride="carousel">
            <!-- Wrapper for slides -->
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <h4>"Are you happy with the result?"<br>
                        <span style="font-style: normal;">Come on man!! Still work hard</span></h4>
                </div>
                <div class="item">
                    <h4>"Do not forget your dream"<br>
                        <span style="font-style: normal;">Become the best Programmer</span></h4>
                </div>
                <div class="item">
                    <h4>"See below two leaders"<br>
                        <span style="font-style: normal;">It is not impossible</span></h4>
                </div>
            </div>
            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>
    <div class="container-fluid text-center bg-grey">
        <h2>My Idol</h2>
        <h4>Let me hit them</h4>
        <div class="row text-center">
            <div class="col-md-6">
                <div class="thumbnail">
                    <img src="../Content/img/yun.jpg" width="300" height="100" />
                    <p><strong>Jack Ma</strong></p>
                    <p>Jack Ma or Ma Yun(Chinese: 马云; born September 10, 1964)[3] is a Chinese business magnate and philanthropist. He is the founder and executive chairman of Alibaba Group, a family of successful Internet-based businesses. He is the first mainland Chinese entrepreneur to appear on the cover of Forbes.[2] As of November 2014, he is the richest man in China (Hong Kong not included) and 18th richest person in the world, with an estimated net worth of $24.1 billion, according to Forbes</p>
                </div>
            </div>
            <div class="col-md-6">
                <div class="thumbnail">
                    <img src="../Content/img/steven.jpg" width="400" height="300" />
                    <p><strong>Steve Jobs</strong></p>
                    <p>Steven Paul "Steve" Jobs (/ˈdʒɒbz/; February 24, 1955 – October 5, 2011) was an American information technology entrepreneur and inventor. He was the co-founder, chairman, and chief executive officer (CEO) of Apple Inc.; CEO and largest shareholder of Pixar Animation Studios;[3] a member of The Walt Disney Company's board of directors following its acquisition of Pixar; and founder, chairman, and CEO of NeXT Inc. Jobs is widely recognized as a pioneer of the microcomputer revolution of the 1970s, along with Apple co-founder Steve Wozniak. Shortly after his death, Jobs's official biographer, Walter Isaacson, described him as a "creative entrepreneur whose passion for perfection and ferocious drive revolutionized six industries: personal computers, animated movies, music, phones, tablet computing, and digital publishing</p>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
