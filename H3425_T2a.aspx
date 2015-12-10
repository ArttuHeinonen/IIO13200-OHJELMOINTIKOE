<%@ Page Language="C#" AutoEventWireup="true" CodeFile="H3425_T2a.aspx.cs" Inherits="H3425_T2a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Tehtävä 2a</h1>
        <asp:Button ID="btnVakituiset" OnClick="btnVakituiset_Click" runat="server" Text="Näytä vakituiset" />
        <asp:GridView ID="gv" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
