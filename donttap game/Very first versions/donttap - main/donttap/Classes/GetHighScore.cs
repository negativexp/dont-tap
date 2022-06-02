using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows;
using Newtonsoft.Json.Linq;

namespace donttap.Classes
{
    public class GetHighScore
    {
        public static int Fetch()
        {
            var data = JsonConvert.DeserializeObject<List<Models.Score>>(File.ReadAllText("data/scores.json"));
            return data.Max(x => x.score);
        }
    }
}
