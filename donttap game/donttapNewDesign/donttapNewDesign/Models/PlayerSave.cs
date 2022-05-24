using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donttapNewDesign.Models
{
    public class PlayerSave
    {
        List<Player> player;
    }
    public class Player
    {
        public int Score { get; set; }
        public DateTime Time { get; set; }
        public Settings Settings { get; set; }
    }
    public class Settings
    {
        public int Boardsize { get; set; }
        public int Boxsize { get; set; }
        public int Spacing { get; set; }
        public EndurenceSettings Endurence { get; set; }
        public FrenzySettings Frenzy { get; set; }
    }
    public class EndurenceSettings
    {
        public int Clicks { get; set; }
    }
    public class FrenzySettings
    {
        public int Time { get; set; }
    }
}
