using System;

class Program
{
    static void Main(string[] args)
    {
        // Create menu and user input variables 
        Journal   journalGS = new Journal ();
        int          menuUserinput =0;

       List<string>  menu =new List<string> 
       {
          "please select ",

          "1. write ",
          "2. Display",
          "3. Load ",
          "4.Save ",
          "5. quit ",
       " what do you to do ?"

       };

       while (menuUserinput!= 5)
       {
        foreach(string menuItem in menu ){
            Console.WriteLine(menuItem);
            
        }

        menuUserinput =int.Parse(Console.ReadLine());
       }

       //while user input is not 5


       //stwitch statement for the user .
    }
}