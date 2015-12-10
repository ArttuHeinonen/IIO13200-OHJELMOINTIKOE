<%@ Page Language="C#" AutoEventWireup="true" CodeFile="H3425_T3b.aspx.cs" Inherits="H3425_T3b" %>

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
                <td><img alt="linus" src="Images/linus.jpg" width="400" /></td>
                <td><h1>PuolipilkunViilaajat</h1></td>
                <td><img alt="rms" src="Images/rms.jpg" width="400" /></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label">Name</asp:Label>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" ErrorMessage="Name missing!" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Label">Password</asp:Label>
                    <asp:TextBox ID="txtPass" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtPass" runat="server" ErrorMessage="Password missing!" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Button ID="button" runat="server" OnClick="button_Click" Text="Login" />
                </td>
                <td></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
