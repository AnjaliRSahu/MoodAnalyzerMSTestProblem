using TestingMoodAnalyzer;
namespace TestMOODAnalyzerProblemFull
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMsgReturnHappy()
        {
            //Arrange
            string msg = "I'm Happy";
            string expected = "happy";
            //Act
            AnalyzeMood analyzeMood = new AnalyzeMood(msg);
            var actual = analyzeMood.Mood();

            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void GivenMsgReturnSad()
        {
            //Arrange
            string msg = "I'm sad";
            string expected = "sad";
            //Act
            AnalyzeMood analyzeMood1 = new AnalyzeMood(msg);
            var actual = analyzeMood1.Mood();

            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void AnyMood()
        {
            //Arrange
            string msg = "I'm in any Mood";
            string expected = "HAPPY";
            //Act
            AnalyzeMood analyzeMood = new AnalyzeMood(msg);
            var actual = analyzeMood.Mood1();
            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void HappyMoodReturnSad()
        {
            //Arrange
            string msg = "I'm in Happy Mood";
            string expected = "SAD";
            //Act
            AnalyzeMood analyzeMood2 = new AnalyzeMood(msg);
            var actual = analyzeMood2.Mood2();
            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }

    }
}