using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ApiRushtellSite
{
    interface IView
    {
        ListView listViewDB { get; set; }
        TextBox textBoxId { get; set; }
        TextBox textBoxName { get; set; }
        TextBox textBoxDeposit { get; set; }
        TextBox textBoxType { get; set; }
        Dispatcher dispatcher { get; set; }
    }
}
