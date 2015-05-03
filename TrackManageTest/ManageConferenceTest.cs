using TrackManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TrackManageTest
{
    
    
    /// <summary>
    ///This is a test class for ManageConferenceTest and is intended
    ///to contain all ManageConferenceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ManageConferenceTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ManageConference Constructor
        ///</summary>
        [TestMethod()]
        public void ManageConferenceConstructorTest()
        {
            ManageConference target = new ManageConference();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for AddFilePath
        ///</summary>
        [TestMethod()]
        public void AddFilePathTest()
        {
            ManageConference target = new ManageConference(); // TODO: Initialize to an appropriate value
            string strpath = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AddFilePath(strpath);
            Assert.AreNotEqual("OK",actual);
        }

        /// <summary>
        ///A test for AddFilePath
        ///</summary>
        [TestMethod()]
        public void AddFilePathTest_Valid()
        {
            ManageConference target = new ManageConference(); // TODO: Initialize to an appropriate value
            string strpath = @"C:\Users\Zombie\Desktop\input.txt"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AddFilePath(strpath);
            Assert.AreEqual("OK", actual);
        }
        
    }
}
