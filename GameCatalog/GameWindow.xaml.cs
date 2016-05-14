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
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private void setImages(Game game)
        {
            if (game.images.Count > 0)
            {
                if (System.IO.File.Exists(game.images[0]))
                {
                    firstImage.Source = new BitmapImage(new Uri(getFullPath(game.images[0])));
                }
                if (System.IO.File.Exists(game.images[1]))
                {
                    mainImage.Source = new BitmapImage(new Uri(getFullPath(game.images[1])));
                }
                if (System.IO.File.Exists(game.images[2]))
                {
                    lastImage.Source = new BitmapImage(new Uri(getFullPath(game.images[2])));
                }
            }

        }
        private String getFullPath(String path)
        {
            return System.IO.Path.GetFullPath(path);
        }
        public GameWindow(Game game)
        {
            InitializeComponent();
            rewiew.Text = game.rewiew;
            setImages(game);

        }
    }
}
