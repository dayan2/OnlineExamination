<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddQues.aspx.cs" Inherits="WebUI.AddQues" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

        <h1>Administer</h1>
        <form id="form1" >
        <div>
            
            <div>Question:  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>Answer1:  
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>Answer2:  
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>Answer3:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
    &nbsp;</div>
            <div>Answer4:  
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>Correct Answer:  
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            </div>

        </div>
        </form>

</asp:Content>
