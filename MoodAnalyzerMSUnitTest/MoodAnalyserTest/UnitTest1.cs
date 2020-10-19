 using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerMSUnitTest;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyse(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzerMSUnitTest.MoodAnalyse", "MoodAnalyse");
            //expected.Equals(obj);
            Assert.AreEqual(expected.GetType(), obj.GetType());

        }

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyse("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerMSUnitTest.MoodAnalyse", "MoodAnalyse", "SAD");
            expected.Equals(obj);
        }
    }
}
