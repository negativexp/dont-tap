using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donttap.Models
{
    public class ScoreJSON
    {
        public int score { get; set; }
        public string name { get; set; }
        public Settings settings { get; set; }

    }
    public class Settings
    {
        public int time { get; set; }
        public int boardSize { get; set; }
        public int boxSize { get; set; }
        public int spacing { get; set; }
        public int amountOfStartingBoxes { get; set; }
    }
}
