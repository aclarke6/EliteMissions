using Elite_Missions.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Missions.Design
{
    class DesignLogfileService : ILogfileService
    {
        public string LogFile => Path.Combine( @"%UserProfile%\Saved Games\Frontier Developments\Elite Dangerous", "Journal.180305095054.01.log");

        public FDEventFileheader Fileheader => FDEvent.Builder("{ \"timestamp\":\"2018-03-15T14:29:40Z\", \"event\":\"Fileheader\", \"part\":1, \"language\":\"English\\UK\", \"gameversion\":\"3.0.2.402 EDH\", \"build\":\"r166781/r0 \" }") as FDEventFileheader;

        public void ParseLogfile()
        {
            throw new NotImplementedException();
        }
    }
}
