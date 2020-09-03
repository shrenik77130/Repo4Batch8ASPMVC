<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="textbox1" runat="server" />
        <br />
        <asp:Button ID="button1" runat="server" Text="Show Message"/>


        <br />
        <asp:RadioButton ID="radio_male" runat="server" Text="Male" />


        <asp:RadioButton ID="radio_female" runat="server" Text="Female" />

        <br />
        <asp:CheckBox ID="chk1" Text="C Programming" runat="server" />
        <br />
        <asp:CheckBox ID="chk2" Text="C++ Programming" runat="server" />

        <br />
        <lable runat="server">
            This is Lable Control Created By Shrenik
        </lable>

        <br />
        <asp:TextBox ID="textbox_dob" runat="server" TextMode="Password"/>

    </div>
    </form>
</body>
</html>
