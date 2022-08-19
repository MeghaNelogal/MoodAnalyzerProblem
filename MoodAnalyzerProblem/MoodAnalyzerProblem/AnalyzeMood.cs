using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class AnalyzeMood
    {
        string message;

        public AnalyzeMood()
        {
        }

        public AnalyzeMood(string message)
        {
            this.message = message;
        }
        public string MoodAnalyze()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
                return message;
            }
            catch (Exception)
            {
                return "Happy";
            }
        }
    }
}
       
