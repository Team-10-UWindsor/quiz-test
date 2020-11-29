﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="View_Ques.aspx.cs" Inherits="Quiz_Master.View_Ques" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
   <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="view_ques.css" rel="stylesheet" />
    <title>View Questions</title>
</head>
<body>
    <form runat="server">

    
    <div class="v4505_529">
        <div class="v4505_530">
            <div class="v4505_531"></div>
            <div class="v4505_532"></div>
        </div>
        <span class="v4505_533">QUIZ</span>
        <div class="v4505_544">
            <div class="v4505_545"></div>
        </div>
        <span class="v4505_547">Employee Name</span>
        <span class="v4505_548">Employee ID</span>
 <asp:Label ID="emp_name" class="v4505_549" runat="server" Text="Employee_Name"></asp:Label>
            <asp:Label ID="emp_id" class="v4505_550" runat="server" Text="Employee_ID"></asp:Label>
        <div class="v4505_555">
            <div class="v4505_556">
                <div class="v4505_557"></div>
                <asp:Button ID="publish" runat="server" class="v4505_558" Text="Publish" />
                 
            </div></div>
        <!--
            <ul>
              
            </u>

        <span class="v4505_598">What will be the compound interest on a sum of Rs. 25,000 after 3 years at the rate of 12 p.c.p.a.?</span>
        <span class="v4505_600">What will be the compound interest on a sum of Rs. 25,000 after 3 years at the rate of 12 p.c.p.a.?</span>
        <span class="v4505_602">What will be the compound interest on a sum of Rs. 25,000 after 3 years at the rate of 12 p.c.p.a.?</span>
        <span class="v4505_599">What will be the compound interest on a sum of Rs. 25,000 after 3 years at the rate of 12 p.c.p.a.?</span>
        <span class="v4505_601">What will be the compound interest on a sum of Rs. 25,000 after 3 years at the rate of 12 p.c.p.a.?</span>
        <span class="v4505_603">What will be the compound interest on a sum of Rs. 25,000 after 3 years at the rate of 12 p.c.p.a.?</span>
                    -->
        <span class="v4505_590">Empoyee details</span>

        <div class="name"></div>
        <span class="v4505_595">Quiz ID:</span>
        <asp:Label ID="quiz_id" class="v4505_596" runat="server" Text="Quiz ID"></asp:Label>
            
        
        <span class="v4505_604">Questions</span>
        <div class="v4505_724">
            </div></div>

        
 <div class="v4505_598">
         <table>
          <asp:Repeater ID="Repeater_3" runat="server">
                          <ItemTemplate>
                              <table>
                                  <tr>
                                       <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='#'><%#Eval("Question_Description")%></asp:HyperLink></td>
                                      
                                      
                                      
                                  </tr>
                               </table>
                            </ItemTemplate>
        </asp:Repeater>  
     </table>
 </div>

        </form>
</body>
</html>

