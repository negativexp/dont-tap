using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace donttapNewDesign.Classes
{
    internal class CreateData
    {
        public static void Create()
        {
            if(!File.Exists("data.json"))
            {
                Models.Data data = new Models.Data();
                data.Scores = new Models.PlayerSave();
                data.Scores.Endurance = new List<Models.EnduranceSave>();
                data.Scores.Frenzy = new List<Models.FrenzySave>();
                data.Settings = new Models.Settings() { Boardsize = 4, Boxsize = 165, Spacing = 1};
                data.EnduranceSettings = new Models.EnduranceSettings() { Clicks = 40 };
                data.FrenzySettings = new Models.FrenzySettings() { GameTime = 30 };
                File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
            }
        }
    }
}
