using System.IO;
using Newtonsoft.Json;

namespace donttap.Classes
{
    public class CreateJson
    {
        public static void CreateFolder()
        {
            Directory.CreateDirectory("data");
        }

        public static void CreateSettings(int boardSize, int boxSize, int spacing,
                                int amountOfStartingBoxes)
        {
            Models.Settings settings = new Models.Settings();
            settings.boardSize = boardSize;
            settings.boxSize = boxSize;
            settings.spacing = spacing;
            settings.amountOfStartingBoxes = amountOfStartingBoxes;
            var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText("data/settings.json", json);
        }

        public static void CreateScore(int score, int gamemode, string name)
        {
            if (File.Exists("data/scores.json"))
            {
                var data = File.ReadAllText("data/scores.json");
                Models.Settings settings = JsonConvert.DeserializeObject<Models.Settings>(File.ReadAllText("data/settings.json"));
                Models.Gamer list = JsonConvert.DeserializeObject<Models.Gamer>(data);
                list.gamer.Add(new Models.Score
                {
                    name = name,
                    score = score,
                    gamemode = gamemode,
                    settings = settings
                });
                var json = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText("data/scores.json", json);
            }
            else
            {
                Models.Gamer gamer = new Models.Gamer();
                Models.Score scr = new Models.Score();
                Models.Settings settings = new Models.Settings();

                settings = JsonConvert.DeserializeObject<Models.Settings>(File.ReadAllText("data/settings.json"));
                
                scr.name = name;
                scr.score = score;
                scr.gamemode = gamemode;
                scr.settings = settings;

                gamer.gamer = new System.Collections.Generic.List<Models.Score>() { scr };
                var json = JsonConvert.SerializeObject(gamer, Formatting.Indented);
                File.WriteAllText("data/scores.json", json);
            }

        }
    }
}
