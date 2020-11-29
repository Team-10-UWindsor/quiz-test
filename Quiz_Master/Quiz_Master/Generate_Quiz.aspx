<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Generate_Quiz.aspx.cs" Inherits="Quiz_Master.Generate_Quiz" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="generate_quiz.css" rel="stylesheet" />
    <title>Document</title>
</head>
<body>
    <form runat="server">

    
    <div class="v4569_196">
        <div class="v4569_197">
            <div class="v4569_198"></div>
            <div class="v4569_199"></div>
        </div>
        <span class="v4569_200">QUIZ</span>
        <div class="v4569_211">
            <div class="v4569_212"></div>
            <span class="v4569_213">Enter</span>
        </div>
        <span class="v4569_214">Employee Name</span>
        <span class="v4569_215">Employee ID</span>
        <label class="v4569_216" for="emp_name" id="emp_name">Iron Man</label>
        <label class="v4569_217" for="emp_id" id="emp_id">EMP012345</label> 
        <div class="v4569_218">
            <div class="v4569_219">
                <div class="v4569_220"></div>
                <asp:Button ID="next" runat="server" class="v4569_221" Text="Next" />
                 
            </div></div>
        <div class="v4569_222">
            <div class="v4569_223">
                <div class="v4569_224"></div>
                 
                <asp:Button ID="prev" runat="server" class="v4569_225" Text="Previous" />
            </div></div>
        <div class="v4569_226">
            <div class="v4569_227">
                <div class="v4569_228"></div>
                <asp:Button ID="done" runat="server" class="v4569_229" Text="Done" />
                 
            </div></div>
        <div class="v4569_234">
            <div class="v4569_235"></div>
            <div class="name"></div>
            <asp:TextBox ID="question" runat="server" class="v4569_237" name="enter_question" placeholder="Enter question"></asp:TextBox>
            
        </div>
        <div class="v4569_349">
            <div class="v4569_350"></div>
            <div class="name"></div>
            <asp:TextBox ID="ansoption" class="v4569_352" runat="server" name="enter_answer_option" placeholder="Enter Answer Option"></asp:TextBox>
            
        </div>
        <div class="v4569_238">
            <div class="v4569_239"></div>
            <div class="name"></div>
            <asp:TextBox ID="option2" runat="server" class="v4569_241" name="enter_option2" placeholder="Enter option 2"></asp:TextBox>
            
        </div>
        <div class="v4569_242">
            <div class="v4569_243"></div>
            <div class="name"></div>
            <asp:TextBox ID="option1" runat="server" class="v4569_245" name="enter_option1" placeholder="Enter option 1"></asp:TextBox>
            
        </div>
        <div class="v4569_246">
            <div class="v4569_247"></div>
            <div class="name"></div>
            <asp:TextBox ID="enter_option3" runat="server" class="v4569_249" name="enter_option3" placeholder="Enter option 3"></asp:TextBox>
           
        </div>
        <div class="v4569_250">
            <div class="v4569_251"></div>
            <div class="name"></div>
            <asp:TextBox ID="option4" class="v4569_253" runat="server" name="enter_option4" placeholder="Enter option 4"></asp:TextBox>
            

        </div>
        <span class="v4569_257">Empoyee details</span>
        <div class="name"></div>
        <span class="v4569_262">Quiz ID:</span>
         <label class="v4569_263" for="emp_id" id="quiz_id">02345</label> 
        <div class="v4569_264"></div>
    </div>
        </form>
</body>
</html>