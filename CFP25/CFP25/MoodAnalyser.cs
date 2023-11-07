using System;
using System.Collections.Generic;
using System.Text;

namespace CFP25
{
    public class MoodAnalyserException : ApplicationException
    {
        public override string Message
        {
            get { return "I am not in certain mood"; }

        }
    }     
    public class MoodAnalyser
    {
        public string MoodAnalyserTest1(string message)
        {
            try
            {
                if (message == null)
                {
                    throw new ArgumentNullException("Mood cannot be null");
                }
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else if(message.ToLower().Contains("happy"))
                {
                    return "HAPPY";

                }
                else
                {
                    throw new MoodAnalyserException();
                }
            }
            catch(MoodAnalyserException e)
            {
                return e.Message;

            }
            catch(ArgumentNullException ex)
            {
                return ex.Message;
            }
            

        }
    }
}
