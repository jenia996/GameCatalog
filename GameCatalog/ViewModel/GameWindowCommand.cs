using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GameCatalog.View;
namespace GameCatalog.ViewModel
{
    public class GameWindowCommands : ObservableObject
    {
        private GameService gameService;
        private ICommand findGameCommand;
        private ICommand deleteGameCommand;
        private ICommand showSettingsCommand;
        public ICommand FindGameCommand
        {
            get { return findGameCommand; }
        }
        public ICommand DeleteGameCommand
        {
            get { return deleteGameCommand; }
        }
        public ICommand ShowSettingsCommand
        {
            get { return showSettingsCommand; }
        }
        private ObservableCollection<Game> games;
        public ObservableCollection<Game> Games
        {
            get
            {
                if (games.Count == 0)
                {
                    games = new ObservableCollection<Game>() { new Game() { name = "MassEffect", description = "One of the best games", logo = @"D:\Dropbox\My\University\Технологии программирования\GameCatalog\GameCatalog\Data\Mass Effect.jpg", genre = Genre.Action, averageMark = 9.0, dateAdded = DateTime.Now.ToString("dd/MM/yyyy") } };
                }
                return games;
            }
            set { games = value; }
        }
        public GameWindowCommands()
        {
            gameService = new GameService();
            games = new ObservableCollection<Game>();
            deleteGameCommand = new DelegateCommand<Game>(deleteGame);
            showSettingsCommand = new DelegateCommand(showSettingsWindow);
            findGameCommand = new DelegateCommand<String>(findGameByName);
        }
        private void deleteGame(Game game)
        {
            games.Remove(game);
        }
        private void findGameByName(String name)
        {
            games.Add(new Game() { name = name, description = "Added by search" });
        }
        private void showSettingsWindow()
        {
            UserSettingsWindow settingsWindow = new UserSettingsWindow();
            settingsWindow.ShowDialog();
        }
    }
}
