<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Quiz_Master.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
      <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="signup.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

            <asp:Table ID="Table1" runat="server"></asp:Table>
            <tr>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="hello" />

                </td>
            </tr>
        
    </form>
</body>
</html>
