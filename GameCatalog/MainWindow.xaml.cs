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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Game> initialize()
        {
            List<Game> games = new List<Game>();
            games.Add(new Game() { id = 1, name = "Mass Effect", description = "Some Description", averageMark = 9.5, image = @"..\..\Data\Mass Effect.jpg", dateAdded = DateTime.Now.ToString("yyyy/MM/dd"), genre = Genre.RPG });
            games.Add(new Game() { id = 2, name = "Mass effect 2", dateAdded = DateTime.Now.ToString("yyyy/MM/dd"), genre = Genre.Action, averageMark = 9.1, image = @"..\..\Data\Mass Effect 2.jpg" });
            return games;
        }
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = initialize();
        }


        private void dataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Game game = (Game)dataGrid.SelectedItem;
            String path = System.IO.Path.GetFullPath(game.image);
            if (System.IO.File.Exists(path))
            {
                ImageSource imageSource = new BitmapImage(new Uri(path));
                image.Source = imageSource;
            }
            description.Content = game.description;
        }
    }
}
