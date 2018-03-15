using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elite_Missions.Model.ModelTests
{
    [TestClass]
    public class FDEventFileheaderTests
    {
        private const string JsonFileHeader = "{ \"timestamp\":\"2018-03-15T14:29:40Z\", \"event\":\"Fileheader\", \"part\":1, \"language\":\"English\\UK\", \"gameversion\":\"3.0.2.402 EDH\", \"build\":\"r166781/r0 \" }";



        [TestMethod]
        public void PartTest()
        {
            const int Expected = 1;
            FDEventFileheader fdEvent;

            fdEvent = FDEvent.Builder(JsonFileHeader.Replace(@"\", @"\\")) as FDEventFileheader;

            Assert.AreEqual(Expected, fdEvent.Part);
        }

        [TestMethod]
        public void LanguageTest()
        {
            const String Expected = "English\\UK";
            FDEventFileheader fdEvent;

            fdEvent = FDEvent.Builder(JsonFileHeader.Replace(@"\", @"\\")) as FDEventFileheader;

            Assert.AreEqual(Expected, fdEvent.Language);
        }

        [TestMethod]
        public void GameVersionTest()
        {
            const String Expected = "3.0.2.402 EDH";
            FDEventFileheader fdEvent;

            fdEvent = FDEvent.Builder(JsonFileHeader.Replace(@"\", @"\\")) as FDEventFileheader;

            Assert.AreEqual(Expected, fdEvent.GameVersion);
        }

        [TestMethod]
        public void BuildTest()
        {
            const String Expected = "r166781/r0 ";
            FDEventFileheader fdEvent;

            fdEvent = FDEvent.Builder(JsonFileHeader.Replace(@"\", @"\\")) as FDEventFileheader;

            Assert.AreEqual(Expected, fdEvent.Build);
        }

    }
}
