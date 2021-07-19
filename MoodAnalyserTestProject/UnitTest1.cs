using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModdAnalyserForTVSBatch;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyser moodAnalyser;
        /// <summary>
        /// TC1 GivenMessageShouldReturnMood
        /// </summary>
        [TestMethod]
        [TestCategory("Haapy")]
        public void GivenMessageShouldReturnHappy()
        {
            //AAA methodlogy
           
                moodAnalyser = new MoodAnalyser("I am in happy mood");
                //Act
                string actual = moodAnalyser.AnalyseMood();
                    
        }
        [TestMethod]
        [TestCategory("Sad")]
        public void GivenMessageShouldReturnSad()
        {
            //AAA methodlogy
            string expected = "sad";
          moodAnalyser = new MoodAnalyser("Iam in sad Mood");
            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2.1
        /// </summary>
        [TestMethod]
        [TestCategory("Sad")]
        public void GivenNullShouldReturnHappy()
        {
            //AAA methodlogy
            string expected = "happy";
            moodAnalyser = new MoodAnalyser(null);
            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2.1
        /// </summary>
        [TestMethod]
   
        public void GivenEmptyShouldReturnEmptyException()
        {
            //AAA methodlogy
            string expected = "Mood should not be empty";
            try
            {
                moodAnalyser = new MoodAnalyser("");
                //Act
                moodAnalyser.AnalyseMood();
            }
           catch(CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            } 
        }
        //Mood should not be null
        [TestMethod]

        public void GivenNullShouldReturnNullException()
        {
            //AAA methodlogy
            string expected = "Mood should not be null";
            try
            {
                moodAnalyser = new MoodAnalyser(null);
                //Act
                moodAnalyser.AnalyseMood();
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        /// <summary>
        /// UC 4- create default constructor using reflection
        /// </summary>
        [TestMethod]
        public void Given_MoodAnalyser_Using_Reflection_Return_defaultConstuctor()
        {
            MoodAnalyser expected = new MoodAnalyser();
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                //Act
                obj = factory.CreateMoodAnalyserObject("ModdAnalyserForTVSBatch.MoodAnalyser", "MoodAnalyser");
            }
            catch (CustomMoodAnalyserException execption)
            {
                //Assert
                throw new Exception(execption.Message);

            }
            obj.Equals(expected);
        }

        [TestMethod]
        public void Given_MoodAnalyser_Using_Reflection_Return_ParameterizedConstuctor()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                //Act
                actual = factory.CreateMoodAnalyserParameterizedObject("MoodAnalyser", "MoodAnalyser", message);
            }
            catch (CustomMoodAnalyserException execption)
            {
                //Assert
                throw new Exception(execption.Message);

            }
            actual.Equals(expected);
        }

        [TestMethod]
        public void Given_MoodAnalyser_Using_Reflection_Return_Method()
        {
            string message = "I am in sad mood";
            string methodName = "AnalyseMood";
            string expected = "sad";
           string actual = "";
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                //Act
                actual = factory.InvokeAnalyserMethod(message,methodName);
            }
            catch (CustomMoodAnalyserException execption)
            {
                //Assert
                throw new Exception(execption.Message);

            }
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Given_MoodAnalyser_Using_Reflection_Set_Field()
        {
            string msg = "I am in sad mood";
            string methodName = "message";
            string expected = "I am in sad mood";
            string actual = "";
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                //Act
                actual = factory.SetField(msg, methodName);
            }
            catch (CustomMoodAnalyserException execption)
            {
                //Assert
                throw new Exception(execption.Message);

            }
            Assert.AreEqual(expected, actual);
        }
    }
}
