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
        public static int Load()
        {
            Models.Data data = JsonConvert.DeserializeObject<Models.Data>(File.ReadAllText("data.json"));
            if(data.Scores.Endurance != null)
            {
                return data.Scores.Endurance[data.Scores.Endurance.Count - 1].Score;
            }
            return -1;
        }
    }
}
