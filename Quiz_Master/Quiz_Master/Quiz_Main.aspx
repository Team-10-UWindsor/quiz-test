<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz_Main.aspx.cs" Inherits="Quiz_Master.Quiz_Main" %>


<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="QuizMain.css" rel="stylesheet" />
    <title>Quiz</title>
</head>
<body>
    <form runat="server">

    <div class="v0_159">
        <div class="v0_160">
            <div class="v0_161"></div>
            <div class="v0_162"></div>
        </div>
        <span class="v0_163">QUIZ</span>
        <div class="v0_174">
            <div class="v0_175"></div>
        </div>

        <span class="v0_188">Empoyee details:</span>
        <span class="v0_177">Employee Name</span>
        <span class="v0_178">Employee ID</span>
        <span class="v0_179">Iron Man</span>
        <span class="v0_180">EMP012345</span>




        <!--   <div>

            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <table>
                    <tr>
                        <td><%#Eval("Question_Id")%>: <%#Eval("Question_Description") %></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="RadioButton1" runat="server" Text='<%#Eval("OptionA")%>' GroupName="option"/>
                            <asp:RadioButton ID="RadioButton2" runat="server" Text='<%#Eval("OptionB")%>' GroupName="option"/>
                            <asp:RadioButton ID="RadioButton3" runat="server" Text='<%#Eval("OptionC")%>' GroupName="option"/>
                            <asp:RadioButton ID="RadioButton4" runat="server" Text='<%#Eval("OptionD")%>' GroupName="option"/>
                            <br />                                                                                                                                      
                         
                        </td>
                    </tr>

                </table>

            </ItemTemplate>

        </asp:Repeater>

        </div> -->

        <div class="v0_181">
            <div class="v0_182">
                <div class="v0_183"></div>
                <asp:Button ID="done" runat="server" class="v0_184" Text="Done" OnClick="done_Click"   />
            </div>
            <div class="v0_185">
                <div class="v0_186"></div>
                <asp:Button ID="next" runat="server" class="v0_187" Text="Next"  OnClick="next_Click" />
            </div>

        </div>

        <div class="v4535_6"></div>
        <div class="v4536_124"></div>
        <asp:Button ID="prev" runat="server" Text="Prev"  class="v4536_126" OnClick="prev_Click"/>
       
        <span class="v0_189"><asp:Label ID ="question_no" runat="server">Question 1 of 5</asp:Label></span>

        <!--<span class="v0_190">Question 1:</span>-->

      

        





        <!--
            <ol id="list"></ol>
         -->

         <span class="v0_190" >
            <asp:PlaceHolder ID="PlaceHolder1" runat="server" >
                    <asp:Table ID="Table1" runat="server">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Ques_desc" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell><br /></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell><br /></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:RadioButton ID="optionA" GroupName ="options" Text =" " runat="server" /><br />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell><br /></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:RadioButton ID="optionB" GroupName ="options" Text =" " runat="server" /><br />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell><br /></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:RadioButton ID="optionC" GroupName ="options" Text =" " runat="server" /><br />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell><br /></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:RadioButton ID="optionD" GroupName ="options" Text =" " runat="server" /><br />
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
            </asp:PlaceHolder>

        </span>


        <span class="v0_192">
            <asp:ListBox ID="que_list" runat="server" Height="270px" Font-Bold="True" Font-Names="Verdana" Font-Size="Large" Font-Underline="False" ForeColor="#004DBF" AutoPostBack="True" BackColor="White" CssClass="lb_quelist" OnSelectedIndexChanged="que_list_SelectedIndexChanged" Width="365px"></asp:ListBox>
        </span>
        <!--<span class="v0_193">The difference between simple interest and compound on Rs. 1200 for one year at 10% per annum reckoned half-yearly is ?</span>
        <span class="v0_194">At what rate of compound interest per annum will a sum of Rs. 1200 become Rs. 1348.32 in 2 years?</span>
        <span class="v0_195">The compound interest on Rs. 30,000 at 7% per annum is Rs. 4347. The period (in years) is ?</span>
        <span class="v0_196">What is the difference between the compound interests on Rs. 5000 for 1 years at 4% per annum compounded yearly and half-yearly?</span>-->
       
        <div class="v0_200"></div>

        <span class="v0_201">Time Left:</span>
        
        <label id="duration" class="v0_202">05:00
        </label>
             <label  class="v0_217">mins</label>
            <!--<span class="v0_202">15:00 mins remaining</span>-->

        <div class="name"></div>
        <div class="name"></div>
        <div class="name"></div>
        <div class="name"></div>
        <div class="name"></div>
        
        <div class="name"></div>
        <div class="name"></div>
        
    </div>

        
       
 

</form>
</body>
</html>
