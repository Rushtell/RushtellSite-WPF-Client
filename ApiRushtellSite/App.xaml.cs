using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ApiRushtellSite
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        static void Main()
        {
            MainWindow view = new MainWindow();

            Model model = new Model();

            Presenter presenter = new Presenter(view, model);
            model.FillLocalDb();

            App app = new App();
            app.Run(view);
        }
    }
}
