using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCatalog
{
    public class Game
    {
        public int id { get; set; }
        public String name { get; set; }
        public double averageMark { get; set; }
        public Genre genre { get; set; }
        public string dateAdded { get; set; }
        public string logo { get; set; }
        public string description { get; set; }
        public List<Platform> platforms { get; set; }
        public List<string> comments { get; set; }
        public String rewiew { get; set; }
        public List<String> images { get; set; }
        public Game()
        {
            images = new List<string>();
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
