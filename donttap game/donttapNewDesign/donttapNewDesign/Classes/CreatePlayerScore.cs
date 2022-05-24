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
            Models.PlayerSave scores;
            Models.Settings settings = JsonConvert.DeserializeObject<Models.Settings>(File.ReadAllText("settings.json"));

            if (File.Exists("scores.json"))
            {
                scores = JsonConvert.DeserializeObject<Models.PlayerSave>(File.ReadAllText("scores.json"));
                Models.EndurenceSettings endurenceSettings = JsonConvert.DeserializeObject<Models.EndurenceSettings>(File.ReadAllText("settingsEndurence.json"));


                if (gamemode == 0)
                {
                    endurenceSettings = JsonConvert.DeserializeObject<Models.EndurenceSettings>(File.ReadAllText("settingsEndurence.json"));
                    scores.Endurence.Add(new Models.EndurenceSettings
                    {
                        Score = score,
                        Boardsize = settings.Boardsize,
                        Boxsize = settings.Boxsize,
                        Spacing = settings.Spacing,
                        Time = DateTime.Now,
                        Clicks = endurenceSettings.Clicks
                    });
                    File.WriteAllText("scores.json", JsonConvert.SerializeObject(scores, Formatting.Indented));
                }
            }
            else
            {
                if (gamemode == 0)
                {
                    Models.EndurenceSettings endurenceSettings = JsonConvert.DeserializeObject<Models.EndurenceSettings>(File.ReadAllText("settingsEndurence.json"));

                    Models.PlayerSave _scores = new Models.PlayerSave();
                    endurenceSettings.Score = score;
                    endurenceSettings.Boardsize = settings.Boardsize;
                    endurenceSettings.Boxsize = settings.Boxsize;
                    endurenceSettings.Spacing = settings.Spacing;
                    endurenceSettings.Time = DateTime.Now;
                    _scores.Endurence = new List<Models.EndurenceSettings>() { endurenceSettings };
                    File.WriteAllText("scores.json", JsonConvert.SerializeObject(_scores, Formatting.Indented));
                }
            }
        }
    }
}
