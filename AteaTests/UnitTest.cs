using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Atea;

namespace Atea.Tests
{
    [TestClass()]
    public class UnitTest
    {
        //Initierar klass-variabler för test.
        string testString = "Test message";
        DateTime dateTime = DateTime.Now;

        //Test-metod för att se om SaveTextToDb-metod kan ta rätt värden.
        [TestMethod()]
        public void SaveTextToDbTest()
        {
            Program.userInput = testString;
            Program.timeStamp = dateTime;
        }

        //Test-metod för att se om GetMessage-metod kan ta rätt värde.
        [TestMethod()]
        public void GetMessageTest()
        {
            Program.GetMessage(testString);
        }
    }
}