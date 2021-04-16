using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using ApiRushtellLibrary;

namespace ApiRushtellSite
{
    class Presenter
    {
        IView view { get; set; }

        IModel model { get; set; }

        int index = -1;

        public Presenter(IView View, IModel Model)
        {
            this.view = View;
            this.model = Model;

            view.ClientAdded += View_ClientAdded;
            view.ClientDeleted += View_ClientDeleted;
            view.IndexListChanged += View_IndexListChanged;
            model.repositoryChange += Model_repositoryChange;
            model.errorAddClient += Model_errorAddClient;
        }

        private void Model_errorAddClient(object sender, string e)
        {
            view.ShowError(e);
        }

        private void View_IndexListChanged(object sender, int e)
        {
            index = e;
        }

        private void Model_repositoryChange(object sender, System.Collections.ObjectModel.ObservableCollection<Client> e)
        {
            view.ChangeRepository(e);
        }

        private void View_ClientDeleted(object sender, Client e)
        {
            if (index != -1)
            {
                model.DeleteFromDb(e);
            }
            else
            {
                view.ShowError("Выберите кого хотите удалить");
            }
        }

        private void View_ClientAdded(object sender, Client e)
        {
            model.AddInDb(e);
        }
    }
}
