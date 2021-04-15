using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiRushtellLibrary;

namespace ApiRushtellSite
{
    class Repository
    {
        public ObservableCollection<Client> db = new ObservableCollection<Client>();
    }
}
