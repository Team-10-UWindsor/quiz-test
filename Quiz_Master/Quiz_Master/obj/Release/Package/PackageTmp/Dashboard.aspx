<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Quiz_Master.Dashboard" %>


<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="dashboard.css" rel="stylesheet" />
    <title>Dashboard</title>
    
</head>
<body>
    <div class="v4505_231" >
    <form runat="server">
            
        <div class="v4505_232">
            <div class="v4505_233"></div>
            <div class="v4505_234"></div>
        </div>
        <span class="v4505_235">QUIZ</span>
        <div class="v4505_246">
            <div class="v4505_247"></div>
        </div>
        <span class="v4505_249">Employee Name</span>
        <span class="v4505_250">Employee ID</span>
        
                <asp:Label ID="emp_name" class="v4505_251" runat="server" Text="Employee_Name"></asp:Label>
            <asp:Label ID="emp_id" class="v4505_252" runat="server" Text="Employee_ID"></asp:Label>
        
        <div class="v4505_253">
            <div class="v4505_257">
                <div class="v4505_258"></div>
                <asp:Button ID="next" runat="server" Text="Next" class="v4505_259" OnClick="next_Click" />
                
            </div></div>
        <span class="v4505_260">Empoyee details</span>
        <div class="name"></div>
        <!--
            <div class="v4505_384">
 <span class="v4505_269">View Report</span>
 <div class="v4505_379"><div class="v4505_380"></div>
 </div></div>
            -->
        <div class="v4505_384">
            <div class="v4505_379">
            <asp:RadioButton ID="report" GroupName="dashboard" runat="server"  />
            </div>
            <label class="v4505_269" for="view_report">View Report</label><br>       
            </div>
            <div class="v4505_387">
            <asp:RadioButton ID="quiz" GroupName="dashboard" runat="server" />
            </div>
            <label class="v4505_386" for="generate_quiz">Generate Quiz</label><br>
        <div class="name"></div>
        <div class="name"></div>        
        <div class="v4505_726"></div>        
        <!--
            <span class="v4505_386">Generate Quiz</span>
 <span class="v4505_401">Create New Quiz</span>
 <span class="v4505_402">Fetch Previous Quiz</span><div class="name"></div>
 <div class="name"></div><div class="v4505_387"><div class="v4505_388"></div></div>
 <div class="v4505_726"></div><div class="v4505_727"></div></div>
            -->
   
    </form>
     </div>
</body>
</html>