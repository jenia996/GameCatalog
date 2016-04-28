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
    public partial class Settings : Window
    {
        UserSettings settings;
        private void initializeCheckBoxes()
        {
            platformPlayStation.IsChecked = settings.preferedPlatforms.playstation;
            platformAndroid.IsChecked = settings.preferedPlatforms.android;
            platformXbox.IsChecked = settings.preferedPlatforms.xbox;
            platformIOS.IsChecked = settings.preferedPlatforms.ios;
            platformPC.IsChecked = settings.preferedPlatforms.pc;

            genreAction.IsChecked = settings.preferedGenres.action;
            genreAdventure.IsChecked = settings.preferedGenres.adventure;
            genreCard.IsChecked = settings.preferedGenres.card;
            genreLogic.IsChecked = settings.preferedGenres.logic;
            genreRPG.IsChecked = settings.preferedGenres.rpg;
            genreStrategy.IsChecked = settings.preferedGenres.strategy;


            markBox.Text = settings.minMark.ToString();
        }
        public Settings(UserSettings settings)
        {
            this.settings = settings;
            InitializeComponent();
            initializeCheckBoxes();
        }

        private void canselBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            Tuple<bool, double> mark = checkMark();
            if (!mark.Item1)
            {
                markBox.BorderBrush = Brushes.Red;
            }
            else
            {
                save();
                settings.minMark = mark.Item2;
                this.DialogResult = true;
            }
        }
        private void save()
        {
            settings.preferedGenres.action = (bool)genreAction.IsChecked;
            settings.preferedGenres.adventure = (bool)genreAdventure.IsChecked;
            settings.preferedGenres.card = (bool)genreCard.IsChecked;
            settings.preferedGenres.logic = (bool)genreLogic.IsChecked;
            settings.preferedGenres.rpg = (bool)genreRPG.IsChecked;
            settings.preferedGenres.strategy = (bool)genreStrategy.IsChecked;

            settings.preferedPlatforms.android = (bool)platformAndroid.IsChecked;
            settings.preferedPlatforms.ios = (bool)platformIOS.IsChecked;
            settings.preferedPlatforms.pc = (bool)platformPC.IsChecked;
            settings.preferedPlatforms.playstation = (bool)platformPlayStation.IsChecked;
            settings.preferedPlatforms.xbox = (bool)platformXbox.IsChecked;
            using (StreamWriter writer = new StreamWriter("Settings.json"))
            {
                writer.Write(JsonConvert.SerializeObject(settings));
            }


        }
        private Tuple<bool, double> checkMark()
        {
            double temp = -1;
            Double.TryParse(markBox.Text, out temp);
            if (temp > 0 && temp < 10)
            {
                return Tuple.Create(true, temp);
            }
            return Tuple.Create(false, -1.0);

        }


    }
}
