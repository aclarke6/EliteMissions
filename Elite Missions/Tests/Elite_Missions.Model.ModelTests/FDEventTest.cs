using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elite_Missions.Model.ModelTests
{
    [TestClass]
    public class FDEventTest
    {
        private const string JsonFileHeader = "{ \"timestamp\":\"2018-03-15T14:29:40Z\", \"event\":\"Fileheader\", \"part\":1, \"language\":\"English\\UK\", \"gameversion\":\"3.0.2.402 EDH\", \"build\":\"r166781/r0 \" }";

        [TestMethod]
        public void InvalidHeaderFail()
        {
            const string Json = "{ \"timestamp\":\"2018-03-15T14:30:31Z\", \"event\":\"Friends\", \"Status\":\"Online\", \"Name\":\"Falcon Darkstar\"  }";

            FDEventFileheader fdEvent;
            fdEvent = FDEvent.Builder(Json) as FDEventFileheader;
            Assert.IsNull(fdEvent);
        }


        [TestMethod]
        public void FileHeaderTest()
        {
            const string Expected = "Fileheader";
            FDEvent fdEvent;

            fdEvent = FDEvent.Builder(JsonFileHeader.Replace(@"\",@"\\")) as FDEventFileheader;

            
            Assert.AreEqual(Expected,fdEvent.Event);
        }

        [TestMethod]
        public void TimeStampTest()
        {
            DateTime Expected = new DateTime(2018, 3, 15, 14, 29, 40);
            FDEvent fdEvent;

            fdEvent = FDEvent.Builder(JsonFileHeader.Replace(@"\", @"\\")) as FDEventFileheader;

            Assert.AreEqual(Expected, fdEvent.TimeStamp);
        }
    }
}
