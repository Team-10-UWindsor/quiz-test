<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz_Landing_Page.aspx.cs" Inherits="Quiz_Master.Quiz_Landing_Page" %>

<!DOCTYPE html>
<html>
<head>
    <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="quiz_landing_page.css" rel="stylesheet" />
    <title>Quiz Landing Page</title>
</head>
<body>
<form runat="server">
     <div class="v0_93">
    <div class="v0_94">
        <div class="v0_95"></div>
        <div class="v0_96"></div>
        </div>
    <span class="v0_97">QUIZ</span>
    <div class="v0_108">
        <div class="v0_109"></div>
        <span class="v0_110">Enter</span>
        </div>
    <div class="v0_111">
        <div class="v0_112"></div>
        <div class="name"></div>
        <asp:TextBox ID="emp_name" name="emp_name" placeholder="Enter employee name" class="v0_114" runat="server"></asp:TextBox>
    </div>
    <div class="v0_115">
        <div class="v0_116"></div>
        <div class="name"></div>
        <asp:TextBox ID="emp_id" class="v0_118" name="emp_id" placeholder="Enter employee ID" runat="server"></asp:TextBox>
    </div>
    <div class="v0_119">
        <div class="v0_120"></div>
        <asp:Button ID="submit"  class="v0_121" runat="server" Text="Submit" OnClick="submit_Click" />
    </div>
    <div class="v0_122">
        <div class="v0_123">
        <div class="v0_124"></div>
        <span class="v0_125">Done</span>
            </div>
        <div class="v0_126">
        <div class="v0_127">
            </div>
        <span class="v0_128">Next</span>
            </div>
        </div>
    <span class="v0_129">Enter empoyee details</span>
    <span class="v0_130">Question 1 of 5</span>
    <span class="v0_131">Question 1:</span>
    <span class="v0_132">What will be the compound interest on a sum of Rs. 25,000 after 3 years at the rate of 12 p.c.p.a.?</span>
     <ul>
         <li class="v0_133">What will be the compound interest on a sum of Rs. 25,000 after 3 years at the rate of 12 p.c.p.a.?</li>
         <li class="v0_134">The difference between simple interest and compound on Rs. 1200 for one year at 10% per annum reckoned half-yearly is ?</li>
         <li class="v0_135">At what rate of compound interest per annum will a sum of Rs. 1200 become Rs. 1348.32 in 2 years?</li>
         <li class="v0_136">The compound interest on Rs. 30,000 at 7% per annum is Rs. 4347. The period (in years) is ?</li>
         <li class="v0_137">What is the difference between the compound interests on Rs. 5000 for 1 years at 4% per annum compounded yearly and half-yearly?</li>
     </ul>
        <!-- 
               <span class="v0_133">What will be the compound interest on a sum of Rs. 25,000 after 3 years at the rate of 12 p.c.p.a.?</span>
    <span class="v0_134">The difference between simple interest and compound on Rs. 1200 for one year at 10% per annum reckoned half-yearly is ?</span>
    <span class="v0_135">At what rate of compound interest per annum will a sum of Rs. 1200 become Rs. 1348.32 in 2 years?</span>
    <span class="v0_136">The compound interest on Rs. 30,000 at 7% per annum is Rs. 4347. The period (in years) is ?</span>
    <span class="v0_137">What is the difference between the compound interests on Rs. 5000 for 1 years at 4% per annum compounded yearly and half-yearly?</span>
    -->
    <span class="v0_138">Rs. 9000.30</span>
    <span class="v0_139">Rs. 9720</span>
    <span class="v0_140">Rs. 10123.20</span>
    <div class="v0_141"></div>
    <span class="v0_142">Time</span>
    <span class="v0_143">15:00 mins remaining</span>
    <div class="name"></div>
    <div class="name"></div>
    <div class="name"></div>
    <div class="name"></div>
    <div class="name"></div>
    <span class="v0_149">Rs. 10483.20</span>
    <span class="v0_150">None of these</span>
    <div class="name"></div>
    <div class="name"></div>
   
    <span class="v0_153">1.</span>
    <span class="v0_154">2.</span>
    <span class="v0_155">3.</span>
    <span class="v0_156">4.</span>    
    <span class="v0_157">5.</span>
    <div class="v0_158"></div>
    </div>
</form>
</body>
</html>

