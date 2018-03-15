using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Missions.Model
{
    public class FDEventMusic : FDEvent
    {
        public string MusicTrack { get; private set; }

        internal FDEventMusic( string json) : base("Music", json)
        {
            MusicTrack = jObject.GetValue("MusicTrack").Value<string>();
        }
    }
}
