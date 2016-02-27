<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeEdit.aspx.cs" Inherits="UI.Admin.BookTypeEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        id:<%=BtModel.TypeId %>
        <input type="hidden" name="tid" value="<%=BtModel.TypeId %>"/>
        <br />
        Classcification Name: <input type="text" name="title" value="<%=BtModel.TypeTitle %>" />
        <br />
        <input type="hidden" name="tpid" value="<%=BtModel.TypeParentId %>"/>
        <input type="submit" value="Update" />
    </div>
    </form>
</body>
</html>
