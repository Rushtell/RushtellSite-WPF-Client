using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiRushtellLibrary;

namespace ApiRushtellSite
{
    interface IModel
    {
        event EventHandler<ObservableCollection<Client>> repositoryChange;

        void DeleteFromDb(Client client);

        void AddInDb(Client client);
    }
}
