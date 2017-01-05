using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMS_Parser
{
    class Parser
    {
        public string filename;
        private Song song { get; }

        public Song Parse()
        {
            StreamReader fs;
            try
            {
                fs = new StreamReader(filename);
            }
            catch (FileNotFoundException)
            {
                return null;
            }

            while (true)
            {
                string line = fs.ReadLine();
                if (line[0] != '#') continue;

            }

            return song;
        }
    }
}
