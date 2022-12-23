using System;
using System.Collections.Generic;
using System.Text;

namespace TC_uc_2
{
    public class mood
    {
        string Message;
        public mood(string message)
        {
            this.Message = message;
        }
        public string analyse()
        {



            if (Message.Contains("sad"))
            {
                return "sad";
            }

            else
            {
                return "happy";
            }


        }

        //public string AnalyseMethodInvalidInput()
        //{
        //    try
        //    {
        //        if (Message.Contains("sad"))
        //        {
        //            return "sad";
        //        }
        //        else
        //        {
        //            return "happy";
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return "Happy";
        //    }
        //}
    }
}
