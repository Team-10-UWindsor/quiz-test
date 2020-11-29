<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Generate_Quiz.aspx.cs" Inherits="Quiz_Master.QuizCreate" %>

<!DOCTYPE html>
<script runat="server">


</script>

<html>
<head>
    <meta charset="utf-8" />
    <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="generate_quiz.css" rel="stylesheet" />
    <title>Document</title>
</head>
<body>
    <form runat="server" method="get">


<div class="v4505_424">
    <div class="v4505_425">
        <div class="v4505_426"></div>
        <div class="v4505_427"></div>
    </div>
    <span class="v4505_428">QUIZ</span>
    <div class="v4505_439">
        <div class="v4505_440"></div>
    </div>
    <span class="v4505_442">Employee Name</span>
    <span class="v4505_443">Employee ID</span>
    <label class="v4505_444" for="emp_name" id="emp_name">Iron Man</label>
    <label class="v4505_445" for="emp_id" id="emp_id">EMP012345</label>  

    <div class="v4505_446"><div class="v4505_447">
        <div class="v4505_448"></div>
        <asp:Button ID="next" runat="server" class="v4505_449" Text="Next" OnClick="next_Click" />
        
        </div></div>
    <div class="v4505_497">
        <div class="v4505_498">
            <div class="v4505_499"></div>
            <asp:Button ID="prev" runat="server" Text="Previous" class="v4505_500" />
            
        </div></div>
    <div class="v4505_501">
        <div class="v4505_502">
            <div class="v4505_503"></div>
            <asp:Button ID="done" class="v4505_500" runat="server" Text="Done" OnClick="done_Click" />
            
        </div></div>
    <div class="v4505_487">
        <div class="v4505_488">
            <div class="v4505_489"></div>
            <asp:Button ID="new_ques" runat="server" class="v4505_490" Text="Enter New Question" />
            
            </div></div>
    <div class="v4505_505">
        <div class="v4505_506"></div>
        <div class="name"></div>
        <asp:TextBox ID="question" class="v4505_508" runat="server" placeholder="Enter Question" name="enterquestion"></asp:TextBox>
        
        
        </div>
    <div class="v4505_514">
        <div class="v4505_515"></div>
        <div class="name"></div>
        <asp:TextBox ID="enteroption1" class="v4505_517" runat="server" placeholder="Enter Option 1" name="enteroption1"></asp:TextBox>
        
        </div>
    
    <div class="v4505_510">
        <div class="v4505_511"></div>
        <div class="name"></div>
        <asp:TextBox ID="enteroption2"  class="v4505_513" runat="server" placeholder="Enter Option 2" name="enteroption2"></asp:TextBox>
        
    </div>



    <div class="v4505_518">
        <div class="v4505_519"></div>
        <div class="name"></div>
        <asp:TextBox ID="enteroption3" class="v4505_521" runat="server" placeholder="Enter Option 3" name="enteroption3"></asp:TextBox>
        
    </div>
    <div class="v4505_522">
        <div class="v4505_523"></div>
        <div class="name"></div>
        <asp:TextBox ID="enteroption4" class="v4505_525" runat="server" placeholder="Enter Option 4" name="enteroption4"></asp:TextBox>
        
    </div>

    </div>
    <div class="v4505_522">
        <div class="v4505_523"></div>
        <div class="name"></div>
        <asp:TextBox ID="entersolution" class="v4505_525" runat="server" placeholder="Enter Solution" name="entersolution"></asp:TextBox>
        
    </div>



    <span class="v4505_450">Empoyee details</span>
    <div class="name"></div>
    <span class="v4505_483">Quiz ID:</span>
    <span class="v4505_486">02345</span>
    <div class="v4505_725"></div>

            </form>
</body>
</html>

