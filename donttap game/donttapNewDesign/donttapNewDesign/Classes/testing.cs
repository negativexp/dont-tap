using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace donttapNewDesign.Classes
{
    internal class testing
    {
        public static void test()
        {
            Models.Data data = new Models.Data();
            data.Settings = new Models.Settings();
            data.Settings.Boardsize = 10;
            data.Settings.Boxsize = 10;
            data.Settings.Spacing = 10;
            File.WriteAllText("data.json", JsonConvert.SerializeObject(data,Formatting.Indented));
        }
    }
}
