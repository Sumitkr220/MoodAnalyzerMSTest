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
            
            string mood = moodAnalyse.MoodAnalyser();

            Assert.AreEqual(expected,mood);   
        }

        [TestMethod]
        public void TestMethod2()
        {
            string expected = "HAPPY";
            MoodAnalyse moodAnalyse = new MoodAnalyse(null);

            string mood = moodAnalyse.MoodAnalyser();

            Assert.AreEqual(expected, mood);
        }
    }
}
