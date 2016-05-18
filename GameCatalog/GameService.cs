using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCatalog
{
    class GameService
    {
        GameRepository repository;
        public static void findGames(Game name)
        {

           // String temp = (String)name;
            List<Game> games = new List<Game>() { new Game() { name = "Mass effect" } };
        }
        public GameService()
        {
            repository = new GameRepository();
        }
        public void addGame(Game game)
        {
            repository.save(game);
        }
        public void deleteGame(Game game)
        {
            repository.delete(game);
        }
        public void editGame(Game game)
        {
            repository.update(game);
        }
        public Game getGame(int id)
        {
            return repository.get(id);
        }
        public List<Game> getAllGames()
        {
            return repository.getAll();
        }
        public List<Game> findGamesByName(String name)
        {
            return repository.findGamesByName(name);
        }
    }
}
