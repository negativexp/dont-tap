using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace donttapNewDesign.Classes
{
    internal class CreateEndurenceSettings
    {
        public static void Create(int x)
        {
            Models.EndurenceSettings endurenceSettings = new Models.EndurenceSettings();
            endurenceSettings.Clicks = x;
            File.WriteAllText("settingsEndurence.json", JsonConvert.SerializeObject(endurenceSettings, Formatting.Indented));
        }
    }
}
