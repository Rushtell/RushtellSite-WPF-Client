using System;
using System.Collections.Generic;
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

        public Model()
        {
            api = new ApiRushtellSiteModel();

            repository = new Repository();
        }
    }
}
