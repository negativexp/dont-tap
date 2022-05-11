using System.IO;
using Newtonsoft.Json;

namespace donttap.Classes
{
    public class CreateSettingsJson
    {
        public static void CreateFolder()
        {
            Directory.CreateDirectory("data");
        }

        public static void Create(int time, int boardSize, int boxSize, int spacing,
                                int amountOfStartingBoxes)
        {
            Models.Settings settings = new Models.Settings();
            settings.time = time;
            settings.boardSize = boardSize;
            settings.boxSize = boxSize;
            settings.spacing = spacing;
            settings.amountOfStartingBoxes = amountOfStartingBoxes;
            var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText("data/settings.json", json);
        }
    }
}
