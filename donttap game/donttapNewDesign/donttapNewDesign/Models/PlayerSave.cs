using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donttapNewDesign.Models
{
    public class PlayerSave
    {
        public List<EndurenceSettings> Endurence;
        public List<FrenzySettings> Frenzy;
        public List<PatternSettings> Pattern;
    }
    public class Settings
    {
        public int Boardsize { get; set; }
        public int Boxsize { get; set; }
        public int Spacing { get; set; }
    }
    public class EndurenceSettings
    {
        public int Score { get; set; }
        public int Boardsize { get; set; }
        public int Boxsize { get; set; }
        public int Spacing { get; set; }
        public DateTime Time { get; set; }
        public int Clicks { get; set; }
    }
    public class FrenzySettings
    {
        public int Score { get; set; }
        public int Boardsize { get; set; }
        public int Boxsize { get; set; }
        public int Spacing { get; set; }
        public DateTime Time { get; set; }
        public int GameTime { get; set; }
    }
    public class PatternSettings
    {
        public int Score { get; set; }
        public int Boardsize { get; set; }
        public int Boxsize { get; set; }
        public int Spacing { get; set; }
        public DateTime Time { get; set; }
    }
}
