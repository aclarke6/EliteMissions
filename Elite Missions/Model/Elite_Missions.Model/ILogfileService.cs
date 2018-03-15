using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Missions.Model
{
    public interface ILogfileService
    {

        String LogFile { get; }

        void ParseLogfile();
    }
}
