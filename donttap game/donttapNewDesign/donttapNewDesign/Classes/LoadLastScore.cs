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
        public static int Load(int x)
        {
            //nefunguje pokud neexistuje
            try
            {
                if (x == 0)
                {
                    var lastscore = JsonConvert.DeserializeObject<Models.PlayerSave>(File.ReadAllText("scores.json"));
                    return lastscore.Endurence[lastscore.Endurence.Count - 1].Score;
                }
                if (x == 1)
                {
                    var lastscore = JsonConvert.DeserializeObject<Models.PlayerSave>(File.ReadAllText("scores.json"));
                    return lastscore.Frenzy[lastscore.Endurence.Count - 1].Score;
                }
                if (x == 2)
                {
                    var lastscore = JsonConvert.DeserializeObject<Models.PlayerSave>(File.ReadAllText("scores.json"));
                    return lastscore.Pattern[lastscore.Endurence.Count - 1].Score;
                }
            }
            catch (Exception)
            {
            }
            return -1;
        }
    }
}
