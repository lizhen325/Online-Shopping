<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookInfoStatic.aspx.cs" Inherits="UI.Admin.BookInfoStatic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Start Id: </td>
                <td><input type="text"  name="startId"/></td>
            </tr>
            <tr>
                <td>End Id: </td>
                <td><input type="text" name="endId"/></td>
            </tr>
            <tr>
                <td><input type="submit" value="Generate" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
