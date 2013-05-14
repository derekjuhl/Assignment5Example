<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Donor Login</h1>
        <table>
            <tr>
            <td>User name</td>
            <td>
                <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
            </td>
            </tr>
              <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            </tr>
              <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Log In" OnClick="Button1_Click" /></td>
            <td>
                <asp:Label ID="lblmsg" runat="server" ></asp:Label>
            </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
