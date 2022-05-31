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

            if (gamemode == 0)
            {
                data.Scores.Endurance.Add(new Models.EnduranceSave
                {
                    Score = score,
                    Boardsize = data.Settings.Boardsize,
                    Boxsize = data.Settings.Boxsize,
                    Spacing = data.Settings.Spacing,
                    Time = DateTime.Now.ToString(),
                    Clicks = data.EnduranceSettings.Clicks
                });
                File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            if (gamemode == 1)
            {
                data.Scores.Frenzy.Add(new Models.FrenzySave
                {
                    Score = score,
                    Boardsize = data.Settings.Boardsize,
                    Boxsize = data.Settings.Boxsize,
                    Spacing = data.Settings.Spacing,
                    Time = DateTime.Now.ToString(),
                    GameTime = data.FrenzySettings.GameTime
                });
                File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
            }
        }
    }
}
