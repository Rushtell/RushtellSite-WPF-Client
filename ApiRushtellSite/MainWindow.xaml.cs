using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ApiRushtellSite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        public ListView listViewDB { get; set; }
        public TextBox textBoxId { get; set; }
        public TextBox textBoxName { get; set; }
        public TextBox textBoxDeposit { get; set; }
        public TextBox textBoxType { get; set; }
        public Dispatcher dispatcher { get; set; }
        Presenter presenter;

        public MainWindow()
        {
            InitializeComponent();

            listViewDB = listView;
            textBoxId = Id;
            textBoxName = Name;
            textBoxDeposit = Deposit;
            textBoxType = Type;
            dispatcher = Dispatcher;

            presenter = new Presenter(this);

            presenter.ViewFromDB();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            presenter.AddToDB();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            presenter.DeleteFromDB();
        }
    }
}
