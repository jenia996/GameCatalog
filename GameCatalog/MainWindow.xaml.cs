using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Interactivity;


namespace GameCatalog
{
    public partial class MainWindow : Window
    {
        private GameWindowCommands commands;
        public GameWindowCommands Commands
        {
            get { return commands; }
        }
        public MainWindow()
        {
            InitializeComponent();
            commands = new GameWindowCommands(this);
        }

    }
}
