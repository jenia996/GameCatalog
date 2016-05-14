using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCatalog
{
    class UserSettingsService
    {
        UserSettingsRepository repository;
        public UserSettingsService()
        {
            repository = new UserSettingsRepository();
        }
        public UserSettings get(int id)
        {
            return repository.get(id);
        }
        public void save(UserSettings settings)
        {
            repository.save(settings);
        }
        public void update(UserSettings settings)
        {
            repository.update(settings);
        }
        public void delete(UserSettings settings)
        {
            repository.delete(settings);
        }
    }
}
