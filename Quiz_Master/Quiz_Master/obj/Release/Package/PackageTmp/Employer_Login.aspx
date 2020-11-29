<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employer_Login.aspx.cs" Inherits="Quiz_Master.Employer_Login" %>

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
                  <asp:TextBox ID="user_name"  class="v0_49" placeholder="User name" name="user_name" runat="server" OnTextChanged="user_name_TextChanged"></asp:TextBox>
               
              </div>
              <div class="v0_50">
                  <div class="v0_51"></div>
                  <div class="name"></div>
                  <asp:TextBox ID="password" class="v0_53" name="password" placeholder="Password" runat="server"></asp:TextBox>
               
              </div>
              <div class="v0_54"></div>
              <asp:Button ID="signin" runat="server" class="v0_55" Text="Sign in" OnClick="signin_Click" />
              <div class="v0_56">
                  <div class="v0_57"></div>
                  <asp:Button ID="signup" class="v0_58" runat="server" Text="Sign up" />
              </div>
              <div class="v0_59">
                  <span class="v0_60">or</span>
                  <div class="name"></div>
                  <div class="name"></div>
              </div>
               <a class="v0_63" href="www.google.com?">Forgot password?</a>           
               
              <div class="v0_64">
                  <div class="v0_65">
                      <asp:CheckBox ID="checkbox" runat="server" />
                  </div>
                  <span class="v0_67">By joining  I agree with  Terms & Conditions and Privacy policy</span>
              </div></div>
          <span class="v0_68">QUIZ</span>
      </div>
    </form>
</body>
</html>
