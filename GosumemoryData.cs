using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu2ass
{
    /// <summary>
    /// Gosumemory的Json实体类
    /// </summary>
    public class GosumemoryData
    {
        public Settings settings { get; set; }
        public Menu menu { get; set; }
        public Gameplay gameplay { get; set; }
        public Resultsscreen resultsScreen { get; set; }
        public Tourney tourney { get; set; }
    }

    public class Settings
    {
        public bool showInterface { get; set; }
        public Folders folders { get; set; }
    }

    public class Folders
    {
        public string game { get; set; }
        public string skin { get; set; }
        public string songs { get; set; }
    }

    public class Menu
    {
        public Mainmenu mainMenu { get; set; }
        public int state { get; set; }
        public int gameMode { get; set; }
        public int isChatEnabled { get; set; }
        public Bm bm { get; set; }
        public Mods mods { get; set; }
        public Pp pp { get; set; }
    }

    public class Mainmenu
    {
        public float bassDensity { get; set; }
    }

    public class Bm
    {
        public Time time { get; set; }
        public int id { get; set; }
        public int set { get; set; }
        public string md5 { get; set; }
        public int rankedStatus { get; set; }
        public Metadata metadata { get; set; }
        public Stats stats { get; set; }
        public Path path { get; set; }
    }

    public class Time
    {
        public int firstObj { get; set; }
        public int current { get; set; }
        public int full { get; set; }
        public int mp3 { get; set; }
    }

    public class Metadata
    {
        public string artist { get; set; }
        public string artistOriginal { get; set; }
        public string title { get; set; }
        public string titleOriginal { get; set; }
        public string mapper { get; set; }
        public string difficulty { get; set; }
    }

    public class Stats
    {
        public float AR { get; set; }
        public float CS { get; set; }
        public float OD { get; set; }
        public float HP { get; set; }
        public float SR { get; set; }
        public BPM BPM { get; set; }
        public int maxCombo { get; set; }
        public float fullSR { get; set; }
        public float memoryAR { get; set; }
        public float memoryCS { get; set; }
        public float memoryOD { get; set; }
        public float memoryHP { get; set; }
    }

    public class BPM
    {
        public float min { get; set; }
        public float max { get; set; }
    }

    public class Path
    {
        public string full { get; set; }
        public string folder { get; set; }
        public string file { get; set; }
        public string bg { get; set; }
        public string audio { get; set; }
    }

    public class Mods
    {
        public int num { get; set; }
        public string str { get; set; }
    }

    public class Pp
    {
        public float _100 { get; set; }
        public float _99 { get; set; }
        public float _98 { get; set; }
        public float _97 { get; set; }
        public float _96 { get; set; }
        public float _95 { get; set; }
        public float[] strains { get; set; }
    }

    public class Gameplay
    {
        public int gameMode { get; set; }
        public string name { get; set; }
        public int score { get; set; }
        public float accuracy { get; set; }
        public Combo combo { get; set; }
        public Hp hp { get; set; }
        public Hits hits { get; set; }
        public Pp1 pp { get; set; }
        public Keyoverlay keyOverlay { get; set; }
        public Leaderboard leaderboard { get; set; }
    }

    public class Combo
    {
        public int current { get; set; }
        public int max { get; set; }
    }

    public class Hp
    {
        public float normal { get; set; }
        public float smooth { get; set; }
    }

    public class Hits
    {
        public int _300 { get; set; }
        public int geki { get; set; }
        public int _100 { get; set; }
        public int katu { get; set; }
        public int _50 { get; set; }
        public int _0 { get; set; }
        public int sliderBreaks { get; set; }
        public Grade grade { get; set; }
        public float unstableRate { get; set; }
        public object hitErrorArray { get; set; }
    }

    public class Grade
    {
        public string current { get; set; }
        public string maxThisPlay { get; set; }
    }

    public class Pp1
    {
        public float current { get; set; }
        public float fc { get; set; }
        public float maxThisPlay { get; set; }
    }

    public class Keyoverlay
    {
        public K1 k1 { get; set; }
        public K2 k2 { get; set; }
        public M1 m1 { get; set; }
        public M2 m2 { get; set; }
    }

    public class K1
    {
        public bool isPressed { get; set; }
        public int count { get; set; }
    }

    public class K2
    {
        public bool isPressed { get; set; }
        public int count { get; set; }
    }

    public class M1
    {
        public bool isPressed { get; set; }
        public int count { get; set; }
    }

    public class M2
    {
        public bool isPressed { get; set; }
        public int count { get; set; }
    }

    public class Leaderboard
    {
        public bool hasLeaderboard { get; set; }
        public bool isVisible { get; set; }
        public Ourplayer ourplayer { get; set; }
        public object slots { get; set; }
    }

    public class Ourplayer
    {
        public string name { get; set; }
        public int score { get; set; }
        public int combo { get; set; }
        public int maxCombo { get; set; }
        public string mods { get; set; }
        public int h300 { get; set; }
        public int h100 { get; set; }
        public int h50 { get; set; }
        public int h0 { get; set; }
        public int team { get; set; }
        public int position { get; set; }
        public int isPassing { get; set; }
    }

    public class Resultsscreen
    {
        public string name { get; set; }
        public int score { get; set; }
        public int maxCombo { get; set; }
        public Mods1 mods { get; set; }
        public int _300 { get; set; }
        public int geki { get; set; }
        public int _100 { get; set; }
        public int katu { get; set; }
        public int _50 { get; set; }
        public int _0 { get; set; }
    }

    public class Mods1
    {
        public int num { get; set; }
        public string str { get; set; }
    }

    public class Tourney
    {
        public Manager manager { get; set; }
        public object ipcClients { get; set; }
    }

    public class Manager
    {
        public int ipcState { get; set; }
        public int bestOF { get; set; }
        public Teamname teamName { get; set; }
        public Stars stars { get; set; }
        public Bools bools { get; set; }
        public object chat { get; set; }
        public Gameplay1 gameplay { get; set; }
    }

    public class Teamname
    {
        public string left { get; set; }
        public string right { get; set; }
    }

    public class Stars
    {
        public int left { get; set; }
        public int right { get; set; }
    }

    public class Bools
    {
        public bool scoreVisible { get; set; }
        public bool starsVisible { get; set; }
    }

    public class Gameplay1
    {
        public Score score { get; set; }
    }

    public class Score
    {
        public int left { get; set; }
        public int right { get; set; }
    }
}
