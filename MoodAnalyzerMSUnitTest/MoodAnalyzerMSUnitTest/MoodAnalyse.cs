using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerMSUnitTest
{
    public class MoodAnalyse
    {
        private string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string MoodAnalyser()
        {
            try
            {
                if (this.message.Contains("happy"))
                {
                    return "HAPPY";
                }
                else
                {
                    return "SAD";
                }
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
