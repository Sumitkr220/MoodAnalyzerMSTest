using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerMSUnitTest;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "HAPPY";
            string message = "This is happy hour";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            
            string mood = moodAnalyse.MoodAnalyser(message);

            Assert.AreEqual(expected,mood);   
        }
    }
}
