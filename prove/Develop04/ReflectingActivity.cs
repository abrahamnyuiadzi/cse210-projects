public class ReflectingActivity{

    int _time;

      public  String DisplayMessage()
    {

  return "welcome to Reflecting Activity  thsi activity will help you relax ";

    }
      public  void GetTime()
    {

 Console.Write(" how long in second do you like for your session ? : ");
 Console.ReadLine();

 //for (int i =5 ;i> 0;i--){
// Console.Write(5);
 //Thread.Sleep(1000);
// }

List<String> animationStrings =new List<String>();
animationStrings.Add("|") ;
animationStrings.Add("/") ;
animationStrings.Add("-") ;
animationStrings.Add("/") ;
animationStrings.Add("\\") ;
//foreach(string s in animationStrings)
//{
 // Console.WriteLine(s);
 // Thread.Sleep(1000);
 // Console.Write("\b \b");
//}
DateTime  startTime = DateTime.Now;
DateTime  endTime = startTime.AddSeconds(30);

int i = 0;
while(DateTime.Now < endTime) 
{
  String s =animationStrings[i];
Console.WriteLine(s);
  Thread.Sleep(1000);
  Console.Write("\b \b");

  i++;
  if(i >= animationStrings.Count) 
  {
 i= 0;
  }
}

Console.WriteLine("breath in ");

  for (int i =5 ;i> 0;i--){
 Console.Write(5);
 Thread.Sleep(1000);
 Console.WriteLine(" Now breath out ");
 }


 Console.WriteLine("Done");
 
    }

}