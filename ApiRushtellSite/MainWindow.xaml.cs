using ApiRushtellLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public event EventHandler<Client> ClientAdded;
        public event EventHandler<Client> ClientDeleted;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ChangeRepository(ObservableCollection<Client> clients)
        {
            listView.ItemsSource = clients;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClientAdded?.Invoke(this, new Client()
            {
                Id = Convert.ToInt32(Id.Text),
                Name = Name.Text,
                Deposit = Convert.ToInt32(Deposit.Text),
                Type = Type.Text
            });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClientDeleted?.Invoke(this, (listView.SelectedItem as Client));
        }
    }
}
