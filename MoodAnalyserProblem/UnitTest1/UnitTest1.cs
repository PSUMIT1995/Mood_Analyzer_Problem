using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// TC 1.1 Given �I am in Sad Mood� message
        // Should Return SAD
        /// </summary>
        [TestMethod]
        public void ReturnSadTest()
        {
            ///AAA Methodology
            //assign
            string expected = "sad";
            string message = "I am in SadMood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //act
            string actual = moodAnalyser.AnalyseMood();
            //assert
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// TC 1.2 Given �I am in any mood� message
        // Should Return happy
        /// </summary>
        [TestMethod]
        public void ReturnHappyTest()
        {
            //assign
            string expected = "happy";
            string message = "I am in Any mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //act
            string actual = moodAnalyser.AnalyseMood();
            //assert
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// TC 2.1 Nulls reference test.
        /// </summary>
        [TestMethod]
        public void GivenNullShouldReturnHappy()
        {
            ///AAA Methodology
            //assign
            string expected = "happy";

            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            //act
            string actual = moodAnalyser.AnalyseMood();
            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}