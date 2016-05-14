using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GameCatalog
{
    public class GameWindowCommands
    {
        MainWindow mainWindow;
        GameService gameService;
        private ICommand showGameCommand;
        private ICommand findGameCommand;
        private ICommand deleteGameCommand;
        private ICommand dialogResultCommand;
        private ICommand showUserSettingsCommand;
        public ICommand DialogResultCommand
        {
            get { return dialogResultCommand; }
        }
        public ICommand ShowGameCommand
        {
            get { return showGameCommand; }
        }
        public ICommand FindGameCommand
        {
            get { return findGameCommand; }
        }
        public ICommand DeleteGameCommand
        {
            get { return deleteGameCommand; }
        }
        public ICommand ShowUserSettingsCommand
        {
            get { return showUserSettingsCommand; }
        }
        public GameWindowCommands(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            gameService = new GameService();
            showGameCommand = new DelegateCommand<Game>(showGame);
            deleteGameCommand = new DelegateCommand<Game>(deleteGame);
            findGameCommand = new DelegateCommand<String>(findGamesByName);
            dialogResultCommand = new DelegateCommand<Window>(dialogOkResult);
            showUserSettingsCommand = new DelegateCommand(showSettingsWindow);
        }
        private void deleteGame(Game game)
        {
            //gameService.deleteGame(game);
            mainWindow.dataGrid.ItemsSource = null;
            mainWindow.description.Text = String.Empty;
        }
        private void findGamesByName(String name)
        {
            List<Game> games = new List<Game>() { new Game() { name = "Dark souls", description = "Finished" } };
            mainWindow.dataGrid.ItemsSource = games;
        }
        private void showGame(Game game)
        {
            if (game != null)
            {
                mainWindow.description.Text = game.description;
            }
        }
        private void showSettingsWindow()
        {
            var settings = new UserSettingsWindow(this) { Owner = mainWindow };
            settings.ShowDialog();
        }
        private void dialogOkResult(Window window)
        {
            window.DialogResult = true;
        }
    }
}
