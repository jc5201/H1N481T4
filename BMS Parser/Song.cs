using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_Parser
{
    //참고 링크
    //http://cosmic.mearie.org/2005/03/bmsguide/
    //https://hitkey.nekokan.dyndns.info/cmds.htm#CONTROL-FLOW
    class Song
    {
        public int PLAYER;
        public string TITLE;
        public string SUBTITLE;
        public string ARTIST;
        public string SUBARTIST;
        public string MAKER;
        public string GENRE;
        public string COMMENT;  //""로 감싸인 문자열
        public Single BPM;
        public Single BASEBPM;
        public int LEVEL;
        public int DIFFICULTY;
        //public int RANK;      //판정 조절
        public int TOTALOBJECT;
        public int VOLWAV;      //default 100
        //public string MIDIBACK;
        public string STAGEFILE;
        public string BANNER;
        public string VIDEOFILE;

        List<string> WAVEFILE = new List<string>();

        //xxxyy:aabbccdd
        //      xxx:마디 번호
        //      yy:채널 번호
    }
}
