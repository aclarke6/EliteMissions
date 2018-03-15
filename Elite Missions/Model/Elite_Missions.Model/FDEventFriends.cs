using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Missions.Model
{
    public class FDEventFriends : FDEvent
    {
        public Boolean Status { get; private set; }
        public String Name { get; private set; }

        internal FDEventFriends(String json) : base("Friends", json)
        {
            Status = jObject.GetValue("Status").Value<string>()=="Online";
            Name = jObject.GetValue("Name").Value<string>();
        }
    }
}
