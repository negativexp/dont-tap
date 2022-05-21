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
        public static void Create()
        {
            if(!File.Exists("settings.json"))
            {
                Models.Settings settings = new Models.Settings();
                settings.Boardsize = 4;
                settings.Boxsize = 165;
                settings.Spacing = 1;
                File.WriteAllText("settings.json", JsonConvert.SerializeObject(settings, Formatting.Indented));
            }
        }
    }
}
