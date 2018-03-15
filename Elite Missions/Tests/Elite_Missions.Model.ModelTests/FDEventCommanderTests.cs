using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elite_Missions.Model.ModelTests
{
    [TestClass]
    public class FDEventCommanderTests
    {
        [TestMethod]

        public void InvalidHeaderFail()
        {
            const string Json = "{ \"timestamp\":\"2018-03-15T14:29:40Z\", \"event\":\"Music\", \"MusicTrack\":\"NoTrack\"  }";

            var fdEvent = FDEvent.Builder(Json) as FDEventCommander;
            Assert.IsNull(fdEvent);
        }


        [TestMethod]
        public void NameTest()
        {
            const string Json = "{ \"timestamp\":\"2018-03-15T14:31:10Z\", \"event\":\"Commander\", \"Name\":\"La Mancha\" }";
            const string Expected = "La Mancha";
            FDEventCommander fdEvent;

            fdEvent = FDEvent.Builder(Json) as FDEventCommander;

            Assert.AreEqual(Expected, fdEvent.Name);
        }
    }
}
