using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace donttapNewDesign.Classes
{
    internal class CreatePlayerScore
    {
        public static void Create(int gamemode, int score)
        {
            Models.Data data = JsonConvert.DeserializeObject<Models.Data>(File.ReadAllText("data.json"));
            if(data.Scores == null)
            {
                data.Scores = new Models.PlayerSave();
                data.Scores.Endurance = new List<Models.EnduranceSave>();
            }

            if (gamemode == 0)
            {
                data.Scores.Endurance.Add(new Models.EnduranceSave
                {
                    Score = score,
                    Boardsize = data.Settings.Boardsize,
                    Boxsize = data.Settings.Boxsize,
                    Spacing = data.Settings.Spacing,
                    Time = DateTime.Now,
                    Clicks = data.EnduranceSettings.Clicks
                });
                File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
            }
        }
    }
}
