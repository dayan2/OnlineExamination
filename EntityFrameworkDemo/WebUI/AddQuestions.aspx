<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddQuestions.aspx.cs" Inherits="WebUI.AddQuestions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Administer</h1>
    <form id="form1" runat="server">
    <div>
        <div>Examination Type:  
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
        </div>
        <div>Cut-Off Mark:  
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </div>
        <br/>
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
</body>
</html>
