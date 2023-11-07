using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CFP25;
using System.Runtime.CompilerServices;

namespace CFP25TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            User z = new User();
            string firstname = "Hello";
            string secondname = "World";
            string expected = "Hello World";

            //Act

            string actual = z.Test1(firstname, secondname);
            //Assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            User z = new User();
            string firstname = "Good";
            string secondname = "Morning";
            string expected = "Good Morning";

            //Act
            string actual = z.Test1(firstname, secondname);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MoodAnalyserSadorhappy1()
        {
            //Arrange
            MoodAnalyser a = new MoodAnalyser();
            String message = "I am Happy Today";
            string Expected = "HAPPY";

            //Act
            string actual = a.MoodAnalyserTest1(message);

            //Assert
            Assert.AreEqual(Expected, actual);

        }
        [TestMethod]
        public void MoodAnalyserSadorhappy2()
        {
            //Arrange
            MoodAnalyser a = new MoodAnalyser();
            String message = "I am sad Today";
            string Expected = "SAD";

            //Act
            string actual = a.MoodAnalyserTest1(message);

            //Assert
            Assert.AreEqual(Expected, actual);

        }
        [TestMethod]
        public void MoodAnalyserSadorhappy3()
        {
            //Arrange
            MoodAnalyser a = new MoodAnalyser();
            String message = "I am Angry Today";
            string Expected = "I am not in certain mood";

            //Act
            string actual = a.MoodAnalyserTest1(message);

            //Assert
            Assert.AreEqual(Expected, actual);

        }
        [TestMethod]
        public void MoodAnalyserSadorhappy4()
        {
            try
            { //Arrange
                MoodAnalyser a = new MoodAnalyser();
                String message = null;
                string actual = a.MoodAnalyserTest1(message);

                //Act
            }
            catch (MoodAnalyserException e)
            {
                //Assert
                Assert.AreEqual("Mood cannot be null", e.Message);
            }

        }

        [TestMethod]
        public void Checkstring()
        {
            //Arrange
            try
            {
                TestString y = new TestString();
                string x = null;


                //Act
                string actual = y.Test1(x);
            }
            catch (ArgumentNullException ex)
            {

                //Assert
                Assert.AreEqual("value cannot be null", ex.Message);
            }

        }
        [TestMethod]
        public void Checkstring1()
        {
            //Arrange
            TestString y = new TestString();
            string x = "_";
            string expected = "_";

            //Act
            string actual = y.Test1(x);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MoodAnalyserSadorhappy6()
        {
            //Arrange
            try
            {
                MoodAnalyser a = new MoodAnalyser();
                String message = " ";


                //Act
                string actual = a.MoodAnalyserTest1(message);
            }
            catch (ArgumentNullException a)
            {

                //Assert
                Assert.AreEqual("I am not in certain mood",a.Message);
            }

        }


    }
}
