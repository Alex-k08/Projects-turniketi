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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
       
        public MainWindow()
        {
            InitializeComponent();
            NavigationService.Navigate(new Page1());
        }

        private void najmi_Click(object sender, RoutedEventArgs e)
        {
        }

        private void prohod_Click(object sender, RoutedEventArgs e)
        {
          
        }

    }
}


