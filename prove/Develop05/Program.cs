using System;

class Program
{
 
    int choice;
    static void Main(string[] args)
    {
          
        Console.WriteLine(@"what is your choose between 1-5);
        .......1.create a new goal
        ........2.Lists Goals
        ........3.Save goals 
        ........4 Load goals
                ........5.record event 
        ........6 Exit 
        ");

        System.Console.WriteLine("what is your choice ");
        String userInput =Console.ReadLine();

          
           
         

       

          if (userInput == "1") {


           

          }
     else if (userInput=="2"){
     }
     else if (userInput=="3"){
      
     }
     
     
      else if (userInput=="4"){
      
     }
      else if (userInput=="5"){
      
     }
     
      else if (userInput=="6){
      System.Environment.Exit (1);
     }
      else{
      System.Console.writeLine("Invalid input please enter 1-5");
     }
     
    
    }
  
}
