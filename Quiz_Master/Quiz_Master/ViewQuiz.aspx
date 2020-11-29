<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewQuiz.aspx.cs" Inherits="Quiz_Master.ViewQuiz" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
     <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
    <link href="view_quizes.css" rel="stylesheet" />
    <title>View Quizes</title>
    </head>
<body>
    <form runat="server">
 <div class="v4505_608">
        <div class="v4505_609">
            <div class="v4505_610"></div>
            <div class="v4505_611"></div>
        </div>
        <span class="v4505_612">QUIZ</span>
        <div class="v4505_623"><div class="v4505_624"></div>
            </div>
        <span class="v4505_626">Employee Name</span>
        <span class="v4505_627">Employee ID</span>
        <label class="v4505_628" for="emp_name" id="emp_name">Iron Man</label>
        <label class="v4505_629" for="emp_id" id="emp_id">EMP012345</label>
        <div class="v4505_630">
            <div class="v4505_631">
                <div class="v4505_632"></div>
                <asp:Button ID="dashboard" runat="server" class="v4505_633" Text="Dashboard" />
                
             </div></div>
      <!--
            <ul v4505_638 id="list">
          </ul>
         

        <span class="v4505_638">Quiz 1</span>
        <span class="v4505_639">Quiz 3</span>
        <span class="v4505_640">Quiz 5</span>
        <span class="v4505_641">Quiz 2</span>
        <span class="v4505_642">Quiz 4</span>
        <span class="v4505_643">Quiz 6</span>
     -->

     
    
        <span class="v4505_644">Empoyee details</span>
        <div class="name"></div>
        <span class="v4505_650">All Quizes</span>
        <div class="v4505_731"></div>
        </div>

 <div class="v4505_638">
         <table>
          <asp:Repeater ID="Repeater_2" runat="server">
                          <ItemTemplate>
                              <table>
                                  <tr>
                                       <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='View_Ques.aspx?Quiz_Id='><%#Eval("Quiz_Name")%></asp:HyperLink></td>
                                      
                                      
                                      
                                  </tr>
                               </table>
                            </ItemTemplate>
        </asp:Repeater>  
     </table>
 </div>

</form>
</body>
</html>
 