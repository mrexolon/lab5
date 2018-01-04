using NUnit.Framework;
using System.Collections.Generic;

namespace lab5.Tests
{
    [TestFixture]
    class Tests
    {
        private Steps.Steps steps = new Steps.Steps();
        private string FROM = string.Empty;
        private string TO = string.Empty;
        private string NUMBEROFPASSANGERS = string.Empty;
        private string DEPARTDATE = string.Empty;
        private string RETURNDATE = string.Empty;
        private string AIRCLASS = string.Empty;
        private string COUNTROOM = string.Empty;
        private IList<string> DATE;
        private IList<string> TIMEOFDAY;
        private IList<string> TYPEPASSANGERS;


        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void TestCaseOne()
        {
            FROM = "Владивосток (VVO)";
            TO = "Москва Домодедово (DME)";
            NUMBEROFPASSANGERS = "1";
            DEPARTDATE = "08.01.2018";
            RETURNDATE = "15.01.2018";
            steps.SearchCaseOne(FROM, TO, NUMBEROFPASSANGERS, DEPARTDATE, RETURNDATE);
        }

        [Test]
        public void TestCaseTwo()
        {
            FROM = "Владивосток (VVO)";
            TO = "Владивосток (VVO)";
            NUMBEROFPASSANGERS = "1";
            DEPARTDATE = "08.01.2018";
            RETURNDATE = "15.01.2018";
            steps.SearchCaseTwo(FROM, TO, NUMBEROFPASSANGERS, DEPARTDATE, RETURNDATE);
        }

        [Test]
        public void TestCaseThree()
        {
            FROM = "Владивосток (VVO)";
            TO = "Москва Домодедово (DME)";
            NUMBEROFPASSANGERS = "1";
            DEPARTDATE = "08.01.2018";
            steps.SearchCaseThree(FROM, TO, NUMBEROFPASSANGERS, DEPARTDATE);
        }

        [Test]
        public void TestCaseFour()
        {
            FROM = "Владивосток (VVO)";
            TO = "Москва Домодедово (DME)";
            NUMBEROFPASSANGERS = "6";
            DEPARTDATE = "08.01.2018";
            RETURNDATE = "15.01.2018";
            steps.SearchCaseFour(FROM, TO, NUMBEROFPASSANGERS, DEPARTDATE, RETURNDATE);
        }  

    }
}
