using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elite_Missions.Model.ModelTests
{
    [TestClass]
    public class FDEventFriendsTests
    {
        [TestMethod]

        public void InvalidHeaderFail()
        {
            const string Json = "{ \"timestamp\":\"2018-03-15T14:29:40Z\", \"event\":\"Music\", \"MusicTrack\":\"NoTrack\"  }";

            FDEventFriends fdEvent;
            fdEvent = FDEvent.Builder(Json) as FDEventFriends;
            Assert.IsNull(fdEvent);
        }

        [TestMethod]
        public void OnlineTest()
        {
            const string JsonFriends = "{ \"timestamp\":\"2018-03-15T14:30:31Z\", \"event\":\"Friends\", \"Status\":\"Online\", \"Name\":\"Falcon Darkstar\"  }";

            const Boolean Expected = true;
            FDEventFriends fdEvent;

            fdEvent = FDEvent.Builder(JsonFriends) as FDEventFriends;

            Assert.AreEqual(Expected, fdEvent.Status);
        }

        [TestMethod]
        public void OfflineTest()
        {
            const string JsonFriends = "{ \"timestamp\":\"2018-03-15T14:30:31Z\", \"event\":\"Friends\", \"Status\":\"Offline\", \"Name\":\"Falcon Darkstar\"  }";

            const Boolean Expected = false;
            FDEventFriends fdEvent;

            fdEvent = FDEvent.Builder(JsonFriends) as FDEventFriends;

            Assert.AreEqual(Expected, fdEvent.Status);
        }

        [TestMethod]
        public void NameTest()
        {
            const string JsonFriends = "{ \"timestamp\":\"2018-03-15T14:30:31Z\", \"event\":\"Friends\", \"Status\":\"Online\", \"Name\":\"Falcon Darkstar\"  }";
            const string Expected = "Falcon Darkstar";

            FDEventFriends fdEvent;

            fdEvent = FDEvent.Builder(JsonFriends) as FDEventFriends;

            Assert.AreEqual(Expected, fdEvent.Name);
        }
    }
}
