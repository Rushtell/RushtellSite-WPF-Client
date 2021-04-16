using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;
using ApiRushtellLibrary;

namespace ApiRushtellSite
{
    interface IView
    {
        void ChangeRepository(ObservableCollection<Client> clients);
        void ShowError(string msg);

        event EventHandler<Client> ClientAdded;
        event EventHandler<Client> ClientDeleted;
        event EventHandler<int> IndexListChanged;
    }
}
