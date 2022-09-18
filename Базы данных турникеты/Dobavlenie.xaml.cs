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
    /// Логика взаимодействия для Dobavlenie.xaml
    /// </summary>
    public partial class Dobavlenie : Page
    {
        DataGrid dataTable;
        Gimnazia1Entities3 db;
        public Dobavlenie(DataGrid table, Gimnazia1Entities3 db)
        {
            InitializeComponent();
            dataTable = table;
            this.db = db;
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;

            Events codeStruct = new Events
            {
                Contents = codeRegionEn.Text,
              
            };  // инициализируем объект codes и складываем в него значения из TextBox

            db.Events.Add(codeStruct); // добавляем его в локальную структуру Entity
            db.SaveChanges(); // Сохраняем изменения
            this.Cursor = Cursors.Arrow; // Переводим курсор в обычное состояние
            dataTable.ItemsSource = null; // Обнуляем список в DataGrid
            dataTable.ItemsSource = db.Events.ToList(); // Запрашиваем и присваиваем новые значения
            NavigationService.GoBack();
        }

    }
}
