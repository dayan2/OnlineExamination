<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebUI.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
            <tr>
                <td>
                    <h1><b>Employee Login&nbsp; </b></h1>
                    <div>User Name:  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                    <div>Password:   
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </div>
                    <div>    
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </div>
                </td>
               
                <td cellpadding="5" cellspacing="5">
                    
                    <h1><b>Admin Login</b></h1>
                    <div>User Name:  
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </div>
                    <div>Password:   
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </div>
                    <div>    
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Button" />
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </div>
                    
                </td>  
                
            </tr>
        </table>


</asp:Content>
