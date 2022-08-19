using MoodAnalyzerProblem;

namespace TestMoodAnalyzer
{
    [TestClass]
    public class TestMood
    {
        [TestMethod]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnReturnEmpty()
        {
            try
            {
                AnalyzeMood analyzer = new AnalyzeMood("");
                string actual = analyzer.MoodAnalyze();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }
        }
        [TestMethod]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnReturnNull()
        {
            try
            {
                AnalyzeMood analyzer = new AnalyzeMood(null);
                string actual = analyzer.MoodAnalyze();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is Null");
            }
        }
        [TestMethod]
        public void GivenAnalyzeMoodClassName_ShouldReturnMoodAnalyzeObject()
        {
            object expected = new AnalyzeMood();
            object obj = MoodAnalyzerFactory.CreateAnalyzeMood("MoodAnalyzerProblem.AnalyzeMood", "AnalyzeMood");
            expected.Equals(obj);
        }
        [TestMethod]
        public void GivenAnalyzeMoodClassName_ShouldReturnMoodAnalyzeObject_UsingParameterizedConstrctor()
        {
            object expected = new AnalyzeMood("HAPPY");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyzeUsingParameterizedConstrctor("MoodAnalyzerProblem.AnalyzeMood", "AnalyzeMood", "HAPPY");
            expected.Equals(obj);
        }
    }

}
