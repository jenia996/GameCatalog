using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCatalog
{
    interface IRepository<T,in Tkey>
    {
        T get(Tkey id);
        void save(T obj);
        void update(T obj);
        void delete(T obj);
    }
}
