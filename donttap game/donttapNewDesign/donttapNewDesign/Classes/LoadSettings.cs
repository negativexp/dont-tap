using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace donttapNewDesign.Classes
{
    internal class LoadSettings
    {
        public static int[] Load()
        {
            int[] toReturn = new int[3];
            var data = JsonConvert.DeserializeObject<Models.Settings>(File.ReadAllText("settings.json"));
            toReturn[0] = data.Boardsize;
            toReturn[1] = data.Boxsize;
            toReturn[2] = data.Spacing;
            return toReturn;
        }
    }
}
