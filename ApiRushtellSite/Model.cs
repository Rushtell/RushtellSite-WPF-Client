using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using ApiRushtellLibrary;

namespace ApiRushtellSite
{
    class Model : IModel
    {
        public ApiRushtellSiteModel api { get; set; }

        public Repository repository { get; set; }

        public event EventHandler<ObservableCollection<Client>> repositoryChange;
        public event EventHandler<string> errorAddClient;

        public Model()
        {
            api = new ApiRushtellSiteModel();

            repository = new Repository();

            FillLocalDb();
            repositoryChange?.Invoke(this, repository.db);
        }

        public void AddInDb(Client client)
        {
            foreach (var item in repository.db)
            {
                if (item.Id == client.Id)
                {
                    errorAddClient?.Invoke(this, "Клиент с указаным идентификатором уже существует");
                    return;
                }
            }
            api.AddClient(client);
            FillLocalDb();
        }

        public void DeleteFromDb(Client client)
        {
            api.DeleteClient(client.Id);
            FillLocalDb();
        }

        public void FillLocalDb()
        {
            repository.db.Clear();
            api.GetClients().ToList().ForEach(e => repository.db.Add(e));
            repositoryChange?.Invoke(this, repository.db);
        }

    }
}
