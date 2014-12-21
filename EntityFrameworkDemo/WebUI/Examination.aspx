<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Examination.aspx.cs" Inherits="WebUI._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <h1>Online Examination System</h1>
    <p>Current Time: <asp:Label ID="Label1" runat="server"></asp:Label> 
       
        <asp:DropDownList ID="DropDownList_Answers" runat="server"></asp:DropDownList>     


        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetExams" TypeName="DataLayer.Repository"></asp:ObjectDataSource>
       


        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="CutOffMark" HeaderText="CutOffMark" SortExpression="CutOffMark" />
            </Columns>
        </asp:GridView>


 
       


</asp:Content>
