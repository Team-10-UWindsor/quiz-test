<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sign_Up.aspx.cs" Inherits="Quiz_Master.Sign_Up" %>

<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8" />
      <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="signup.css" rel="stylesheet" />
    <title>Sign Up</title>
</head>
<body>
    <form runat="server">
    <div class="v4539_0">
        <div class="v4539_1">
            <div class="v4539_2"></div>            
        </div>
        <div class="v4539_14">
            <div class="v4539_15"></div>
            <div class="v4539_83">
                <div class="v4539_84"></div>
                <div class="name"></div>
                <asp:TextBox ID="confirmpswd" name="confirm_pswd" class="v4539_86" runat="server" placeholder="Confirm Password"></asp:TextBox>
            </div>
            <div class="v4539_47">
                <div class="v4539_48"></div>
                <div class="name"></div>
                <asp:TextBox ID="password" class="v4539_50" runat="server" name="password" placeholder="Password"></asp:TextBox>
           </div>
           <div class="v4539_43">
               <div class="v4539_44"></div>
               <div class="name"></div>
               <asp:TextBox ID="emailId" class="v4539_46" runat="server" name="emailid" placeholder="Email Id"></asp:TextBox>
           </div>
            <span class="v4539_16">Create your account</span>
            <div class="v4539_17">
                <div class="v4539_18"></div>
                <div class="name"></div>
                <asp:TextBox ID="username" class="v4539_20" runat="server" name="user_name" placeholder="User name"></asp:TextBox>
            </div>
            <div class="v4539_21">
                <div class="v4539_22"></div>
                <div class="name"></div>
                <asp:TextBox ID="phone" class="v4539_24" runat="server" name="phone" placeholder="Phone"></asp:TextBox>
            </div>
            <div class="v4539_27">
                <div class="v4539_28"></div>
                <asp:Button ID="sign_up" runat="server" class="v4539_29" Text="Sign up" OnClick="sign_up_Click"  />              
            </div>
            <div class="v4539_35">
                <div class="v4539_36">  
                    <asp:CheckBox ID="checkbox" runat="server" OnCheckedChanged="checkbox_CheckedChanged" />
                </div>
                <span class="v4539_38">By joining  I agree with  Terms & Conditions and Privacy policy</span>
            </div></div>
        <span class="v4539_39">QUIZ</span>
    </div>
        </form>
</body>
</html>