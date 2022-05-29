using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace donttapNewDesign.Classes
{
    internal class CreateData
    {
        public static void Create()
        {
            if(!File.Exists("data.json"))
            {
                Models.Data data = new Models.Data();
                File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
            }
        }
    }
}
