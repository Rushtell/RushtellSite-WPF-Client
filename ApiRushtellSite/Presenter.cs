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

        public Presenter(IView View, IModel Model)
        {
            this.view = View;
            this.model = Model;

            view.ClientAdded += View_ClientAdded;
            view.ClientDeleted += View_ClientDeleted;
            model.repositoryChange += Model_repositoryChange;
        }

        private void Model_repositoryChange(object sender, System.Collections.ObjectModel.ObservableCollection<Client> e)
        {
            view.ChangeRepository(e);
        }

        private void View_ClientDeleted(object sender, Client e)
        {
            model.DeleteFromDb(e);
        }

        private void View_ClientAdded(object sender, Client e)
        {
            model.AddInDb(e);
        }




        //public void ViewFromDB()
        //{
        //    View.listViewDB.ItemsSource = Model.repository.db;

        //    View.dispatcher.Invoke(() => Model.api.GetClients().ToList().ForEach(e => Model.repository.db.Add(e)));
        //}

        //public void AddToDB()
        //{
        //    foreach (var item in Model.repository.db)
        //    {
        //        if (item.Id == Convert.ToInt32(View.textBoxId.Text))
        //        {
        //            MessageBox.Show("Укажите другой Id");
        //            return;
        //        }
        //    }
        //    Client client = new Client()
        //    {
        //        Id = Convert.ToInt32(View.textBoxId.Text),
        //        Name = View.textBoxName.Text,
        //        Deposit = Convert.ToInt32(View.textBoxDeposit.Text),
        //        Type = View.textBoxType.Text,
        //    };

        //    Model.repository.db.Clear();

        //    Model.api.AddClient(client);

        //    View.dispatcher.Invoke(() => Model.api.GetClients().ToList().ForEach(e => Model.repository.db.Add(e)));
        //}

        //public void DeleteFromDB()
        //{
        //    if (View.listViewDB.SelectedIndex != -1)
        //    {
        //        Model.api.DeleteClient(((Client)View.listViewDB.SelectedItem).Id);
        //        Model.repository.db.Remove(View.listViewDB.SelectedItem as Client);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Выберите кого хотите удалить");
        //    }
        //}
    }
}
