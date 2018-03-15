using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Missions.Model
{
    public abstract class FDEvent
    {
        protected JObject jObject { get; private set; }

        public DateTime TimeStamp { get; private set; }

        public String Event { get; set; }

        protected FDEvent()
        {
            
        }

        protected FDEvent(string eventName, string json) : this()
        {
            jObject = JObject.Parse(json);

            var timeStamp = jObject.GetValue("timestamp").Value<DateTime>();
            //TimeStamp = timeStamp.FromIso8601Date();//
            TimeStamp = timeStamp;

            Event = jObject.GetValue("event").Value<String>();
            ValidateHeader(eventName);
            
        }

        protected void ValidateHeader(string eventName)
        {
            if (Event != eventName)
            {
                throw new ArgumentException($"Object is not a {eventName} Event.");
            }
        }

        public static FDEvent Builder(string json)
        {
            var jObject = JObject.Parse(json);

            var eventName = jObject.GetValue("event").Value<String>();

            switch (eventName)
            {
                case "Fileheader":
                    return new FDEventFileheader(json);
                case "Music":
                    return new FDEventMusic(json);
                case "Friends":
                    return new FDEventFriends(json);
                case "Commander":
                    return new FDEventCommander(json);
                default:
                    throw new ArgumentException("Event not recognised.");
            }
        }
    }
}
