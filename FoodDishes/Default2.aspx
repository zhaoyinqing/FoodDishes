<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="FoodDishes.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" 
                DataKeyNames="OrderID" OnRowCancelingEdit="GridView1_RowCancelingEdit"
                OnRowDeleting="GridView1_RowDeleting" 
                OnRowEditing="GridView1_RowEditing"
                OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
        <asp:TemplateField HeaderText="Username" SortExpression="Username">
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Username") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="FoodID" SortExpression="FoodID">
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("FoodID") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FoodName" SortExpression="FoodName">
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("FoodName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Size" SortExpression="Size">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Size") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Size") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Chilli" SortExpression="Chilli">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Chilli") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Chilli") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="MoreSalt" SortExpression="MoreSalt">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("MoreSalt") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("MoreSalt") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Pepper" SortExpression="Pepper">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Pepper") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Pepper") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=ISS-BOR31102;Initial Catalog=FoodStall;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Orders]"></asp:SqlDataSource>
            
            <asp:DataList ID="DataList1" runat="server" OnItemCommand="Pick_Command">
  <ItemTemplate>  
    <table border="1">  
        <tr><td>OrderID</td>  
            <td>  
                <asp:Label ID="Label8" runat="server" Text='<%# Eval("OrderID")%>'></asp:Label>  
            </td>  
        </tr>  
        <tr><td>Username</td>  
            <td>  
                <%# Eval("Username")%>  
            </td>  
        </tr>  
        <tr><td>FoodID</td>  
            <td>  
                <%# Eval("FoodID")%> 
                <asp:Button ID="Button1" runat="server" Text="Pick this"
                     CommandName="Pick" 
                     CommandArgument='<%# Eval("FoodID") %>' />
            </td>  
        </tr>  
      </table>
   </ItemTemplate>
</asp:DataList>
<asp:Label ID="DataStatus" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
