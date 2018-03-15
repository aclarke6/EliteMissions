using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elite_Missions.Model.ModelTests
{
    [TestClass]
    public class FDEventMusicTests
    {
        private const string JsonMusic = "{ \"timestamp\":\"2018-03-15T14:29:40Z\", \"event\":\"Music\", \"MusicTrack\":\"NoTrack\"  }";

        [TestMethod]
        public void InvalidHeaderFail()
        {
            const string Json = "{ \"timestamp\":\"2018-03-15T14:30:31Z\", \"event\":\"Friends\", \"Status\":\"Online\", \"Name\":\"Falcon Darkstar\"  }";

            FDEventMusic fdEvent;
            fdEvent = FDEvent.Builder(Json) as FDEventMusic;
            Assert.IsNull(fdEvent);
        }

        [TestMethod]
        public void MusicTest()
        {
            const string Expected = "NoTrack";
            FDEventMusic fdEvent;

            fdEvent = FDEvent.Builder(JsonMusic) as FDEventMusic;

            Assert.AreEqual(Expected, fdEvent.MusicTrack);
        }
    }
}
