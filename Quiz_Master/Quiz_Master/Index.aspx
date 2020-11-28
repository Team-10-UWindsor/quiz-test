<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Quiz_Master.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:LinkButton ID="Employer_Login" runat="server" OnClick="Employer_Login_Click">Employer Login</asp:LinkButton>
            <asp:LinkButton ID="Participant" runat="server" OnClick="Participant_Click">Participant</asp:LinkButton>


        </div>
    </form>
</body>
</html>
