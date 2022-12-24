using System;

namespace Factor_TC
{
    public class Program
    {
        string mood;
        

        public Program(string mood)
        {
            this.mood = mood;
            
        }

        public string Analyse()
        {
            if (mood.Contains("sad"))
            {
                return "i am sad";
            }
          
            else
            {
                return "Happy";
            }
        }
        
        static void Main(string[] args)
        {
            Program a = new Program("sad");
           

            Console.WriteLine("enter mood");
            string c= Console.ReadLine();
            Console.WriteLine(a.Analyse());
           


        }
    }
}
