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
            Models.Data data = JsonConvert.DeserializeObject<Models.Data>(File.ReadAllText("data.json"));
            if(data.Settings != null)
            {
                toReturn[0] = data.Settings.Boardsize;
                toReturn[1] = data.Settings.Boxsize;
                toReturn[2] = data.Settings.Spacing;
            }
            return toReturn;
        }
    }
}
