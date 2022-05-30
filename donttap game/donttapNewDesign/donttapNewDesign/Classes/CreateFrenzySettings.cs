using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace donttapNewDesign.Classes
{
    internal class CreateFrenzySettings
    {
        public static void Create(int x)
        {
            Models.Data data = JsonConvert.DeserializeObject<Models.Data>(File.ReadAllText("data.json"));
            data.FrenzySettings.GameTime = x;
            File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
        }
    }
}
