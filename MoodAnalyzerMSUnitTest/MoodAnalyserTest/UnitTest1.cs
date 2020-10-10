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
        public void Given_EMPTY_Mood_Should_Throw_MoodAnalyzerCustomException() 
        {
            try
            {
                string message ="";
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.MoodAnalyser();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }

        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalyzerCustomException()
        {
            try
            {
                string message = null;
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.MoodAnalyser();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

    }
}
