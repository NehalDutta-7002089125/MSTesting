using System;

namespace MoodAnalyse
{
    public class Program
    {
        
        public string Analyse(string mood)
        {
            if (mood.Contains("sad"))
            {
                return "sad";
            }
           
            else
            {
                return "i happy";
            }
            
        }
    }
    public class e
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("enter mood");
            string c = Console.ReadLine();
            Console.WriteLine(a.Analyse(c));
        }
    }
    
}
