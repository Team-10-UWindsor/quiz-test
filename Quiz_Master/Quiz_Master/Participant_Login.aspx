<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Participant_Login.aspx.cs" Inherits="Quiz_Master.Participant_Login" %>

<!DOCTYPE html>
<html>
<head>

    <meta charset="utf-8" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="Participant_Login_Stylesheet.css" rel="stylesheet" />
    <title>Participant Login</title>
    
</head>
<body>    
    <form runat="server">
        <div class="v0_69">

        <div class="v0_70">
            <div class="v0_71"></div>
            <div class="v0_72"></div>
            </div>
        <div class="v0_83">
            <div class="v0_84"></div>
            <span class="v0_85">Quiz ID</span>
            <div class="v0_86">
                <div class="v0_87"></div>
                <div class="name"></div>
                
                <asp:TextBox ID="quiz_id" class="v0_89" runat="server" name="quiz_id" placeholder="Enter Quiz ID"></asp:TextBox>

            </div>
            <div class="v0_90"></div>

            
            <asp:Button ID="enter" class="v0_91" runat="server" Text="Button" OnClick="enter_Click" />
            
        </div>
            <span class="v0_92">QUIZ</span>
        </div>
   </form> 
</body>
</html>
