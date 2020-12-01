<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generate_Quiz.aspx.cs" Inherits="Quiz_Master.Generate_Quiz" %>

<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="generate_quiz.css" rel="stylesheet" />
    <title>QUIZ</title>
</head>

<body>
    
<div class="v4505_424">
    <form runat="server">


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
        <asp:Label ID="emp_name" class="v4505_444" runat="server" Text="emp_name"></asp:Label>
        <asp:Label ID="emp_id" class="v4505_445" runat="server" Text="Emp_id"></asp:Label>
    
    

    <div class="v4505_446"><div class="v4505_447">
        <div class="v4505_448"></div>
        <asp:Button ID="next" runat="server" class="v4505_449" Text="Next" OnClick="next_Click" />
        
        </div></div>
    <div class="v4505_497">
        <div class="v4505_498">
            <div class="v4505_499"></div>
            <asp:Button ID="prev" runat="server" Text="Previous" class="v4505_500" OnClick="prev_Click" />
            
        </div></div>
    <div class="v4505_501">
        <div class="v4505_502">
            <div class="v4505_503"></div>
            <asp:Button ID="done" class="v4505_500" runat="server" Text="Done" OnClick="done_Click" OnClientClick="return confirm('Changes cannot be undone after this point. Are you sure you want to continue to publish?');" />
            
        </div>
    </div>
    <div class="v4505_505l">
        <asp:Label ID="que_no" runat="server" Text="1" Font-Bold="True" Font-Size="X-Large" ForeColor="#333333"></asp:Label>
    </div>
    <div class="v4505_505">
        <div class="v4505_506"></div>
        <div class="name"></div>
        <asp:TextBox ID="question" class="v4505_508" runat="server" placeholder="Enter Question" name="enterquestion" TextMode="MultiLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="QuestionValidator" runat="server" ErrorMessage="Please Enter The Question" ControlToValidate="question"></asp:RequiredFieldValidator>
        
    </div>

    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <div class="v4505_510b">
                <asp:RadioButton ID="rdA" GroupName="Solution" Text="" runat="server" />
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div class="v4505_510">
                <div class="v4505_511"></div>
                <div class="name"></div>
                <asp:TextBox ID="optionA"  class="v4505_513" runat="server" placeholder="Enter Option A" name="enteroption1" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="optionAValidator" runat="server" ErrorMessage="Enter Option A" ControlToValidate="optionA"></asp:RequiredFieldValidator>
                </div>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <div class="v4505_514b">
                <asp:RadioButton ID="rdB" GroupName="Solution" Text="" runat="server" />
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div class="v4505_514">
                <div class="v4505_515"></div>
                <div class="name"></div>
                <asp:TextBox ID="optionB" class="v4505_517" runat="server" placeholder="Enter Option B" name="enteroption2" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="optionBValidator" runat="server" ErrorMessage="Enter Option B" ControlToValidate="optionB"></asp:RequiredFieldValidator>
                </div>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <div class="v4505_518b">
                <asp:RadioButton ID="rdC" GroupName="Solution" runat="server" />
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div class="v4505_518">
                <div class="v4505_519"></div>
                <div class="name"></div>
                <asp:TextBox ID="optionC" class="v4505_521" runat="server" placeholder="Enter Option C" name="enteroption3" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="optionCValidator" runat="server" ErrorMessage="Enter Option C" ControlToValidate="optionC"></asp:RequiredFieldValidator>
                </div>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <div class="v4505_522b">
                <asp:RadioButton ID="rdD" GroupName="Solution" runat="server" />
                </div>
            </asp:TableCell>
            <asp:TableCell>
                <div class="v4505_522">
                <div class="v4505_523"></div>
                <div class="name"></div>
                <asp:TextBox ID="optionD" class="v4505_525" runat="server" placeholder="Enter Option D" name="enteroption5" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="optionDValidator" runat="server" ErrorMessage="Enter Option D" ControlToValidate="optionD"></asp:RequiredFieldValidator>
                </div>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    
            <span class="v4505_450">Empoyee details</span>
    <div class="name"></div>
    <span class="v4505_483">Quiz:</span>
        <asp:Label ID="Quiz_Name"  class="v4505_486" runat="server" Text="Quiz_Name"></asp:Label>
    
    <div class="v4505_725"></div>
            </form>
    </div>
</body>
</html>

