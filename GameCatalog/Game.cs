using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCatalog
{
    class Game
    {
        public int id { get; set; }
        public string name { get; set; }
        public double averageMark { get; set; }
        public Genre genre { get; set; }
        public string dateAdded { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public Platform platform { get; set; }


    }
}
