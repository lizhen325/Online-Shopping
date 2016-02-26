<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UI.Admin.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <frameset rows="*" cols="180,*" frameborder="no" border="0" framespacing="0">
                <frame src="Left.aspx" name="leftFrame" scrolling="auto" noresize="noresize" id="leftFrame" title="leftFrame" />
                <frameset rows="50,*" frameborder="no" border="0" framespacing="0">
                    <frame src="Head.aspx" name="topFrame" scrolling="No" noresize="noresize" id="topFrame" title="topFrame" />
                    <frame src="Main.aspx" name="mainFrame" id="mainFrame" title="mainFrame" />
                </frameset>
            </frameset>
<body>
    <form id="form1" runat="server">
        <div>
            
        </div>
    </form>
</body>
</html>
