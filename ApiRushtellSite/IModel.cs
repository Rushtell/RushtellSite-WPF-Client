using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiRushtellLibrary;

namespace ApiRushtellSite
{
    interface IModel
    {
        ApiRushtellSiteModel api { get; set; }

        Repository repository { get; set; }
    }
}
