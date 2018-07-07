<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FoodDishes.Default" %>

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
                <td>Username</td>
                <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                <td>Food Item</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                <td>Size</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList></td>
                </tr>
                <tr>
                 <td>Chilli</td>
                <td><asp:CheckBox ID="CheckBox1" runat="server" /></td>
                </tr>
                <tr>
                 <td>More salt</td>
                <td> <asp:CheckBox ID="CheckBox2" runat="server" /></td>
                </tr>
                <tr>
                 <td>Pepper</td>
                <td>
                    <asp:CheckBox ID="CheckBox3" runat="server" /></td>
                </tr>
                 <tr><td> </td><td>
                     <asp:Button ID="Button1" runat="server" Text="Order" OnClick="Button1_Click" />
            </td></tr>

            </table>
        </div>
    </form>
</body>
</html>
