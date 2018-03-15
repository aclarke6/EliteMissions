using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Missions.Model
{

    public class FDEventFileheader : FDEvent
    {
        public int Part { get; private set; }

        public String Language { get; private set; }

        public String GameVersion { get; private set; }

        public String Build { get; private set; }


        internal FDEventFileheader(string json) : base("Fileheader", json)
        {
            Part = jObject.GetValue("part").Value<int>();
            Language = jObject.GetValue("language").Value<String>();
            GameVersion = jObject.GetValue("gameversion").Value<String>();
            Build = jObject.GetValue("build").Value<String>();
        }
    }
}
