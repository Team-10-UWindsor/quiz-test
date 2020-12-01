<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployerLogin.aspx.cs" Inherits="Quiz_Master.EmployerLogin" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="empyr_login_stylesheet.css" rel="stylesheet" />
    <title>Employer_login</title>
</head>
<body>
    <form runat="server">
      <div class="v0_29">
          <div class="v0_30">
              <div class="v0_31"></div>
              <div class="v0_32"></div>
          </div>
          <div class="v0_43">
              <div class="v0_44"></div>
              <span class="v0_45">Login</span>
              <div class="v0_46">
                  <div class="v0_47"></div>
                  <div class="name"></div>
                  <asp:TextBox ID="user_name"  class="v0_49" placeholder="User name" name="user_name" runat="server" ></asp:TextBox>
                  <asp:RequiredFieldValidator ID="UserNameValidator" runat="server" ErrorMessage="Please Enter Your Username" ControlToValidate="user_name"></asp:RequiredFieldValidator>
               
              </div>
              <div class="v0_50">
                  <div class="v0_51"></div>
                  <div class="name"></div>
                  <asp:TextBox ID="password" class="v0_53" name="password" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" ErrorMessage="Please Enter Your Password" ControlToValidate="password"></asp:RequiredFieldValidator>
               
              </div>
              <div class="v0_54"></div>
              <asp:Button ID="signin" runat="server" class="v0_55" Text="Sign in" OnClick="signin_Click" />
              <div class="v0_56">
                  <div class="v0_57"></div>
                  <asp:Button ID="signup" class="v0_58" runat="server" Text="Sign up" OnClick="signup_Click" />
              </div>
              <div class="v0_59">
                  <span class="v0_60">or</span>
                  <div class="name"></div>
                  <div class="name"></div>
              </div>
               
               
              <div class="v0_64">
                  <div class="v0_65">
                   
                  </div>
                  
              </div></div>
          <span class="v0_68">QUIZ</span>
      </div>
    </form>
</body>
</html>
