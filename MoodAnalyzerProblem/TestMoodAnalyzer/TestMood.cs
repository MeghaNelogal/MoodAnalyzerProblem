using MoodAnalyzerProblem;

namespace TestMoodAnalyzer
{
    [TestClass]
    public class TestMood
    {
        [TestMethod]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnReturnSad()
        {
            AnalyzeMood analyzer = new AnalyzeMood("I am in Sad Mood");
            string actual = analyzer.MoodAnalyze();
            Assert.AreEqual(actual, "Sad");
        }
        [TestMethod]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnReturnHappy()
        {
            AnalyzeMood analyzer = new AnalyzeMood(null);
            string actual = analyzer.MoodAnalyze();
            Assert.AreEqual(actual, "Happy");
        }
    }

}
