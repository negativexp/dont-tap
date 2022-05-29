using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace donttapNewDesign.Classes
{
    internal class CreateSettings
    {
        public static void CreateDeafult()
        {
            if(!File.Exists("data.json"))
            {
                Models.Data data = new Models.Data();
                data.Settings = new Models.Settings();
                data.Settings.Boardsize = 4;
                data.Settings.Boxsize = 165;
                data.Settings.Spacing = 1;
                File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
            }
        }
    }
}
