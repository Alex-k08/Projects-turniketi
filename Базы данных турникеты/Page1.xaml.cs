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

namespace Базы_данных_турникеты
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        DataGrid dataTable;
        Gimnazia1Entities3 db;
        public Page1()
        {
            InitializeComponent();
            Gimnazia1Entities3 db = new Gimnazia1Entities3();
            data_table.ItemsSource = db.Events.ToList();
        }

        private void prohod_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Dobavlenie());
        }
    }
}
