<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="Quiz_Master.Reports" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
      <link href="https://fonts.googleapis.com/css?family=Rosario&display=swap" rel="stylesheet" />
      <link href="https://fonts.googleapis.com/css?family=Arial&display=swap" rel="stylesheet" />
      <link href="reports.css" rel="stylesheet" />
      <title>Reports</title>
</head>
<body>
       <div class="v4505_657">
    <form runat="server">
   
              <div class="v4505_658">
                  <div class="v4505_659"></div>
                  <div class="v4505_660"></div>
              </div>
              <span class="v4505_661">QUIZ</span>
              <div class="v4505_672">
                  <div class="v4505_673"></div>
                  
              </div>
              <span class="v4505_675">Employee Name</span>
              <span class="v4505_676">Employee ID</span>

          <asp:Label ID="emp_name" class="v4505_677" runat="server" Text="Employee_Name"></asp:Label>
            <asp:Label ID="emp_id" class="v4505_678" runat="server" Text="Employee_ID"></asp:Label>
           

              <div class="v4505_679">
                  <div class="v4505_680">
                      <div class="v4505_681"></div>
                      <asp:Button ID="done" runat="server" class="v4505_682" Text="Done" OnClick="done_Click" />
                                        
                   </div></div>
              <span class="v4505_689">Empoyee details</span>
              <div class="name"></div>
              <span class="v4505_694">Reports</span>
              <div class="v4505_720">

                  <!--
                  <span class="v4505_702">Name 1</span>
                  <span class="v4505_706">Name 2</span>
                  <span class="v4505_710">Name 3</span>
                  <span class="v4505_714">Name 4</span>
                  <span class="v4505_718">Name 5</span>
                  <span class="v4505_705">Score 1</span>
                  <span class="v4505_707">Score 2</span>
                  <span class="v4505_711">Score 3</span>
                  <span class="v4505_715">Score 4</span>
                  <span class="v4505_719">Score 5</span>
                  -->
                  

                  <div class="v4505_698">  
                      <table>
                      <tr class="v4505_697">
                          <th class="v4505_700">Participant Name</th>
                          <th class="v4505_701">Score</th>
                      </tr> 
                      </table>
                      <div class="v4505_702"> 
                          <table>
                              <asp:Repeater ID="Repeater_1" runat="server">
                                  <ItemTemplate>
                                      <tr>
                                          <td><%#Eval("Participant_Name")%></td>
                                      </tr>
                                  </ItemTemplate>
                     </asp:Repeater> 
                           </table>
                              </div>
                      <div class="v4505_705"> 
                          <table>
                              <asp:Repeater ID="Repeater_2" runat="server">
                                  <ItemTemplate>
                                      <tr>
                                          <td><%#Eval("Percentage")%></td>
                                      </tr>
                                  </ItemTemplate>
                     </asp:Repeater> 
                           </table>
                              </div>
                      </div>

                  <!--
                  <div class="v4505_697"></div>         
                 
                  -->
                  </div>
              <div class="v4505_722"></div>
        </form>  
        </div>
        
</body>
</html>

