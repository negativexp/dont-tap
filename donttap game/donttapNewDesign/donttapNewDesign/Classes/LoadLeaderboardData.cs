using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace donttapNewDesign.Classes
{
    internal class LoadLeaderboardData
    {
        public static async Task<Models.Data> Load()
        {
            return JsonConvert.DeserializeObject<Models.Data>(File.ReadAllText("data.json"));
        }
    }
}
