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

        <span class="v0_188">Participant details:</span>
        <span class="v0_177">Participant Name</span>
        <span class="v0_178">Participant ID</span>
        <asp:Label ID="p_name" class="v0_179" runat="server" Text="Participant_Name"></asp:Label>
        <asp:Label ID="p_id" class="v0_180" runat="server" Text="Participant_ID"></asp:Label>
       

        <div class="v0_181">
            <div class="v0_182">
                <div class="v0_183"></div>
                <asp:Button ID="done" runat="server" class="v0_184" Text="Done" OnClick="done_Click"   />
            </div>
            <div class="v0_185">
                <div class=""></div>
                <asp:Button ID="next" runat="server" class="v0_187" Text="Next"  OnClick="next_Click" />
            </div>

        </div>

        <div class="v4535_6"></div>
        <div class=""></div>
        <asp:Button ID="prev" runat="server" Text="Prev"  class="v4536_126" OnClick="prev_Click"/>
       
        <span class="v0_189"><asp:Label ID ="question_no" runat="server">Question 1 of 5</asp:Label></span>

       

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
            <span class="v0_219">All Questions</span>
            <asp:ListBox ID="que_list" runat="server" style="line-height:2.2" Height="270px" Font-Bold="True" Font-Names="Verdana" Font-Size="Large" Font-Underline="False" ForeColor="#004DBF" AutoPostBack="True" BackColor="White" CssClass="lb_quelist" OnSelectedIndexChanged="que_list_SelectedIndexChanged" Width="365px"></asp:ListBox>
        </span>
        
        <div class="v0_200"></div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <span class="v0_201">
                        <asp:Label ID="timeleft" runat="server" Text="Time Left:"></asp:Label>
                    </span>
                    <span class="v0_202">
                        <asp:Label ID="cdtimer" runat="server" Text=""></asp:Label>
                    </span>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID ="duration_timer" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:Timer ID="duration_timer" runat="server" Interval ="1000" OnTick="duration_timer_Tick"></asp:Timer>
        </div>
       
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
