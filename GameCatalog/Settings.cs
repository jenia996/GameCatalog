using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCatalog
{
    public class UserSettings
    {
        private static readonly Lazy<UserSettings> lazy =
         new Lazy<UserSettings>(() => new UserSettings());

        public static UserSettings Instance { get { return lazy.Value; } }

        private UserSettings()//Change to request to db
        {
            preferedGenres = new List<Genre> { Genre.RPG, Genre.Action };
            preferedPlatform = new List<Platform> { Platform.PC, Platform.Playstation };
            minMark = 9;
        }
        public List<Genre> preferedGenres { get; set; }
        public List<Platform> preferedPlatform { get; set; }
        public double minMark { get; set; }

    }
}
