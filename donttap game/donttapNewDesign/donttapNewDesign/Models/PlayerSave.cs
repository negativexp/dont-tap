using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donttapNewDesign.Models
{
    public class Data
    {
        public PlayerSave Scores { get; set; }
        public Settings Settings { get; set; }
        public EnduranceSettings EnduranceSettings { get; set; }
        public FrenzySettings FrenzySettings { get; set; }
    }
    public class PlayerSave
    {
        public List<EnduranceSave> Endurance;
        public List<FrenzySave> Frenzy;
    }
    public class Settings
    {
        public int Boardsize { get; set; }
        public int Boxsize { get; set; }
        public int Spacing { get; set; }
    }
    public class EnduranceSave
    {
        public int Score { get; set; }
        public DateTime Time { get; set; }
        public int Boardsize { get; set; }
        public int Boxsize { get; set; }
        public int Spacing { get; set; }
        public int Clicks { get; set; }
    }
    public class FrenzySave
    {
        public int Score { get; set; }
        public DateTime Time { get; set; }
        public int Boardsize { get; set; }
        public int Boxsize { get; set; }
        public int Spacing { get; set; }
        public int GameTime { get; set; }
    }
    public class EnduranceSettings
    {
        public int Clicks { get; set; }
    }
    public class FrenzySettings
    {
        public int GameTime { get; set; }
    }
}
