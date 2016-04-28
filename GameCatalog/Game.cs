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
        public List<Platform> platforms { get; set; }
        public List<string> comments { get; set; }
        public Game()
        {
            platforms = new List<Platform>();
            comments = new List<string>();
        }
        public String Platforms
        {
            get
            {
                return String.Join(", ", platforms);
            }
        }
    }
}
