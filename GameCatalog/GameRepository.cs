using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCatalog
{
    class GameRepository : IRepository<Game, int>
    {
        public Game get(int id)
        {
            throw new NotImplementedException();
        }
        public void save(Game obj)
        {
            throw new NotImplementedException();
        }
        public void update(Game obj)
        {
            throw new NotImplementedException();
        }
        public void delete(Game obj)
        {
            throw new NotImplementedException();
        }
        public List<Game> getAll()
        {
            throw new NotImplementedException();
        }
        public List<Game> findGamesByName(String name)
        {
            throw new NotImplementedException();
        }
    }
}
