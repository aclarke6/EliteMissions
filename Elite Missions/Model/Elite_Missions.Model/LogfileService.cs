using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Elite_Missions.Model
{
    public class LogfileService : ILogfileService
    {
        private const string defaultLocation = @"Saved Games\Frontier Developments\Elite Dangerous";
        private string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        public string GetFolderPath { get; private set; }

        public string LogFile
        {
            get
            {
                return GetLogFiles().FirstOrDefault();
            }
        }

        public FDEventFileheader Fileheader => throw new NotImplementedException();

        public String GetFolderName()
        {
            String folder = Path.Combine(userFolder, defaultLocation);
            return folder;
        }

        public List<String> GetLogFiles()
        {
            List<String> files = new List<string>();

            foreach(string file in Directory.GetFiles(GetFolderName(), "Journal.*.log").OrderByDescending(f=>f))
            {
                files.Add(file);
            }

            return files;
        }
    }
}
