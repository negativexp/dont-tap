using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace donttapNewDesign.Classes
{
    internal class LoadFrenzySettings
    {
        public static async Task<int> Load()
        {
            Models.Data data = JsonConvert.DeserializeObject<Models.Data>(File.ReadAllText("data.json"));
            return data.FrenzySettings.GameTime;
        }
    }
}
