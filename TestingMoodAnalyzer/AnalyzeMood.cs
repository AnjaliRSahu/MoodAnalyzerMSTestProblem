using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMoodAnalyzer
{
    public class AnalyzeMood
    {
        public string message;

        public AnalyzeMood(string message)
        {
            this.message = message;
        }

        public string Mood()
        {
            message = message.ToLower();
            if (message.Contains("happy"))
                return "happy";
            else
                return "sad";
        }
        public string Mood1()
        {
            message = message.ToLower();
            if (message.Contains("any mood"))
                return "HAPPY";
            else
                return "sad";
        }
        public string Mood2()
        {
            message = message.ToLower();
            if (message.Contains("happy mood"))
                return "SAD";
            else
                return "happy";
        }

    }
}
