using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameCatalog
{
    public class UserSettings
    {
        public double minMark { get; set; }

        public class PreferedGenres
        {
            public bool rpg { get; set; }
            public bool card { get; set; }
            public bool logic { get; set; }
            public bool action { get; set; }
            public bool strategy { get; set; }
            public bool adventure { get; set; }
        }
        public class PreferedPlatforms
        {
            public bool pc { get; set; }
            public bool ios { get; set; }
            public bool xbox { get; set; }
            public bool android { get; set; }
            public bool playstation { get; set; }
        }

        public PreferedGenres preferedGenres { get; set; }
        public PreferedPlatforms preferedPlatforms { get; set; }
        public UserSettings()
        {
            preferedGenres = new PreferedGenres();
            preferedPlatforms = new PreferedPlatforms();
            minMark = 0;
        }
    }
}
