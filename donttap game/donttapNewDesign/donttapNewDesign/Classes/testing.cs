using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace donttapNewDesign.Classes
{
    internal class testing
    {
        public static Task<string> test()
        {
            return Task.Run(() =>
            {
                WebClient client = new WebClient();
                return client.DownloadString("https://my-json-server.typicode.com/negativexp/json-testing/Scores");
            });
        }
    }
}
