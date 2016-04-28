using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace GameCatalog
{
    class UserSettingsParser
    {
        public static UserSettings getUserSettings()
        {
            UserSettings userSettings = getSettingsJSON();
            if (userSettings == null)
            {
                return new UserSettings();
            }
            return userSettings;
        }
        private static UserSettings getSettingsJSON()
        {
            try
            {
                if (File.Exists("Settings.json"))
                {
                    return JsonConvert.DeserializeObject<UserSettings>(new StreamReader("settings.json").ReadToEnd());
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
