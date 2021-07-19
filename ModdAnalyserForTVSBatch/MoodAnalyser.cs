using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModdAnalyserForTVSBatch
{
    public class MoodAnalyser
    {
        //instance variable
        public string message;

        public MoodAnalyser()
        {
            Console.WriteLine("default constructor");
        }
        //Parametized constructor for intializing instance member 
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        //create Analyse method for analyser mood of the user
        public string AnalyseMood()
        {
            //UC 2
            //Handled exception using try and catch blocks
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
              
                    if (message.ToLower().Contains("happy"))
                    {
                        return "happy";
                    }
                    else
                    {
                        return "sad";
                    }
            }
           
            catch (NullReferenceException ex)
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }
          
        }
    }
}
