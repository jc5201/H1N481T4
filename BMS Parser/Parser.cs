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
                line = line.Substring(1);
                string[] split = line.Split(' ');
                if (split.Length == 1) //xxxyy꼴
                {

                }
                else switch (split[0])
                    {
                        case "PLAYER":

                            break;
                        case "TITLE":

                            break;
                        case "SUBTITLE":

                            break;
                        case "ARTIST":

                            break;
                        case "SUBARTIST":

                            break;
                        case "MAKER":

                            break;
                        case "GENRE":

                            break;
                        case "COMMENT":

                            break;
                        case "BPM":

                            break;
                        case "BASEBPM":

                            break;

                    }
            }

            return song;
        }
    }
}
