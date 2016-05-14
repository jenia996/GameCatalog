using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Newtonsoft.Json;

namespace GameCatalog
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class UserSettingsWindow : Window
    {
        private GameWindowCommands commands;
        public GameWindowCommands Commands
        {
            get { return commands; }
        }
        private UserSettings settings;
        //private UserSettingsService settingsService;
        public String MinMark
        {
            get { return settings.minMark.ToString(); }
            set
            {
                double temp = settings.minMark;
                Double.TryParse(markBox.Text, out temp);
                if (temp > 0 && temp < 10)
                {
                    settings.minMark = temp;
                }
            }
        }
        public UserSettings USettings
        {
            get { return settings; }
        }

        public UserSettingsWindow(GameWindowCommands commands)
        {
            this.commands = commands;
            settings = new UserSettings();
            InitializeComponent();
            canselBtn.Command = new DelegateCommand(this.Close);
        }
    }
}
