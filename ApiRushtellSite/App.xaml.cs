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
        //App()
        //{
        //    InitializeComponent();
        //}

        [STAThread]
        static void Main()
        {
            MainWindow view = new MainWindow();

            App app = new App();
            app.Run(view);
        }
    }
}
