using TrackManagement.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrackManagement.ModelInterface;
using TrackManagement.Model;

namespace TrackManageTest
{
    
    
    /// <summary>
    ///This is a test class for ParsingHelperTest and is intended
    ///to contain all ParsingHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ParsingHelperTest
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
        ///A test for GetSession
        ///</summary>
        [TestMethod()]
        public void GetSessionTest_Empty()
        {
            string sessioninfo = string.Empty; // TODO: Initialize to an appropriate value
            ISessions expected = null; // TODO: Initialize to an appropriate value
            ISessions actual;
            actual = ParsingHelper.GetSession(sessioninfo);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetSession
        ///</summary>
        [TestMethod()]
        public void GetSessionTest_Valid()
        {
            string sessioninfo = "Writing Fast Tests Against Enterprise Rails 30min"; // TODO: Initialize to an appropriate value
            ISessions actual;
            actual = ParsingHelper.GetSession(sessioninfo);
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.GetSessionName(), "Writing Fast Tests Against Enterprise Rails 30min");
            Assert.AreEqual(actual.GetDuration(), 30);
        }
    }
}
