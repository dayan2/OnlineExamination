<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WelcomePage1.aspx.cs" Inherits="WebUI.WelcomePage1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="Style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="box">
        <h1>Online Examination </h1>

        <div class="niv">The online examination system consists a web server with database facility. 
            The server of this system is mostly configured with proper security  measures.  
            Students can connect yourself through the internet to the server and take the exam.</div>

        <asp:Button ID="Button1" runat="server" Text="Learn More" />


        <div class="sector">
            <div> Welcome To Online Examination  </div>
            <div>
                Current Time Is: <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
            
            <div class="button">
                <asp:Button ID="Button2" runat="server" Text="Take Exam" />
            </div>

        </div>
    </div>
</asp:Content>
