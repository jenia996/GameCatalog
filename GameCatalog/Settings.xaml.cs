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

namespace GameCatalog
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        struct CheckedMark
        {
            public bool valid { get; set; }
            public double value { get; set; }
        }
        CheckedMark mark;
        UserSettings settings;
        private void initializeCheckBoxes()
        {
            genreRPG.IsChecked = settings.preferedGenres.Contains(GameCatalog.Genre.RPG);
            genreLogic.IsChecked = settings.preferedGenres.Contains(GameCatalog.Genre.Logic);
            genreCard.IsChecked = settings.preferedGenres.Contains(GameCatalog.Genre.Card);
            genreAdventure.IsChecked = settings.preferedGenres.Contains(GameCatalog.Genre.Adventure);
            genreStrategy.IsChecked = settings.preferedGenres.Contains(GameCatalog.Genre.Strategy);
            genreAction.IsChecked = settings.preferedGenres.Contains(GameCatalog.Genre.Action);
            platformIOS.IsChecked = settings.preferedPlatform.Contains(Platform.IOS);
            platformPC.IsChecked = settings.preferedPlatform.Contains(Platform.PC);
            platformPlayStation.IsChecked = settings.preferedPlatform.Contains(Platform.Playstation);
            platformXbox.IsChecked = settings.preferedPlatform.Contains(Platform.Xbox);
            platformAndroid.IsChecked = settings.preferedPlatform.Contains(Platform.Android);
            markBox.Text = settings.minMark.ToString();
        }
        public Settings(UserSettings settings)
        {
            this.settings = settings;
            InitializeComponent();
            initializeCheckBoxes();
            mark = new CheckedMark() {valid=true, value = settings.minMark };
        }

        private void canselBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            checkMark();
            if (!mark.valid)
            {
                markBox.BorderBrush = Brushes.Red;
            }
            else
            {
                settings.minMark = mark.value;
                this.DialogResult = true;
            }
        }
        private void checkMark()
        {
            mark.valid = false;
            double temp = -1;
            Double.TryParse(markBox.Text, out temp);
            if (temp > 0 && temp < 10)
            {
                mark.valid = true;
                mark.value = temp;
            }
            return;
            
        }
    }
}
