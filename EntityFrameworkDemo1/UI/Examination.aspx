<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examination.aspx.cs" Inherits="UI.Examination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Online Examination System</h1>

        <p>Current Time: <asp:Label ID="Label1" runat="server"></asp:Label> 
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetExams" TypeName="DataLayer.Repository"></asp:ObjectDataSource>
        </p>
        <p>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1">
            </asp:ListView>
        </p>
        
    </div>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetQuestions" TypeName="DataLayer.Repository"></asp:ObjectDataSource>
        <asp:ListView ID="ListView2" runat="server" DataSourceID="ObjectDataSource2">
        </asp:ListView>
    </form>
</body>
</html>
