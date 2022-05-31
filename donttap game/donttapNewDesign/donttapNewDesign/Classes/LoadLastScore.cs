using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace donttapNewDesign.Classes
{
    internal class LoadLastScore
    {
        public static async Task<int> Load(int gamemode)
        {
            Models.Data data = JsonConvert.DeserializeObject<Models.Data>(File.ReadAllText("data.json"));
            if(gamemode == 0)
                if(data.Scores.Endurance.Count > 0)
                    return data.Scores.Endurance[data.Scores.Endurance.Count - 1].Score;

            if (gamemode == 1)
                if (data.Scores.Frenzy.Count > 0)
                    return data.Scores.Frenzy[data.Scores.Frenzy.Count - 1].Score;
            return -1;
        }
    }
}
