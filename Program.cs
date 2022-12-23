using System;

namespace TC_uc_2
{
    public class Program
    {
      
            static void Main(string[] args)
        {
            Console.WriteLine("enter mood");
            string c = Console.ReadLine();
            
            mood a = new mood(c);
           
          
             Console.WriteLine(a.analyse());
        }
    }
}
