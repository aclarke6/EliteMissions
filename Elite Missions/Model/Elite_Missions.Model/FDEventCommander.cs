using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Missions.Model
{
    public class FDEventCommander : FDEvent
    {
        public string Name { get; private set; }

        private FDEventCommander()
        {

        }

        internal FDEventCommander(string json) : base("Commander", json)
        {
            Name = jObject.GetValue("Name").Value<string>();
        }
    }
}